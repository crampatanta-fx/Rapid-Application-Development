namespace ProjRentalHub
{
    partial class CustomerMyProfile
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
            btnSave = new Button();
            lblAdminPanel = new Label();
            panel1 = new Panel();
            pGoBackIcon = new PictureBox();
            txtPassword = new TextBox();
            customerPassword = new Label();
            txtUserName = new TextBox();
            customerUsername = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(255, 356);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 41);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(78, 16);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(154, 38);
            lblAdminPanel.TabIndex = 28;
            lblAdminPanel.Text = "My Profile";
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
            panel1.TabIndex = 45;
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
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(401, 292);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 30);
            txtPassword.TabIndex = 39;
            // 
            // customerPassword
            // 
            customerPassword.AutoSize = true;
            customerPassword.Location = new Point(329, 297);
            customerPassword.Name = "customerPassword";
            customerPassword.Size = new Size(73, 20);
            customerPassword.TabIndex = 41;
            customerPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Enabled = false;
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(93, 291);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 30);
            txtUserName.TabIndex = 37;
            // 
            // customerUsername
            // 
            customerUsername.AutoSize = true;
            customerUsername.Location = new Point(10, 296);
            customerUsername.Name = "customerUsername";
            customerUsername.Size = new Size(78, 20);
            customerUsername.TabIndex = 38;
            customerUsername.Text = "Username:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPostalCode.Location = new Point(401, 244);
            txtPostalCode.Margin = new Padding(3, 4, 3, 4);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(210, 30);
            txtPostalCode.TabIndex = 60;
            txtPostalCode.Validating += txtPostalCode_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 250);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 59;
            label1.Text = "Postal Code:";
            // 
            // mtxtPhoneNumber
            // 
            mtxtPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtPhoneNumber.Location = new Point(93, 194);
            mtxtPhoneNumber.Mask = "(999) 000-0000";
            mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            mtxtPhoneNumber.Size = new Size(209, 30);
            mtxtPhoneNumber.TabIndex = 58;
            // 
            // mtxtLicenseNumber
            // 
            mtxtLicenseNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtLicenseNumber.Location = new Point(93, 243);
            mtxtLicenseNumber.Mask = "000000-000";
            mtxtLicenseNumber.Name = "mtxtLicenseNumber";
            mtxtLicenseNumber.Size = new Size(209, 30);
            mtxtLicenseNumber.TabIndex = 57;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtAddress.Location = new Point(401, 143);
            rtxtAddress.Margin = new Padding(3, 4, 3, 4);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(210, 84);
            rtxtAddress.TabIndex = 52;
            rtxtAddress.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 246);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 56;
            label2.Text = "License No:";
            // 
            // customerPhone
            // 
            customerPhone.AutoSize = true;
            customerPhone.Location = new Point(33, 201);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(53, 20);
            customerPhone.TabIndex = 55;
            customerPhone.Text = "Phone:";
            // 
            // customerAddress
            // 
            customerAddress.AutoSize = true;
            customerAddress.Location = new Point(330, 146);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(65, 20);
            customerAddress.TabIndex = 54;
            customerAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(93, 147);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 30);
            txtEmail.TabIndex = 50;
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.Location = new Point(37, 149);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(49, 20);
            emailAddress.TabIndex = 53;
            emailAddress.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(401, 95);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 30);
            txtLastName.TabIndex = 48;
            // 
            // registrationLastName
            // 
            registrationLastName.AutoSize = true;
            registrationLastName.Location = new Point(320, 100);
            registrationLastName.Name = "registrationLastName";
            registrationLastName.Size = new Size(75, 20);
            registrationLastName.TabIndex = 51;
            registrationLastName.Text = "Lastname:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(93, 95);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 30);
            txtFirstName.TabIndex = 47;
            // 
            // registrationFirstName
            // 
            registrationFirstName.AutoSize = true;
            registrationFirstName.Location = new Point(12, 100);
            registrationFirstName.Name = "registrationFirstName";
            registrationFirstName.Size = new Size(76, 20);
            registrationFirstName.TabIndex = 49;
            registrationFirstName.Text = "Firstname:";
            // 
            // CustomerMyProfile
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
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(customerPassword);
            Controls.Add(txtUserName);
            Controls.Add(customerUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerMyProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile [EDIT]";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblAdminPanel;
        private Panel panel1;
        private PictureBox pGoBackIcon;
        private TextBox txtPassword;
        private Label customerPassword;
        private TextBox txtUserName;
        private Label customerUsername;
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
    }
}