using POS_CoffeShop.Modules;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_CoffeShop
{
    public partial class reports : Form
    {
        // Create module object
        private ReportModule reportModule = new ReportModule();

        public reports()
        {
            InitializeComponent();

            // Connect event handlers
            ConnectEventHandlers();

            // Initialize dropdowns
            InitializeControls();
        }

        private void ConnectEventHandlers()
        {
            // Connect button events
            btnGenerate.Click += BtnGenerate_Click;
            btnExport.Click += BtnExport_Click;
            btnPrint.Click += BtnPrint_Click;

            // Connect combobox event
            cmbPeriod.SelectedIndexChanged += CmbPeriod_SelectedIndexChanged;
        }

        private void InitializeControls()
        {
            // Set default selections
            if (cmbReportType.Items.Count > 0)
                cmbReportType.SelectedIndex = 0;

            if (cmbPeriod.Items.Count > 0)
                cmbPeriod.SelectedIndex = 2; // This Month

            // Set dropdown styles
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPeriod.SelectedItem == null)
                return;

            bool isCustomRange = cmbPeriod.SelectedItem.ToString() == "Custom Range";
            dtpFrom.Enabled = isCustomRange;
            dtpTo.Enabled = isCustomRange;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reportType = cmbReportType.SelectedItem.ToString();

            // Clear existing controls except dgvReport
            var controlsToRemove = new System.Collections.Generic.List<Control>();
            foreach (Control ctrl in reportPanel.Controls)
            {
                if (ctrl != dgvReport)
                    controlsToRemove.Add(ctrl);
            }
            foreach (var ctrl in controlsToRemove)
            {
                reportPanel.Controls.Remove(ctrl);
            }

            // Clear grid
            dgvReport.Columns.Clear();
            dgvReport.Rows.Clear();

            // Add title
            Label lblReportTitle = new Label();
            lblReportTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReportTitle.Location = new Point(10, 10);
            lblReportTitle.Size = new Size(500, 30);
            reportPanel.Controls.Add(lblReportTitle);

            // Generate report based on selection
            try
            {
                switch (reportType)
                {
                    case "Sales Report":
                        lblReportTitle.Text = "Sales Report - " + cmbPeriod.SelectedItem.ToString();
                        reportModule.GenerateSalesReport(dgvReport);
                        break;
                    case "Income Report":
                        lblReportTitle.Text = "Income Report - " + cmbPeriod.SelectedItem.ToString();
                        reportModule.GenerateIncomeReport(dgvReport);
                        break;
                    case "Product Sales":
                        lblReportTitle.Text = "Product Sales Report";
                        reportModule.GenerateProductSalesReport(dgvReport);
                        break;
                    case "Inventory Report":
                        lblReportTitle.Text = "Inventory Report";
                        reportModule.GenerateInventoryReport(dgvReport);
                        break;
                    case "Customer Report":
                        lblReportTitle.Text = "Customer Report";
                        reportModule.GenerateCustomerReport(dgvReport);
                        break;
                    case "Staff Performance":
                        lblReportTitle.Text = "Staff Performance Report";
                        reportModule.GenerateStaffPerformanceReport(dgvReport);
                        break;
                }

                AddReportSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddReportSummary()
        {
            Label lblSummary = new Label();
            lblSummary.Text =
                $"Report Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n" +
                $"Period: {cmbPeriod.SelectedItem}\n" +
                $"Total Records: {dgvReport.Rows.Count}";
            lblSummary.Location = new Point(10, 380);
            lblSummary.Size = new Size(1100, 50);
            lblSummary.ForeColor = Color.Gray;
            lblSummary.Font = new Font("Segoe UI", 9F);
            reportPanel.Controls.Add(lblSummary);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export functionality would save the report to Excel file.\n" +
                          "Implementation requires Excel library (e.g., EPPlus or ClosedXML).",
                          "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality would open print dialog.\n" +
                          "Implementation requires PrintDocument class.",
                          "Print Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reports_Load(object sender, EventArgs e)
        {
            // Form load event
        }
    }
}