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
    public partial class UC_CarReturnUser : UserControl
    {
        private string _carID_m;
        private string _cardesc_m;
        private string _pic_m;
        private decimal _dailyRate_m;
        private string _status_m;
        private DateTime _startDate_m;
        private DateTime _endDate_m;
        private decimal _amoutPaid_m;
        private int _numberOfDays_m;
        private string gUserId = "";

        public UC_CarReturnUser()
        {
            InitializeComponent();
            lblcarID_m.Visible = false;
        }

        public UC_CarReturnUser(string prmUserId)
        {
            gUserId = prmUserId;
        }

        private void UC_CarReturn_Load(object sender, EventArgs e)
        {
            pCar_m.Image = Image.FromFile(_pic_m);
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            CarReturn carReturn = new CarReturn(lblcarID_m.Text);
            carReturn.ShowDialog();
        }

        [Category("Custom Props")]
        public string carID_m
        {
            get { return _carID_m; }
            set { _carID_m = value; lblcarID_m.Text = value; }
        }

        [Category("Custom Props")]
        public string CarDesc_m
        {
            get { return _cardesc_m; }
            set { _cardesc_m = value; lblcarDesc_m.Text = value; }
        }

        public string Picture_m
        {
            get { return _pic_m; }
            set { _pic_m = value; lblpicture_m.Text = value; }
        }

        [Category("Custom Props")]
        public decimal DailyRate_m
        {
            get { return _dailyRate_m; }
            set { _dailyRate_m = value; txtDailyRate.Text = value.ToString("F"); }
        }

        public DateTime StartDate_m
        {
            get { return _startDate_m; }
            set { _startDate_m = value; txtStartDate.Text = value.ToString("MMMM dd, yyyy"); }
        }

        public DateTime EndDate_m
        {
            get { return _endDate_m; }
            set { _endDate_m = value; txtEndDate.Text = value.ToString("MMMM dd, yyyy"); }
        }

        [Category("Custom Props")]
        public decimal AmoutPaid_m
        {
            get { return _amoutPaid_m; }
            set { _amoutPaid_m = value; txtAmtPaid.Text = value.ToString("F"); }
        }

        [Category("Custom Props")]
        public string Status_m
        {
            get { return _status_m; }
            set { _status_m = value; txtStatus.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public int NumberOfDays_m
        {
            get { return _numberOfDays_m; }
            set { _numberOfDays_m = value; txtNoOfDays.Text = value.ToString(); }
        }
    }
}
