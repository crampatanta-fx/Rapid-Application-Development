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
    public partial class ReturnMenu : Form
    {
        private int currentPage = 1;
        private int pageSize = 9;
        private string gUserId = "";

        public ReturnMenu(string prmuserid)
        {
            InitializeComponent();
            gUserId = prmuserid;
            PopulateBookedCars();
        }

        private void PopulateBookedCars(int page = 1)
        {
            using (var context = new rentalHubDBContext())
            {
                var sqlCommand = $"EXECUTE dbo.spCustomerBook @userIdFilter={{0}}";
                var results = context.BookedCars.FromSqlRaw(sqlCommand, gUserId).ToList();
                int skipAmount = (page - 1) * pageSize;
                var cars = results.Skip(skipAmount).Take(pageSize).ToList();

                UC_CarReturnUser[] uc_carReturn = new UC_CarReturnUser[cars.Count];

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
                        var bookedCar = cars[i];
                        uc_carReturn[i] = new UC_CarReturnUser();
                        uc_carReturn[i].carID_m = bookedCar.carId;
                        uc_carReturn[i].CarDesc_m = bookedCar.cardesc;
                        uc_carReturn[i].Picture_m = bookedCar.picture;
                        uc_carReturn[i].DailyRate_m = bookedCar.dailyRate;
                        uc_carReturn[i].Status_m = bookedCar.status;
                        uc_carReturn[i].NumberOfDays_m = bookedCar.numberOfDays;
                        uc_carReturn[i].StartDate_m = bookedCar.startDate;
                        uc_carReturn[i].EndDate_m = bookedCar.endDATE;
                        uc_carReturn[i].AmoutPaid_m = bookedCar.amountPaid;

                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(uc_carReturn[i]);
                        }
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

        private void pGoBackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                PopulateBookedCars(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            PopulateBookedCars(currentPage);
        }
    }
}
