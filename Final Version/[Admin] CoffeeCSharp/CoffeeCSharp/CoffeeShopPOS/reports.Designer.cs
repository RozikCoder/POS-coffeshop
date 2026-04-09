using System.Windows.Forms;
using System.Drawing;

namespace POS_CoffeShop
{
    partial class reports
    {
        private ComboBox cmbReportType;
        private ComboBox cmbPeriod;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnGenerate;
        private Button btnExport;
        private Button btnPrint;
        private Panel reportPanel;
        private DataGridView dgvReport;

        private void InitializeComponent()
        {
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.lblReportType = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.Items.AddRange(new object[] {
            "Sales Report",
            "Income Report",
            "Product Sales",
            "Inventory Report",
            "Customer Report",
            "Staff Performance"});
            this.cmbReportType.Location = new System.Drawing.Point(20, 45);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(200, 24);
            this.cmbReportType.TabIndex = 1;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month",
            "This Year",
            "Custom Range"});
            this.cmbPeriod.Location = new System.Drawing.Point(240, 45);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(150, 24);
            this.cmbPeriod.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(410, 45);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(630, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(860, 40);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Report";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(818, 578);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 32);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(911, 578);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 32);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.White;
            this.reportPanel.Controls.Add(this.dgvReport);
            this.reportPanel.Location = new System.Drawing.Point(20, 150);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(984, 408);
            this.reportPanel.TabIndex = 1;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeight = 29;
            this.dgvReport.Location = new System.Drawing.Point(10, 50);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(945, 320);
            this.dgvReport.TabIndex = 0;
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.White;
            this.filterPanel.Controls.Add(this.lblReportType);
            this.filterPanel.Controls.Add(this.cmbReportType);
            this.filterPanel.Controls.Add(this.lblPeriod);
            this.filterPanel.Controls.Add(this.cmbPeriod);
            this.filterPanel.Controls.Add(this.dtpFrom);
            this.filterPanel.Controls.Add(this.dtpTo);
            this.filterPanel.Controls.Add(this.btnGenerate);
            this.filterPanel.Location = new System.Drawing.Point(20, 20);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(984, 120);
            this.filterPanel.TabIndex = 0;
            // 
            // lblReportType
            // 
            this.lblReportType.Location = new System.Drawing.Point(20, 15);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(100, 23);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(240, 15);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(100, 23);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Period:";
            // 
            // reports
            // 
            this.ClientSize = new System.Drawing.Size(1038, 627);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Name = "reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports & Analytics";
            this.Load += new System.EventHandler(this.reports_Load);
            this.reportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel filterPanel;
        private Label lblReportType;
        private Label lblPeriod;
    }
}
