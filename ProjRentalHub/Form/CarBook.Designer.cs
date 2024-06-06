namespace ProjRentalHub
{
    partial class CarBook
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
            dtstartDate = new DateTimePicker();
            dtEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtPickupTime = new DateTimePicker();
            btnBook = new Button();
            pBookCar = new PictureBox();
            lblcarDesc_m = new Label();
            label6 = new Label();
            label8 = new Label();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            label13 = new Label();
            txtcapacity = new TextBox();
            label10 = new Label();
            txtregNumber = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtdailyRate = new TextBox();
            label7 = new Label();
            label14 = new Label();
            txtCategory = new TextBox();
            txtMaker = new TextBox();
            txtModel = new TextBox();
            txtColor = new TextBox();
            txtYear = new TextBox();
            txtStatus = new TextBox();
            txtChildSeat = new TextBox();
            txtInsuranceType = new TextBox();
            panel1 = new Panel();
            lblAdminPanel = new Label();
            pGoBackIcon = new PictureBox();
            lblPictureFilename = new Label();
            ((System.ComponentModel.ISupportInitialize)pBookCar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            SuspendLayout();
            // 
            // dtstartDate
            // 
            dtstartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtstartDate.Location = new Point(14, 520);
            dtstartDate.Margin = new Padding(3, 4, 3, 4);
            dtstartDate.Name = "dtstartDate";
            dtstartDate.Size = new Size(174, 27);
            dtstartDate.TabIndex = 0;
            // 
            // dtEndDate
            // 
            dtEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtEndDate.Location = new Point(195, 519);
            dtEndDate.Margin = new Padding(3, 4, 3, 4);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(174, 27);
            dtEndDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 495);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 495);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "End Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 496);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "Pickup Time:";
            // 
            // dtPickupTime
            // 
            dtPickupTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtPickupTime.Location = new Point(377, 520);
            dtPickupTime.Margin = new Padding(3, 4, 3, 4);
            dtPickupTime.Name = "dtPickupTime";
            dtPickupTime.Size = new Size(189, 27);
            dtPickupTime.TabIndex = 4;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.DodgerBlue;
            btnBook.FlatStyle = FlatStyle.Popup;
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(609, 520);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(138, 31);
            btnBook.TabIndex = 6;
            btnBook.Text = "BOOK";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // pBookCar
            // 
            pBookCar.Image = Properties.Resources.Renault_Clio_Diesel;
            pBookCar.Location = new Point(14, 83);
            pBookCar.Margin = new Padding(3, 4, 3, 4);
            pBookCar.Name = "pBookCar";
            pBookCar.Size = new Size(467, 329);
            pBookCar.SizeMode = PictureBoxSizeMode.Zoom;
            pBookCar.TabIndex = 7;
            pBookCar.TabStop = false;
            // 
            // lblcarDesc_m
            // 
            lblcarDesc_m.AutoSize = true;
            lblcarDesc_m.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarDesc_m.ForeColor = Color.Red;
            lblcarDesc_m.Location = new Point(158, 424);
            lblcarDesc_m.Name = "lblcarDesc_m";
            lblcarDesc_m.Size = new Size(197, 37);
            lblcarDesc_m.TabIndex = 15;
            lblcarDesc_m.Text = "Toyota Camry";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 92);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 36;
            label6.Text = "Category:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(510, 128);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 40;
            label8.Text = "Maker:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 167);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 42;
            label4.Text = "Model:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(515, 201);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 44;
            label9.Text = "Color:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 236);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 51;
            label5.Text = "Year:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(487, 479);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 63;
            label13.Text = "Child Seat:";
            // 
            // txtcapacity
            // 
            txtcapacity.BorderStyle = BorderStyle.FixedSingle;
            txtcapacity.Enabled = false;
            txtcapacity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtcapacity.Location = new Point(568, 309);
            txtcapacity.Margin = new Padding(3, 4, 3, 4);
            txtcapacity.Name = "txtcapacity";
            txtcapacity.Size = new Size(193, 30);
            txtcapacity.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(495, 315);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 61;
            label10.Text = "Capacity:";
            // 
            // txtregNumber
            // 
            txtregNumber.BorderStyle = BorderStyle.FixedSingle;
            txtregNumber.Enabled = false;
            txtregNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtregNumber.Location = new Point(568, 351);
            txtregNumber.Margin = new Padding(3, 4, 3, 4);
            txtregNumber.Name = "txtregNumber";
            txtregNumber.Size = new Size(193, 30);
            txtregNumber.TabIndex = 60;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(489, 355);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 59;
            label12.Text = "Reg Plate:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(490, 272);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 57;
            label11.Text = "Insurance:";
            // 
            // txtdailyRate
            // 
            txtdailyRate.BorderStyle = BorderStyle.FixedSingle;
            txtdailyRate.Enabled = false;
            txtdailyRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtdailyRate.Location = new Point(568, 392);
            txtdailyRate.Margin = new Padding(3, 4, 3, 4);
            txtdailyRate.Name = "txtdailyRate";
            txtdailyRate.Size = new Size(193, 30);
            txtdailyRate.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 437);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 54;
            label7.Text = "Status:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(488, 396);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 53;
            label14.Text = "Daily Rate:";
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Enabled = false;
            txtCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCategory.Location = new Point(568, 88);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(193, 30);
            txtCategory.TabIndex = 65;
            // 
            // txtMaker
            // 
            txtMaker.BorderStyle = BorderStyle.FixedSingle;
            txtMaker.Enabled = false;
            txtMaker.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaker.Location = new Point(568, 124);
            txtMaker.Margin = new Padding(3, 4, 3, 4);
            txtMaker.Name = "txtMaker";
            txtMaker.Size = new Size(193, 30);
            txtMaker.TabIndex = 66;
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Enabled = false;
            txtModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtModel.Location = new Point(568, 160);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(193, 30);
            txtModel.TabIndex = 67;
            // 
            // txtColor
            // 
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Enabled = false;
            txtColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtColor.Location = new Point(568, 196);
            txtColor.Margin = new Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(193, 30);
            txtColor.TabIndex = 68;
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Enabled = false;
            txtYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtYear.Location = new Point(568, 232);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(193, 30);
            txtYear.TabIndex = 69;
            // 
            // txtStatus
            // 
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtStatus.Location = new Point(568, 433);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(193, 30);
            txtStatus.TabIndex = 70;
            // 
            // txtChildSeat
            // 
            txtChildSeat.BorderStyle = BorderStyle.FixedSingle;
            txtChildSeat.Enabled = false;
            txtChildSeat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtChildSeat.Location = new Point(568, 475);
            txtChildSeat.Margin = new Padding(3, 4, 3, 4);
            txtChildSeat.Name = "txtChildSeat";
            txtChildSeat.Size = new Size(193, 30);
            txtChildSeat.TabIndex = 71;
            // 
            // txtInsuranceType
            // 
            txtInsuranceType.BorderStyle = BorderStyle.FixedSingle;
            txtInsuranceType.Enabled = false;
            txtInsuranceType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtInsuranceType.Location = new Point(568, 268);
            txtInsuranceType.Margin = new Padding(3, 4, 3, 4);
            txtInsuranceType.Name = "txtInsuranceType";
            txtInsuranceType.Size = new Size(193, 30);
            txtInsuranceType.TabIndex = 72;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lblAdminPanel);
            panel1.Controls.Add(pGoBackIcon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 75);
            panel1.TabIndex = 73;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(79, 18);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(139, 38);
            lblAdminPanel.TabIndex = 74;
            lblAdminPanel.Text = "Bookings";
            // 
            // pGoBackIcon
            // 
            pGoBackIcon.Image = Properties.Resources.back;
            pGoBackIcon.Location = new Point(10, 9);
            pGoBackIcon.Margin = new Padding(3, 4, 3, 4);
            pGoBackIcon.Name = "pGoBackIcon";
            pGoBackIcon.Size = new Size(61, 56);
            pGoBackIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pGoBackIcon.TabIndex = 75;
            pGoBackIcon.TabStop = false;
            pGoBackIcon.Click += pGoBackIcon_Click;
            // 
            // lblPictureFilename
            // 
            lblPictureFilename.AutoSize = true;
            lblPictureFilename.Location = new Point(378, 427);
            lblPictureFilename.Name = "lblPictureFilename";
            lblPictureFilename.Size = new Size(58, 20);
            lblPictureFilename.TabIndex = 74;
            lblPictureFilename.Text = "label15";
            lblPictureFilename.Visible = false;
            // 
            // BookCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 576);
            ControlBox = false;
            Controls.Add(lblPictureFilename);
            Controls.Add(panel1);
            Controls.Add(txtInsuranceType);
            Controls.Add(txtChildSeat);
            Controls.Add(txtStatus);
            Controls.Add(txtYear);
            Controls.Add(txtColor);
            Controls.Add(txtModel);
            Controls.Add(txtMaker);
            Controls.Add(txtCategory);
            Controls.Add(label13);
            Controls.Add(txtcapacity);
            Controls.Add(label10);
            Controls.Add(txtregNumber);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtdailyRate);
            Controls.Add(label7);
            Controls.Add(label14);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(lblcarDesc_m);
            Controls.Add(pBookCar);
            Controls.Add(btnBook);
            Controls.Add(label3);
            Controls.Add(dtPickupTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtEndDate);
            Controls.Add(dtstartDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookCar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car [BOOK]";
            Load += BookCar_Load;
            ((System.ComponentModel.ISupportInitialize)pBookCar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtstartDate;
        private DateTimePicker dtEndDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtPickupTime;
        private Button btnBook;
        private PictureBox pBookCar;
        private Label lblcarDesc_m;
        private Label label6;
        private Label label8;
        private Label label4;
        private Label label9;
        private Label label5;
        private Label label13;
        private TextBox txtcapacity;
        private Label label10;
        private TextBox txtregNumber;
        private Label label12;
        private Label label11;
        private TextBox txtdailyRate;
        private Label label7;
        private Label label14;
        private TextBox txtCategory;
        private TextBox txtMaker;
        private TextBox txtModel;
        private TextBox txtColor;
        private TextBox txtYear;
        private TextBox txtStatus;
        private TextBox txtChildSeat;
        private TextBox txtInsuranceType;
        private Panel panel1;
        private Label lblAdminPanel;
        private PictureBox pGoBackIcon;
        private Label lblPictureFilename;
    }
}