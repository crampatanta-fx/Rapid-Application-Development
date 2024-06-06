namespace ProjRentalHub
{
    partial class CarReturnAdmin
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
            pGoBackIcon = new PictureBox();
            lblCarID = new Label();
            label2 = new Label();
            cboType = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblAdminPanel = new Label();
            numericUpDownYear = new NumericUpDown();
            cboModel = new ComboBox();
            cboChildSeat = new ComboBox();
            label9 = new Label();
            label13 = new Label();
            label6 = new Label();
            txtCapacity = new TextBox();
            cboMaker = new ComboBox();
            label10 = new Label();
            cboCategory = new ComboBox();
            txtRegNumber = new TextBox();
            cboColor = new ComboBox();
            label12 = new Label();
            label8 = new Label();
            cboInsurance = new ComboBox();
            label11 = new Label();
            cboStatus = new ComboBox();
            txtDailyRate = new TextBox();
            txtFileName = new TextBox();
            pCar = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnBrowse = new Button();
            btnReturn = new Button();
            lblcarDesc_m = new Label();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pCar).BeginInit();
            SuspendLayout();
            // 
            // pGoBackIcon
            // 
            pGoBackIcon.Image = Properties.Resources.back;
            pGoBackIcon.Location = new Point(3, 0);
            pGoBackIcon.Margin = new Padding(3, 4, 3, 4);
            pGoBackIcon.Name = "pGoBackIcon";
            pGoBackIcon.Size = new Size(61, 56);
            pGoBackIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pGoBackIcon.TabIndex = 52;
            pGoBackIcon.TabStop = false;
            pGoBackIcon.Click += pGoBackIcon_Click;
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarID.ForeColor = Color.Red;
            lblCarID.Location = new Point(468, 106);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(111, 28);
            lblCarID.TabIndex = 130;
            lblCarID.Text = "CAR00001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 113);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 121;
            label2.Text = "Car ID:";
            // 
            // cboType
            // 
            cboType.Enabled = false;
            cboType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Diesel", "Electric", "Hybrid", "Petrol" });
            cboType.Location = new Point(469, 382);
            cboType.Margin = new Padding(3, 4, 3, 4);
            cboType.Name = "cboType";
            cboType.Size = new Size(242, 31);
            cboType.TabIndex = 120;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(426, 385);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 119;
            label7.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 244);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 122;
            label1.Text = "Model:";
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
            panel1.Size = new Size(723, 59);
            panel1.TabIndex = 118;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(72, 9);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(243, 38);
            lblAdminPanel.TabIndex = 52;
            lblAdminPanel.Text = "Car Management";
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Enabled = false;
            numericUpDownYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownYear.Location = new Point(468, 336);
            numericUpDownYear.Margin = new Padding(3, 4, 3, 4);
            numericUpDownYear.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(241, 30);
            numericUpDownYear.TabIndex = 117;
            numericUpDownYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // cboModel
            // 
            cboModel.Enabled = false;
            cboModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboModel.FormattingEnabled = true;
            cboModel.Items.AddRange(new object[] { "3 Series", "5 Series", "A5", "Accord", "Altima", "Camry", "C-Class", "Civic", "Corolla", "CR-V", "E-Class", "Elantra", "Explorer", "Focus", "Forester", "GLC", "Golf", "i20", "Impala", "Impreza", "Jetta", "Leaf", "Malibu", "Model 3", "Model Y", "Mustang", "MX-5", "Octavia", "Outback", "Passat", "Prius", "R8", "RAV4", "Rogue", "Santa ...", "Sentra", "Sonata", "Sporta...", "Tahoe", "Transp...", "X5", "XF", "Z4" });
            cboModel.Location = new Point(469, 241);
            cboModel.Margin = new Padding(3, 4, 3, 4);
            cboModel.Name = "cboModel";
            cboModel.Size = new Size(242, 31);
            cboModel.TabIndex = 123;
            // 
            // cboChildSeat
            // 
            cboChildSeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChildSeat.Enabled = false;
            cboChildSeat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboChildSeat.FormattingEnabled = true;
            cboChildSeat.Items.AddRange(new object[] { "Yes", "No" });
            cboChildSeat.Location = new Point(468, 512);
            cboChildSeat.Margin = new Padding(3, 4, 3, 4);
            cboChildSeat.Name = "cboChildSeat";
            cboChildSeat.Size = new Size(242, 31);
            cboChildSeat.TabIndex = 116;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(420, 292);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 128;
            label9.Text = "Color:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(388, 515);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 115;
            label13.Text = "Child Seat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 151);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 124;
            label6.Text = "Category:";
            // 
            // txtCapacity
            // 
            txtCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtCapacity.Enabled = false;
            txtCapacity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCapacity.Location = new Point(469, 427);
            txtCapacity.Margin = new Padding(3, 4, 3, 4);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(242, 30);
            txtCapacity.TabIndex = 114;
            // 
            // cboMaker
            // 
            cboMaker.Enabled = false;
            cboMaker.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboMaker.FormattingEnabled = true;
            cboMaker.Items.AddRange(new object[] { "Audi", "BMW", "Chevrolet", "Ferrari", "Ford", "Honda", "Hyundai", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Mazda", "Mercedes", "Mercedes-Benz", "Mitsubishi", "Nissan", "Porsche", "Skoda", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            cboMaker.Location = new Point(469, 194);
            cboMaker.Margin = new Padding(3, 4, 3, 4);
            cboMaker.Name = "cboMaker";
            cboMaker.Size = new Size(242, 31);
            cboMaker.TabIndex = 127;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(400, 432);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 113;
            label10.Text = "Capacity:";
            // 
            // cboCategory
            // 
            cboCategory.Enabled = false;
            cboCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Classic", "Compact", "Convertible", "Coupe", "Crossover", "Diesel", "Electric", "Hatchback", "Hybrid", "Luxury", "Mini-Van", "Muscle", "Off-road", "Racing", "Sedan", "Sports", "SUV", "Truck", "Van", "Wagon" });
            cboCategory.Location = new Point(469, 148);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(242, 31);
            cboCategory.TabIndex = 125;
            // 
            // txtRegNumber
            // 
            txtRegNumber.BorderStyle = BorderStyle.FixedSingle;
            txtRegNumber.Enabled = false;
            txtRegNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtRegNumber.Location = new Point(155, 474);
            txtRegNumber.Margin = new Padding(3, 4, 3, 4);
            txtRegNumber.Name = "txtRegNumber";
            txtRegNumber.Size = new Size(223, 30);
            txtRegNumber.TabIndex = 112;
            // 
            // cboColor
            // 
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColor.Enabled = false;
            cboColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboColor.FormattingEnabled = true;
            cboColor.Items.AddRange(new object[] { "Beige", "Black", "Blue", "Brown", "Charcoal", "Gold", "Gray", "Green", "Lime", "Maroon", "Orange", "Pink", "Purple", "Red", "Silver", "Tan", "Teal", "Turquoise", "Violet", "White", "Yellow" });
            cboColor.Location = new Point(468, 289);
            cboColor.Margin = new Padding(3, 4, 3, 4);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(242, 31);
            cboColor.TabIndex = 129;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 476);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 111;
            label12.Text = "Registration Plate:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 197);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 126;
            label8.Text = "Maker:";
            // 
            // cboInsurance
            // 
            cboInsurance.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInsurance.Enabled = false;
            cboInsurance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboInsurance.FormattingEnabled = true;
            cboInsurance.Items.AddRange(new object[] { "Classic", "Collision", "Comprehensive", "Custom", "Emergency", "Gap", "Guaranteed", "Lease", "Liability", "Medical", "No-fault", "Pay-per-mile", "Personal", "Rental", "Roadside", "Telematics", "Travel", "Underinsured", "Uninsured" });
            cboInsurance.Location = new Point(155, 431);
            cboInsurance.Margin = new Padding(3, 4, 3, 4);
            cboInsurance.Name = "cboInsurance";
            cboInsurance.Size = new Size(223, 31);
            cboInsurance.TabIndex = 110;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(78, 434);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 109;
            label11.Text = "Insurance:";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Enabled = false;
            cboStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Rented" });
            cboStatus.Location = new Point(469, 467);
            cboStatus.Margin = new Padding(3, 4, 3, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(242, 31);
            cboStatus.TabIndex = 108;
            // 
            // txtDailyRate
            // 
            txtDailyRate.BorderStyle = BorderStyle.FixedSingle;
            txtDailyRate.Enabled = false;
            txtDailyRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDailyRate.Location = new Point(155, 514);
            txtDailyRate.Margin = new Padding(3, 4, 3, 4);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(223, 30);
            txtDailyRate.TabIndex = 107;
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFileName.Location = new Point(11, 391);
            txtFileName.Margin = new Padding(3, 4, 3, 4);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(277, 30);
            txtFileName.TabIndex = 106;
            // 
            // pCar
            // 
            pCar.Image = Properties.Resources.Renault_Clio_Diesel;
            pCar.Location = new Point(11, 109);
            pCar.Margin = new Padding(3, 4, 3, 4);
            pCar.Name = "pCar";
            pCar.Size = new Size(375, 275);
            pCar.SizeMode = PictureBoxSizeMode.Zoom;
            pCar.TabIndex = 103;
            pCar.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 475);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 102;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 515);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 101;
            label4.Text = "Daily Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 338);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 100;
            label3.Text = "Year:";
            // 
            // btnBrowse
            // 
            btnBrowse.Enabled = false;
            btnBrowse.Location = new Point(294, 389);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(86, 31);
            btnBrowse.TabIndex = 105;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DodgerBlue;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(294, 555);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(138, 31);
            btnReturn.TabIndex = 104;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblcarDesc_m
            // 
            lblcarDesc_m.AutoSize = true;
            lblcarDesc_m.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarDesc_m.ForeColor = Color.DodgerBlue;
            lblcarDesc_m.Location = new Point(125, 72);
            lblcarDesc_m.Name = "lblcarDesc_m";
            lblcarDesc_m.Size = new Size(161, 31);
            lblcarDesc_m.TabIndex = 99;
            lblcarDesc_m.Text = "Toyota Camry";
            lblcarDesc_m.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CarReturnAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 592);
            ControlBox = false;
            Controls.Add(lblCarID);
            Controls.Add(label2);
            Controls.Add(cboType);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(numericUpDownYear);
            Controls.Add(cboModel);
            Controls.Add(cboChildSeat);
            Controls.Add(label9);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(txtCapacity);
            Controls.Add(cboMaker);
            Controls.Add(label10);
            Controls.Add(cboCategory);
            Controls.Add(txtRegNumber);
            Controls.Add(cboColor);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(cboInsurance);
            Controls.Add(label11);
            Controls.Add(cboStatus);
            Controls.Add(txtDailyRate);
            Controls.Add(txtFileName);
            Controls.Add(pCar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBrowse);
            Controls.Add(btnReturn);
            Controls.Add(lblcarDesc_m);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarReturnAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car [RETURN]";
            Load += CarReturnAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pGoBackIcon;
        private Label lblCarID;
        private Label label2;
        private ComboBox cboType;
        private Label label7;
        private Label label1;
        private Panel panel1;
        private Label lblAdminPanel;
        private NumericUpDown numericUpDownYear;
        private ComboBox cboModel;
        private ComboBox cboChildSeat;
        private Label label9;
        private Label label13;
        private Label label6;
        private TextBox txtCapacity;
        private ComboBox cboMaker;
        private Label label10;
        private ComboBox cboCategory;
        private TextBox txtRegNumber;
        private ComboBox cboColor;
        private Label label12;
        private Label label8;
        private ComboBox cboInsurance;
        private Label label11;
        private ComboBox cboStatus;
        private TextBox txtDailyRate;
        private TextBox txtFileName;
        private PictureBox pCar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnBrowse;
        private Button btnReturn;
        private Label lblcarDesc_m;
    }
}