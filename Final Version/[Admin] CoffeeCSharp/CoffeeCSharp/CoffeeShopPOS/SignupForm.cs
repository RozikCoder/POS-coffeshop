using System;
using System.Windows.Forms;

namespace CoffeeShopPOS
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void panelRightSignup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtConfirmPasswordSignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmPasswordSignup_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordSignup_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordSignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailSignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmailSignup_Click(object sender, EventArgs e)
        {

        }

        private void lblUsernameSignup_Click(object sender, EventArgs e)
        {

        }

        private void txtUsernameSignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignupLeftSignup_Click(object sender, EventArgs e)
        {
            // Optional: refresh/reset signup form
            this.Hide();

            SignupForm signup = new SignupForm();
            signup.FormClosed += (s, args) => this.Close();

            signup.Show();
        }

        private void btnSigninSignup_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide signup screen

            SigninForm signin = new SigninForm();
            signin.FormClosed += (s, args) => this.Close();

            signin.Show();
        }

    }
}
