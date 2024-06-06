using ProjRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjRentalHub
{
    public partial class UC_CarReturnAdmin : UserControl
    {

        private string _cardesc_m;
        private string _pic_m;
        private string _carID_m;
        private string _model_m;
        private int _year_m;
        private decimal _dailyRate;
        private string _status_m;
        private string gUserId;

        public UC_CarReturnAdmin()
        {
            InitializeComponent();
        }

        public UC_CarReturnAdmin(string prmUserId)
        {
            gUserId = prmUserId;
        }

        private void ModifyItem_Load(object sender, EventArgs e)
        {
            pCar_m.Image = Image.FromFile(_pic_m);

            if (_status_m == "Rented")
            {
                txtStatus.ForeColor = Color.Red;
                btnReturnEdit.Text = "More Info";
                txtStatus.Visible = false;
                lblStatus.Visible = false;
            }
            else
            {
                txtStatus.ForeColor = Color.Green;
                btnReturnEdit.Text = "Edit";
            }
        }

        private void btnReturnEdit_Click(object sender, EventArgs e)
        {
            if (btnReturnEdit.Text == "Edit")
            {
                CarEdit editCar = new CarEdit(txtCarID.Text);
                editCar.ShowDialog();
            }
            else
            {
                CarReturnAdmin carReturnAdmin = new CarReturnAdmin(txtCarID.Text);
                carReturnAdmin.ShowDialog();
            }
        }

        [Category("Custom Props")]
        public string carDesc_m
        {
            get { return _cardesc_m; }
            set { _cardesc_m = value; lblCarDesc.Text = value; }
        }

        [Category("Custom Props")]
        public string Picture_m
        {
            get { return _pic_m; }
            set { _pic_m = value; lblPicture.Text = value; }
        }

        [Category("Custom Props")]
        public string carID_m
        {
            get { return _carID_m; }
            set { _carID_m = value; txtCarID.Text = value; }
        }

        [Category("Custom Props")]
        public string Model_m
        {
            get { return _model_m; }
            set { _model_m = value; lblModel.Text = value; }
        }

        [Category("Custom Props")]
        public int Year_m
        {
            get { return _year_m; }
            set { _year_m = value; lblYear.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public decimal DailyRate_m
        {
            get { return _dailyRate; }
            set { _dailyRate = value; lblDailyRate.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string Status_m
        {
            get { return _status_m; }
            set { _status_m = value; txtStatus.Text = value.ToString(); }
        }
    }
}
