namespace ProjRentalHub
{
    partial class CustomerAdd
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
            btnClear = new Button();
            lblAdminPanel = new Label();
            panel1 = new Panel();
            pGoBackIcon = new PictureBox();
            btnAdd = new Button();
            txtPostalCode = new TextBox();
            label1 = new Label();
            mtxtPhoneNumber = new MaskedTextBox();
            mtxtLicenseNumber = new MaskedTextBox();
            rtxtAddress = new RichTextBox();
            label2 = new Label();
            customerPhone = new Label();
            customerAddress = new Label();
            txtPassword = new TextBox();
            customerPassword = new Label();
            txtUsername = new TextBox();
            customerUsername = new Label();
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
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(322, 355);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 41);
            btnClear.TabIndex = 46;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(197, 354);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 41);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Location = new Point(404, 243);
            txtPostalCode.Margin = new Padding(3, 4, 3, 4);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(210, 27);
            txtPostalCode.TabIndex = 64;
            txtPostalCode.Validating += txtPostalCode_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 249);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 63;
            label1.Text = "Postal Code:";
            // 
            // mtxtPhoneNumber
            // 
            mtxtPhoneNumber.Location = new Point(96, 193);
            mtxtPhoneNumber.Mask = "(999) 000-0000";
            mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            mtxtPhoneNumber.Size = new Size(209, 27);
            mtxtPhoneNumber.TabIndex = 62;
            // 
            // mtxtLicenseNumber
            // 
            mtxtLicenseNumber.Location = new Point(96, 242);
            mtxtLicenseNumber.Mask = "000000-000";
            mtxtLicenseNumber.Name = "mtxtLicenseNumber";
            mtxtLicenseNumber.Size = new Size(209, 27);
            mtxtLicenseNumber.TabIndex = 61;
            mtxtLicenseNumber.KeyPress += mtxtLicenseNumber_KeyPress;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(404, 142);
            rtxtAddress.Margin = new Padding(3, 4, 3, 4);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(210, 84);
            rtxtAddress.TabIndex = 53;
            rtxtAddress.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 245);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 60;
            label2.Text = "License No:";
            // 
            // customerPhone
            // 
            customerPhone.AutoSize = true;
            customerPhone.Location = new Point(36, 200);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(53, 20);
            customerPhone.TabIndex = 59;
            customerPhone.Text = "Phone:";
            // 
            // customerAddress
            // 
            customerAddress.AutoSize = true;
            customerAddress.Location = new Point(333, 145);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(65, 20);
            customerAddress.TabIndex = 58;
            customerAddress.Text = "Address:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(404, 290);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 56;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // customerPassword
            // 
            customerPassword.AutoSize = true;
            customerPassword.Location = new Point(332, 295);
            customerPassword.Name = "customerPassword";
            customerPassword.Size = new Size(73, 20);
            customerPassword.TabIndex = 57;
            customerPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(96, 292);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(209, 27);
            txtUsername.TabIndex = 54;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // customerUsername
            // 
            customerUsername.AutoSize = true;
            customerUsername.Location = new Point(13, 294);
            customerUsername.Name = "customerUsername";
            customerUsername.Size = new Size(78, 20);
            customerUsername.TabIndex = 55;
            customerUsername.Text = "Username:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(96, 146);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 27);
            txtEmail.TabIndex = 51;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.Location = new Point(40, 148);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(49, 20);
            emailAddress.TabIndex = 52;
            emailAddress.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(404, 94);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 27);
            txtLastName.TabIndex = 49;
            txtLastName.KeyPress += txtLastName_KeyPress;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // registrationLastName
            // 
            registrationLastName.AutoSize = true;
            registrationLastName.Location = new Point(323, 99);
            registrationLastName.Name = "registrationLastName";
            registrationLastName.Size = new Size(75, 20);
            registrationLastName.TabIndex = 50;
            registrationLastName.Text = "Lastname:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(96, 94);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 27);
            txtFirstName.TabIndex = 47;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // registrationFirstName
            // 
            registrationFirstName.AutoSize = true;
            registrationFirstName.Location = new Point(15, 99);
            registrationFirstName.Name = "registrationFirstName";
            registrationFirstName.Size = new Size(76, 20);
            registrationFirstName.TabIndex = 48;
            registrationFirstName.Text = "Firstname:";
            // 
            // CustomerAdd
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
            Controls.Add(txtPassword);
            Controls.Add(customerPassword);
            Controls.Add(txtUsername);
            Controls.Add(customerUsername);
            Controls.Add(txtEmail);
            Controls.Add(emailAddress);
            Controls.Add(txtLastName);
            Controls.Add(registrationLastName);
            Controls.Add(txtFirstName);
            Controls.Add(registrationFirstName);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer [ADD]";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label lblAdminPanel;
        private Panel panel1;
        private PictureBox pGoBackIcon;
        private Button btnAdd;
        private TextBox txtPostalCode;
        private Label label1;
        private MaskedTextBox mtxtPhoneNumber;
        private MaskedTextBox mtxtLicenseNumber;
        private RichTextBox rtxtAddress;
        private Label label2;
        private Label customerPhone;
        private Label customerAddress;
        private TextBox txtPassword;
        private Label customerPassword;
        private TextBox txtUsername;
        private Label customerUsername;
        private TextBox txtEmail;
        private Label emailAddress;
        private TextBox txtLastName;
        private Label registrationLastName;
        private TextBox txtFirstName;
        private Label registrationFirstName;
    }
}