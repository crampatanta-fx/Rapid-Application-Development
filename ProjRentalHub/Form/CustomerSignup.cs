using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjRentalHub.Class;
using System.Data;
using System.Text.RegularExpressions;

namespace ProjRentalHub
{
    public partial class CustomerSignup : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public CustomerSignup()
        {
            InitializeComponent();
        }

        private void customerSignupButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(rtxtAddress.Text))
            {
                MessageBox.Show($"Address is mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtAddress.Focus();
                return;
            }

            using (var context = new rentalHubDBContext())
            {
                const int maxRetries = 5;
                int currentTry = 0;
                bool success = false;

                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string address = rtxtAddress.Text;
                string licenseNumber = mtxtLicenseNumber.Text;
                string postalCode = txtPostalCode.Text;

                while (currentTry < maxRetries && !success)
                {
                    try
                    {
                        var lastUserId = context.Users
                                    .OrderByDescending(u => u.userId)
                                    .Select(u => u.userId)
                                    .FirstOrDefault();

                        string _newUserId;
                        if (string.IsNullOrEmpty(lastUserId))
                        {
                            _newUserId = "USR00001";
                        }
                        else
                        {   // Extract the numeric part
                            int lastNumericId = int.Parse(lastUserId.Substring(3));

                            int newNumericId = lastNumericId + 1;

                            _newUserId = "USR" + newNumericId.ToString("D5");
                        }
                        var user = new Users
                        {
                            userId = _newUserId,
                            userName = txtUsername.Text,
                            password = txtPassword.Text,
                            email = txtEmail.Text,
                            isActive = true,
                            phoneNumber = mtxtPhoneNumber.Text,
                            role = "user",
                            firstName = txtFirstName.Text,
                            lastName = txtLastName.Text
                        };
                        context.Users.Add(user);
                        context.SaveChanges();
                        success = true;

                    }
                    catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 2627)
                    {
                        // 2627 is SQL Server's error code for primary key violation
                        currentTry++;
                        success = false;
                    }
                }

                if (!success)
                {
                    // Handle the situation where all retries failed, e.g., inform the user
                    MessageBox.Show($"Failed to add a new user {firstName} {lastName} after multiple attempts.",
                        "User Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (success)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        MessageBox.Show($"User {firstName} {lastName} added successfully!",
                        "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AddCustomer(email, address, licenseNumber, postalCode);
                        ClearInputs();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add a new user after multiple attempts.",
                        "User Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddCustomer(string email, string address, string licenseNumber, string postalCode)
        {
            using (var context = new rentalHubDBContext())
            {
                var user = context.Users.FirstOrDefault(u => u.email == email);

                if (user != null)
                {
                    string userId = user.userId;

                    var customer = new Customers
                    {
                        userId = userId,
                        address = address,
                        licenseNumber = licenseNumber,
                        postalCode = postalCode
                    };

                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
            }
        }

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                if (c is MaskedTextBox)
                {
                    c.Text = "";
                }

                if (c is RichTextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void txtfirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtlastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtemail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtfirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtlastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtlicenseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtPostalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //At least one letter or number, min 4-char, max 10-char, start with letters only
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{3,9}$");
            if (regex.IsMatch(txtUsername.Text))
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
            else
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(this.txtUsername, "Invalid username.");
                return;
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //At least one uppercase or lowercase letter or number or special char, min 8-char, 
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (regex.IsMatch(txtPassword.Text))
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
            else
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider.SetError(this.txtPassword, "Invalid password.");
                return;
            }
        }
    }
}
