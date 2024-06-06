using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using ProjRentalHub.Class;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjRentalHub
{
    public partial class CarAdd : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public CarAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new rentalHubDBContext())
            {
                const int maxRetries = 5;
                int currentTry = 0;
                bool success = false;

                string carDesc = cboDescription.Text;

                while (currentTry < maxRetries && !success)
                {
                    try
                    {
                        var lastCarId = context.Cars
                                    .OrderByDescending(u => u.carID)
                                    .Select(u => u.carID)
                                    .FirstOrDefault();

                        string _newCarId;

                        if (string.IsNullOrEmpty(lastCarId))
                        {
                            _newCarId = "CAR00001";
                        }
                        else
                        {   // Extract the numeric part
                            int lastNumericId = int.Parse(lastCarId.Substring(3));

                            int newNumericId = lastNumericId + 1;

                            _newCarId = "CAR" + newNumericId.ToString("D5");
                        }

                        var car = new Cars
                        {
                            carID = _newCarId,
                            carDesc = carDesc,
                            categoryId = _GetIdByName("category", cboCategory.Text),
                            carmakerID = _GetIdByName("maker", cboMaker.Text),
                            carmodelID = _GetIdByName("model", cboModel.Text),
                            color = cboColor.Text,
                            year = Int32.Parse(numericUpDownYear.Text),
                            type = cboType.Text,
                            insuranceId = _GetIdByName("insurance", cboInsurance.Text),
                            capacity = Int32.Parse(numericUpDownCapacity.Text),
                            regNumber = txtRegNumber.Text,
                            dailyRate = decimal.Parse(txtDailyRate.Text),
                            status = cboStatus.Text,
                            childSeat = cboChildSeat.Text,
                            picture = txtFileName.Text,
                        };
                        context.Cars.Add(car);
                        context.SaveChanges();
                        success = true;

                    }
                    catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 2627)
                    {
                        // 2627 is SQL Server's error code for primary key violation
                        currentTry++;
                        success = false;
                    }

                    if (!success)
                    {
                        // Handle the situation where all retries failed, e.g., inform the user
                        MessageBox.Show($"Failed to add a new car {carDesc} after multiple attempts.",
                                        "Car Registration Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (success)
                    {
                        MessageBox.Show($"Car {carDesc} added successfully!",
                                        "Car Registration",
                                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a new car after multiple attempts.",
                                         "Car Registration Error",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            cboDescription.SelectedItem = null;
            cboCategory.SelectedItem = null;
            cboMaker.SelectedItem = null;
            cboModel.SelectedItem = null;
            cboColor.SelectedItem = null;
            numericUpDownYear.Value = 2000;
            cboType.SelectedItem = null;
            cboInsurance.SelectedItem = null;
            numericUpDownCapacity.Value = 1;
            txtRegNumber.Text = "";
            txtDailyRate.Text = "";
            cboStatus.SelectedItem = "Available";
            cboChildSeat.SelectedItem = null;
            txtFileName.Text = "";
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
