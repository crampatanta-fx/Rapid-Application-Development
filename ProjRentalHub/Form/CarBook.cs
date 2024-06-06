using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjRentalHub
{
    public partial class CarBook : Form
    {
        private string gcarID = "";
        private string gUserId = "";
        public CarBook(string prmUserId, string prmcarID)
        {
            InitializeComponent();
            gUserId = prmUserId;
            gcarID = prmcarID;

            dtPickupTime.Format = DateTimePickerFormat.Custom;
            dtPickupTime.CustomFormat = "yyyy-MM-dd h:mm tt";
            dtPickupTime.ShowUpDown = true; // to prevent the dropdown calendar from appearing

            _GetCarRecords();

            pBookCar.Image = Image.FromFile(lblPictureFilename.Text);
        }

        private void _GetCarRecords()
        {
            using var context = new rentalHubDBContext();

            var car = context.v_Cars.FirstOrDefault(u => u.carID == gcarID);

            if (car == null) return;
            lblcarDesc_m.Text = car.carDesc;
            lblPictureFilename.Text = car.picture;
            txtCategory.Text = car.category_name;
            txtMaker.Text = car.carmaker_name;
            txtModel.Text = car.carmodel_name;
            txtColor.Text = car.color;
            txtYear.Text = car.year.ToString();
            txtInsuranceType.Text = car.insurance_type;
            txtcapacity.Text = car.capacity.ToString();
            txtregNumber.Text = car.regNumber;
            txtdailyRate.Text = car.dailyRate.ToString("F");
            txtStatus.Text = car.status;
            txtChildSeat.Text = car.childSeat.ToString();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            DateTime date_reserved = DateTime.Now;
            var startDate = DateOnly.FromDateTime(dtstartDate.Value);
            var endDate = DateOnly.FromDateTime(dtEndDate.Value);
            var pickupDate = DateOnly.FromDateTime(dtPickupTime.Value);
            var today = DateOnly.FromDateTime(DateTime.Now);
            var numberOfDays = endDate.DayNumber - startDate.DayNumber + 1;
            var amountPaid = numberOfDays * decimal.Parse(txtdailyRate.Text);

            if (startDate > endDate)
            {
                MessageBox.Show("Start Date is greater than End Date!");
                return;
            }

            if (startDate < today)
            {
                MessageBox.Show("Start Date must not be earlier than today!");
                return;
            }

            if (pickupDate != startDate)
            {
                MessageBox.Show("Pickup date must be on the Start date!");
                return;
            }

            using (var context = new rentalHubDBContext())
            {
                var lastreservedId = context.Reservation.OrderByDescending(u => u.reservationid)
                                    .Select(u => u.reservationid)
                                    .FirstOrDefault();

                //START - Get the Reservation ID
                string _newReservationId;
                if (string.IsNullOrEmpty(lastreservedId))
                {
                    _newReservationId = "RES00001";
                }
                else
                {   // Extract the numeric part
                    int lastNumericId = int.Parse(lastreservedId.Substring(3));

                    int newNumericId = lastNumericId + 1;

                    _newReservationId = "RES" + newNumericId.ToString("D5");
                }
                //END - Get the Reservation ID

                var reservation = new Reservation
                {
                    reservationid = _newReservationId,
                    startDate = dtstartDate.Value,
                    endDate = dtEndDate.Value,
                    bookingStatus = "Rented",
                    pickuptime = dtPickupTime.Value,
                    carId = gcarID,
                    userid = gUserId,
                    created_date = date_reserved,
                    amountPaid = amountPaid,
                    numberOfDays = numberOfDays,
                };

                context.Reservation.Add(reservation);
                context.SaveChanges();
            }

            using (var context = new rentalHubDBContext())
            {

                var car = context.Cars.FirstOrDefault(u => u.carID == gcarID);
                if (car == null) return;

                car.status = "Rented";
                context.SaveChanges();

                MessageBox.Show("Car has been successfully rented for " +
                    numberOfDays + " days at $" + amountPaid.ToString("F") + "!");

                DisableBooking();
            }
        }

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookCar_Load(object sender, EventArgs e)
        {
            using (var context = new rentalHubDBContext())
            {
                var car = context.v_Cars.FirstOrDefault(u => u.carID == gcarID && u.status == "Rented");

                if (car != null)
                {
                    MessageBox.Show($"Apologies, the car is currently rented.",
                        "Rented", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DisableBooking();
                }

                var bookedCar = context.Reservation.FirstOrDefault(u => u.carId == gcarID);

                if (bookedCar == null) return;

                dtstartDate.Text = bookedCar.startDate.ToString("MMMM dd, yyyy");
                dtEndDate.Text = bookedCar.endDate.ToString("MMMM dd, yyyy"); ;
                dtPickupTime.Text = bookedCar.pickuptime.ToString("MMMM dd, yyyy"); ;
            }
        }

        private void DisableBooking()
        {
            btnBook.Enabled = false;
            dtstartDate.Enabled = false;
            dtEndDate.Enabled = false;
            dtPickupTime.Enabled = false;
        }
    }
}
