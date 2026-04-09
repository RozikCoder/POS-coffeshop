using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;

namespace cashier_dashboard
{

    public static class Win32
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        private const int DWMWA_SYSTEMBACKDROP_TYPE = 38; 

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        // Auto-detect Windows 11 and apply best blur
        public static void ApplyAcrylicEffect(Control control)
        {
            if (Environment.OSVersion.Version.Major < 10) return;

            var hwnd = control.Handle;
            int val = 1;
            DwmSetWindowAttribute(hwnd, DWMWA_USE_IMMERSIVE_DARK_MODE, ref val, sizeof(int));

            if (Environment.OSVersion.Version.Build >= 22000) 
            {           
                int backdrop = 2; 
                DwmSetWindowAttribute(hwnd, DWMWA_SYSTEMBACKDROP_TYPE, ref backdrop, sizeof(int));
            }
            else
            {

                MARGINS margins = new MARGINS { cxLeftWidth = -1 };
                DwmExtendFrameIntoClientArea(hwnd, ref margins);
            }
        }
    }
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Panels
        private Panel mainContainer;
        private Panel panelSidebar;
        private Panel panelHeader;
        private Button btnStaffManagement;

        // Sidebar controls
        private PictureBox csSidebarGreen;
        private PictureBox csSidebar;
        private Label lblSidebarCashier;
        private Label lblSidebarStatus;
        //private Button btnDashboard, btnCashier, btnSales, btnInventory, btnCustomers, btnMembership, btnReporting, btnSettings, btnLogout;

        // Header controls
        private Label lblHeader;
        private TextBox textBoxSearchBarDashboard;
        private PictureBox pictureBoxSearchIconDashboard, pictureBoxBellIconDashboard, pictureBoxCartDashboard, pictureBoxAccountDashboard;
        private Label lblSearchDashboard;

        // Products Panel
        private Panel panelProducts;
        private DataGridView dgvProducts;
        private Label labelProducts;

        // Cart Panel
        private Panel panelCart;
        private DataGridView dgvCart;
        private Label labelCart;
        private NumericUpDown numQty;
        private Button btnAddToCart, btnUpdateCart, btnDeleteCart;

        // Membership Group
        private GroupBox grpMembership;
        private Label lblMemberNameTitle;
        private Label lblMemberName;
        private Label lblMemberId;
        private Label lblDiscountTitle;
        private Label lblDiscount;
        private Label lblSubtotalTitle;
        private Label lblSubtotal;
        private Label lblTotalTitle;
        private Label lblTotalValue;
        private TextBox txtMemberId;
        private Button btnFindMember;

        // Analytics Group
        private GroupBox grpAnalytics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProduct, chartMonthlyRevenu;
        private Label lblTotalRevenue, lblTotalTransactions, lblTopProduct;
        private Button btnDownloadReport, btnDownloadReceipt;

        private Panel panelDashboard;


        private Panel CreateCompactCard(string title, string value, Color backColor)
        {
            var card = new Panel
            {
                BackColor = backColor,
                Size = new Size(350, 85),
                Margin = new Padding(8),
                Padding = new Padding(18, 15, 18, 15)
            };

            var lblTitle = new Label
            {
                Text = title,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = true
            };

            var lblValue = new Label
            {
                Text = value,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                Location = new Point(0, 35),
                AutoSize = true
            };

            card.Controls.AddRange(new Control[] { lblTitle, lblValue });
            return card;
        }

        private void SetupPieChart(Chart chart)
        {
            chart.ChartAreas.Clear();
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            var area = new ChartArea();
            area.BackColor = Color.Transparent;
            area.Area3DStyle.Enable3D = true;
            area.Area3DStyle.Rotation = 15;
            area.Area3DStyle.Inclination = 30;
            chart.ChartAreas.Add(area);

            chart.Titles.Add("Top Selling Products");
            chart.Titles[0].Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chart.Titles[0].ForeColor = Color.FromArgb(60, 70, 90);

            var legend = new Legend { Docking = Docking.Right };
            chart.Legends.Add(legend);
        }

        private void SetupColumnChart(Chart chart)
        {
            chart.ChartAreas.Clear();
            chart.Series.Clear();
            chart.Titles.Clear();

            var area = new ChartArea();
            area.BackColor = Color.Transparent;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            area.AxisY.LabelStyle.Format = "$#,##0";   
            chart.ChartAreas.Add(area);

            chart.Titles.Add("Monthly Revenue");
            chart.Titles[0].Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chart.Titles[0].ForeColor = Color.FromArgb(60, 70, 90);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            const int SIDEBAR_WIDTH = 250;
            const int HEADER_HEIGHT = 90;
            const int CONTENT_LEFT = SIDEBAR_WIDTH + 20;
            const int TOP_MARGIN = HEADER_HEIGHT + 15;

            mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.FromArgb(245, 248, 255)
            };

            // ======================= DASHBOARD PANEL =======================

            panelDashboard = new Panel
            {
                Location = new Point(CONTENT_LEFT, TOP_MARGIN),
                Size = new Size(1145, 900),
                BackColor = Color.Transparent,
                AutoScroll = true,
                Visible = false
            };

            var lblWelcome = new Label
            {
                Text = "Welcome back, Cashier!",
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 43, 63),
                Location = new Point(0, 0),
                AutoSize = true
            };

            //var lblToday = new Label
            //{
            //    Text = $"Today is {DateTime.Now:dddd, MMMM dd, yyyy}",
            //    Font = new Font("Segoe UI", 14F),
            //    ForeColor = Color.Gray,
            //    Location = new Point(0, 60),
            //    AutoSize = true
            //};

            panelDashboard.Controls.AddRange(new Control[] { lblWelcome });
            var panelTodayCards = new TableLayoutPanel
            {
                Location = new Point(0, 130),
                Size = new Size(1095, 100),
                ColumnCount = 4,
                RowCount = 1,
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Percent, 25F),
                    new ColumnStyle(SizeType.Percent, 25F),
                    new ColumnStyle(SizeType.Percent, 25F),
                    new ColumnStyle(SizeType.Percent, 25F)
                }
            };
            // Today's Summary Cards
            var cardTodayRevenue = CreateCompactCard("TODAY'S REVENUE", "$1,245.50", Color.FromArgb(0, 122, 255));
            var cardTodayTransactions = CreateCompactCard("TRANSACTIONS TODAY", "48", Color.FromArgb(0, 180, 90));
            var cardAvgTicket = CreateCompactCard("AVG TICKET SIZE", "$25.95", Color.FromArgb(255, 140, 0));
            var cardMembersServed = CreateCompactCard("MEMBERS SERVED", "12", Color.FromArgb(128, 0, 128));

            panelTodayCards.Controls.Add(cardTodayRevenue, 0, 0);
            panelTodayCards.Controls.Add(cardTodayTransactions, 1, 0);
            panelTodayCards.Controls.Add(cardAvgTicket, 2, 0);
            panelTodayCards.Controls.Add(cardMembersServed, 3, 0);

            panelDashboard.Controls.Add(panelTodayCards);

            // ======================= TODAY'S ANALYTICS WITH PERFECT CHARTS =======================
            var analyticsPanel = new Panel
            {
                Location = new Point(0, 260),
                Size = new Size(1145, 520),
                BackColor = Color.White,
                Padding = new Padding(30)
            };

            var analyticsTitle = new Label
            {
                Text = "TODAY'S ANALYTICS",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 57, 80),
                Location = new Point(0, 0),
                AutoSize = true
            };

            var panelCharts = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,          
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(15)
            };
            panelCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            chartTopProduct = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(252, 254, 255),
                BorderlineColor = Color.FromArgb(220, 220, 220),
                BorderlineWidth = 1,
                BorderlineDashStyle = ChartDashStyle.Solid
            };
            SetupPieChart(chartTopProduct);
            panelCharts.Controls.Add(chartTopProduct, 0, 0);

            chartMonthlyRevenu = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(252, 254, 255),
                BorderlineColor = Color.FromArgb(220, 220, 220),
                BorderlineWidth = 1,
                BorderlineDashStyle = ChartDashStyle.Solid
            };
            SetupColumnChart(chartMonthlyRevenu);
            panelCharts.Controls.Add(chartMonthlyRevenu, 1, 0);
            analyticsPanel.Controls.Add(analyticsTitle);
            analyticsPanel.Controls.Add(panelCharts);
            panelDashboard.Controls.Add(analyticsPanel);
            mainContainer.Controls.Add(panelDashboard);

            panelSidebar = new Panel
            {
                Width = 250,
                Location = new Point(0, 0),
                Height = this.ClientSize.Height,
                BackColor = Color.FromArgb(33, 43, 63)   
            };

            var profileContainer = new Panel
            {
                Size = new Size(250, 120),
                Location = new Point(0, 15),
                BackColor = Color.Transparent
            };

            // Avatar
            csSidebar = new PictureBox
            {
                Image = Properties.Resources.cashier,
                Size = new Size(58, 58),
                Location = new Point(20, 25),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };

            csSidebar.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(0, 230, 130), 4))
                    e.Graphics.DrawEllipse(pen, 2, 2, 54, 54);
            };

            csSidebarGreen = new PictureBox
            {
                Image = Properties.Resources.green1,
                Size = new Size(18, 18),
                Location = new Point(62, 66),        
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            csSidebarGreen.BringToFront();

            lblSidebarCashier = new Label
            {
                Text = "Cashier",
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 14.5F, FontStyle.Bold),
                Location = new Point(90, 30),
                AutoSize = true
            };

           
            lblSidebarStatus = new Label
            {
                Text = "Online",
                ForeColor = Color.FromArgb(0, 255, 140),   
                Font = new Font("Segoe UI Semibold", 12F),
                Location = new Point(90, 54),              
                AutoSize = true
            };

            profileContainer.Controls.Add(csSidebar);
            profileContainer.Controls.Add(csSidebarGreen);
            profileContainer.Controls.Add(lblSidebarCashier);
            profileContainer.Controls.Add(lblSidebarStatus);

            csSidebarGreen.BringToFront();
            panelSidebar.Controls.Add(profileContainer);

            btnLogout = new Button();
            btnProductsSales = new Button();
            btnStaffManagement = new Button();
            btnDashboard = new Button();

            panelSidebar.Controls
                .OfType<Panel>()
                .Where(p => p.Tag is string)
                .ToList()
                .ForEach(p => panelSidebar.Controls.Remove(p));

            panelSidebar.Controls.Add(profileContainer);
            csSidebarGreen.BringToFront();

            panelHeader = new Panel
            {
                Height = HEADER_HEIGHT,
                Dock = DockStyle.Top,
                BackColor = Color.White
            };

            lblHeader = new Label
            {
                Text = "Membership",
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 43, 63),
                Location = new Point(SIDEBAR_WIDTH + 30, 25),   // ← same as before
                AutoSize = true
            };

            // === SEARCH BAR ===
            textBoxSearchBarDashboard = new TextBox
            {
                Size = new Size(300, 40),
                Location = new Point(0, 25),
                Font = new Font("Segoe UI", 12F),
                Text = "Search",
                ForeColor = Color.Gray,
                BackColor = Color.FromArgb(248, 249, 252),
                BorderStyle = BorderStyle.FixedSingle
            };
            textBoxSearchBarDashboard.GotFocus += (s, e) => { if (textBoxSearchBarDashboard.Text == "Search") { textBoxSearchBarDashboard.Text = ""; textBoxSearchBarDashboard.ForeColor = Color.Black; } };
            textBoxSearchBarDashboard.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(textBoxSearchBarDashboard.Text)) { textBoxSearchBarDashboard.Text = "Search"; textBoxSearchBarDashboard.ForeColor = Color.Gray; } };

            pictureBoxSearchIconDashboard = new PictureBox
            {
                Image = global::cashier_dashboard.Properties.Resources.search1, // Add search_icon.png
                Size = new Size(39, 29),
                Location = new Point(0, 25),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand
            };

            pictureBoxBellIconDashboard = new PictureBox
            {
                Image = global::cashier_dashboard.Properties.Resources.black_notification1,
                Size = new Size(39, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand
            };

            pictureBoxCartDashboard = new PictureBox
            {
                Image = global::cashier_dashboard.Properties.Resources.balck_cart1,
                Size = new Size(37, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand
            };

            pictureBoxAccountDashboard = new PictureBox
            {
                Image = global::cashier_dashboard.Properties.Resources.account1,
                Size = new Size(37, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand
            };

            panelHeader.Controls.AddRange(new Control[]
            {
                lblHeader,
                textBoxSearchBarDashboard,
                pictureBoxSearchIconDashboard,
                pictureBoxBellIconDashboard,
                pictureBoxCartDashboard,
                pictureBoxAccountDashboard
            });

            panelProducts = new Panel
            {
                Location = new Point(CONTENT_LEFT, TOP_MARGIN),
                Size = new Size(550, 280),           // Slightly taller for better look
                BackColor = Color.White,
                Padding = new Padding(15, 15, 15, 15)
            };

            labelProducts = new Label
            {
                Text = "PRODUCTS",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 60),
                Location = new Point(15, 12),
                AutoSize = true
            };

            dgvProducts = new DataGridView
            {
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                EnableHeadersVisualStyles = false,
                ColumnHeadersHeight = 48,
                RowTemplate = { Height = 48 },   
                GridColor = Color.FromArgb(235, 235, 240),
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            };

            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 255);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            dgvProducts.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 60);
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 255);
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProducts.DefaultCellStyle.Padding = new Padding(10);

            dgvProducts.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var row = dgvProducts.Rows[e.RowIndex];
                    row.DefaultCellStyle.BackColor = row.Selected ? Color.FromArgb(0, 122, 255) : Color.White;
                    row.DefaultCellStyle.ForeColor = row.Selected ? Color.White : Color.FromArgb(40, 40, 60);
                }
            };

            var productBorder = new Panel
            {
                Location = new Point(12, 45),
                Size = new Size(526, 205),       // Grid now shows 4+ rows comfortably
                BackColor = Color.FromArgb(200, 200, 210),
                Padding = new Padding(2)
            };
            productBorder.Controls.Add(dgvProducts);
            dgvProducts.Dock = DockStyle.Fill;

            panelProducts.Controls.AddRange(new Control[] { labelProducts, productBorder });


            panelCart = new Panel
            {
                Location = new Point(CONTENT_LEFT + 570, TOP_MARGIN),  // Closer together
                Size = new Size(590, 280),
                BackColor = Color.White,
                Padding = new Padding(15, 15, 15, 15)
            };

            labelCart = new Label
            {
                Text = "CART",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 50),
                Location = new Point(15, 12),
                AutoSize = true
            };

            // Buttons (created first)
            numQty = new NumericUpDown
            {
                Location = new Point(15, 218),
                Size = new Size(90, 34),
                Font = new Font("Segoe UI", 11F),
                Minimum = 1,
                Value = 1
            };

            btnAddToCart = new Button { Location = new Point(115, 217), Size = new Size(90, 36), Text = "Add" };
            btnUpdateCart = new Button { Location = new Point(215, 217), Size = new Size(90, 36), Text = "Update" };
            btnDeleteCart = new Button { Location = new Point(315, 217), Size = new Size(90, 36), Text = "Delete" };

            void StyleBtn(Button b)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = Color.FromArgb(0, 122, 255);
                b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                b.Cursor = Cursors.Hand;
            }
            StyleBtn(btnAddToCart); StyleBtn(btnUpdateCart); StyleBtn(btnDeleteCart);

            // Cart Grid – Same as Products
            dgvCart = new DataGridView
            {
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                EnableHeadersVisualStyles = false,
                ColumnHeadersHeight = 48,
                RowTemplate = { Height = 48 },
                GridColor = Color.FromArgb(235, 235, 240),
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            };

            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 255);
            dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dgvCart.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCart.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            dgvCart.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 60);
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 255);
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCart.DefaultCellStyle.Padding = new Padding(10);

            dgvCart.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var row = dgvCart.Rows[e.RowIndex];
                    row.DefaultCellStyle.BackColor = row.Selected ? Color.FromArgb(0, 122, 255) : Color.White;
                    row.DefaultCellStyle.ForeColor = row.Selected ? Color.White : Color.FromArgb(40, 40, 60);
                }
            };

            var cartBorder = new Panel
            {
                Location = new Point(12, 45),
                Size = new Size(561, 165),       // Shows 3–4 cart items easily
                BackColor = Color.FromArgb(200, 200, 210),
                Padding = new Padding(2)
            };
            cartBorder.Controls.Add(dgvCart);
            dgvCart.Dock = DockStyle.Fill;

            panelCart.Controls.AddRange(new Control[]
            {
                labelCart,
                cartBorder,
                numQty,
                btnAddToCart,
                btnUpdateCart,
                btnDeleteCart
            });

            // Events
            btnAddToCart.Click += btnAddToCart_Click;
            btnUpdateCart.Click += btnUpdateCart_Click;
            btnDeleteCart.Click += btnDeleteCart_Click;
            dgvCart.SelectionChanged += dgvCart_SelectionChanged;


            grpMembership = new GroupBox
            {
                Location = new Point(CONTENT_LEFT, TOP_MARGIN + 300),
                Size = new Size(1145, 300),
                BackColor = Color.White,
                Text = ""
            };

            // === BLUE HEADER ===
            var header = new Panel
            {
                BackColor = Color.FromArgb(0, 122, 255),
                Dock = DockStyle.Top,
                Height = 70
            };
            var lbHeader = new Label
            {
                Text = "PAYMENT SUMMARY",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                Location = new Point(30, 20),
                AutoSize = true
            };
            header.Controls.Add(lbHeader);
            grpMembership.Controls.Add(header);

            // === MEMBER ID + FIND BUTTON ===
            txtMemberId = new TextBox
            {
                Location = new Point(30, 90),
                Size = new Size(320, 48),
                Font = new Font("Segoe UI", 14F),
                BackColor = Color.FromArgb(245, 248, 255)
            };

            btnFindMember = new Button();
            btnFindMember.Text = "Find Member";
            btnFindMember.Location = new Point(365, 89);
            btnFindMember.Size = new Size(150, 50);
            btnFindMember.BackColor = Color.FromArgb(0, 122, 255);
            btnFindMember.ForeColor = Color.White;
            btnFindMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFindMember.FlatStyle = FlatStyle.Flat;
            btnFindMember.FlatAppearance.BorderSize = 0;
            btnFindMember.Click += btnFindMember_Click;

            // === CUSTOMER NAME + DISCOUNT ===
            lblMemberName = new Label();
            lblMemberName.Text = "";
            lblMemberName.Location = new Point(30, 155);
            lblMemberName.Size = new Size(380, 55);
            lblMemberName.BackColor = Color.FromArgb(235, 245, 255);
            lblMemberName.ForeColor = Color.FromArgb(0, 90, 180);
            lblMemberName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMemberName.TextAlign = ContentAlignment.MiddleLeft;
            lblMemberName.Padding = new Padding(25, 0, 0, 0);

            lblDiscount = new Label();
            lblDiscount.Text = "";
            lblDiscount.Location = new Point(425, 155);
            lblDiscount.Size = new Size(100, 55);
            lblDiscount.BackColor = Color.FromArgb(0, 180, 90);
            lblDiscount.ForeColor = Color.White;
            lblDiscount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;

            // === SUBTOTAL & TOTAL (NOW IN FRONT & PERFECT SIZE) ===
            var lblSubtotalLabel = new Label { Text = "Subtotal", Location = new Point(700, 100), ForeColor = Color.Gray, Font = new Font("Segoe UI", 13F), AutoSize = true };
            lblSubtotal = new Label();
            lblSubtotal.Text = "";
            lblSubtotal.Location = new Point(700, 125);
            lblSubtotal.Size = new Size(380, 40);
            lblSubtotal.Font = new Font("Segoe UI", 20F);
            lblSubtotal.ForeColor = Color.FromArgb(70, 70, 90);
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotal.Padding = new Padding(0, 0, 40, 0);

            var lblTotalLabel = new Label { Text = "TOTAL", Location = new Point(700, 165), ForeColor = Color.FromArgb(30, 30, 50), Font = new Font("Segoe UI", 10F, FontStyle.Bold), AutoSize = true };
            lblTotalValue = new Label();
            lblTotalValue.Text = "";
            lblTotalValue.Location = new Point(650, 165);
            lblTotalValue.Size = new Size(430, 60);
            lblTotalValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);  // Reduced from 42 → 32
            lblTotalValue.ForeColor = Color.FromArgb(0, 122, 255);
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            lblTotalValue.Padding = new Padding(0, 0, 40, 0);

            btnCheckout = new Button
            {
                Text = "CHECKOUT",
                Location = new Point(730, 220),
                Size = new Size(170, 55),
                BackColor = Color.FromArgb(0, 180, 90),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Cursor = Cursors.Hand
            };
            btnCheckout.Click += btnCheckout_Click;

            btnPrintReceipt = new Button
            {
                Text = "PRINT RECEIPT",
                Location = new Point(915, 220),
                Size = new Size(150, 55),
                BackColor = Color.FromArgb(52, 73, 94),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Cursor = Cursors.Hand
            };
            btnPrintReceipt.Click += btnDownloadReceipt_Click;


            grpMembership.Controls.AddRange(new Control[]
            {
                txtMemberId, btnFindMember,
                lblMemberName, lblDiscount,
                lblSubtotalLabel, lblSubtotal,
                lblTotalLabel, lblTotalValue,
                btnCheckout, btnPrintReceipt
            });
            this.Controls.Clear();
            this.Controls.Add(mainContainer);
            this.Controls.Add(panelHeader);
            this.Controls.Add(panelSidebar);     
            
            // Only content goes in mainContainer
            mainContainer.Controls.AddRange(new Control[]
            {
                panelProducts,
                panelCart,
                grpMembership,
                //grpAnalytics
            });

            panelProducts.BringToFront();
            panelCart.BringToFront();
            grpMembership.BringToFront();
            //grpAnalytics.BringToFront();
            // Form settings
            this.ClientSize = new Size(1400, 900);
            this.MinimumSize = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cashier Dashboard";
            this.BackColor = Color.FromArgb(245, 248, 255);

            this.Load += (s, e) => PositionHeaderControls();
            //this.Resize += (s, e) => panelSidebar.Height = this.ClientSize.Height;
            this.Resize += (s, e) =>
            {
                panelSidebar.Height = this.ClientSize.Height;
                PositionHeaderControls();
            };

            panelSidebar.BringToFront();           
            this.BackColor = Color.FromArgb(33, 43, 63);

            btnDashboard = CreateSidebarButton("Dashboard", 160, true);
            CreateSidebarButton("Cashier", 220);
            CreateSidebarButton("Reporting", 280);
            CreateSidebarButton("Logout", 340);

            this.ResumeLayout(false);
        }

        // Helper to switch panels
        private void ShowPanel(Control panel)
        {
            panel.BringToFront();

            // Auto-scroll to show the panel
            mainContainer.ScrollControlIntoView(panel);

            // Extra smooth scroll to top of panel
            int offset = panel.Top - 100;
            if (offset < 0) offset = 0;
            mainContainer.AutoScrollPosition = new Point(0, offset);
        }

        private void SetupSidebarButton(Button btn, string text, int y)
        {
            btn.Text = text;
            btn.Width = 160;
            btn.Height = 45;
            btn.Location = new Point(10, y);
            btn.BackColor = Color.FromArgb(52, 73, 94);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);
        }

        private void PositionHeaderControls()
        {
            int right = this.ClientSize.Width - 30;
            pictureBoxAccountDashboard.Location = new Point(right - 45, 22); right -= 55;
            pictureBoxCartDashboard.Location = new Point(right - 45, 22); right -= 55;
            pictureBoxBellIconDashboard.Location = new Point(right - 45, 22); right -= 65;
            pictureBoxSearchIconDashboard.Location = new Point(right - 40, 25); right -= 45;
            textBoxSearchBarDashboard.Location = new Point(right - 300, 25);
        }

        private void ShowPage(string pageName)
        {
            lblHeader.Text = pageName;
            foreach (Button btn in panelSidebar.Controls.OfType<Button>())
            {
                {
                    bool active = btn.Text == pageName;
                    btn.BackColor = active ? Color.FromArgb(0, 122, 255) : Color.Transparent;
                    btn.Font = new Font("Segoe UI", 11F, active ? FontStyle.Bold : FontStyle.Regular);

                    var indicator = btn.Controls.OfType<Panel>().FirstOrDefault();
                    if (indicator != null) btn.Controls.Remove(indicator);
                    if (active)
                    {
                        btn.Controls.Add(new Panel { Width = 5, Height = 48, BackColor = Color.FromArgb(0, 180, 255) });
                    }
                }
            }
        }
        private Panel panelDashboardPlaceholder() => new Panel { BackColor = Color.Yellow, Size = new Size(200, 200) };

        private void ShowPanel(Panel p)
        {
            mainContainer.Controls.Add(p);
            p.BringToFront();
            mainContainer.ScrollControlIntoView(p);
        }      
    }
}
