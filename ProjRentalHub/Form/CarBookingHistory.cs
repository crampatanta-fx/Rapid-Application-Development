using Microsoft.EntityFrameworkCore;
using ProjRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjRentalHub
{
    public partial class CarBookingHistory : Form
    {
        private int currentPage = 1;
        private string userIdFilter = "";
        private int pageSize = 9;
        public CarBookingHistory(string prmUserId)
        {
            InitializeComponent();
            userIdFilter = prmUserId;
            PopulateBookedCar();
        }

        private void PopulateBookedCar(int page = 1)
        {
            using (var context = new rentalHubDBContext())
            {
                int skipAmount = (page - 1) * pageSize;
                var sqlCommand = $"EXECUTE dbo.spCustomerBook @userIdFilter={{0}}";
                var results = context.BookedCars.FromSqlRaw(sqlCommand, userIdFilter).ToList();
                var cars = results.Skip(skipAmount).Take(pageSize).ToList();

                UC_CarBookingHistory[] uc_BookedCar = new UC_CarBookingHistory[cars.Count];

                flowLayoutPanel1.Controls.Clear();

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
                        var bookedCar = cars[i];

                        uc_BookedCar[i] = new UC_CarBookingHistory();
                        uc_BookedCar[i].CarDesc_m = bookedCar.cardesc;
                        uc_BookedCar[i].Picture_m = bookedCar.picture;
                        uc_BookedCar[i].DailyRate_m = bookedCar.dailyRate;
                        uc_BookedCar[i].StartDate_m = bookedCar.startDate;
                        uc_BookedCar[i].EndDate_m = bookedCar.endDATE;
                        uc_BookedCar[i].AmoutPaid_m = bookedCar.amountPaid;

                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                            flowLayoutPanel1.Controls.Add(uc_BookedCar[i]);
                    }
                }
                else
                {
                    Label lblNoRecords = new Label();
                    lblNoRecords.Size = new Size(300, 30);
                    lblNoRecords.Font = new Font("Arial", 12, FontStyle.Bold);
                    lblNoRecords.ForeColor = Color.Red;
                    lblNoRecords.Text = "No bookings found.";
                    flowLayoutPanel1.Padding = new Padding(450, 100, 10, 80);
                    flowLayoutPanel1.Controls.Add(lblNoRecords);
                    btnNext.Enabled = false;
                    btnPrev.Enabled = false;
                    return;
                }
            }
        }

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                PopulateBookedCar(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            PopulateBookedCar(currentPage);
        }
    }
}
