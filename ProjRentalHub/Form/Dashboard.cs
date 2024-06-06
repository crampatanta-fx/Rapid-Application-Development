using Microsoft.EntityFrameworkCore;
using ProjRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjRentalHub
{
    public partial class Dashboard : Form
    {
        private int currentPage = 1;
        private int pageSize = 3;
        private string gUserId = "";
        private int currentRecordIndex = 0;

        // This list will hold all the car information
        private List<v_Cars> _carInfoList = new List<v_Cars>();
        public Dashboard(string prmUserId)
        {
            InitializeComponent();

            gUserId = prmUserId;

            _ShowUser(prmUserId);
            _ShowCarsAvailability();
            _ShowReservationCount();
            _ShowPickUp();
            _ShowLiveCarStatus();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblCalendar.Text = "Today's date: " + DashboardCalendar.SelectionStart.ToString("MMMM dd, yyyy");

            DashboardTimer.Tick += DashboardTimer_Tick; // Subscribe to the Tick event
            DashboardTimer.Start();
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("Customers");
            customer.ShowDialog();
        }
        private void btnCarManagement_Click(object sender, EventArgs e)
        {
            CarManagement carManagement = new CarManagement("admin", gUserId);
            carManagement.ShowDialog();

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _ShowUser(string prmUserId)
        {
            using (var context = new rentalHubDBContext())
            {
                var user = context.Users.FirstOrDefault(u => u.userId == prmUserId);

                if (user == null) return;

                lblUsername.Text = user.firstName + " " + user.lastName;
            }
        }
        private void _ShowCarsAvailability()
        {
            using (var context = new rentalHubDBContext())
            {
                var v_showavail = context.v_showavailcar.FirstOrDefault();

                if (v_showavail == null) return;

                ProgressBarAvail.Maximum = v_showavail.totalcars;

                ProgressBarAvail.Value = v_showavail.available;

                lblCarsAvail.Text = lblCarsAvail.Text + "(" + ProgressBarAvail.Value.ToString() + "/" +
                                                         ProgressBarAvail.Maximum.ToString() + ")";
            }
        }
        private void _ShowReservationCount()
        {
            using (var context = new rentalHubDBContext())
            {
                var v_showbooking = context.v_showbooking.FirstOrDefault();

                if (v_showbooking == null) return;

                ProgressBarReservation.Maximum = v_showbooking.totalcars;

                ProgressBarReservation.Value = v_showbooking.rented;

                lblReservationProgress.Text = ProgressBarReservation.Value.ToString() + " booking " +
                                                         " as of today";// + DateTime.Now.Date.ToString("yyyy-MM-dd");
            }
        }
        private void _ShowPickUp(int page = 1)
        {
            using (var context = new rentalHubDBContext())
            {
                int skipAmount = (page - 1) * pageSize;

                var PickUp = context.v_PickUp.Skip(skipAmount).Take(pageSize).ToList();

                if (PickUp.Count < pageSize || PickUp.Count == 0)
                    btnNextPickup.Enabled = false;
                else
                    btnNextPickup.Enabled = true;

                if (page == 1)
                {
                    btnPreviousPickup.Enabled = false;
                }
                else
                {
                    btnPreviousPickup.Enabled = true;
                }

                if (!PickUp.Any()) return;

                lvPickUp.Items.Clear();

                foreach (var pickup in PickUp)
                {
                    ListViewItem item = new ListViewItem(pickup.carDesc);

                    item.SubItems.Add(pickup.startdate.ToString("MMMM dd, yyyy"));
                    item.SubItems.Add(pickup.enddate.ToString("MMMM dd, yyyy"));
                    lvPickUp.Items.Add(item);
                }
            }
        }
        private void _ShowLiveCarStatus(int page = 1)
        {
            using (var context = new rentalHubDBContext())
            {
                int skipAmount = (page - 1) * pageSize;

                // Assuming v_Cars is a DbSet or DbQuery in your context
                var cars = context.v_Cars.Skip(skipAmount).Take(pageSize).ToList();

                if (cars.Count < pageSize || cars.Count == 0)
                    btnCarStatusNext.Enabled = false;
                else
                    btnCarStatusNext.Enabled = true;

                if (page == 1)
                {
                    btnCarStatusPrev.Enabled = false;
                }
                else
                {
                    btnCarStatusPrev.Enabled = true;
                }

                if (!cars.Any()) return;

                // Assuming you have a ListView control named lvLiveCarStatus
                lvLiveCarStatus.Items.Clear(); // Clear existing items

                foreach (var car in cars)
                {
                    // Create a new ListViewItem
                    ListViewItem item = new ListViewItem(car.carDesc);

                    // Add sub-items for each additional column you want to display
                    item.SubItems.Add(car.category_name);
                    item.SubItems.Add(car.carmaker_name);
                    item.SubItems.Add(car.carmodel_name);
                    item.SubItems.Add(car.color);
                    item.SubItems.Add(car.insurance_type);
                    item.SubItems.Add(car.gas_type);
                    item.SubItems.Add(car.regNumber);
                    item.SubItems.Add(car.status);
                    item.SubItems.Add(car.childSeat);
                    // ... Add as many sub-items as you have columns

                    // Add the ListViewItem to the ListView
                    lvLiveCarStatus.Items.Add(item);
                }
            }
        }
        private void DashboardTimer_Tick(object sender, EventArgs e)
        {
            LoadNextRecord();
        }
        private void LoadNextRecord()
        {
            using (var context = new rentalHubDBContext())
            {
                var records = context.v_Cars.ToList(); // Ideally, you would not want to load all records every time.

                if (records.Count > currentRecordIndex)
                {
                    var record = records[currentRecordIndex];
                    lblCarDesc.Text = record.carDesc;
                    pCarPicture.Image = Image.FromFile(record.picture);
                    lblDailyRateValue.Text = "$" + record.dailyRate.ToString("F") + " CAD";
                    lblCategoryValue.Text = record.category_name;
                    lblYearValue.Text = record.year.ToString();
                    lblColorValue.Text = record.color;
                    lblTypeValue.Text = record.gas_type;
                    lblCapacityValue.Text = record.capacity.ToString();
                    lblStatusValue.Text = record.status;
                    lblChildseatvalue.Text = record.childSeat.ToString();
                    currentRecordIndex = (currentRecordIndex + 1) % records.Count; // Increment and wrap around if needed.
                }
            }
        }

        private void btnCarStatusNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            _ShowLiveCarStatus(currentPage);
        }

        private void btnCarStatusPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                _ShowLiveCarStatus(currentPage);
            }
        }

        private void btnRegCar_Click(object sender, EventArgs e)
        {
            CarAdd carAdd = new CarAdd();
            carAdd.ShowDialog();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("Bookings");
            customer.ShowDialog();
        }

        private void btnPreviousPickup_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                _ShowPickUp(currentPage);
            }
        }

        private void btnNextPickup_Click(object sender, EventArgs e)
        {
            currentPage++;
            _ShowPickUp(currentPage);
        }
    }
}
