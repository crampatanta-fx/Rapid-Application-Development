namespace ProjRentalHub
{
    partial class CarEdit
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
            lblcarID_m = new Label();
            btnBrowse = new Button();
            btnSave = new Button();
            pCar = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblcarDesc_m = new Label();
            txtFileName = new TextBox();
            label1 = new Label();
            cboModel = new ComboBox();
            txtDailyRate = new TextBox();
            cboStatus = new ComboBox();
            label6 = new Label();
            cboCategory = new ComboBox();
            cboMaker = new ComboBox();
            label8 = new Label();
            cboColor = new ComboBox();
            label9 = new Label();
            cboInsurance = new ComboBox();
            label11 = new Label();
            txtRegNumber = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label13 = new Label();
            cboChildSeat = new ComboBox();
            numericUpDownYear = new NumericUpDown();
            panel1 = new Panel();
            lblAdminPanel = new Label();
            pGoBackIcon = new PictureBox();
            cboType = new ComboBox();
            label7 = new Label();
            cboCarDesc = new ComboBox();
            label14 = new Label();
            numericUpDownCapacity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
            SuspendLayout();
            // 
            // lblcarID_m
            // 
            lblcarID_m.AutoSize = true;
            lblcarID_m.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarID_m.ForeColor = Color.Red;
            lblcarID_m.Location = new Point(479, 90);
            lblcarID_m.Name = "lblcarID_m";
            lblcarID_m.Size = new Size(111, 28);
            lblcarID_m.TabIndex = 23;
            lblcarID_m.Text = "CAR00002";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(302, 382);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(86, 31);
            btnBrowse.TabIndex = 22;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(300, 548);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 31);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pCar
            // 
            pCar.Image = Properties.Resources.Renault_Clio_Diesel;
            pCar.Location = new Point(12, 101);
            pCar.Margin = new Padding(3, 4, 3, 4);
            pCar.Name = "pCar";
            pCar.Size = new Size(375, 275);
            pCar.SizeMode = PictureBoxSizeMode.Zoom;
            pCar.TabIndex = 20;
            pCar.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 473);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 18;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 511);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 17;
            label4.Text = "Daily Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 342);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 16;
            label3.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 97);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 15;
            label2.Text = "Car ID:";
            // 
            // lblcarDesc_m
            // 
            lblcarDesc_m.AutoSize = true;
            lblcarDesc_m.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarDesc_m.ForeColor = Color.DodgerBlue;
            lblcarDesc_m.Location = new Point(119, 63);
            lblcarDesc_m.Name = "lblcarDesc_m";
            lblcarDesc_m.Size = new Size(161, 31);
            lblcarDesc_m.TabIndex = 14;
            lblcarDesc_m.Text = "Toyota Camry";
            lblcarDesc_m.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFileName.Location = new Point(12, 384);
            txtFileName.Margin = new Padding(3, 4, 3, 4);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(284, 30);
            txtFileName.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 256);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 29;
            label1.Text = "Model:";
            // 
            // cboModel
            // 
            cboModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboModel.FormattingEnabled = true;
            cboModel.Items.AddRange(new object[] { "3 Series", "5 Series", "A5", "Accord", "Altima", "Camry", "C-Class", "Civic", "Corolla", "CR-V", "E-Class", "Elantra", "Explorer", "Focus", "Forester", "GLC", "Golf", "i20", "Impala", "Impreza", "Jetta", "Leaf", "Malibu", "Model 3", "Model Y", "Mustang", "MX-5", "Octavia", "Outback", "Passat", "Prius", "R8", "RAV4", "Rogue", "Santa ...", "Sentra", "Sonata", "Sporta...", "Tahoe", "Transp...", "X5", "XF", "Z4" });
            cboModel.Location = new Point(481, 250);
            cboModel.Margin = new Padding(3, 4, 3, 4);
            cboModel.Name = "cboModel";
            cboModel.Size = new Size(229, 31);
            cboModel.TabIndex = 30;
            // 
            // txtDailyRate
            // 
            txtDailyRate.BorderStyle = BorderStyle.FixedSingle;
            txtDailyRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDailyRate.Location = new Point(157, 509);
            txtDailyRate.Margin = new Padding(3, 4, 3, 4);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(230, 30);
            txtDailyRate.TabIndex = 32;
            txtDailyRate.KeyPress += txtDailyRate_KeyPress;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Rented" });
            cboStatus.Location = new Point(482, 465);
            cboStatus.Margin = new Padding(3, 4, 3, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(228, 31);
            cboStatus.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 172);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 34;
            label6.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Classic", "Compact", "Convertible", "Coupe", "Crossover", "Diesel", "Electric", "Hatchback", "Hybrid", "Luxury", "Mini-Van", "Muscle", "Off-road", "Racing", "Sedan", "Sports", "SUV", "Truck", "Van", "Wagon" });
            cboCategory.Location = new Point(482, 169);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(229, 31);
            cboCategory.TabIndex = 35;
            // 
            // cboMaker
            // 
            cboMaker.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboMaker.FormattingEnabled = true;
            cboMaker.Items.AddRange(new object[] { "Audi", "BMW", "Chevrolet", "Ferrari", "Ford", "Honda", "Hyundai", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Mazda", "Mercedes", "Mercedes-Benz", "Mitsubishi", "Nissan", "Porsche", "Skoda", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            cboMaker.Location = new Point(482, 208);
            cboMaker.Margin = new Padding(3, 4, 3, 4);
            cboMaker.Name = "cboMaker";
            cboMaker.Size = new Size(229, 31);
            cboMaker.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(429, 212);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 38;
            label8.Text = "Maker:";
            // 
            // cboColor
            // 
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboColor.FormattingEnabled = true;
            cboColor.Items.AddRange(new object[] { "Beige", "Black", "Blue", "Brown", "Charcoal", "Gold", "Gray", "Green", "Lime", "Maroon", "Orange", "Pink", "Purple", "Red", "Silver", "Tan", "Teal", "Turquoise", "Violet", "White", "Yellow" });
            cboColor.Location = new Point(481, 293);
            cboColor.Margin = new Padding(3, 4, 3, 4);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(229, 31);
            cboColor.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(436, 296);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 40;
            label9.Text = "Color:";
            // 
            // cboInsurance
            // 
            cboInsurance.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInsurance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboInsurance.FormattingEnabled = true;
            cboInsurance.Items.AddRange(new object[] { "Classic", "Collision", "Comprehensive", "Custom", "Emergency", "Gap", "Guaranteed", "Lease", "Liability", "Medical", "No-fault", "Pay-per-mile", "Personal", "Rental", "Roadside", "Telematics", "Travel", "Underinsured", "Uninsured" });
            cboInsurance.Location = new Point(157, 425);
            cboInsurance.Margin = new Padding(3, 4, 3, 4);
            cboInsurance.Name = "cboInsurance";
            cboInsurance.Size = new Size(230, 31);
            cboInsurance.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 428);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 42;
            label11.Text = "Insurance:";
            // 
            // txtRegNumber
            // 
            txtRegNumber.BorderStyle = BorderStyle.FixedSingle;
            txtRegNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtRegNumber.Location = new Point(157, 468);
            txtRegNumber.Margin = new Padding(3, 4, 3, 4);
            txtRegNumber.Name = "txtRegNumber";
            txtRegNumber.Size = new Size(230, 30);
            txtRegNumber.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 470);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 44;
            label12.Text = "Registration Plate:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(412, 429);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 46;
            label10.Text = "Capacity:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(402, 508);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 48;
            label13.Text = "Child Seat:";
            // 
            // cboChildSeat
            // 
            cboChildSeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChildSeat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboChildSeat.FormattingEnabled = true;
            cboChildSeat.Items.AddRange(new object[] { "Yes", "No" });
            cboChildSeat.Location = new Point(481, 506);
            cboChildSeat.Margin = new Padding(3, 4, 3, 4);
            cboChildSeat.Name = "cboChildSeat";
            cboChildSeat.Size = new Size(229, 31);
            cboChildSeat.TabIndex = 49;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownYear.Location = new Point(484, 335);
            numericUpDownYear.Margin = new Padding(3, 4, 3, 4);
            numericUpDownYear.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(226, 30);
            numericUpDownYear.TabIndex = 50;
            numericUpDownYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
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
            panel1.TabIndex = 51;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(72, 11);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(243, 38);
            lblAdminPanel.TabIndex = 52;
            lblAdminPanel.Text = "Car Management";
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
            // cboType
            // 
            cboType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Diesel", "Electric", "Hybrid", "Petrol" });
            cboType.Location = new Point(483, 379);
            cboType.Margin = new Padding(3, 4, 3, 4);
            cboType.Name = "cboType";
            cboType.Size = new Size(227, 31);
            cboType.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(439, 382);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 52;
            label7.Text = "Type:";
            // 
            // cboCarDesc
            // 
            cboCarDesc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboCarDesc.FormattingEnabled = true;
            cboCarDesc.Items.AddRange(new object[] { "Audi A5", "Audi R8", "BMW X5", "BMW Z4", "BMW Z4", "Ford Focus", "Honda CR-V", "Hyundai i20", "Jaguar XF", "Kia Sportage", "Kia Sportage", "Mazda MX-5 Hybrid", "Mercedes C-Class", "Mercedes GLC", "Nissan Leaf", "Skoda Octavia", "Tesla Model 3", "Tesla Model Y", "Toyota Camry", "Toyota RAV4", "Volkswagen Transporter" });
            cboCarDesc.Location = new Point(482, 127);
            cboCarDesc.Margin = new Padding(3, 4, 3, 4);
            cboCarDesc.Name = "cboCarDesc";
            cboCarDesc.Size = new Size(229, 31);
            cboCarDesc.TabIndex = 55;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(394, 132);
            label14.Name = "label14";
            label14.Size = new Size(88, 20);
            label14.TabIndex = 54;
            label14.Text = "Description:";
            // 
            // numericUpDownCapacity
            // 
            numericUpDownCapacity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownCapacity.Location = new Point(483, 424);
            numericUpDownCapacity.Margin = new Padding(3, 4, 3, 4);
            numericUpDownCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCapacity.Name = "numericUpDownCapacity";
            numericUpDownCapacity.Size = new Size(227, 30);
            numericUpDownCapacity.TabIndex = 56;
            numericUpDownCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CarEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 592);
            ControlBox = false;
            Controls.Add(numericUpDownCapacity);
            Controls.Add(cboCarDesc);
            Controls.Add(label14);
            Controls.Add(cboType);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(numericUpDownYear);
            Controls.Add(cboChildSeat);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(txtRegNumber);
            Controls.Add(label12);
            Controls.Add(cboInsurance);
            Controls.Add(label11);
            Controls.Add(cboColor);
            Controls.Add(label9);
            Controls.Add(cboMaker);
            Controls.Add(label8);
            Controls.Add(cboCategory);
            Controls.Add(label6);
            Controls.Add(cboStatus);
            Controls.Add(txtDailyRate);
            Controls.Add(cboModel);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Controls.Add(lblcarID_m);
            Controls.Add(btnBrowse);
            Controls.Add(btnSave);
            Controls.Add(pCar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblcarDesc_m);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car [EDIT]";
            Load += ModifyCar_Load;
            ((System.ComponentModel.ISupportInitialize)pCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblcarID_m;
        private Button btnBrowse;
        private Button btnSave;
        private PictureBox pCar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblcarDesc_m;
        private TextBox txtFileName;
        private Label label1;
        private ComboBox cboModel;
        private TextBox txtDailyRate;
        private ComboBox cboStatus;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox cboCategory;
        private ComboBox cboMaker;
        private Label label8;
        private ComboBox cboColor;
        private Label label9;
        private ComboBox cboInsurance;
        private ComboBox comboBox6;
        private Label label11;
        private TextBox txtRegNumber;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox5;
        private Label label10;
        private Label label13;
        private ComboBox cboChildSeat;
        private NumericUpDown numericUpDownYear;
        private Panel panel1;
        private PictureBox pGoBackIcon;
        private Label lblAdminPanel;
        private ComboBox cboType;
        private Label label7;
        private ComboBox cboCarDesc;
        private Label label14;
        private NumericUpDown numericUpDownCapacity;
    }
}