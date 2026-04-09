using System.Windows.Forms;
using System.Drawing;

namespace CoffeeShopPOS
{
    partial class SignupForm
    {
        private System.ComponentModel.IContainer componentsSignup = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (componentsSignup != null))
                componentsSignup.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeftSignup = new System.Windows.Forms.Panel();
            this.labelWelcomeSignup = new System.Windows.Forms.Label();
            this.labelSystemNameSignup = new System.Windows.Forms.Label();
            this.btnSigninSignup = new System.Windows.Forms.Button();
            this.btnSignupLeftSignup = new System.Windows.Forms.Button();
            this.panelRightSignup = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsernameSignup = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswordSignup = new System.Windows.Forms.TextBox();
            this.btnSignupSignup = new System.Windows.Forms.Button();
            this.lblNoAccountSignup = new System.Windows.Forms.Label();
            this.lblUsernameSignup = new System.Windows.Forms.Label();
            this.lblConfirmPasswordSignup = new System.Windows.Forms.Label();
            this.txtPasswordSignup = new System.Windows.Forms.TextBox();
            this.lblEmailSignup = new System.Windows.Forms.Label();
            this.lblPasswordSignup = new System.Windows.Forms.Label();
            this.txtEmailSignup = new System.Windows.Forms.TextBox();
            this.labelCreateAccountSignup = new System.Windows.Forms.Label();
            this.panelLeftSignup.SuspendLayout();
            this.panelRightSignup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSignup
            // 
            this.panelLeftSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelLeftSignup.Controls.Add(this.labelWelcomeSignup);
            this.panelLeftSignup.Controls.Add(this.labelSystemNameSignup);
            this.panelLeftSignup.Controls.Add(this.btnSigninSignup);
            this.panelLeftSignup.Controls.Add(this.btnSignupLeftSignup);
            this.panelLeftSignup.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSignup.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSignup.Name = "panelLeftSignup";
            this.panelLeftSignup.Size = new System.Drawing.Size(379, 600);
            this.panelLeftSignup.TabIndex = 0;
            // 
            // labelWelcomeSignup
            // 
            this.labelWelcomeSignup.AutoSize = true;
            this.labelWelcomeSignup.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelWelcomeSignup.ForeColor = System.Drawing.Color.White;
            this.labelWelcomeSignup.Location = new System.Drawing.Point(91, 200);
            this.labelWelcomeSignup.Name = "labelWelcomeSignup";
            this.labelWelcomeSignup.Size = new System.Drawing.Size(203, 37);
            this.labelWelcomeSignup.TabIndex = 0;
            this.labelWelcomeSignup.Text = "Welcome Back";
            // 
            // labelSystemNameSignup
            // 
            this.labelSystemNameSignup.AutoSize = true;
            this.labelSystemNameSignup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSystemNameSignup.ForeColor = System.Drawing.Color.White;
            this.labelSystemNameSignup.Location = new System.Drawing.Point(55, 253);
            this.labelSystemNameSignup.Name = "labelSystemNameSignup";
            this.labelSystemNameSignup.Size = new System.Drawing.Size(274, 23);
            this.labelSystemNameSignup.TabIndex = 1;
            this.labelSystemNameSignup.Text = "Sell More. Waste Less. Smile Often.";
            // 
            // btnSigninSignup
            // 
            this.btnSigninSignup.BackColor = System.Drawing.Color.White;
            this.btnSigninSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigninSignup.Location = new System.Drawing.Point(98, 301);
            this.btnSigninSignup.Name = "btnSigninSignup";
            this.btnSigninSignup.Size = new System.Drawing.Size(80, 35);
            this.btnSigninSignup.TabIndex = 2;
            this.btnSigninSignup.Text = "SIGN IN";
            this.btnSigninSignup.UseVisualStyleBackColor = false;
            this.btnSigninSignup.Click += new System.EventHandler(this.btnSigninSignup_Click);
            // 
            // btnSignupLeftSignup
            // 
            this.btnSignupLeftSignup.BackColor = System.Drawing.Color.White;
            this.btnSignupLeftSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupLeftSignup.Location = new System.Drawing.Point(193, 301);
            this.btnSignupLeftSignup.Name = "btnSignupLeftSignup";
            this.btnSignupLeftSignup.Size = new System.Drawing.Size(80, 35);
            this.btnSignupLeftSignup.TabIndex = 3;
            this.btnSignupLeftSignup.Text = "SIGN UP";
            this.btnSignupLeftSignup.UseVisualStyleBackColor = false;
            this.btnSignupLeftSignup.Click += new System.EventHandler(this.btnSignupLeftSignup_Click);
            // 
            // panelRightSignup
            // 
            this.panelRightSignup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRightSignup.Controls.Add(this.groupBox1);
            this.panelRightSignup.Controls.Add(this.labelCreateAccountSignup);
            this.panelRightSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSignup.Location = new System.Drawing.Point(379, 0);
            this.panelRightSignup.Name = "panelRightSignup";
            this.panelRightSignup.Size = new System.Drawing.Size(521, 600);
            this.panelRightSignup.TabIndex = 1;
            this.panelRightSignup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightSignup_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsernameSignup);
            this.groupBox1.Controls.Add(this.txtConfirmPasswordSignup);
            this.groupBox1.Controls.Add(this.btnSignupSignup);
            this.groupBox1.Controls.Add(this.lblNoAccountSignup);
            this.groupBox1.Controls.Add(this.lblUsernameSignup);
            this.groupBox1.Controls.Add(this.lblConfirmPasswordSignup);
            this.groupBox1.Controls.Add(this.txtPasswordSignup);
            this.groupBox1.Controls.Add(this.lblEmailSignup);
            this.groupBox1.Controls.Add(this.lblPasswordSignup);
            this.groupBox1.Controls.Add(this.txtEmailSignup);
            this.groupBox1.Location = new System.Drawing.Point(33, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 473);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.twitter;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(272, 350);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(66, 57);
            this.panel7.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.g;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(203, 350);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 57);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.facebook4;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(127, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 53);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.eye_open_close_2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(383, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(31, 25);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.eye_open_close_1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(383, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(31, 25);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.email;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(381, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 25);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.account;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(380, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 25);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(170, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Or Signup with";
            // 
            // txtUsernameSignup
            // 
            this.txtUsernameSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignup.Location = new System.Drawing.Point(232, 48);
            this.txtUsernameSignup.Name = "txtUsernameSignup";
            this.txtUsernameSignup.Size = new System.Drawing.Size(180, 27);
            this.txtUsernameSignup.TabIndex = 2;
            this.txtUsernameSignup.TextChanged += new System.EventHandler(this.txtUsernameSignup_TextChanged);
            // 
            // txtConfirmPasswordSignup
            // 
            this.txtConfirmPasswordSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordSignup.Location = new System.Drawing.Point(234, 182);
            this.txtConfirmPasswordSignup.Name = "txtConfirmPasswordSignup";
            this.txtConfirmPasswordSignup.Size = new System.Drawing.Size(180, 27);
            this.txtConfirmPasswordSignup.TabIndex = 8;
            this.txtConfirmPasswordSignup.UseSystemPasswordChar = true;
            this.txtConfirmPasswordSignup.TextChanged += new System.EventHandler(this.txtConfirmPasswordSignup_TextChanged);
            // 
            // btnSignupSignup
            // 
            this.btnSignupSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSignupSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupSignup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignupSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignupSignup.Location = new System.Drawing.Point(158, 265);
            this.btnSignupSignup.Name = "btnSignupSignup";
            this.btnSignupSignup.Size = new System.Drawing.Size(140, 35);
            this.btnSignupSignup.TabIndex = 10;
            this.btnSignupSignup.Text = "SIGN UP";
            this.btnSignupSignup.UseVisualStyleBackColor = false;
            // 
            // lblNoAccountSignup
            // 
            this.lblNoAccountSignup.AutoSize = true;
            this.lblNoAccountSignup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccountSignup.ForeColor = System.Drawing.Color.Blue;
            this.lblNoAccountSignup.Location = new System.Drawing.Point(275, 225);
            this.lblNoAccountSignup.Name = "lblNoAccountSignup";
            this.lblNoAccountSignup.Size = new System.Drawing.Size(144, 23);
            this.lblNoAccountSignup.TabIndex = 9;
            this.lblNoAccountSignup.Text = "Forgot password?";
            // 
            // lblUsernameSignup
            // 
            this.lblUsernameSignup.AutoSize = true;
            this.lblUsernameSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameSignup.Location = new System.Drawing.Point(42, 49);
            this.lblUsernameSignup.Name = "lblUsernameSignup";
            this.lblUsernameSignup.Size = new System.Drawing.Size(108, 25);
            this.lblUsernameSignup.TabIndex = 1;
            this.lblUsernameSignup.Text = "Username:";
            this.lblUsernameSignup.Click += new System.EventHandler(this.lblUsernameSignup_Click);
            // 
            // lblConfirmPasswordSignup
            // 
            this.lblConfirmPasswordSignup.AutoSize = true;
            this.lblConfirmPasswordSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordSignup.Location = new System.Drawing.Point(42, 184);
            this.lblConfirmPasswordSignup.Name = "lblConfirmPasswordSignup";
            this.lblConfirmPasswordSignup.Size = new System.Drawing.Size(177, 25);
            this.lblConfirmPasswordSignup.TabIndex = 7;
            this.lblConfirmPasswordSignup.Text = "Confirm Password:";
            this.lblConfirmPasswordSignup.Click += new System.EventHandler(this.lblConfirmPasswordSignup_Click);
            // 
            // txtPasswordSignup
            // 
            this.txtPasswordSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignup.Location = new System.Drawing.Point(234, 137);
            this.txtPasswordSignup.Name = "txtPasswordSignup";
            this.txtPasswordSignup.Size = new System.Drawing.Size(180, 27);
            this.txtPasswordSignup.TabIndex = 6;
            this.txtPasswordSignup.UseSystemPasswordChar = true;
            this.txtPasswordSignup.TextChanged += new System.EventHandler(this.txtPasswordSignup_TextChanged);
            // 
            // lblEmailSignup
            // 
            this.lblEmailSignup.AutoSize = true;
            this.lblEmailSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSignup.Location = new System.Drawing.Point(42, 94);
            this.lblEmailSignup.Name = "lblEmailSignup";
            this.lblEmailSignup.Size = new System.Drawing.Size(66, 25);
            this.lblEmailSignup.TabIndex = 3;
            this.lblEmailSignup.Text = "Email:";
            this.lblEmailSignup.Click += new System.EventHandler(this.lblEmailSignup_Click);
            // 
            // lblPasswordSignup
            // 
            this.lblPasswordSignup.AutoSize = true;
            this.lblPasswordSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignup.Location = new System.Drawing.Point(42, 139);
            this.lblPasswordSignup.Name = "lblPasswordSignup";
            this.lblPasswordSignup.Size = new System.Drawing.Size(104, 25);
            this.lblPasswordSignup.TabIndex = 5;
            this.lblPasswordSignup.Text = "Password:";
            this.lblPasswordSignup.Click += new System.EventHandler(this.lblPasswordSignup_Click);
            // 
            // txtEmailSignup
            // 
            this.txtEmailSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSignup.Location = new System.Drawing.Point(232, 92);
            this.txtEmailSignup.Name = "txtEmailSignup";
            this.txtEmailSignup.Size = new System.Drawing.Size(180, 27);
            this.txtEmailSignup.TabIndex = 4;
            this.txtEmailSignup.TextChanged += new System.EventHandler(this.txtEmailSignup_TextChanged);
            // 
            // labelCreateAccountSignup
            // 
            this.labelCreateAccountSignup.AutoSize = true;
            this.labelCreateAccountSignup.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelCreateAccountSignup.Location = new System.Drawing.Point(164, 29);
            this.labelCreateAccountSignup.Name = "labelCreateAccountSignup";
            this.labelCreateAccountSignup.Size = new System.Drawing.Size(213, 37);
            this.labelCreateAccountSignup.TabIndex = 0;
            this.labelCreateAccountSignup.Text = "Create Account";
            // 
            // SignupForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelRightSignup);
            this.Controls.Add(this.panelLeftSignup);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup Form";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.panelLeftSignup.ResumeLayout(false);
            this.panelLeftSignup.PerformLayout();
            this.panelRightSignup.ResumeLayout(false);
            this.panelRightSignup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel panelLeftSignup;
        private Label labelWelcomeSignup;
        private Label labelSystemNameSignup;
        private Button btnSigninSignup;
        private Button btnSignupLeftSignup;

        private Panel panelRightSignup;
        private Label labelCreateAccountSignup;

        private Label lblUsernameSignup;
        private TextBox txtUsernameSignup;

        private Label lblEmailSignup;
        private TextBox txtEmailSignup;

        private Label lblPasswordSignup;
        private TextBox txtPasswordSignup;

        private Label lblConfirmPasswordSignup;
        private TextBox txtConfirmPasswordSignup;

        private Label lblNoAccountSignup;
        private Button btnSignupSignup;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private Panel panel7;
    }
}
