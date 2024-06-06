namespace ProjRentalHub
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            lblCategoryValue = new Label();
            lblCategory = new Label();
            lblDailyRate = new Label();
            panel13 = new Panel();
            pictureBox6 = new PictureBox();
            lblChildseatvalue = new Label();
            lblChildseat = new Label();
            panel12 = new Panel();
            pictureBox4 = new PictureBox();
            lblStatusValue = new Label();
            lblStatus = new Label();
            panel11 = new Panel();
            pictureBox3 = new PictureBox();
            lblCapacity = new Label();
            lblCapacityValue = new Label();
            panel10 = new Panel();
            pictureBox2 = new PictureBox();
            lblType = new Label();
            lblTypeValue = new Label();
            panel9 = new Panel();
            pictureBox5 = new PictureBox();
            lblColor = new Label();
            lblColorValue = new Label();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            lblYear = new Label();
            lblYearValue = new Label();
            lblDailyRateValue = new Label();
            lblCarDesc = new Label();
            pCarPicture = new PictureBox();
            panel4 = new Panel();
            lblCalendar = new Label();
            DashboardCalendar = new MonthCalendar();
            panel5 = new Panel();
            ProgressBarReservation = new ProgressBar();
            lblReservationProgress = new Label();
            progressBar2 = new ProgressBar();
            label2 = new Label();
            ProgressBarAvail = new ProgressBar();
            lblCarsAvail = new Label();
            panel6 = new Panel();
            lvPickUp = new ListView();
            CarDescription = new ColumnHeader();
            StartDate = new ColumnHeader();
            EndDate = new ColumnHeader();
            btnPreviousPickup = new Button();
            btnNextPickup = new Button();
            label17 = new Label();
            panel7 = new Panel();
            lvLiveCarStatus = new ListView();
            Description = new ColumnHeader();
            Category = new ColumnHeader();
            Maker = new ColumnHeader();
            Model = new ColumnHeader();
            Colors = new ColumnHeader();
            Insurance = new ColumnHeader();
            Type = new ColumnHeader();
            Registration = new ColumnHeader();
            Status = new ColumnHeader();
            Childseat = new ColumnHeader();
            btnCarStatusPrev = new Button();
            btnCarStatusNext = new Button();
            lblLiveCarStatus = new Label();
            DashboardTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            cboAdminProfile = new ComboBox();
            label9 = new Label();
            panel2 = new Panel();
            lblUsername = new Label();
            pUserProfile = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel14 = new Panel();
            btnDashBoard = new Button();
            panel16 = new Panel();
            btnCustomers = new Button();
            panel17 = new Panel();
            btnRegCar = new Button();
            panel15 = new Panel();
            btnCarManagement = new Button();
            panel18 = new Panel();
            btnBookings = new Button();
            panel19 = new Panel();
            btnLogout = new Button();
            panel3.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pCarPicture).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pUserProfile).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel15.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(327, 68);
            label6.Name = "label6";
            label6.Size = new Size(348, 23);
            label6.TabIndex = 4;
            label6.Text = "Today is an excellent day for renting a car.";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblCategoryValue);
            panel3.Controls.Add(lblCategory);
            panel3.Controls.Add(lblDailyRate);
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(lblDailyRateValue);
            panel3.Controls.Add(lblCarDesc);
            panel3.Controls.Add(pCarPicture);
            panel3.Location = new Point(238, 114);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 468);
            panel3.TabIndex = 20;
            // 
            // lblCategoryValue
            // 
            lblCategoryValue.AutoSize = true;
            lblCategoryValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoryValue.ForeColor = Color.Maroon;
            lblCategoryValue.Location = new Point(351, 429);
            lblCategoryValue.Name = "lblCategoryValue";
            lblCategoryValue.Size = new Size(83, 32);
            lblCategoryValue.TabIndex = 32;
            lblCategoryValue.Text = "Sedan";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Gray;
            lblCategory.Location = new Point(264, 430);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(96, 28);
            lblCategory.TabIndex = 31;
            lblCategory.Text = "Category:";
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDailyRate.ForeColor = Color.Gray;
            lblDailyRate.Location = new Point(16, 430);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(104, 28);
            lblDailyRate.TabIndex = 5;
            lblDailyRate.Text = "Daily Rate:";
            // 
            // panel13
            // 
            panel13.BackColor = Color.PaleTurquoise;
            panel13.Controls.Add(pictureBox6);
            panel13.Controls.Add(lblChildseatvalue);
            panel13.Controls.Add(lblChildseat);
            panel13.Location = new Point(512, 315);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(102, 105);
            panel13.TabIndex = 30;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.seat;
            pictureBox6.Location = new Point(2, 8);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // lblChildseatvalue
            // 
            lblChildseatvalue.AutoSize = true;
            lblChildseatvalue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblChildseatvalue.Location = new Point(16, 52);
            lblChildseatvalue.Name = "lblChildseatvalue";
            lblChildseatvalue.Size = new Size(51, 32);
            lblChildseatvalue.TabIndex = 28;
            lblChildseatvalue.Text = "Yes";
            // 
            // lblChildseat
            // 
            lblChildseat.AutoSize = true;
            lblChildseat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblChildseat.Location = new Point(35, 19);
            lblChildseat.Name = "lblChildseat";
            lblChildseat.Size = new Size(69, 23);
            lblChildseat.TabIndex = 27;
            lblChildseat.Text = "CHSeat";
            // 
            // panel12
            // 
            panel12.BackColor = Color.MediumTurquoise;
            panel12.Controls.Add(pictureBox4);
            panel12.Controls.Add(lblStatusValue);
            panel12.Controls.Add(lblStatus);
            panel12.Location = new Point(402, 315);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(102, 105);
            panel12.TabIndex = 29;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.signal_status;
            pictureBox4.Location = new Point(7, 8);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusValue.Location = new Point(7, 52);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(72, 28);
            lblStatusValue.TabIndex = 28;
            lblStatusValue.Text = "Active";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(41, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 23);
            lblStatus.TabIndex = 27;
            lblStatus.Text = "Status";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Beige;
            panel11.Controls.Add(pictureBox3);
            panel11.Controls.Add(lblCapacity);
            panel11.Controls.Add(lblCapacityValue);
            panel11.Location = new Point(511, 200);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(102, 105);
            panel11.TabIndex = 28;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.skills;
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapacity.Location = new Point(35, 16);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(46, 23);
            lblCapacity.TabIndex = 25;
            lblCapacity.Text = "Cap.";
            // 
            // lblCapacityValue
            // 
            lblCapacityValue.AutoSize = true;
            lblCapacityValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapacityValue.Location = new Point(16, 53);
            lblCapacityValue.Name = "lblCapacityValue";
            lblCapacityValue.Size = new Size(28, 32);
            lblCapacityValue.TabIndex = 26;
            lblCapacityValue.Text = "4";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Khaki;
            panel10.Controls.Add(pictureBox2);
            panel10.Controls.Add(lblType);
            panel10.Controls.Add(lblTypeValue);
            panel10.Location = new Point(402, 200);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(102, 105);
            panel10.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.petrol;
            pictureBox2.Location = new Point(7, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(41, 16);
            lblType.Name = "lblType";
            lblType.Size = new Size(48, 23);
            lblType.TabIndex = 25;
            lblType.Text = "Type";
            // 
            // lblTypeValue
            // 
            lblTypeValue.AutoSize = true;
            lblTypeValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeValue.Location = new Point(17, 53);
            lblTypeValue.Name = "lblTypeValue";
            lblTypeValue.Size = new Size(82, 32);
            lblTypeValue.TabIndex = 26;
            lblTypeValue.Text = "Petrol";
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkSalmon;
            panel9.Controls.Add(pictureBox5);
            panel9.Controls.Add(lblColor);
            panel9.Controls.Add(lblColorValue);
            panel9.Location = new Point(511, 85);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(102, 105);
            panel9.TabIndex = 27;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.color_palette;
            pictureBox5.Location = new Point(3, 7);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblColor.Location = new Point(35, 16);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(53, 23);
            lblColor.TabIndex = 25;
            lblColor.Text = "Color";
            // 
            // lblColorValue
            // 
            lblColorValue.AutoSize = true;
            lblColorValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblColorValue.Location = new Point(16, 57);
            lblColorValue.Name = "lblColorValue";
            lblColorValue.Size = new Size(57, 32);
            lblColorValue.TabIndex = 26;
            lblColorValue.Text = "Red";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Bisque;
            panel8.Controls.Add(pictureBox1);
            panel8.Controls.Add(lblYear);
            panel8.Controls.Add(lblYearValue);
            panel8.Location = new Point(402, 85);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(102, 105);
            panel8.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.Location = new Point(41, 16);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(43, 23);
            lblYear.TabIndex = 25;
            lblYear.Text = "Year";
            // 
            // lblYearValue
            // 
            lblYearValue.AutoSize = true;
            lblYearValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblYearValue.Location = new Point(17, 57);
            lblYearValue.Name = "lblYearValue";
            lblYearValue.Size = new Size(70, 32);
            lblYearValue.TabIndex = 26;
            lblYearValue.Text = "2023";
            // 
            // lblDailyRateValue
            // 
            lblDailyRateValue.AutoSize = true;
            lblDailyRateValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDailyRateValue.ForeColor = Color.Red;
            lblDailyRateValue.Location = new Point(111, 429);
            lblDailyRateValue.Name = "lblDailyRateValue";
            lblDailyRateValue.Size = new Size(127, 32);
            lblDailyRateValue.TabIndex = 23;
            lblDailyRateValue.Text = "$300 CAD";
            // 
            // lblCarDesc
            // 
            lblCarDesc.AutoSize = true;
            lblCarDesc.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarDesc.Location = new Point(16, 13);
            lblCarDesc.Name = "lblCarDesc";
            lblCarDesc.Size = new Size(216, 45);
            lblCarDesc.TabIndex = 21;
            lblCarDesc.Text = "Nissan GTR";
            // 
            // pCarPicture
            // 
            pCarPicture.Image = Properties.Resources._2023_11_02_13_32_46_Car_Rental_Dashboard_by_Mubarak_Hossen_on_Dribbble;
            pCarPicture.Location = new Point(14, 85);
            pCarPicture.Margin = new Padding(3, 4, 3, 4);
            pCarPicture.Name = "pCarPicture";
            pCarPicture.Size = new Size(382, 335);
            pCarPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pCarPicture.TabIndex = 16;
            pCarPicture.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblCalendar);
            panel4.Controls.Add(DashboardCalendar);
            panel4.Location = new Point(874, 114);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(287, 239);
            panel4.TabIndex = 21;
            // 
            // lblCalendar
            // 
            lblCalendar.AutoSize = true;
            lblCalendar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalendar.Location = new Point(15, 2);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(124, 23);
            lblCalendar.TabIndex = 19;
            lblCalendar.Text = "October, 2023";
            // 
            // DashboardCalendar
            // 
            DashboardCalendar.Location = new Point(12, 24);
            DashboardCalendar.Margin = new Padding(10, 12, 10, 12);
            DashboardCalendar.Name = "DashboardCalendar";
            DashboardCalendar.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(ProgressBarReservation);
            panel5.Controls.Add(lblReservationProgress);
            panel5.Controls.Add(progressBar2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(ProgressBarAvail);
            panel5.Controls.Add(lblCarsAvail);
            panel5.Location = new Point(874, 358);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 224);
            panel5.TabIndex = 22;
            // 
            // ProgressBarReservation
            // 
            ProgressBarReservation.Location = new Point(15, 181);
            ProgressBarReservation.Margin = new Padding(3, 4, 3, 4);
            ProgressBarReservation.Maximum = 5;
            ProgressBarReservation.Name = "ProgressBarReservation";
            ProgressBarReservation.Size = new Size(261, 31);
            ProgressBarReservation.TabIndex = 40;
            // 
            // lblReservationProgress
            // 
            lblReservationProgress.AutoSize = true;
            lblReservationProgress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReservationProgress.Location = new Point(14, 155);
            lblReservationProgress.Name = "lblReservationProgress";
            lblReservationProgress.Size = new Size(150, 23);
            lblReservationProgress.TabIndex = 39;
            lblReservationProgress.Text = "Booking Progress";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(15, 113);
            progressBar2.Margin = new Padding(3, 4, 3, 4);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(261, 31);
            progressBar2.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 87);
            label2.Name = "label2";
            label2.Size = new Size(211, 23);
            label2.TabIndex = 37;
            label2.Text = "Pickups for Specific Days";
            // 
            // ProgressBarAvail
            // 
            ProgressBarAvail.Location = new Point(15, 44);
            ProgressBarAvail.Margin = new Padding(3, 4, 3, 4);
            ProgressBarAvail.Name = "ProgressBarAvail";
            ProgressBarAvail.Size = new Size(261, 31);
            ProgressBarAvail.TabIndex = 36;
            // 
            // lblCarsAvail
            // 
            lblCarsAvail.AutoSize = true;
            lblCarsAvail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarsAvail.Location = new Point(14, 15);
            lblCarsAvail.Name = "lblCarsAvail";
            lblCarsAvail.Size = new Size(137, 23);
            lblCarsAvail.TabIndex = 27;
            lblCarsAvail.Text = "Cars availability";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lvPickUp);
            panel6.Controls.Add(btnPreviousPickup);
            panel6.Controls.Add(btnNextPickup);
            panel6.Controls.Add(label17);
            panel6.Location = new Point(239, 588);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(923, 179);
            panel6.TabIndex = 23;
            // 
            // lvPickUp
            // 
            lvPickUp.Columns.AddRange(new ColumnHeader[] { CarDescription, StartDate, EndDate });
            lvPickUp.Location = new Point(15, 51);
            lvPickUp.Margin = new Padding(3, 4, 3, 4);
            lvPickUp.Name = "lvPickUp";
            lvPickUp.Size = new Size(893, 116);
            lvPickUp.TabIndex = 24;
            lvPickUp.UseCompatibleStateImageBehavior = false;
            lvPickUp.View = View.Details;
            // 
            // CarDescription
            // 
            CarDescription.Text = "Car Description";
            CarDescription.Width = 130;
            // 
            // StartDate
            // 
            StartDate.Text = "Start Date";
            StartDate.Width = 150;
            // 
            // EndDate
            // 
            EndDate.Text = "End Date";
            EndDate.Width = 150;
            // 
            // btnPreviousPickup
            // 
            btnPreviousPickup.BackColor = Color.FromArgb(224, 224, 224);
            btnPreviousPickup.FlatStyle = FlatStyle.Popup;
            btnPreviousPickup.Location = new Point(15, 12);
            btnPreviousPickup.Margin = new Padding(3, 4, 3, 4);
            btnPreviousPickup.Name = "btnPreviousPickup";
            btnPreviousPickup.Size = new Size(38, 31);
            btnPreviousPickup.TabIndex = 3;
            btnPreviousPickup.Text = "<";
            btnPreviousPickup.UseVisualStyleBackColor = false;
            btnPreviousPickup.Click += btnPreviousPickup_Click;
            // 
            // btnNextPickup
            // 
            btnNextPickup.BackColor = Color.FromArgb(224, 224, 224);
            btnNextPickup.FlatStyle = FlatStyle.Popup;
            btnNextPickup.Location = new Point(59, 12);
            btnNextPickup.Margin = new Padding(3, 4, 3, 4);
            btnNextPickup.Name = "btnNextPickup";
            btnNextPickup.Size = new Size(38, 31);
            btnNextPickup.TabIndex = 2;
            btnNextPickup.Text = ">";
            btnNextPickup.UseVisualStyleBackColor = false;
            btnNextPickup.Click += btnNextPickup_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(101, 12);
            label17.Name = "label17";
            label17.Size = new Size(112, 28);
            label17.TabIndex = 0;
            label17.Text = "For Pick-up";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lvLiveCarStatus);
            panel7.Controls.Add(btnCarStatusPrev);
            panel7.Controls.Add(btnCarStatusNext);
            panel7.Controls.Add(lblLiveCarStatus);
            panel7.Location = new Point(239, 774);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(923, 220);
            panel7.TabIndex = 4;
            // 
            // lvLiveCarStatus
            // 
            lvLiveCarStatus.Columns.AddRange(new ColumnHeader[] { Description, Category, Maker, Model, Colors, Insurance, Type, Registration, Status, Childseat });
            lvLiveCarStatus.Location = new Point(15, 49);
            lvLiveCarStatus.Margin = new Padding(3, 4, 3, 4);
            lvLiveCarStatus.Name = "lvLiveCarStatus";
            lvLiveCarStatus.Size = new Size(893, 161);
            lvLiveCarStatus.TabIndex = 23;
            lvLiveCarStatus.UseCompatibleStateImageBehavior = false;
            lvLiveCarStatus.View = View.Details;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 120;
            // 
            // Category
            // 
            Category.Text = "Category";
            Category.Width = 100;
            // 
            // Maker
            // 
            Maker.Text = "Maker";
            Maker.Width = 100;
            // 
            // Model
            // 
            Model.Text = "Model";
            Model.Width = 100;
            // 
            // Colors
            // 
            Colors.Text = "Colors";
            // 
            // Insurance
            // 
            Insurance.Text = "Insurance";
            Insurance.Width = 100;
            // 
            // Type
            // 
            Type.Text = "Type";
            // 
            // Registration
            // 
            Registration.Text = "Registration";
            Registration.Width = 100;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 100;
            // 
            // Childseat
            // 
            Childseat.Text = "Childseat";
            // 
            // btnCarStatusPrev
            // 
            btnCarStatusPrev.BackColor = Color.FromArgb(224, 224, 224);
            btnCarStatusPrev.FlatStyle = FlatStyle.Popup;
            btnCarStatusPrev.Location = new Point(15, 9);
            btnCarStatusPrev.Margin = new Padding(3, 4, 3, 4);
            btnCarStatusPrev.Name = "btnCarStatusPrev";
            btnCarStatusPrev.Size = new Size(38, 31);
            btnCarStatusPrev.TabIndex = 6;
            btnCarStatusPrev.Text = "<";
            btnCarStatusPrev.UseVisualStyleBackColor = false;
            btnCarStatusPrev.Click += btnCarStatusPrev_Click;
            // 
            // btnCarStatusNext
            // 
            btnCarStatusNext.BackColor = Color.FromArgb(224, 224, 224);
            btnCarStatusNext.FlatStyle = FlatStyle.Popup;
            btnCarStatusNext.Location = new Point(59, 9);
            btnCarStatusNext.Margin = new Padding(3, 4, 3, 4);
            btnCarStatusNext.Name = "btnCarStatusNext";
            btnCarStatusNext.Size = new Size(38, 31);
            btnCarStatusNext.TabIndex = 5;
            btnCarStatusNext.Text = ">";
            btnCarStatusNext.UseVisualStyleBackColor = false;
            btnCarStatusNext.Click += btnCarStatusNext_Click;
            // 
            // lblLiveCarStatus
            // 
            lblLiveCarStatus.AutoSize = true;
            lblLiveCarStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLiveCarStatus.Location = new Point(106, 11);
            lblLiveCarStatus.Name = "lblLiveCarStatus";
            lblLiveCarStatus.Size = new Size(138, 28);
            lblLiveCarStatus.TabIndex = 16;
            lblLiveCarStatus.Text = "Live Car Status";
            // 
            // DashboardTimer
            // 
            DashboardTimer.Enabled = true;
            DashboardTimer.Interval = 15000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 47);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 33;
            label1.Text = "Administrator";
            // 
            // cboAdminProfile
            // 
            cboAdminProfile.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAdminProfile.DropDownWidth = 25;
            cboAdminProfile.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboAdminProfile.FormattingEnabled = true;
            cboAdminProfile.Location = new Point(445, 27);
            cboAdminProfile.Margin = new Padding(3, 4, 3, 4);
            cboAdminProfile.Name = "cboAdminProfile";
            cboAdminProfile.Size = new Size(23, 33);
            cboAdminProfile.TabIndex = 34;
            cboAdminProfile.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(238, 994);
            label9.Name = "label9";
            label9.Size = new Size(340, 23);
            label9.TabIndex = 35;
            label9.Text = "2023 Car Rental Hub. All rights reserved.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(pUserProfile);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cboAdminProfile);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1167, 107);
            panel2.TabIndex = 36;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(328, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(65, 32);
            lblUsername.TabIndex = 35;
            lblUsername.Text = "User";
            // 
            // pUserProfile
            // 
            pUserProfile.Image = Properties.Resources.profile;
            pUserProfile.Location = new Point(234, 9);
            pUserProfile.Margin = new Padding(3, 4, 3, 4);
            pUserProfile.Name = "pUserProfile";
            pUserProfile.Size = new Size(86, 83);
            pUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pUserProfile.TabIndex = 16;
            pUserProfile.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel14);
            flowLayoutPanel1.Controls.Add(panel16);
            flowLayoutPanel1.Controls.Add(panel17);
            flowLayoutPanel1.Controls.Add(panel15);
            flowLayoutPanel1.Controls.Add(panel18);
            flowLayoutPanel1.Controls.Add(panel19);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 107);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(232, 910);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Silver;
            panel14.Controls.Add(btnDashBoard);
            panel14.Location = new Point(3, 4);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(0, 40, 0, 0);
            panel14.Size = new Size(225, 100);
            panel14.TabIndex = 39;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashBoard.ForeColor = Color.DodgerBlue;
            btnDashBoard.Image = (Image)resources.GetObject("btnDashBoard.Image");
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, -3);
            btnDashBoard.Margin = new Padding(3, 4, 3, 4);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Padding = new Padding(29, 40, 0, 0);
            btnDashBoard.Size = new Size(230, 105);
            btnDashBoard.TabIndex = 41;
            btnDashBoard.Text = "             Dashboard";
            btnDashBoard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Silver;
            panel16.Controls.Add(btnCustomers);
            panel16.Location = new Point(3, 112);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(225, 57);
            panel16.TabIndex = 43;
            // 
            // btnCustomers
            // 
            btnCustomers.ForeColor = Color.Gray;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(-2, -3);
            btnCustomers.Margin = new Padding(3, 4, 3, 4);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(29, 0, 0, 0);
            btnCustomers.Size = new Size(230, 63);
            btnCustomers.TabIndex = 41;
            btnCustomers.Text = "             Customer";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Silver;
            panel17.Controls.Add(btnRegCar);
            panel17.Location = new Point(3, 177);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(225, 57);
            panel17.TabIndex = 44;
            // 
            // btnRegCar
            // 
            btnRegCar.ForeColor = Color.Gray;
            btnRegCar.Image = (Image)resources.GetObject("btnRegCar.Image");
            btnRegCar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegCar.Location = new Point(-2, -3);
            btnRegCar.Margin = new Padding(3, 4, 3, 4);
            btnRegCar.Name = "btnRegCar";
            btnRegCar.Padding = new Padding(29, 0, 0, 0);
            btnRegCar.Size = new Size(230, 63);
            btnRegCar.TabIndex = 41;
            btnRegCar.Text = "             Car Registration";
            btnRegCar.TextAlign = ContentAlignment.MiddleLeft;
            btnRegCar.UseVisualStyleBackColor = true;
            btnRegCar.Click += btnRegCar_Click;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Silver;
            panel15.Controls.Add(btnCarManagement);
            panel15.Location = new Point(3, 242);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(225, 57);
            panel15.TabIndex = 42;
            // 
            // btnCarManagement
            // 
            btnCarManagement.ForeColor = Color.Gray;
            btnCarManagement.Image = (Image)resources.GetObject("btnCarManagement.Image");
            btnCarManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarManagement.Location = new Point(-2, -3);
            btnCarManagement.Margin = new Padding(3, 4, 3, 4);
            btnCarManagement.Name = "btnCarManagement";
            btnCarManagement.Padding = new Padding(29, 0, 0, 0);
            btnCarManagement.Size = new Size(230, 63);
            btnCarManagement.TabIndex = 41;
            btnCarManagement.Text = "             Car Management";
            btnCarManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnCarManagement.UseVisualStyleBackColor = true;
            btnCarManagement.Click += btnCarManagement_Click;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Silver;
            panel18.Controls.Add(btnBookings);
            panel18.Location = new Point(3, 307);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(225, 57);
            panel18.TabIndex = 45;
            // 
            // btnBookings
            // 
            btnBookings.ForeColor = Color.Gray;
            btnBookings.Image = (Image)resources.GetObject("btnBookings.Image");
            btnBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookings.Location = new Point(-2, -3);
            btnBookings.Margin = new Padding(3, 4, 3, 4);
            btnBookings.Name = "btnBookings";
            btnBookings.Padding = new Padding(29, 0, 0, 0);
            btnBookings.Size = new Size(230, 63);
            btnBookings.TabIndex = 41;
            btnBookings.Text = "             Bookings";
            btnBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // panel19
            // 
            panel19.BackColor = Color.Silver;
            panel19.Controls.Add(btnLogout);
            panel19.Location = new Point(3, 372);
            panel19.Margin = new Padding(3, 4, 3, 4);
            panel19.Name = "panel19";
            panel19.Padding = new Padding(0, 67, 0, 0);
            panel19.Size = new Size(225, 149);
            panel19.TabIndex = 46;
            // 
            // btnLogout
            // 
            btnLogout.ForeColor = Color.Gray;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, -3);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(29, 0, 0, 0);
            btnLogout.Size = new Size(230, 156);
            btnLogout.TabIndex = 41;
            btnLogout.Text = "             Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1167, 1017);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pCarPicture).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pUserProfile).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel3;
        private PictureBox pCarPicture;
        private Label lblCarDesc;
        private Label lblDailyRateValue;
        private Panel panel4;
        private Label lblCalendar;
        private MonthCalendar DashboardCalendar;
        private Panel panel5;
        private Panel panel6;
        private Button btnPreviousPickup;
        private Button btnNextPickup;
        private Label label17;
        private Panel panel7;
        private Label lblLiveCarStatus;
        private Panel panel9;
        private Label lblColor;
        private Label lblColorValue;
        private Panel panel8;
        private Label lblYear;
        private Label lblYearValue;
        private Panel panel11;
        private Label lblCapacity;
        private Label lblCapacityValue;
        private Panel panel10;
        private Label lblType;
        private Label lblTypeValue;
        private Panel panel12;
        private Label lblStatusValue;
        private Label lblStatus;
        private Panel panel13;
        private Label lblChildseatvalue;
        private Label lblChildseat;
        private Button btnCarStatusPrev;
        private Button btnCarStatusNext;
        private Label lblDailyRate;
        private Label lblCategory;
        private Label lblCategoryValue;
        private System.Windows.Forms.Timer DashboardTimer;
        private Label label1;
        private ComboBox cboAdminProfile;
        private Label label9;
        private Label lblCarsAvail;
        private ProgressBar ProgressBarAvail;
        private ProgressBar ProgressBarReservation;
        private Label lblReservationProgress;
        private ProgressBar progressBar2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel2;
        private PictureBox pUserProfile;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel14;
        private Button btnDashBoard;
        private Panel panel15;
        private Button btnCarManagement;
        private Panel panel16;
        private Button btnCustomers;
        private Panel panel17;
        private Button btnRegCar;
        private Panel panel18;
        private Button btnBookings;
        private Panel panel19;
        private Button btnLogout;
        private Label lblUsername;
        private ListView lvLiveCarStatus;
        private ColumnHeader Category;
        private ColumnHeader Maker;
        private ColumnHeader Model;
        private ColumnHeader Colors;
        private ColumnHeader Insurance;
        private ColumnHeader Type;
        private ColumnHeader Registration;
        private ColumnHeader Status;
        private ColumnHeader Description;
        private ColumnHeader Childseat;
        private ListView lvPickUp;
        private ColumnHeader CarDescription;
        private ColumnHeader StartDate;
        private ColumnHeader EndDate;
    }
}