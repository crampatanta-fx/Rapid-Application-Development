namespace ProjRentalHub
{
    partial class CustomerEditAdmin
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
            txtPostalCode = new TextBox();
            label1 = new Label();
            mtxtPhoneNumber = new MaskedTextBox();
            mtxtLicenseNumber = new MaskedTextBox();
            rtxtAddress = new RichTextBox();
            label2 = new Label();
            customerPhone = new Label();
            customerAddress = new Label();
            txtEmail = new TextBox();
            emailAddress = new Label();
            txtLastName = new TextBox();
            registrationLastName = new Label();
            txtFirstName = new TextBox();
            registrationFirstName = new Label();
            txtPassword = new TextBox();
            customerPassword = new Label();
            txtUserName = new TextBox();
            pGoBackIcon = new PictureBox();
            panel1 = new Panel();
            lblAdminPanel = new Label();
            btnSave = new Button();
            customerUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPostalCode
            // 
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPostalCode.Location = new Point(401, 257);
            txtPostalCode.Margin = new Padding(3, 4, 3, 4);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(210, 30);
            txtPostalCode.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 263);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 79;
            label1.Text = "Postal Code:";
            // 
            // mtxtPhoneNumber
            // 
            mtxtPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtPhoneNumber.Location = new Point(93, 207);
            mtxtPhoneNumber.Mask = "(999) 000-0000";
            mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            mtxtPhoneNumber.Size = new Size(209, 30);
            mtxtPhoneNumber.TabIndex = 78;
            // 
            // mtxtLicenseNumber
            // 
            mtxtLicenseNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtLicenseNumber.Location = new Point(93, 256);
            mtxtLicenseNumber.Mask = "000000-000";
            mtxtLicenseNumber.Name = "mtxtLicenseNumber";
            mtxtLicenseNumber.Size = new Size(209, 30);
            mtxtLicenseNumber.TabIndex = 77;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtAddress.Location = new Point(401, 156);
            rtxtAddress.Margin = new Padding(3, 4, 3, 4);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(210, 84);
            rtxtAddress.TabIndex = 72;
            rtxtAddress.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 259);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 76;
            label2.Text = "License No:";
            // 
            // customerPhone
            // 
            customerPhone.AutoSize = true;
            customerPhone.Location = new Point(33, 214);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(53, 20);
            customerPhone.TabIndex = 75;
            customerPhone.Text = "Phone:";
            // 
            // customerAddress
            // 
            customerAddress.AutoSize = true;
            customerAddress.Location = new Point(330, 159);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(65, 20);
            customerAddress.TabIndex = 74;
            customerAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(93, 160);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 30);
            txtEmail.TabIndex = 70;
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.Location = new Point(37, 162);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(49, 20);
            emailAddress.TabIndex = 73;
            emailAddress.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(401, 108);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 30);
            txtLastName.TabIndex = 68;
            // 
            // registrationLastName
            // 
            registrationLastName.AutoSize = true;
            registrationLastName.Location = new Point(320, 113);
            registrationLastName.Name = "registrationLastName";
            registrationLastName.Size = new Size(75, 20);
            registrationLastName.TabIndex = 71;
            registrationLastName.Text = "Lastname:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(93, 108);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 30);
            txtFirstName.TabIndex = 67;
            // 
            // registrationFirstName
            // 
            registrationFirstName.AutoSize = true;
            registrationFirstName.Location = new Point(12, 113);
            registrationFirstName.Name = "registrationFirstName";
            registrationFirstName.Size = new Size(76, 20);
            registrationFirstName.TabIndex = 69;
            registrationFirstName.Text = "Firstname:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(401, 305);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 30);
            txtPassword.TabIndex = 63;
            // 
            // customerPassword
            // 
            customerPassword.AutoSize = true;
            customerPassword.Location = new Point(329, 310);
            customerPassword.Name = "customerPassword";
            customerPassword.Size = new Size(73, 20);
            customerPassword.TabIndex = 64;
            customerPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Enabled = false;
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(93, 304);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 30);
            txtUserName.TabIndex = 61;
            // 
            // pGoBackIcon
            // 
            pGoBackIcon.Image = Properties.Resources.back;
            pGoBackIcon.Location = new Point(9, 8);
            pGoBackIcon.Margin = new Padding(3, 4, 3, 4);
            pGoBackIcon.Name = "pGoBackIcon";
            pGoBackIcon.Size = new Size(61, 56);
            pGoBackIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pGoBackIcon.TabIndex = 26;
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
            panel1.Size = new Size(632, 68);
            panel1.TabIndex = 65;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(78, 16);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(143, 38);
            lblAdminPanel.TabIndex = 28;
            lblAdminPanel.Text = "Customer";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(255, 369);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 41);
            btnSave.TabIndex = 66;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // customerUsername
            // 
            customerUsername.AutoSize = true;
            customerUsername.Location = new Point(10, 309);
            customerUsername.Name = "customerUsername";
            customerUsername.Size = new Size(78, 20);
            customerUsername.TabIndex = 62;
            customerUsername.Text = "Username:";
            // 
            // CustomerEditAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 423);
            ControlBox = false;
            Controls.Add(txtPostalCode);
            Controls.Add(label1);
            Controls.Add(mtxtPhoneNumber);
            Controls.Add(mtxtLicenseNumber);
            Controls.Add(rtxtAddress);
            Controls.Add(label2);
            Controls.Add(customerPhone);
            Controls.Add(customerAddress);
            Controls.Add(txtEmail);
            Controls.Add(emailAddress);
            Controls.Add(txtLastName);
            Controls.Add(registrationLastName);
            Controls.Add(txtFirstName);
            Controls.Add(registrationFirstName);
            Controls.Add(txtPassword);
            Controls.Add(customerPassword);
            Controls.Add(txtUserName);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(customerUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerEditAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer [EDIT]";
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPostalCode;
        private Label label1;
        private MaskedTextBox mtxtPhoneNumber;
        private MaskedTextBox mtxtLicenseNumber;
        private RichTextBox rtxtAddress;
        private Label label2;
        private Label customerPhone;
        private Label customerAddress;
        private TextBox txtEmail;
        private Label emailAddress;
        private TextBox txtLastName;
        private Label registrationLastName;
        private TextBox txtFirstName;
        private Label registrationFirstName;
        private TextBox txtPassword;
        private Label customerPassword;
        private TextBox txtUserName;
        private PictureBox pGoBackIcon;
        private Panel panel1;
        private Label lblAdminPanel;
        private Button btnSave;
        private Label customerUsername;
    }
}