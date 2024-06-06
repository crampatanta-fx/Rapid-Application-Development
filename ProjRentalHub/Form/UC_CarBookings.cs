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
    public partial class UC_CarBookings : UserControl
    {
        public UC_CarBookings(string prmUserId)
        {
            InitializeComponent();
            gUserId = prmUserId;
        }

        private string _picCar;
        private string _carID;
        private string _carDesc;
        private string gUserId = "";

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            CarBook bookCar = new CarBook(gUserId, lblCarID.Text);
            bookCar.ShowDialog();
        }

        private void UC_Cars_Load(object sender, EventArgs e)
        {
            pCarPicList.Image = Image.FromFile(_picCar);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CarBook carBook = new CarBook(gUserId, lblCarID.Text);
            carBook.ShowDialog();
        }

        [Category("Custom Props")]
        public string CarPic
        {
            get { return _picCar; }
            set { _picCar = value; lblPictureFilename.Text = value; }
        }

        [Category("Custom Props")]
        public string carID
        {
            get { return _carID; }
            set { _carID = value; lblCarID.Text = value; }
        }

        [Category("Custom Props")]
        public string carDesc
        {
            get { return _carDesc; }
            set { _carDesc = value; lblcarDesc.Text = value; }
        }
    }
}
