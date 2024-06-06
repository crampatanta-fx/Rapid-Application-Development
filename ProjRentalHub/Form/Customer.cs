using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SqlServer.Types;
using ProjRentalHub.Class;
using ProjRentalHub.Properties;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjRentalHub
{
    public partial class Customer : Form
    {
        string gFunctionName = "";
        private int currentPage = 1;
        private int pageSize = 9;
        public Customer(string functionName)
        {
            InitializeComponent();
            gFunctionName = functionName;
            if (gFunctionName == "Bookings")
            {
                linklblAddNewCust.Visible = false;
                this.Text = "Bookings";
                lblAdminPanel.Text = "Bookings";
            }
            _PopulateUser();
        }

        private void _PopulateUser(int page = 1)
        {
            using (var context = new rentalHubDBContext())
            {
                int skipAmount = (page - 1) * pageSize;

                var customers = context.v_Customers.Skip(skipAmount).Take(pageSize).ToList();

                //if (customers == null || !customers.Any()) return;

                if (gFunctionName == "Customers")
                {
                    UC_CustomerEdit[] uc_CustomerEdit = new UC_CustomerEdit[customers.Count];
                    flowLayoutPanel1.Controls.Clear();

                    if (customers.Count < pageSize || customers.Count == 0)
                        btnNext.Enabled = false;
                    else
                        btnNext.Enabled = true;

                    if (page == 1)
                    {
                        btnPrev.Enabled = false;
                    }
                    else
                    {
                        btnPrev.Enabled = true;
                    }

                    if (customers != null && customers.Count >= 1)
                    {
                        for (int i = 0; i < customers.Count; i++)
                        {
                            var customer = customers[i];

                            uc_CustomerEdit[i] = new UC_CustomerEdit();
                            uc_CustomerEdit[i].UserId = customer.userId;
                            uc_CustomerEdit[i].FirstName = customer.firstName;
                            uc_CustomerEdit[i].LastName = customer.lastName;
                            uc_CustomerEdit[i].Email = customer.email;
                            uc_CustomerEdit[i].PhoneNo = customer.phoneNumber;

                            if (flowLayoutPanel1.Controls.Count < 0)
                            {
                                flowLayoutPanel1.Controls.Clear();
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(uc_CustomerEdit[i]);
                            }

                        }
                    }
                    else
                    {
                        //
                    }
                }
                else
                {
                    UC_CustomerBookings[] uc_CustomerBookings = new UC_CustomerBookings[customers.Count];
                    flowLayoutPanel1.Controls.Clear();

                    if (customers.Count < pageSize || customers.Count == 0)
                        btnNext.Enabled = false;
                    else
                        btnNext.Enabled = true;

                    if (page == 1)
                    {
                        btnPrev.Enabled = false;
                    }
                    else
                    {
                        btnPrev.Enabled = true;
                    }

                    if (customers != null && customers.Count >= 1)
                    {
                        for (int i = 0; i < customers.Count; i++)
                        {
                            var customerBookings = customers[i];

                            uc_CustomerBookings[i] = new UC_CustomerBookings();
                            uc_CustomerBookings[i].UserId = customerBookings.userId;
                            uc_CustomerBookings[i].FirstName = customerBookings.firstName;
                            uc_CustomerBookings[i].LastName = customerBookings.lastName;
                            uc_CustomerBookings[i].Email = customerBookings.email;
                            uc_CustomerBookings[i].PhoneNo = customerBookings.phoneNumber;

                            if (flowLayoutPanel1.Controls.Count < 0)
                            {
                                flowLayoutPanel1.Controls.Clear();
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(uc_CustomerBookings[i]);
                            }
                        }
                    }
                    else
                    {
                        //
                    }
                }
            }
        }

        private void linklblAddNewCust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerAdd customerAdd = new CustomerAdd();
            customerAdd.ShowDialog();
        }

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                _PopulateUser(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            _PopulateUser(currentPage);
        }
    }
}
