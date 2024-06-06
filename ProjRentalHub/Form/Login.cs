using System;
using System.Linq;
using ProjRentalHub.Class;
using ProjRentalHub.Properties;

namespace ProjRentalHub
{

    public partial class Login : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public Login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtpassword.Text;

            using var context = new rentalHubDBContext();

            var user = context.Users.FirstOrDefault(u => u.userName == username 
                && u.password == password);

            if (user != null)
            {
                if (user.role == "admin")
                {
                    Dashboard dashboard = new Dashboard(user.userId);
                    dashboard.ShowDialog();
                }
                else if (user.role == "user")
                {
                    MainForm mainfForm = new MainForm(user.userId);
                    mainfForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show($"Username or Password is incorrect!",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerSignup customerSignup = new CustomerSignup();
            customerSignup.ShowDialog();
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider.SetError(txtUserName, "User ID needs to be entered.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUserName, null);
            }
        }
    }
}