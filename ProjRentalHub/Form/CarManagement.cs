using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProjRentalHub.Class;
using ProjRentalHub.Properties;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjRentalHub
{
    public partial class CarManagement : Form
    {
        private int currentPage = 1;
        private int pageSize = 9;
        private string gRole = "";
        private string gUserId = "";

        public CarManagement(string prmuserid)
        {
            InitializeComponent();
            gUserId = prmuserid;
            PopulateCategory();
            PopulateCarMaker();
            PopulateColor();
        }

        public CarManagement(string role, string prmuserid)
        {
            InitializeComponent();

            gUserId = prmuserid;

            if (role == "user")
            {
                PopulateCarsCust();
                gRole = "user";
                this.Text = "Bookings";
            }
            else
            {
                PopulateCarsAdmin();
                gRole = "admin";
                this.Text = "Car Management";
            }

            PopulateCategory();
            PopulateCarMaker();
            PopulateColor();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int page = 1;

            string descFilter = txtSearchDesc.Text == "Key-in car description" ? null : txtSearchDesc.Text;
            string categoryFilter = cboCategory.Text == "Select category" ? null : cboCategory.Text;
            string makerFilter = cboMaker.Text == "Select car maker" ? null : cboMaker.Text;
            string colorFilter = cboColor.Text == "Select color" ? null : cboColor.Text;

            using (var context = new rentalHubDBContext())
            {
                var sqlCommand = $"EXECUTE dbo.spCarLoad @descFilter={{0}}, @categoryFilter={{1}}, @makerFilter={{2}}, @colorFilter={{3}}";
                var results = context.Results.FromSqlRaw(sqlCommand, descFilter, categoryFilter, makerFilter, colorFilter).ToList();

                int skipAmount = (page - 1) * pageSize;

                var cars = results.Skip(skipAmount).Take(pageSize).ToList();

                if (cars == null || !cars.Any())
                {
                    flowLayoutPanel1.Controls.Clear();
                    MessageBox.Show("No records found.", "Info");
                }

                if (gRole == "user")
                {
                    UC_CarBookings[] uc_CarBookings = new UC_CarBookings[cars.Count];

                    flowLayoutPanel1.Padding = new Padding(0, 80, 0, 80); // Add 10px space to the top of the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Clear(); // Clearing controls at the beginning

                    for (int i = 0; i < cars.Count; i++)
                    {
                        var car = cars[i];
                        uc_CarBookings[i] = new UC_CarBookings(gUserId);
                        uc_CarBookings[i].CarPic = car.picture;
                        uc_CarBookings[i].carID = car.carID;
                        uc_CarBookings[i].carDesc = car.carDesc;

                        flowLayoutPanel1.Controls.Add(uc_CarBookings[i]);
                    }
                }
                else
                {
                    UC_CarReturnAdmin[] uc_CarReturnAdmin = new UC_CarReturnAdmin[cars.Count];

                    flowLayoutPanel1.Padding = new Padding(0, 80, 0, 80); // Add 10px space to the top of the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Clear(); // Clearing controls at the beginning

                    for (int i = 0; i < cars.Count; i++)
                    {
                        var car_m = cars[i];

                        uc_CarReturnAdmin[i] = new UC_CarReturnAdmin();
                        uc_CarReturnAdmin[i].carDesc_m = car_m.carDesc;
                        uc_CarReturnAdmin[i].carID_m = car_m.carID;
                        uc_CarReturnAdmin[i].Picture_m = car_m.picture;
                        uc_CarReturnAdmin[i].Model_m = car_m.carmodel_name;
                        uc_CarReturnAdmin[i].Year_m = car_m.year;
                        uc_CarReturnAdmin[i].DailyRate_m = car_m.dailyRate;
                        uc_CarReturnAdmin[i].Status_m = car_m.status;

                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                            flowLayoutPanel1.Controls.Add(uc_CarReturnAdmin[i]);
                    }
                }

                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _ResetFilter();
            btnPrev.Enabled = true;
            btnNext.Enabled = true;

            if (gRole == "user")
            {
                PopulateCarsCust();
            }
            else
            {
                PopulateCarsAdmin();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (gRole == "user")
            {
                currentPage++;
                PopulateCarsCust(currentPage);
            }
            else
            {
                currentPage++;
                PopulateCarsAdmin(currentPage);
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                if (gRole == "user")
                {
                    PopulateCarsCust(currentPage);
                }
                else
                {
                    PopulateCarsAdmin(currentPage);
                }
            }
        }
        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ResetFilter()
        {
            txtSearchDesc.Text = "Key-in car description";
            cboCategory.Text = "Select category";
            cboMaker.Text = "Select car maker";
            cboColor.Text = "Select color";
        }
        private void PopulateCategory()
        {
            using (var context = new rentalHubDBContext())
            {
                var allCategory = context.Category.Select(t => t.name).Distinct().ToList();

                // Insert the "Please select car maker" at the beginning of the list
                allCategory.Insert(0, "Select category");
                cboCategory.DataSource = allCategory;
                cboCategory.SelectedIndex = 0;
            }
        }
        private void PopulateCarMaker()
        {
            using (var context = new rentalHubDBContext())
            {
                var allCarMaker = context.CarMaker.Select(t => t.name).Distinct().ToList();

                // Insert the "Please select car maker" at the beginning of the list
                allCarMaker.Insert(0, "Select car maker");
                cboMaker.DataSource = allCarMaker;

                // Set the ComboBox to display the first item ("Please select car maker")
                cboMaker.SelectedIndex = 0;
            }
        }
        private void PopulateColor()
        {
            using (var context = new rentalHubDBContext())
            {
                var allColor = context.Cars.Select(t => t.color).Distinct().ToList();

                // Insert the "Please select car maker" at the beginning of the list
                allColor.Insert(0, "Select color");
                cboColor.DataSource = allColor;
                cboColor.SelectedIndex = 0;
            }
        }
        private void PopulateCarsAdmin(int page = 1)
        {
            using (var context = new rentalHubDBContext())
            {
                int skipAmount = (page - 1) * pageSize;
                var cars = context.v_Cars.Skip(skipAmount).Take(pageSize).ToList();

                UC_CarReturnAdmin[] uc_CarReturnAdmin = new UC_CarReturnAdmin[cars.Count];

                flowLayoutPanel1.Padding = new Padding(0, 80, 0, 80); // Add 10px space to the top of the FlowLayoutPanel
                flowLayoutPanel1.Controls.Clear(); // Clearing controls at the beginning

                if (cars.Count < pageSize || cars.Count == 0)
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

                if (cars != null && cars.Count >= 1)
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        var car_m = cars[i];

                        uc_CarReturnAdmin[i] = new UC_CarReturnAdmin();
                        uc_CarReturnAdmin[i].carDesc_m = car_m.carDesc;
                        uc_CarReturnAdmin[i].carID_m = car_m.carID;
                        uc_CarReturnAdmin[i].Picture_m = car_m.picture;
                        uc_CarReturnAdmin[i].Model_m = car_m.carmodel_name;
                        uc_CarReturnAdmin[i].Year_m = car_m.year;
                        uc_CarReturnAdmin[i].DailyRate_m = car_m.dailyRate;
                        uc_CarReturnAdmin[i].Status_m = car_m.status;

                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                            flowLayoutPanel1.Controls.Add(uc_CarReturnAdmin[i]);
                    }
                }
                else
                {
                    if (page == 1)
                    {
                        Label lblNoRecords = new Label();
                        lblNoRecords.Size = new Size(300, 30);
                        lblNoRecords.Font = new Font("Arial", 12, FontStyle.Bold);
                        lblNoRecords.ForeColor = Color.Red;
                        lblNoRecords.Text = "No cars to be returned.";
                        flowLayoutPanel1.Padding = new Padding(450, 200, 10, 80);
                        flowLayoutPanel1.Controls.Add(lblNoRecords);
                        btnNext.Enabled = false;
                        btnPrev.Enabled = false;
                        return;
                    }
                }
            }
        }
        private void PopulateCarsCust(int page = 1)
        {
            using (var context = new rentalHubDBContext())
            {

                int skipAmount = (page - 1) * pageSize;
                var carsQuery = context.v_Cars.AsQueryable();
                var cars = carsQuery.Skip(skipAmount).Take(pageSize).ToList();

                UC_CarBookings[] uc_CarBookings = new UC_CarBookings[cars.Count];

                flowLayoutPanel1.Padding = new Padding(0, 80, 0, 80); // Add 10px space to the top of the FlowLayoutPanel
                flowLayoutPanel1.Controls.Clear(); // Clearing controls at the beginning

                if (cars.Count < pageSize || cars.Count == 0)
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

                if (cars != null && cars.Count >= 1)
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        var car = cars[i];
                        uc_CarBookings[i] = new UC_CarBookings(gUserId);
                        uc_CarBookings[i].CarPic = car.picture;
                        uc_CarBookings[i].carID = car.carID;
                        uc_CarBookings[i].carDesc = car.carDesc;

                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                            flowLayoutPanel1.Controls.Add(uc_CarBookings[i]);
                    }
                }
                else
                {
                    if (page == 1)
                    {
                        Label lblNoRecords = new Label();
                        lblNoRecords.Size = new Size(300, 30);
                        lblNoRecords.Font = new Font("Arial", 12, FontStyle.Bold);
                        lblNoRecords.ForeColor = Color.Red;
                        lblNoRecords.Text = "No records found.";
                        flowLayoutPanel1.Padding = new Padding(450, 200, 10, 80);
                        flowLayoutPanel1.Controls.Add(lblNoRecords);
                        btnNext.Enabled = false;
                        btnPrev.Enabled = false;
                        return;
                    }
                }
            }
        }
    }
}
