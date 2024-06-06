using ProjRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjRentalHub
{
    public partial class CustomerEditAdmin : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private string userIdFilter = "";
        public CustomerEditAdmin(string prmUserId)
        {
            InitializeComponent();
            userIdFilter = prmUserId;
            LoadUserRecord(prmUserId);
            LoadCustomerRecord(prmUserId);
        }

        private void LoadUserRecord(string prmUserId)
        {
            using (var context = new rentalHubDBContext())
            {
                var user = context.Users.FirstOrDefault(u => u.userId == prmUserId);
                if (user != null)
                {
                    txtFirstName.Text = user.firstName;
                    txtLastName.Text = user.lastName;
                    mtxtPhoneNumber.Text = user.phoneNumber;
                    txtEmail.Text = user.email;
                    txtUserName.Text = user.userName;
                    txtPassword.Text = user.password;
                }
            }
        }

        private void LoadCustomerRecord(string prmUserId)
        {
            using (var context = new rentalHubDBContext())
            {
                var customer = context.Customers.FirstOrDefault(c => c.userId == prmUserId);
                if (customer != null)
                {
                    rtxtAddress.Text = customer.address;
                    mtxtLicenseNumber.Text = customer.licenseNumber;
                    txtPostalCode.Text = customer.postalCode;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new rentalHubDBContext())
            {
                var user = context.Users.FirstOrDefault(u => u.userId == userIdFilter);
                if (user != null)
                {
                    user.firstName = txtFirstName.Text.ToString();
                    user.lastName = txtLastName.Text.ToString();
                    user.phoneNumber = mtxtPhoneNumber.Text.ToString();
                    user.email = txtEmail.Text.ToString();
                    user.userName = txtUserName.Text.ToString();
                    user.password = txtPassword.Text.ToString();

                    context.SaveChanges();
                }
            }

            using (var context = new rentalHubDBContext())
            {
                var customer = context.Customers.FirstOrDefault(c => c.userId == userIdFilter);
                if (customer != null)
                {
                    customer.address = rtxtAddress.Text.ToString();
                    customer.licenseNumber = mtxtLicenseNumber.Text.ToString();
                    customer.postalCode = txtPostalCode.Text.ToString();

                    context.SaveChanges();
                    MessageBox.Show($"Customer saved successfully!", "Confirmation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider.SetError(txtFirstName, "First name needs to be entered.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFirstName, null);
            }
        }

        private void txtfirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtlastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider.SetError(txtLastName, "Last name needs to be entered.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLastName, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([a-zA-Z]([-\.\w]*[a-zA-Z0-9])*@[a-zA-Z]*[-\w]*[a-zA-Z]\.)+[a-zA-Z]{2,10}$");

            if (regex.IsMatch(txtEmail.Text))
            {
                errorProvider.Clear();
            }
            else
            {
                txtEmail.Focus();
                errorProvider.SetError(this.txtEmail, "Invalid e-mail address.");
                return;
            }
        }

        private void txtlastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtLicenseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtPostalCode_Validating(object sender, CancelEventArgs e)
        {
            // letter, number, letter, space?, number, letter, number
            Regex regex = new Regex(@"^([A-CEGHJ-NPR-TVXY][0-9][A-CEGHJ-NPR-TVXY]\s?[0-9][A-CEGHJ-NPR-TVXY][0-9])");
            if (regex.IsMatch(txtPostalCode.Text))
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
            else
            {
                e.Cancel = true;
                txtPostalCode.Focus();
                errorProvider.SetError(this.txtPostalCode, "Invalid postal code.");
                return;
            }
        }
    }
}
