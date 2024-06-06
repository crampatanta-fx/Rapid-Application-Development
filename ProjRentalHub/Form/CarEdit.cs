using ProjRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjRentalHub
{
    public partial class CarEdit : Form
    {
        public CarEdit(string prmcarID)
        {
            InitializeComponent();

            lblcarID_m.Text = prmcarID;

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
                    cboCarDesc.Text = car.carDesc;
                    pCar.Image = Image.FromFile(car.picture);
                    cboCategory.Text = car.category_name;
                    cboMaker.Text = car.carmaker_name;
                    cboModel.Text = car.carmodel_name;
                    cboColor.Text = car.color;
                    numericUpDownYear.Value = car.year;
                    cboType.Text = car.gas_type;
                    cboInsurance.Text = car.insurance_type;
                    numericUpDownCapacity.Value = car.capacity;
                    txtRegNumber.Text = car.regNumber.ToString();
                    txtDailyRate.Text = car.dailyRate.ToString("F");
                    cboStatus.Text = car.status;
                    cboChildSeat.Text = car.childSeat;
                    txtFileName.Text = car.picture;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new rentalHubDBContext())
            {
                var car = context.Cars.FirstOrDefault(u => u.carID == lblcarID_m.Text);
                if (car != null)
                {
                    car.carDesc = cboCarDesc.SelectedItem.ToString();
                    car.picture = txtFileName.Text;
                    car.categoryId = _GetIdByName("category", cboCategory.SelectedItem.ToString());
                    car.carmakerID = _GetIdByName("maker", cboMaker.SelectedItem.ToString());
                    car.carmodelID = _GetIdByName("model", cboModel.SelectedItem.ToString());
                    car.color = cboColor.Text;
                    car.year = Int32.Parse(numericUpDownYear.Text);
                    car.type = cboType.SelectedItem.ToString();
                    car.insuranceId = _GetIdByName("insurance", cboInsurance.SelectedItem.ToString());
                    car.capacity = Int32.Parse(numericUpDownCapacity.Text);
                    car.regNumber = txtRegNumber.Text;
                    car.dailyRate = decimal.Parse(txtDailyRate.Text);
                    car.status = cboStatus.SelectedItem.ToString();
                    car.childSeat = cboChildSeat.SelectedItem.ToString();

                    context.SaveChanges();
                    MessageBox.Show($"Car edit successfully!", "Confirmation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpeg;*.png;*.bmp;*.jpg)|*.jpeg;*.png;*.bmp;*.jpg";
                ofd.Title = "Select an Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox.
                    pCar.Image = new System.Drawing.Bitmap(ofd.FileName);
                    txtFileName.Text = ofd.FileName;
                }
            }
        }

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyCar_Load(object sender, EventArgs e)
        {
            cboStatus.Enabled = false;
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

        private void txtDailyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (txtDailyRate.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
