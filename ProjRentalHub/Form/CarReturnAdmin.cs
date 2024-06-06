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

namespace ProjRentalHub
{
    public partial class CarReturnAdmin : Form
    {
        public CarReturnAdmin(string prmcarID)
        {
            InitializeComponent();
            lblCarID.Text = prmcarID;

            _LoadRecords(prmcarID);
        }

        private void _LoadRecords(string prmcarID)
        {
            using (var context = new rentalHubDBContext())
            {
                var car = context.v_Cars.FirstOrDefault(u => u.carID == prmcarID);
                if (car != null)
                {
                    lblcarDesc_m.Text = car.carDesc;
                    pCar.Image = Image.FromFile(car.picture);
                    cboCategory.Text = car.category_name;
                    cboMaker.Text = car.carmaker_name;
                    cboModel.Text = car.carmodel_name;
                    cboColor.Text = car.color;
                    numericUpDownYear.Value = car.year;
                    cboType.Text = car.gas_type;
                    cboInsurance.Text = car.insurance_type;
                    txtCapacity.Text = car.capacity.ToString();
                    txtRegNumber.Text = car.regNumber.ToString();
                    txtDailyRate.Text = car.dailyRate.ToString("F");
                    cboStatus.Text = car.status;
                    cboChildSeat.Text = car.childSeat;
                    txtFileName.Text = car.picture;
                }
            }
        }

        private string _GetIdByName(string prmObj, string prmName)
        {
            string _result = "";
            using var context = new rentalHubDBContext();
            if (prmObj == "category")
            {
                var category = context.Category.FirstOrDefault(u => u.name == prmName);
                if (category != null)
                {
                    _result = category.categoryid;
                }
            }
            else if (prmObj == "maker")
            {
                var maker = context.CarMaker.FirstOrDefault(u => u.name == prmName);
                if (maker != null)
                {
                    _result = maker.carmakerid;
                }
            }
            else if (prmObj == "model")
            {
                var model = context.CarModel.FirstOrDefault(u => u.name == prmName);
                if (model != null)
                {
                    _result = model.carmodelid;
                }
            }
            else
            {
                var insurance = context.Insurance.FirstOrDefault(u => u.type == prmName);
                if (insurance != null)
                {
                    _result = insurance.insuranceid;
                }
            }

            return _result;
        }

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (var context = new rentalHubDBContext())
            {
                var car = context.Cars.FirstOrDefault(u => u.carID == lblCarID.Text);

                if (car != null)
                {
                    car.carDesc = lblcarDesc_m.Text;
                    car.picture = txtFileName.Text;
                    car.categoryId = _GetIdByName("category", cboCategory.SelectedItem.ToString());
                    car.carmakerID = _GetIdByName("maker", cboMaker.SelectedItem.ToString());
                    car.carmodelID = _GetIdByName("model", cboModel.SelectedItem.ToString());
                    car.color = cboColor.Text;
                    car.year = Int32.Parse(numericUpDownYear.Text);
                    car.type = cboType.SelectedItem.ToString();
                    car.insuranceId = _GetIdByName("insurance", cboInsurance.SelectedItem.ToString());
                    car.capacity = Int32.Parse(txtCapacity.Text);
                    car.regNumber = txtRegNumber.Text;
                    car.dailyRate = decimal.Parse(txtDailyRate.Text);
                    car.status = "Available";
                    car.childSeat = cboChildSeat.SelectedItem.ToString();
                    context.SaveChanges();

                    var bookedCar = context.Reservation.FirstOrDefault(r => r.carId == lblCarID.Text && r.bookingStatus == "Rented");
                    if (bookedCar == null)
                    {
                        MessageBox.Show($"The car is already returned.",
                            "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnReturn.Enabled = false;
                        return;
                    }

                    bookedCar.bookingStatus = "Returned";
                    context.SaveChanges();
                    MessageBox.Show($"Car returned successfully!",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void CarReturnAdmin_Load(object sender, EventArgs e)
        {
            using (var context = new rentalHubDBContext())
            {
                var car = context.Cars.FirstOrDefault(u => u.carID == lblCarID.Text);

                if (car != null && car.status == "Available")
                {
                    MessageBox.Show($"The car is already returned.",
                        "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnReturn.Enabled = false;
                }
            }
        }
    }
}
