using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjRentalHub.RentalHubDBDataSetTableAdapters;

namespace ProjRentalHub.Class
{
    public class rentalHubDBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<v_Cars> v_Cars { get; set; }
        public DbSet<CarMaker> CarMaker { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<CarModel> CarModel { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<ResultMappingClass> Results { get; set; }
        public virtual DbSet<BookedCarMappingClass> BookedCars { get; set; }
        public virtual DbSet<v_pickup> v_PickUp { get; set; }
        public virtual DbSet<v_showavailcar> v_showavailcar { get; set; }
        public virtual DbSet<v_showavailcar> v_showbooking { get; set; }
        public virtual DbSet<v_customers> v_Customers { get; set; }
        public virtual DbSet<v_reservations> v_Reservations { get; set; }
        public virtual DbSet<v_bookedcars> v_BookedCars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["RentalHubContext"].ToString();
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<v_showavailcar>().HasNoKey();
            modelBuilder.Entity<v_showbooking>().HasNoKey();
        }
    }

    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }
        public string phoneNumber { get; set; }
        public string role { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string userId { get; set; }
        public string address { get; set; }
        public string licenseNumber { get; set; }
        public string postalCode { get; set; }
    }

    public class Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string carID { get; set; }
        public string carDesc { get; set; }
        public string categoryId { get; set; }
        public string insuranceId { get; set; }
        public string carmakerID { get; set; }
        public string carmodelID { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public int capacity { get; set; }
        public string regNumber { get; set; }
        public decimal dailyRate { get; set; }
        public string picture { get; set; }
        public string childSeat { get; set; }
        public string status { get; set; }
    }

    public class v_Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string carID { get; set; }

        public string category_name { get; set; }
        public string carDesc { get; set; }
        public string carmaker_name { get; set; }
        public string carmodel_name { get; set; }
        public string insurance_type { get; set; }
        public string gas_type { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int capacity { get; set; }
        public string regNumber { get; set; }
        public decimal dailyRate { get; set; }
        public string picture { get; set; }
        public string childSeat { get; set; }
        public string status { get; set; }
    }

    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string reservationid { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string bookingStatus { get; set; }
        public string carId { get; set; }
        public DateTime pickuptime { get; set; }
        public string userid { get; set; }
        public int numberOfDays { get; set; }
        public decimal amountPaid { get; set; }
        public DateTime created_date { get; set; }
    }

    public class CarMaker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string carmakerid { get; set; }
        public string name { get; set; }
    }

    public class CarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string carmodelid { get; set; }
        public string name { get; set; }
        public string carmakerid { get; set; }
    }

    public class Insurance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string insuranceid { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
        public string coverage { get; set; }
    }

    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string categoryid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class ResultMappingClass
    {
        [Key]
        public string carID { get; set; }

        public string category_name { get; set; }
        public string carDesc { get; set; }
        public string carmaker_name { get; set; }
        public string carmodel_name { get; set; }
        public string insurance_type { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int capacity { get; set; }
        public string regNumber { get; set; }
        public decimal dailyRate { get; set; }
        public string picture { get; set; }
        public string childSeat { get; set; }
        public string status { get; set; }
    }

    public class v_pickup
    {
        [Key]
        public string carID { get; set; }
        public string carDesc { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
    }

    public class v_showavailcar
    {
        public int rented { get; set; }
        public int available { get; set; }
        public int totalcars { get; set; }
    }
    public class v_showbooking
    {
        public int rented { get; set; }
        public int totalcars { get; set; }
    }

    public class v_customers
    {
        [Key]
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }

    public class v_reservations
    {
        [Key]
        public string reservationId { get; set; }
        public string startDate { get; set; }
        public string endDATE { get; set; }
        public string carID { get; set; }
        public string userID { get; set; }
        public string pickuptime { get; set; }
        public string created_date { get; set; }
    }

    public class v_bookedcars
    {
        [Key]
        public string cardesc { get; set; }
        public string carmodel_name { get; set; }
        public int year { get; set; }
        public decimal dailyRate { get; set; }
        public string reservationId { get; set; }
        public string startDate { get; set; }
        public string endDATE { get; set; }
        public string pickuptime { get; set; }
        public string created_date { get; set; }
    }

    public class BookedCarMappingClass
    {
        [Key]

        public string carId { get; set; }
        public string reservationId { get; set; }
        public string cardesc { get; set; }
        public string carmodel_name { get; set; }
        public int year { get; set; }
        public decimal dailyRate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDATE { get; set; }
        public DateTime pickuptime { get; set; }
        public DateTime created_date { get; set; }
        public string picture { get; set; }
        public string status { get; set; }
        public string bookingStatus { get; set; }
        public decimal amountPaid { get; set; }
        public int numberOfDays { get; set; }
    }
}