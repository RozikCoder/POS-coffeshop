namespace CoffeeShopPOS
{
    partial class SigninForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelCreateAccountLogin = new System.Windows.Forms.Label();
            this.label1Login = new System.Windows.Forms.Label();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.btnSignupLogin = new System.Windows.Forms.Button();
            this.lblNoAccountLogin = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.groupBox1Login = new System.Windows.Forms.GroupBox();
            this.panel3Login = new System.Windows.Forms.Panel();
            this.panel1Login = new System.Windows.Forms.Panel();
            this.panelLeftLogin = new System.Windows.Forms.Panel();
            this.labelWelcomeLogin = new System.Windows.Forms.Label();
            this.labelSystemNameLogin = new System.Windows.Forms.Label();
            this.btnSigninLogin = new System.Windows.Forms.Button();
            this.btnSignupLeftLogin = new System.Windows.Forms.Button();
            this.panelRightLogin = new System.Windows.Forms.Panel();
            this.label2Login = new System.Windows.Forms.Label();
            this.groupBox1Login.SuspendLayout();
            this.panelLeftLogin.SuspendLayout();
            this.panelRightLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreateAccountLogin
            // 
            this.labelCreateAccountLogin.AutoSize = true;
            this.labelCreateAccountLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelCreateAccountLogin.Location = new System.Drawing.Point(164, 29);
            this.labelCreateAccountLogin.Name = "labelCreateAccountLogin";
            this.labelCreateAccountLogin.Size = new System.Drawing.Size(213, 37);
            this.labelCreateAccountLogin.TabIndex = 2;
            this.labelCreateAccountLogin.Text = "Create Account";
            // 
            // label1Login
            // 
            this.label1Login.AutoSize = true;
            this.label1Login.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1Login.ForeColor = System.Drawing.Color.Blue;
            this.label1Login.Location = new System.Drawing.Point(271, 187);
            this.label1Login.Name = "label1Login";
            this.label1Login.Size = new System.Drawing.Size(144, 23);
            this.label1Login.TabIndex = 5;
            this.label1Login.Text = "Forgot password?";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtUsernameLogin.Location = new System.Drawing.Point(233, 94);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(180, 27);
            this.txtUsernameLogin.TabIndex = 6;
            // 
            // btnSignupLogin
            // 
            this.btnSignupLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSignupLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignupLogin.ForeColor = System.Drawing.Color.White;
            this.btnSignupLogin.Location = new System.Drawing.Point(159, 231);
            this.btnSignupLogin.Name = "btnSignupLogin";
            this.btnSignupLogin.Size = new System.Drawing.Size(140, 35);
            this.btnSignupLogin.TabIndex = 7;
            this.btnSignupLogin.Text = "SIGN IN";
            this.btnSignupLogin.UseVisualStyleBackColor = false;
            this.btnSignupLogin.Click += new System.EventHandler(this.btnSignupLogin_Click);
            // 
            // lblNoAccountLogin
            // 
            this.lblNoAccountLogin.AutoSize = true;
            this.lblNoAccountLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblNoAccountLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblNoAccountLogin.Location = new System.Drawing.Point(94, 281);
            this.lblNoAccountLogin.Name = "lblNoAccountLogin";
            this.lblNoAccountLogin.Size = new System.Drawing.Size(280, 23);
            this.lblNoAccountLogin.TabIndex = 8;
            this.lblNoAccountLogin.Text = "Don’t have an account? Create one";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsernameLogin.Location = new System.Drawing.Point(43, 95);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(108, 25);
            this.lblUsernameLogin.TabIndex = 9;
            this.lblUsernameLogin.Text = "Username:";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtPasswordLogin.Location = new System.Drawing.Point(235, 140);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(180, 27);
            this.txtPasswordLogin.TabIndex = 10;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasswordLogin.Location = new System.Drawing.Point(43, 142);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(104, 25);
            this.lblPasswordLogin.TabIndex = 11;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // groupBox1Login
            // 
            this.groupBox1Login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1Login.Controls.Add(this.panel3Login);
            this.groupBox1Login.Controls.Add(this.panel1Login);
            this.groupBox1Login.Controls.Add(this.label1Login);
            this.groupBox1Login.Controls.Add(this.txtUsernameLogin);
            this.groupBox1Login.Controls.Add(this.btnSignupLogin);
            this.groupBox1Login.Controls.Add(this.lblNoAccountLogin);
            this.groupBox1Login.Controls.Add(this.lblUsernameLogin);
            this.groupBox1Login.Controls.Add(this.txtPasswordLogin);
            this.groupBox1Login.Controls.Add(this.lblPasswordLogin);
            this.groupBox1Login.Location = new System.Drawing.Point(411, 85);
            this.groupBox1Login.Name = "groupBox1Login";
            this.groupBox1Login.Size = new System.Drawing.Size(456, 391);
            this.groupBox1Login.TabIndex = 1;
            this.groupBox1Login.TabStop = false;
            // 
            // panel3Login
            // 
            this.panel3Login.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.eye_open_close_;
            this.panel3Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3Login.Location = new System.Drawing.Point(384, 140);
            this.panel3Login.Name = "panel3Login";
            this.panel3Login.Size = new System.Drawing.Size(31, 25);
            this.panel3Login.TabIndex = 3;
            // 
            // panel1Login
            // 
            this.panel1Login.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.account;
            this.panel1Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1Login.Location = new System.Drawing.Point(381, 95);
            this.panel1Login.Name = "panel1Login";
            this.panel1Login.Size = new System.Drawing.Size(31, 25);
            this.panel1Login.TabIndex = 4;
            // 
            // panelLeftLogin
            // 
            this.panelLeftLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelLeftLogin.Controls.Add(this.labelWelcomeLogin);
            this.panelLeftLogin.Controls.Add(this.labelSystemNameLogin);
            this.panelLeftLogin.Controls.Add(this.btnSigninLogin);
            this.panelLeftLogin.Controls.Add(this.btnSignupLeftLogin);
            this.panelLeftLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLeftLogin.Name = "panelLeftLogin";
            this.panelLeftLogin.Size = new System.Drawing.Size(379, 600);
            this.panelLeftLogin.TabIndex = 0;
            // 
            // labelWelcomeLogin
            // 
            this.labelWelcomeLogin.AutoSize = true;
            this.labelWelcomeLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelWelcomeLogin.ForeColor = System.Drawing.Color.White;
            this.labelWelcomeLogin.Location = new System.Drawing.Point(91, 200);
            this.labelWelcomeLogin.Name = "labelWelcomeLogin";
            this.labelWelcomeLogin.Size = new System.Drawing.Size(203, 37);
            this.labelWelcomeLogin.TabIndex = 0;
            this.labelWelcomeLogin.Text = "Welcome Back";
            // 
            // labelSystemNameLogin
            // 
            this.labelSystemNameLogin.AutoSize = true;
            this.labelSystemNameLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSystemNameLogin.ForeColor = System.Drawing.Color.White;
            this.labelSystemNameLogin.Location = new System.Drawing.Point(55, 253);
            this.labelSystemNameLogin.Name = "labelSystemNameLogin";
            this.labelSystemNameLogin.Size = new System.Drawing.Size(274, 23);
            this.labelSystemNameLogin.TabIndex = 1;
            this.labelSystemNameLogin.Text = "Sell More. Waste Less. Smile Often.";
            // 
            // btnSigninLogin
            // 
            this.btnSigninLogin.BackColor = System.Drawing.Color.White;
            this.btnSigninLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigninLogin.Location = new System.Drawing.Point(98, 301);
            this.btnSigninLogin.Name = "btnSigninLogin";
            this.btnSigninLogin.Size = new System.Drawing.Size(80, 35);
            this.btnSigninLogin.TabIndex = 2;
            this.btnSigninLogin.Text = "SIGN IN";
            this.btnSigninLogin.UseVisualStyleBackColor = false;
            this.btnSigninLogin.Click += new System.EventHandler(this.btnSigninLogin_Click);
            // 
            // btnSignupLeftLogin
            // 
            this.btnSignupLeftLogin.BackColor = System.Drawing.Color.White;
            this.btnSignupLeftLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupLeftLogin.Location = new System.Drawing.Point(193, 301);
            this.btnSignupLeftLogin.Name = "btnSignupLeftLogin";
            this.btnSignupLeftLogin.Size = new System.Drawing.Size(80, 35);
            this.btnSignupLeftLogin.TabIndex = 3;
            this.btnSignupLeftLogin.Text = "SIGN UP";
            this.btnSignupLeftLogin.UseVisualStyleBackColor = false;
            this.btnSignupLeftLogin.Click += new System.EventHandler(this.btnSignupLeftLogin_Click);
            // 
            // panelRightLogin
            // 
            this.panelRightLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRightLogin.Controls.Add(this.label2Login);
            this.panelRightLogin.Controls.Add(this.groupBox1Login);
            this.panelRightLogin.Controls.Add(this.labelCreateAccountLogin);
            this.panelRightLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightLogin.Location = new System.Drawing.Point(0, 0);
            this.panelRightLogin.Name = "panelRightLogin";
            this.panelRightLogin.Size = new System.Drawing.Size(900, 600);
            this.panelRightLogin.TabIndex = 1;
            this.panelRightLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightLogin_Paint);
            // 
            // label2Login
            // 
            this.label2Login.AutoSize = true;
            this.label2Login.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2Login.Location = new System.Drawing.Point(607, 29);
            this.label2Login.Name = "label2Login";
            this.label2Login.Size = new System.Drawing.Size(89, 37);
            this.label2Login.TabIndex = 0;
            this.label2Login.Text = "Login";
            // 
            // SigninForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelLeftLogin);
            this.Controls.Add(this.panelRightLogin);
            this.Name = "SigninForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigninForm";
            this.Load += new System.EventHandler(this.SigninForm_Load);
            this.groupBox1Login.ResumeLayout(false);
            this.groupBox1Login.PerformLayout();
            this.panelLeftLogin.ResumeLayout(false);
            this.panelLeftLogin.PerformLayout();
            this.panelRightLogin.ResumeLayout(false);
            this.panelRightLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3Login;
        private System.Windows.Forms.Panel panel1Login;
        private System.Windows.Forms.Label labelCreateAccountLogin;
        private System.Windows.Forms.Label label1Login;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Button btnSignupLogin;
        private System.Windows.Forms.Label lblNoAccountLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.GroupBox groupBox1Login;
        private System.Windows.Forms.Panel panelLeftLogin;
        private System.Windows.Forms.Label labelWelcomeLogin;
        private System.Windows.Forms.Label labelSystemNameLogin;
        private System.Windows.Forms.Button btnSigninLogin;
        private System.Windows.Forms.Button btnSignupLeftLogin;
        private System.Windows.Forms.Panel panelRightLogin;
        private System.Windows.Forms.Label label2Login;
    }
}
