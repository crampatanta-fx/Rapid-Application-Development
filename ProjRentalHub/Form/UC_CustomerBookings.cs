using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjRentalHub
{
    public partial class UC_CustomerBookings : UserControl
    {
        private string _userId;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNumber;
        public UC_CustomerBookings()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            CarManagement carManagement = new CarManagement("user", _userId);
            carManagement.ShowDialog();
        }

        private void btnBookingHistory_Click(object sender, EventArgs e)
        {
            CarBookingHistory carBookingHistory = new CarBookingHistory(_userId);
            carBookingHistory.ShowDialog();
        }

        private void UC_CustomerBookings_Load(object sender, EventArgs e)
        {
            txtName.Text = lblfirstName.Text + " " + lblLastName.Text;
        }

        [Category("Custom Props")]
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; lblUserId.Text = value; }
        }

        [Category("Custom Props")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; lblfirstName.Text = value; }
        }

        [Category("Custom Props")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; lblLastName.Text = value; }
        }

        [Category("Custom Props")]
        public string Email
        {
            get { return _email; }
            set { _email = value; txtEmail.Text = value; }
        }

        [Category("Custom Props")]
        public string PhoneNo
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; txtPhoneNo.Text = value; }
        }
    }
}
