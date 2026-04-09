using System;
using System.Windows.Forms;

namespace POS_CoffeShop.Modules
{
    public class SettingModule
    {
        // Default settings
        private string defaultShopName = "Coffee Paradise";
        private string defaultAddress = "123 Main Street\nCity Center, State 12345";
        private string defaultPhone = "012-345-6789";
        private string defaultEmail = "info@coffeeparadise.com";
        private string defaultTaxRate = "10";
        private string defaultServiceCharge = "5";
        private string defaultCurrency = "$";

        public void LoadSettings(
            TextBox txtShopName, TextBox txtAddress, TextBox txtPhone, TextBox txtEmail,
            TextBox txtTaxRate, TextBox txtServiceCharge, TextBox txtCurrency,
            ComboBox cmbTheme, ComboBox cmbLanguage, ComboBox cmbPrinter,
            CheckBox chkAutoBackup, CheckBox chkNotifications, CheckBox chkReceipt)
        {
            // Load shop information
            txtShopName.Text = defaultShopName;
            txtAddress.Text = defaultAddress;
            txtPhone.Text = defaultPhone;
            txtEmail.Text = defaultEmail;

            // Load business settings
            txtTaxRate.Text = defaultTaxRate;
            txtServiceCharge.Text = defaultServiceCharge;
            txtCurrency.Text = defaultCurrency;

            // Load theme settings
            if (cmbTheme.Items.Count > 0)
                cmbTheme.SelectedIndex = 0; // Light

            // Load language settings
            if (cmbLanguage.Items.Count > 0)
                cmbLanguage.SelectedIndex = 0; // English

            // Load printer settings
            if (cmbPrinter.Items.Count > 0)
                cmbPrinter.SelectedIndex = 0; // Default Printer

            // Load checkbox settings
            chkAutoBackup.Checked = true;
            chkNotifications.Checked = true;
            chkReceipt.Checked = true;
        }

        public void SaveSettings(
            string shopName, string address, string phone, string email,
            string taxRate, string serviceCharge, string currency,
            string theme, string language, string printer,
            bool autoBackup, bool notifications, bool receipt)
        {
            // In a real application, save to database or config file
            // For now, just store in memory
            defaultShopName = shopName;
            defaultAddress = address;
            defaultPhone = phone;
            defaultEmail = email;
            defaultTaxRate = taxRate;
            defaultServiceCharge = serviceCharge;
            defaultCurrency = currency;

            // Log the saved settings (for debugging)
            System.Diagnostics.Debug.WriteLine("Settings Saved:");
            System.Diagnostics.Debug.WriteLine($"Shop Name: {shopName}");
            System.Diagnostics.Debug.WriteLine($"Theme: {theme}");
            System.Diagnostics.Debug.WriteLine($"Language: {language}");
            System.Diagnostics.Debug.WriteLine($"Auto Backup: {autoBackup}");
        }

        public bool ValidateSettings(string shopName, string taxRate, string serviceCharge, out string errorMsg)
        {
            errorMsg = "";

            // Validate shop name
            if (string.IsNullOrWhiteSpace(shopName))
            {
                errorMsg = "Please enter shop name!";
                return false;
            }

            // Validate tax rate
            if (!decimal.TryParse(taxRate, out decimal tax) || tax < 0 || tax > 100)
            {
                errorMsg = "Please enter a valid tax rate (0-100)!";
                return false;
            }

            // Validate service charge
            if (!decimal.TryParse(serviceCharge, out decimal service) || service < 0 || service > 100)
            {
                errorMsg = "Please enter a valid service charge (0-100)!";
                return false;
            }

            return true;
        }

        public string CreateBackup()
        {
            // In a real application, create actual database backup
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupPath = $"C:\\POS\\Backups\\backup_{timestamp}.bak";

            return $"Database backup created successfully!\n\nLocation: {backupPath}";
        }

        public DialogResult ConfirmRestore()
        {
            return MessageBox.Show(
                "Restoring from backup will overwrite current data.\n" +
                "Are you sure you want to continue?",
                "Confirm Restore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }

        // Get current settings as a summary
        public string GetSettingsSummary()
        {
            return $"Shop Name: {defaultShopName}\n" +
                   $"Phone: {defaultPhone}\n" +
                   $"Email: {defaultEmail}\n" +
                   $"Tax Rate: {defaultTaxRate}%\n" +
                   $"Service Charge: {defaultServiceCharge}%\n" +
                   $"Currency: {defaultCurrency}";
        }

        // Reset settings to defaults
        public void ResetToDefaults(
            TextBox txtShopName, TextBox txtAddress, TextBox txtPhone, TextBox txtEmail,
            TextBox txtTaxRate, TextBox txtServiceCharge, TextBox txtCurrency,
            ComboBox cmbTheme, ComboBox cmbLanguage, ComboBox cmbPrinter,
            CheckBox chkAutoBackup, CheckBox chkNotifications, CheckBox chkReceipt)
        {
            // Reset to original defaults
            defaultShopName = "Coffee Paradise";
            defaultAddress = "123 Main Street\nCity Center, State 12345";
            defaultPhone = "012-345-6789";
            defaultEmail = "info@coffeeparadise.com";
            defaultTaxRate = "10";
            defaultServiceCharge = "5";
            defaultCurrency = "$";

            // Reload settings
            LoadSettings(
                txtShopName, txtAddress, txtPhone, txtEmail,
                txtTaxRate, txtServiceCharge, txtCurrency,
                cmbTheme, cmbLanguage, cmbPrinter,
                chkAutoBackup, chkNotifications, chkReceipt);
        }
    }
}