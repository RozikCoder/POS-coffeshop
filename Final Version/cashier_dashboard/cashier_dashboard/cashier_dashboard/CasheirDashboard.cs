using cashier_dashboard.Data;
using cashier_dashboard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace cashier_dashboard
{
    public partial class Form1 : Form
    {

        private Button btnCheckout;        
        private Button btnPrintReceipt;

        List<SaleItem> cart = new List<SaleItem>();

        private Member currentMember = null;

        private int selectedCartIndex = -1;

        private Button btnProductsSales;
       

        private Button btnDashboard;     // ← PUT THESE 4 LINES HERE
        private Button btnCashier;
        private Button btnReporting;
        private Button btnLogout;
        private Panel panelReporting;

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            LoadCart();
            //LoadDashboardData();
        }

        public void LoadProducts()
        {
            dgvProducts.DataSource = FakeDb.Products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                p.Stock
            }).ToList();
        }

        private void LoadCart()
        {
            // Update cart display
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart.Select(c => new
            {
                c.ProductName,
                c.Qty,
                SubTotal = "$" + c.SubTotal.ToString("0.00")
            }).ToList();

            // Restore selection
            if (selectedCartIndex >= 0 && selectedCartIndex < dgvCart.Rows.Count)
                dgvCart.Rows[selectedCartIndex].Selected = true;

            decimal subtotal = cart.Sum(c => c.SubTotal);
            lblSubtotal.Text = "$" + subtotal.ToString("0.00");

            if (currentMember != null)
            {
                decimal rate = (decimal)currentMember.DiscountRate;
                decimal finalTotal = subtotal * (1 - rate);

                lblDiscount.Text = (rate * 100).ToString("0") + "%";
                lblTotalValue.Text = "$" + finalTotal.ToString("0.00");   // CORRECT LABEL
            }
            else
            {
                lblDiscount.Text = "-";
                lblTotalValue.Text = "$" + subtotal.ToString("0.00");     // CORRECT LABEL
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCart();
            //UpdateAnalytics();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int id = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
            var product = FakeDb.Products.First(p => p.Id == id);

            int qty = (int)numQty.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1");
                return;
            }


            if (qty > product.Stock)
            {
                MessageBox.Show("Not Enough Stock!!");
                return;
            }

            var existing = cart.FirstOrDefault(c => c.ProductId == id);

            if (existing == null)
            {
                cart.Add(new SaleItem
                {
                    ProductId = id,
                    ProductName = product.Name,
                    Qty = qty,
                    SubTotal = qty * product.Price
                });
            }
            else
            {
                existing.Qty += qty;
                existing.SubTotal = existing.Qty * product.Price;
            }

            LoadCart();
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (!cart.Any())
            {
                MessageBox.Show("Cart is empty");
                return;
            }

            decimal subtotal = cart.Sum(i => i.SubTotal);
            decimal discountAmount = 0;
            decimal discountRate = 0;
            string memberName = "-";

            if (currentMember != null)
            {
                discountRate = (decimal)currentMember.DiscountRate;
                discountAmount = subtotal * discountRate;
                memberName = currentMember.Name;
            }

            decimal finalTotal = subtotal - discountAmount;

            var saleItems = cart.Select(c => new SaleItem
            {
                ProductId = c.ProductId,
                ProductName = c.ProductName,
                Qty = c.Qty,
                SubTotal = c.SubTotal
            }).ToList();

            var sale = new Sale
            {
                Id = FakeDb.Sales.Count + 1,
                SaleDate = DateTime.Now,
                Items = saleItems,
                TotalAmount = finalTotal,
                MemberId = currentMember != null ? currentMember.MemberId : "-",
                MemberName = memberName,
                DiscountRate = discountRate
            };

            FakeDb.Sales.Add(sale);

            foreach (var item in cart)
            {
                var prod = FakeDb.Products.First(p => p.Id == item.ProductId);
                prod.Stock -= item.Qty;
            }

            MessageBox.Show($"Checkout successful!\nSubtotal: ${subtotal:0.00}\nDiscount: ${discountAmount:0.00}\nFinal Total: ${finalTotal:0.00}");

            cart.Clear();
            selectedCartIndex = -1;        // ← ADD THIS LINE! (THIS FIXES THE ERROR)
            currentMember = null;
            lblMemberName.Text = "-";
            lblDiscount.Text = "-";
            LoadProducts();
            LoadCart();                   
            //UpdateAnalytics();
            //UpdateAnalyticsAndDashboard();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            string memberId = txtMemberId.Text.Trim();

            if (string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("Please enter Member ID");
                return;
            }

            currentMember = FakeDb.Members.FirstOrDefault(m =>
                m.MemberId.Equals(memberId, StringComparison.OrdinalIgnoreCase));

            if (currentMember == null)
            {
                lblMemberName.Text = "-";
                lblDiscount.Text = "-";
                currentMember = null;
                LoadCart(); // This will update total to full price
                MessageBox.Show("Member not found!");
                return;
            }

            // Member found → show info
            lblMemberName.Text = currentMember.Name;
            lblDiscount.Text = (currentMember.DiscountRate * 100).ToString("0") + "%";

            LoadCart(); // This applies discount to total
        }


        private void ResizeLabelToFitText(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font);
                int newWidth = (int)size.Width + 10; 
                lbl.Width = Math.Min(newWidth, lbl.MaximumSize.Width);
            }
        }


        private void grpMembership_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                selectedCartIndex = dgvCart.SelectedRows[0].Index;
                var item = cart[selectedCartIndex];

                numQty.Value = item.Qty;
            }
        }

        private void btnUpdateCart_Click(object sender, EventArgs e)
        {
            if (selectedCartIndex < 0 || selectedCartIndex >= cart.Count)
            {
                MessageBox.Show("Please select an item to update");
                return;
            }

            int newQty = (int)numQty.Value;

            if (newQty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1");
                return;
            }

            var item = cart[selectedCartIndex];
            var product = FakeDb.Products.First(p => p.Id == item.ProductId);

            if (newQty > product.Stock + item.Qty)
            {
                MessageBox.Show("Not enough stock available");
                return;
            }

            item.Qty = newQty;
            item.SubTotal = newQty * product.Price;

            LoadCart();
            UpdateMemberSummary();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Your logout logic here
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                // Optionally show login form again
                // var loginForm = new LoginForm();
                // loginForm.Show();
                Application.Exit(); // or better: show login form
            }
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            // Switch to Membership / Customers page
            ShowPage("Customers");
            ShowPage("Membership"); // or "Customers" depending on what you want

            // Optional: highlight active button
            ShowPage("Membership");
        }

        private void btnProductsSales_Click(object sender, EventArgs e)
        {
            // Switch to Membership / Customers page
            ShowPage("Inventory");
            ShowPage("Inventory"); // or "Customers" depending on what you want

            // Optional: highlight active button
            ShowPage("Inventory");
        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            // Switch to Membership / Customers page
            ShowPage("Products and Sales");
            ShowPage("Products and Sales"); // or "Customers" depending on what you want

            // Optional: highlight active button
            ShowPage("Products and Sales");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Switch to Membership / Customers page
            ShowPage("Dashboard");
            ShowPage("Dashboard"); // or "Customers" depending on what you want

            // Optional: highlight active button
            ShowPage("Dashboard");
        }

        private void ConfigureSidebarButton(Button btn, string text, int y, bool active = false)
        {
            btn.Name = "btn" + text.Replace(" ", "").Replace("&", "");
            btn.Text = text;
            btn.Size = new Size(140, 40);
            btn.Location = new Point(12, y);
            btn.TabIndex = panelSidebar.Controls.Count;
            btn.BackColor = active ? Color.FromArgb(0, 122, 204) : Color.FromArgb(52, 73, 94);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = Cursors.Hand;

            // Optional active indicator
            if (active)
            {
                var indicator = new Panel
                {
                    Size = new Size(4, 40),
                    Location = new Point(0, 0),
                    BackColor = Color.FromArgb(0, 230, 130)
                };
                btn.Controls.Add(indicator);
            }

            // Click events
            switch (text)
            {
                case "Dashboard":
                    btn.Click += btnDashboard_Click;
                    break;
                case "Products and Sales":
                    btn.Click += btnStaffManagement_Click;
                    break;
                case "Inventory":
                    btn.Click += btnProductsSales_Click;
                    break;
                case "Customers":
                    btn.Click += btnMembership_Click;
                    break;
                case "Logout":
                    btn.Click += btnLogout_Click;
                    break;
            }

            panelSidebar.Controls.Add(btn);
        }

        // ===============================================
        // MODERN SIDEBAR BUTTON CREATOR (LIKE ADMIN DASHBOARD)
        // ===============================================
        //private void CreateSidebarButton(string text, int top, bool isActive = false)
        //{
        //    var btn = new Panel
        //    {
        //        Size = new Size(240, 50),
        //        Location = new Point(8, top),
        //        BackColor = isActive ? Color.FromArgb(0, 122, 255) : Color.FromArgb(40, 55, 80),
        //        Tag = text,
        //        Cursor = Cursors.Hand
        //    };

        //    var label = new Label
        //    {
        //        Text = text,
        //        ForeColor = isActive ? Color.White : Color.FromArgb(200, 200, 200),
        //        Font = new Font("Segoe UI", 10.5F, isActive ? FontStyle.Bold : FontStyle.Regular),
        //        Dock = DockStyle.Fill,
        //        TextAlign = ContentAlignment.MiddleLeft,
        //        Padding = new Padding(50, 0, 0, 0),
        //        BackColor = Color.Transparent,
        //        Cursor = Cursors.Hand
        //    };

        //    btn.Controls.Add(label);

        //    // Green bar if active
        //    if (isActive)
        //    {
        //        var bar = new Panel { Width = 4, Dock = DockStyle.Left, BackColor = Color.FromArgb(0, 230, 130) };
        //        btn.Controls.Add(bar);
        //    }

        //    // Hover effect (only when not active)
        //    void UpdateHover(bool hover)
        //    {
        //        if (btn.BackColor == Color.FromArgb(0, 122, 255)) return; // already active
        //        btn.BackColor = hover ? Color.FromArgb(60, 75, 100) : Color.FromArgb(40, 55, 80);
        //    }

        //    btn.MouseEnter += (s, e) => UpdateHover(true);
        //    btn.MouseLeave += (s, e) => UpdateHover(false);
        //    label.MouseEnter += (s, e) => UpdateHover(true);
        //    label.MouseLeave += (s, e) => UpdateHover(false);

        //    // CLICK → Make this button active
        //    void Activate()
        //    {
        //        // Reset all buttons
        //        foreach (Panel p in panelSidebar.Controls.OfType<Panel>().Where(x => x.Tag is string))
        //        {
        //            p.BackColor = Color.FromArgb(40, 55, 80);

        //            var lbl = p.Controls.OfType<Label>().FirstOrDefault();
        //            if (lbl != null)
        //            {
        //                lbl.ForeColor = Color.FromArgb(200, 200, 200);
        //                lbl.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
        //            }

        //            // Remove only green bar
        //            var bar = p.Controls.OfType<Panel>().FirstOrDefault(c => c.Width == 4);
        //            if (bar != null) p.Controls.Remove(bar);
        //        }

        //        // Activate this one
        //        btn.BackColor = Color.FromArgb(0, 122, 255);
        //        label.ForeColor = Color.White;
        //        label.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);

        //        var activeBar = new Panel { Width = 4, Dock = DockStyle.Left, BackColor = Color.FromArgb(0, 230, 130) };
        //        btn.Controls.Add(activeBar);
        //        label.BringToFront();

        //        // UPDATE HEADER — WORKS 100%
        //        if (lblHeader != null)
        //            lblHeader.Text = text.ToUpper();
        //    }

        //    // Click works on both panel and label
        //    btn.Click += (s, e) => Activate();
        //    label.Click += (s, e) => Activate();

        //    // If created as active → activate once
        //    if (isActive) Activate();

        //    panelSidebar.Controls.Add(btn);
        //}

        // Required Win32 for rounded corners
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);


        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            if (selectedCartIndex < 0 || selectedCartIndex >= cart.Count)
            {
                MessageBox.Show("Please select an item to delete");
                return;
            }

            cart.RemoveAt(selectedCartIndex);

            LoadCart();
            UpdateMemberSummary();
        }

        private void UpdateMemberSummary()
        {
            decimal subtotal = cart.Sum(c => c.SubTotal);
            lblSubtotal.Text = "$" + subtotal.ToString("0.00");

            if (currentMember != null)
            {
                decimal discountAmount = subtotal * (decimal)currentMember.DiscountRate;
                decimal finalTotal = subtotal - discountAmount;

                lblDiscount.Text = (currentMember.DiscountRate * 100).ToString("0.##") + "%";
                lblTotalValue.Text = "$" + finalTotal.ToString("0.00");
            }
            else
            {
                lblTotalValue.Text = "$" + subtotal.ToString("0.00");
            }
        }


        private void lblTotalTransactions_Click(object sender, EventArgs e)
        {

        }

        private List<(int Month, string MonthName)> AllMonths = Enumerable.Range(1, 12)
            .Select(m => (m, new DateTime(2025, m, 1).ToString("MMM")))
            .ToList();

        private void UpdateAnalytics()
        {
            if (chartTopProduct == null || chartMonthlyRevenu == null) return;

            // ==================== PIE CHART - TOP SELLING PRODUCTS ====================
            chartTopProduct.Series.Clear();
            chartTopProduct.ChartAreas.Clear();
            chartTopProduct.Titles.Clear();

            var pieArea = new ChartArea();
            pieArea.Area3DStyle.Enable3D = true;
            pieArea.Area3DStyle.Rotation = 15;
            pieArea.Area3DStyle.Inclination = 30;
            pieArea.Area3DStyle.LightStyle = LightStyle.Realistic;
            chartTopProduct.ChartAreas.Add(pieArea);

            chartTopProduct.Titles.Add("Top Selling Products");
            chartTopProduct.Titles[0].Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            var pie = chartTopProduct.Series.Add("TopProducts");
            pie.ChartType = SeriesChartType.Pie;
            pie.IsValueShownAsLabel = true;
            pie["PieLabelStyle"] = "Outside";
            pie.Font = new Font("Segoe UI", 10F);

            pie.Points.AddXY("Coffee Latte", 180);
            pie.Points.AddXY("Croissant", 120);
            pie.Points.AddXY("Cappuccino", 95);
            pie.Points.AddXY("Sandwich", 80);
            pie.Points.AddXY("Iced Tea", 65);
            pie.Points.AddXY("Muffin", 50);

            // ==================== COLUMN CHART - MONTHLY REVENUE ====================
            chartMonthlyRevenu.Series.Clear();
            chartMonthlyRevenu.ChartAreas.Clear();
            chartMonthlyRevenu.Titles.Clear();

            var colArea = new ChartArea();
            colArea.Area3DStyle.Enable3D = false;  // 2D look for column chart
            colArea.AxisX.MajorGrid.Enabled = false;
            colArea.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            colArea.AxisY.LabelStyle.Format = "$#,##0";
            chartMonthlyRevenu.ChartAreas.Add(colArea);

            chartMonthlyRevenu.Titles.Add("Monthly Revenue");
            chartMonthlyRevenu.Titles[0].Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            var col = chartMonthlyRevenu.Series.Add("Revenue");
            col.ChartType = SeriesChartType.Column;
            col.Color = Color.FromArgb(0, 122, 255);

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] revenue = { 12450, 15800, 19200, 13500, 17800, 21000, 18500, 19800, 17200, 16500, 22800, 24500 };

            for (int i = 0; i < months.Length; i++)
            {
                col.Points.AddXY(months[i], revenue[i]);
            }

            chartTopProduct.Invalidate();
            chartMonthlyRevenu.Invalidate();
        }
        private void btnDownloadReport_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Report");

                ws.Cell(1, 1).Value = "Total Revenue";
                ws.Cell(1, 2).Value = FakeDb.Sales.Sum(s => s.TotalAmount);

                ws.Cell(2, 1).Value = "Total Transactions";
                ws.Cell(2, 2).Value = FakeDb.Sales.Count;

                var topProducts = FakeDb.Sales.SelectMany(s => s.Items)
                    .GroupBy(i => i.ProductName)
                    .Select(g => new { Product = g.Key, Qty = g.Sum(x => x.Qty) })
                    .Take(3)
                    .ToList();

                ws.Cell(4, 1).Value = "Top Products";
                ws.Cell(4, 2).Value = "Quacntity";

                int row = 5;
                foreach (var item in topProducts)
                {
                    ws.Cell(row, 1).Value = item.Product;
                    ws.Cell(row, 2).Value = item.Qty;
                    row++;
                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excell Workbook|*.xlsx";
                saveFileDialog.FileName = "SalesReport";

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Report exported successfully");
                }
            }
        }

        private void btnDownloadReceipt_Click(object sender, EventArgs e)
        {
            if (!FakeDb.Sales.Any())
            {
                MessageBox.Show("No Sale to generate receipt");
                return;
            }

            var lastSale = FakeDb.Sales.Last();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("===== RECEIPT =====");
            sb.AppendLine($"Sale ID: {lastSale.Id}");
            sb.AppendLine($"Date: {lastSale.SaleDate}");
            sb.AppendLine("---------------------------");

            if (!string.IsNullOrEmpty(lastSale.MemberId) && lastSale.MemberId != "-")
            {
                sb.AppendLine($"Member ID: {lastSale.MemberId}");
                sb.AppendLine($"Discount: {lastSale.DiscountRate * 100:0.##}%");
            }
            else
            {
                sb.AppendLine("Member ID: -");
                sb.AppendLine("Discount: 0%");
            }

            sb.AppendLine("---------------------------");
            sb.AppendLine(string.Format("{0,-15} {1,3} {2,7} {3,9}", "Product", "Qty", "Price", "Subtotal"));

            foreach (var item in lastSale.Items)
            {
                var product = FakeDb.Products.FirstOrDefault(p => p.Id == item.ProductId);
                decimal price = product != null ? product.Price : 0;

                sb.AppendLine(string.Format("{0,-15} {1,3} {2,7:C} {3,9:C}",
                    item.ProductName,
                    item.Qty,
                    price,
                    item.SubTotal));
            }

            decimal subtotal = lastSale.Items.Sum(x => x.SubTotal);
            decimal discountAmount = subtotal * lastSale.DiscountRate;
            decimal finalTotal = subtotal - discountAmount;

            sb.AppendLine("---------------------------");
            sb.AppendLine($"Subtotal: {subtotal:C}");
            sb.AppendLine($"Discount: {discountAmount:C}");
            sb.AppendLine($"Total: {finalTotal:C}");
            sb.AppendLine("===========================");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = $"Receipt_{lastSale.Id}.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("TXT receipt downloaded successfully!");
            }
        }

        private Button CreateSidebarButton(string text, int y, bool isActive = false)
        {
            var btn = new Button
            {
                Text = text,
                Size = new Size(220, 50),
                Location = new Point(15, y),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(50, 0, 0, 0),
                Cursor = Cursors.Hand
            };

            var indicator = new Panel
            {
                Size = new Size(6, 50),
                BackColor = Color.FromArgb(0, 180, 255),
                Location = new Point(0, 0),
                Visible = isActive
            };
            btn.Controls.Add(indicator);

            btn.MouseEnter += (s, e) => { if (!indicator.Visible) btn.BackColor = Color.FromArgb(52, 73, 94); };
            btn.MouseLeave += (s, e) => { if (!indicator.Visible) btn.BackColor = Color.Transparent; };

            btn.Click += (s, e) =>
            {

                foreach (Button b in panelSidebar.Controls.OfType<Button>())
                {
                    b.BackColor = Color.Transparent;
                    b.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                    var ind = b.Controls.OfType<Panel>().FirstOrDefault();
                    if (ind != null) ind.Visible = false;
                }

                btn.BackColor = Color.FromArgb(40, 57, 80);
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                indicator.Visible = true;

                panelDashboard.Visible = false;
                panelProducts.Visible = false;
                panelCart.Visible = false;
                grpMembership.Visible = false;
                //grpAnalytics.Visible = false;

                switch (text)
                {
                    case "Dashboard":
                        panelDashboard.Visible = true;
                        panelDashboard.BringToFront();
                        lblHeader.Text = "Dashboard";
                        //LoadDashboardData();
                        UpdateAnalytics();   
                        break;                       
                    case "Cashier":
                        panelProducts.Visible = true;
                        panelCart.Visible = true;
                        grpMembership.Visible = true;
                        //grpAnalytics.Visible = true;        
                        lblHeader.Text = "Cashier";
                        //UpdateAnalytics();
                        break;
                    case "Reporting":
                        lblHeader.Text = "Reporting";
                        ShowReportingPanel();
                        break;
                    case "Logout":
                        if (MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            Application.Exit();
                        break;
                }
            };

            if (isActive) btn.PerformClick();

            panelSidebar.Controls.Add(btn);
            return btn;
        }

        private void UpdateCard(string title, string value, Color color)
        {
            foreach (Control c in panelDashboard.Controls)
            {
                if (c is Panel card && card.Controls.Count >= 2)
                {
                    var lblTitle = card.Controls[0] as Label;
                    var lblValue = card.Controls[1] as Label;
                    if (lblTitle?.Text == title)
                    {
                        lblValue.Text = value;
                        card.BackColor = color;
                    }
                }
            }
        }

        private void ShowReportingPanel()
        {
            panelDashboard.Visible = false;
            panelProducts.Visible = false;
            panelCart.Visible = false;
            grpMembership.Visible = false;

            if (panelReporting == null)
            {
                CreateReportingPanel();
            }

            panelReporting.Visible = true;
            panelReporting.BringToFront();
            mainContainer.Controls.Add(panelReporting);

            LoadReportData();
        }

        private void CreateReportingPanel()
        {
            panelReporting = new Panel
            {
                Location = new Point(260, 120),   
                Size = new Size(1145, 900),
                BackColor = Color.Transparent,
                AutoScroll = true,
                Visible = false
            };

            var title = new Label
            {
                Text = "Sales Report",
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 43, 63),
                Location = new Point(0, 0),
                AutoSize = true
            };

            // Date Range
            var lblFrom = new Label { Text = "From:", Location = new Point(0, 70), AutoSize = true, Font = new Font("Segoe UI", 10F) };
            var dtpFrom = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(60, 68),
                Width = 120
            };
            dtpFrom.Value = DateTime.Today.AddDays(-30);

            var lblTo = new Label { Text = "To:", Location = new Point(200, 70), AutoSize = true, Font = new Font("Segoe UI", 10F) };
            var dtpTo = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(240, 68),
                Width = 120
            };
            dtpTo.Value = DateTime.Today;

            var btnRefresh = new Button
            {
                Text = "Refresh Report",
                Location = new Point(380, 65),
                Size = new Size(120, 35),
                BackColor = Color.FromArgb(0, 122, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };

            // Summary Cards
            var cardsPanel = new TableLayoutPanel
            {
                Location = new Point(0, 120),
                Size = new Size(1095, 100),
                ColumnCount = 4,
                RowCount = 1
            };
            for (int i = 0; i < 4; i++)
                cardsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            var cardTotalSales = CreateCompactCard("TOTAL SALES", "$0.00", Color.FromArgb(0, 122, 255));
            var cardTransactions = CreateCompactCard("TRANSACTIONS", "0", Color.FromArgb(0, 180, 90));
            var cardAvgTicket = CreateCompactCard("AVG TICKET", "$0.00", Color.FromArgb(255, 140, 0));
            var cardProfit = CreateCompactCard("PROFIT (est.)", "$0.00", Color.FromArgb(128, 0, 128));

            cardsPanel.Controls.Add(cardTotalSales, 0, 0);
            cardsPanel.Controls.Add(cardTransactions, 1, 0);
            cardsPanel.Controls.Add(cardAvgTicket, 2, 0);
            cardsPanel.Controls.Add(cardProfit, 3, 0);

            // Top Products Table
            var dgvTopProducts = new DataGridView
            {
                Location = new Point(0, 250),
                Size = new Size(1095, 340),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                EnableHeadersVisualStyles = false,
                GridColor = Color.FromArgb(225, 228, 232),
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                RowTemplate = { Height = 56 },
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing,
                ColumnHeadersHeight = 60,
                Font = new Font("Segoe UI", 10F),
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(245, 247, 250),     // Light gray (very clean)
                    ForeColor = Color.FromArgb(40, 57, 80),        // Dark blue-gray text
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Padding = new Padding(12)
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(33, 37, 41),
                    SelectionBackColor = Color.FromArgb(0, 122, 255),
                    SelectionForeColor = Color.White,
                    Padding = new Padding(12, 8, 12, 8),
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                },
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(248, 250, 252)
                }
            };

            dgvTopProducts.Paint += (s, e) =>
            {
                var rect = new Rectangle(0, 0, dgvTopProducts.Width - 1, dgvTopProducts.Height - 1);
                using (var pen = new Pen(Color.FromArgb(200, 200, 200), 1))
                    e.Graphics.DrawRectangle(pen, rect);
            };
            dgvTopProducts.DataBindingComplete += (s, e) =>
            {
                dgvTopProducts.Columns["Product"].HeaderText = "Product Name";
                dgvTopProducts.Columns["Product"].DefaultCellStyle.Font = new Font("Segoe UI Semibold", 10.5F);
                dgvTopProducts.Columns["Product"].FillWeight = 40;

                dgvTopProducts.Columns["Quantity"].HeaderText = "Qty Sold";
                dgvTopProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTopProducts.Columns["Quantity"].FillWeight = 25;

                dgvTopProducts.Columns["Revenue"].HeaderText = "Revenue";
                dgvTopProducts.Columns["Revenue"].DefaultCellStyle.Format = "$#,##0.00";
                dgvTopProducts.Columns["Revenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTopProducts.Columns["Revenue"].DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                dgvTopProducts.Columns["Revenue"].DefaultCellStyle.ForeColor = Color.FromArgb(0, 140, 70);
                dgvTopProducts.Columns["Revenue"].FillWeight = 35;
            };

            // Export Button
            var btnExport = new Button
            {
                Text = "Export to Excel",
                Location = new Point(950, 600),   
                Size = new Size(140, 45),
                BackColor = Color.FromArgb(34, 139, 34),   
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnExport.Click += (s, e) => ExportToExcel(dgvTopProducts);

            panelReporting.Controls.AddRange(new Control[]
            {
                title, lblFrom, dtpFrom, lblTo, dtpTo, btnRefresh, cardsPanel, dgvTopProducts, btnExport
            });

            panelReporting.Tag = new { dtpFrom, dtpTo, dgvTopProducts, cardTotalSales, cardTransactions, cardAvgTicket, cardProfit };

            btnRefresh.Click += (s, e) => LoadReportData();
        }

        private void LoadReportData()
        {
            var data = panelReporting.Tag as dynamic;
            DateTime from = data.dtpFrom.Value.Date;
            DateTime to = data.dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

            var filteredSales = FakeDb.Sales
                .Where(s => s.SaleDate >= from && s.SaleDate <= to)
                .ToList();

            decimal totalSales = filteredSales.Sum(s => s.TotalAmount);
            int transactions = filteredSales.Count;
            decimal avgTicket = transactions > 0 ? totalSales / transactions : 0;
            decimal profit = totalSales * 0.4m; 

            UpdateReportCard(data.cardTotalSales, $"$ {totalSales:0.00}");
            UpdateReportCard(data.cardTransactions, transactions.ToString());
            UpdateReportCard(data.cardAvgTicket, $"$ {avgTicket:0.00}");
            UpdateReportCard(data.cardProfit, $"$ {profit:0.00}");

            var topProducts = filteredSales
                .SelectMany(s => s.Items)
                .GroupBy(i => i.ProductName)
                .Select(g => new
                {
                    Product = g.Key,
                    Quantity = g.Sum(x => x.Qty),
                    Revenue = g.Sum(x => x.Qty * x.Price)
                })
                .OrderByDescending(x => x.Revenue)
                .Take(5)
                .ToList();

            data.dgvTopProducts.DataSource = topProducts;
        }

        private void UpdateReportCard(Control card, string value)
        {
            if (card is Panel p && p.Controls.Count >= 2)
            {
                var lblValue = p.Controls[1] as Label;
                if (lblValue != null) lblValue.Text = value;
            }
        }

        private void ExportToExcel(DataGridView dgv)
        {
            try
            {
                var sfd = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = $"Sales_Report_{DateTime.Now:yyyyMMdd}.xlsx"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var ws = workbook.Worksheets.Add("Sales Report");
                        for (int i = 1; i <= dgv.Columns.Count; i++)
                            ws.Cell(1, i).Value = dgv.Columns[i - 1].HeaderText;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                            for (int j = 0; j < dgv.Columns.Count; j++)
                                ws.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString();
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }
    }
}
    






