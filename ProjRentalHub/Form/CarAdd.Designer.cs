namespace ProjRentalHub
{
    partial class CarAdd
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
            panel1 = new Panel();
            lblAdminPanel = new Label();
            numericUpDownYear = new NumericUpDown();
            cboChildSeat = new ComboBox();
            label13 = new Label();
            label10 = new Label();
            txtRegNumber = new TextBox();
            label12 = new Label();
            cboInsurance = new ComboBox();
            label11 = new Label();
            cboColor = new ComboBox();
            label9 = new Label();
            cboMaker = new ComboBox();
            label8 = new Label();
            cboCategory = new ComboBox();
            label6 = new Label();
            cboStatus = new ComboBox();
            cboModel = new ComboBox();
            label1 = new Label();
            txtFileName = new TextBox();
            btnBrowse = new Button();
            btnAdd = new Button();
            pCar = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboDescription = new ComboBox();
            cboType = new ComboBox();
            label7 = new Label();
            btnClear = new Button();
            numericUpDownCapacity = new NumericUpDown();
            txtDailyRate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
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
            panel1.TabIndex = 81;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(72, 10);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(227, 38);
            lblAdminPanel.TabIndex = 52;
            lblAdminPanel.Text = "Car Registration";
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownYear.Location = new Point(487, 305);
            numericUpDownYear.Margin = new Padding(3, 4, 3, 4);
            numericUpDownYear.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(222, 30);
            numericUpDownYear.TabIndex = 80;
            numericUpDownYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // cboChildSeat
            // 
            cboChildSeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChildSeat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboChildSeat.FormattingEnabled = true;
            cboChildSeat.Items.AddRange(new object[] { "Yes", "No" });
            cboChildSeat.Location = new Point(487, 484);
            cboChildSeat.Margin = new Padding(3, 4, 3, 4);
            cboChildSeat.Name = "cboChildSeat";
            cboChildSeat.Size = new Size(223, 31);
            cboChildSeat.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(410, 484);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 78;
            label13.Text = "Child Seat:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(420, 404);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 76;
            label10.Text = "Capacity:";
            // 
            // txtRegNumber
            // 
            txtRegNumber.BorderStyle = BorderStyle.FixedSingle;
            txtRegNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtRegNumber.Location = new Point(142, 442);
            txtRegNumber.Margin = new Padding(3, 4, 3, 4);
            txtRegNumber.Name = "txtRegNumber";
            txtRegNumber.Size = new Size(240, 30);
            txtRegNumber.TabIndex = 75;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 446);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 74;
            label12.Text = "Registration Plate:";
            // 
            // cboInsurance
            // 
            cboInsurance.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInsurance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboInsurance.FormattingEnabled = true;
            cboInsurance.Items.AddRange(new object[] { "Classic", "Collision", "Comprehensive", "Custom", "Emergency", "Gap", "Guaranteed", "Lease", "Liability", "Medical", "No-fault", "Pay-per-mile", "Personal", "Rental", "Roadside", "Telematics", "Travel", "Underinsured", "Uninsured" });
            cboInsurance.Location = new Point(142, 396);
            cboInsurance.Margin = new Padding(3, 4, 3, 4);
            cboInsurance.Name = "cboInsurance";
            cboInsurance.Size = new Size(240, 31);
            cboInsurance.TabIndex = 73;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 402);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 72;
            label11.Text = "Insurance:";
            // 
            // cboColor
            // 
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboColor.FormattingEnabled = true;
            cboColor.Items.AddRange(new object[] { "Beige", "Black", "Blue", "Brown", "Charcoal", "Gold", "Gray", "Green", "Lime", "Maroon", "Orange", "Pink", "Purple", "Red", "Silver", "Tan", "Teal", "Turquoise", "Violet", "White", "Yellow" });
            cboColor.Location = new Point(486, 259);
            cboColor.Margin = new Padding(3, 4, 3, 4);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(223, 31);
            cboColor.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(440, 264);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 70;
            label9.Text = "Color:";
            // 
            // cboMaker
            // 
            cboMaker.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaker.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboMaker.FormattingEnabled = true;
            cboMaker.Items.AddRange(new object[] { "Audi", "BMW", "Chevrolet", "Ferrari", "Ford", "Honda", "Hyundai", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Mazda", "Mercedes", "Mercedes-Benz", "Mitsubishi", "Nissan", "Porsche", "Skoda", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            cboMaker.Location = new Point(487, 174);
            cboMaker.Margin = new Padding(3, 4, 3, 4);
            cboMaker.Name = "cboMaker";
            cboMaker.Size = new Size(224, 31);
            cboMaker.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(436, 179);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 68;
            label8.Text = "Maker:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Classic", "Compact", "Convertible", "Coupe", "Crossover", "Diesel", "Electric", "Hatchback", "Hybrid", "Luxury", "Mini-Van", "Muscle", "Off-road", "Racing", "Sedan", "Sports", "SUV", "Truck", "Van", "Wagon" });
            cboCategory.Location = new Point(486, 128);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(224, 31);
            cboCategory.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 133);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 66;
            label6.Text = "Category:";
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Rented" });
            cboStatus.Location = new Point(487, 441);
            cboStatus.Margin = new Padding(3, 4, 3, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(223, 31);
            cboStatus.TabIndex = 65;
            cboStatus.Text = "Available";
            // 
            // cboModel
            // 
            cboModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboModel.FormattingEnabled = true;
            cboModel.Items.AddRange(new object[] { "3 Series", "5 Series", "A5", "Accord", "Altima", "Camry", "C-Class", "Civic", "Corolla", "CR-V", "E-Class", "Elantra", "Explorer", "Focus", "Forester", "GLC", "Golf", "i20", "Impala", "Impreza", "Jetta", "Leaf", "Malibu", "Model 3", "Model Y", "Mustang", "MX-5", "Octavia", "Outback", "Passat", "Prius", "R8", "RAV4", "Rogue", "Santa ...", "Sentra", "Sonata", "Sporta...", "Tahoe", "Transp...", "X5", "XF", "Z4" });
            cboModel.Location = new Point(486, 220);
            cboModel.Margin = new Padding(3, 4, 3, 4);
            cboModel.Name = "cboModel";
            cboModel.Size = new Size(224, 31);
            cboModel.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 225);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 62;
            label1.Text = "Model:";
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFileName.Location = new Point(13, 358);
            txtFileName.Margin = new Padding(3, 4, 3, 4);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(280, 30);
            txtFileName.TabIndex = 61;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(299, 357);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(86, 31);
            btnBrowse.TabIndex = 59;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(234, 548);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 31);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pCar
            // 
            pCar.Image = Properties.Resources.Renault_Clio_Diesel;
            pCar.Location = new Point(12, 75);
            pCar.Margin = new Padding(3, 4, 3, 4);
            pCar.Name = "pCar";
            pCar.Size = new Size(375, 275);
            pCar.SizeMode = PictureBoxSizeMode.StretchImage;
            pCar.TabIndex = 57;
            pCar.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 446);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 56;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 490);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 55;
            label4.Text = "Daily Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 309);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 54;
            label3.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 91);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 82;
            label2.Text = "Description:";
            // 
            // cboDescription
            // 
            cboDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboDescription.FormattingEnabled = true;
            cboDescription.Items.AddRange(new object[] { "Audi A5", "Audi R8", "BMW X5", "BMW Z4", "Ford Focus", "Honda CR-V", "Hyundai i20", "Jaguar XF", "Kia Sportage", "Mazda MX-5 Hybrid", "Mercedes C-Class", "Mercedes GLC", "Nissan Leaf", "Skoda Octavia", "Tesla Model 3", "Tesla Model Y", "Toyota Camry", "Toyota RAV4", "Volkswagen Transporter" });
            cboDescription.Location = new Point(486, 86);
            cboDescription.Name = "cboDescription";
            cboDescription.Size = new Size(224, 31);
            cboDescription.TabIndex = 83;
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Diesel", "Electric", "Hybrid", "Petrol" });
            cboType.Location = new Point(487, 353);
            cboType.Margin = new Padding(3, 4, 3, 4);
            cboType.Name = "cboType";
            cboType.Size = new Size(223, 31);
            cboType.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 358);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 84;
            label7.Text = "Type:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(384, 548);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 31);
            btnClear.TabIndex = 86;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // numericUpDownCapacity
            // 
            numericUpDownCapacity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownCapacity.Location = new Point(488, 400);
            numericUpDownCapacity.Margin = new Padding(3, 4, 3, 4);
            numericUpDownCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCapacity.Name = "numericUpDownCapacity";
            numericUpDownCapacity.Size = new Size(222, 30);
            numericUpDownCapacity.TabIndex = 87;
            numericUpDownCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDailyRate
            // 
            txtDailyRate.BorderStyle = BorderStyle.FixedSingle;
            txtDailyRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDailyRate.Location = new Point(142, 486);
            txtDailyRate.Margin = new Padding(3, 4, 3, 4);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(240, 30);
            txtDailyRate.TabIndex = 88;
            txtDailyRate.KeyPress += txtDailyRate_KeyPress;
            // 
            // CarAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 592);
            ControlBox = false;
            Controls.Add(txtDailyRate);
            Controls.Add(numericUpDownCapacity);
            Controls.Add(btnClear);
            Controls.Add(cboType);
            Controls.Add(label7);
            Controls.Add(cboDescription);
            Controls.Add(label2);
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
            Controls.Add(cboModel);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Controls.Add(btnBrowse);
            Controls.Add(btnAdd);
            Controls.Add(pCar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car [ADD]";
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pGoBackIcon;
        private Panel panel1;
        private Label lblAdminPanel;
        private NumericUpDown numericUpDownYear;
        private ComboBox cboChildSeat;
        private Label label13;
        private Label label10;
        private TextBox txtRegNumber;
        private Label label12;
        private ComboBox cboInsurance;
        private Label label11;
        private ComboBox cboColor;
        private Label label9;
        private ComboBox cboMaker;
        private Label label8;
        private ComboBox cboCategory;
        private Label label6;
        private ComboBox cboStatus;
        private ComboBox cboModel;
        private Label label1;
        private TextBox txtFileName;
        private Button btnBrowse;
        private Button btnAdd;
        private PictureBox pCar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboDescription;
        private ComboBox cboType;
        private Label label7;
        private Button btnClear;
        private NumericUpDown numericUpDownCapacity;
        private TextBox txtDailyRate;
    }
}