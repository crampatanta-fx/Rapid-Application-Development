namespace ProjRentalHub
{
    partial class CustomerSignup
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
        //private void customerSignupButton_Click(object sender, EventArgs e)
        //{

        //}
        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registrationFirstName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            registrationLastName = new Label();
            txtEmail = new TextBox();
            emailAddress = new Label();
            txtUsername = new TextBox();
            customerUsername = new Label();
            txtPassword = new TextBox();
            customerPassword = new Label();
            customerAddress = new Label();
            customerPhone = new Label();
            customerSignupButton = new Button();
            label2 = new Label();
            rtxtAddress = new RichTextBox();
            panel1 = new Panel();
            lblAdminPanel = new Label();
            pGoBackIcon = new PictureBox();
            btnClear = new Button();
            mtxtLicenseNumber = new MaskedTextBox();
            mtxtPhoneNumber = new MaskedTextBox();
            label1 = new Label();
            txtPostalCode = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            SuspendLayout();
            // 
            // registrationFirstName
            // 
            registrationFirstName.AutoSize = true;
            registrationFirstName.Location = new Point(10, 97);
            registrationFirstName.Name = "registrationFirstName";
            registrationFirstName.Size = new Size(76, 20);
            registrationFirstName.TabIndex = 1;
            registrationFirstName.Text = "Firstname:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(91, 92);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.KeyPress += txtfirstName_KeyPress;
            txtFirstName.Validating += txtfirstName_Validating;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(399, 92);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 27);
            txtLastName.TabIndex = 1;
            txtLastName.KeyPress += txtlastName_KeyPress;
            txtLastName.Validating += txtlastName_Validating;
            // 
            // registrationLastName
            // 
            registrationLastName.AutoSize = true;
            registrationLastName.Location = new Point(318, 97);
            registrationLastName.Name = "registrationLastName";
            registrationLastName.Size = new Size(75, 20);
            registrationLastName.TabIndex = 3;
            registrationLastName.Text = "Lastname:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(91, 144);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 27);
            txtEmail.TabIndex = 3;
            txtEmail.Validating += txtemail_Validating;
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.Location = new Point(35, 146);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(49, 20);
            emailAddress.TabIndex = 5;
            emailAddress.Text = "Email:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(91, 290);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(209, 27);
            txtUsername.TabIndex = 6;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // customerUsername
            // 
            customerUsername.AutoSize = true;
            customerUsername.Location = new Point(8, 292);
            customerUsername.Name = "customerUsername";
            customerUsername.Size = new Size(78, 20);
            customerUsername.TabIndex = 7;
            customerUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(399, 288);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 7;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // customerPassword
            // 
            customerPassword.AutoSize = true;
            customerPassword.Location = new Point(327, 293);
            customerPassword.Name = "customerPassword";
            customerPassword.Size = new Size(73, 20);
            customerPassword.TabIndex = 9;
            customerPassword.Text = "Password:";
            // 
            // customerAddress
            // 
            customerAddress.AutoSize = true;
            customerAddress.Location = new Point(328, 143);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(65, 20);
            customerAddress.TabIndex = 17;
            customerAddress.Text = "Address:";
            // 
            // customerPhone
            // 
            customerPhone.AutoSize = true;
            customerPhone.Location = new Point(31, 198);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(53, 20);
            customerPhone.TabIndex = 19;
            customerPhone.Text = "Phone:";
            // 
            // customerSignupButton
            // 
            customerSignupButton.BackColor = Color.DodgerBlue;
            customerSignupButton.FlatStyle = FlatStyle.Popup;
            customerSignupButton.ForeColor = Color.White;
            customerSignupButton.Location = new Point(198, 353);
            customerSignupButton.Margin = new Padding(3, 4, 3, 4);
            customerSignupButton.Name = "customerSignupButton";
            customerSignupButton.Size = new Size(113, 41);
            customerSignupButton.TabIndex = 8;
            customerSignupButton.Text = "Signup";
            customerSignupButton.UseVisualStyleBackColor = false;
            customerSignupButton.Click += customerSignupButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 243);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 24;
            label2.Text = "License No:";
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(399, 140);
            rtxtAddress.Margin = new Padding(3, 4, 3, 4);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(210, 84);
            rtxtAddress.TabIndex = 5;
            rtxtAddress.Text = "";
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
            panel1.TabIndex = 26;
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
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(323, 354);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 41);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // mtxtLicenseNumber
            // 
            mtxtLicenseNumber.Location = new Point(91, 240);
            mtxtLicenseNumber.Mask = "000000-000";
            mtxtLicenseNumber.Name = "mtxtLicenseNumber";
            mtxtLicenseNumber.Size = new Size(209, 27);
            mtxtLicenseNumber.TabIndex = 28;
            // 
            // mtxtPhoneNumber
            // 
            mtxtPhoneNumber.Location = new Point(91, 191);
            mtxtPhoneNumber.Mask = "(999) 000-0000";
            mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            mtxtPhoneNumber.Size = new Size(209, 27);
            mtxtPhoneNumber.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 247);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 30;
            label1.Text = "Postal Code:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Location = new Point(399, 241);
            txtPostalCode.Margin = new Padding(3, 4, 3, 4);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(210, 27);
            txtPostalCode.TabIndex = 31;
            txtPostalCode.Validating += txtPostalCode_Validating;
            // 
            // CustomerSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(632, 423);
            ControlBox = false;
            Controls.Add(txtPostalCode);
            Controls.Add(label1);
            Controls.Add(mtxtPhoneNumber);
            Controls.Add(mtxtLicenseNumber);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(rtxtAddress);
            Controls.Add(label2);
            Controls.Add(customerSignupButton);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer [SIGNUP]";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label registrationFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label registrationLastName;
        private TextBox txtEmail;
        private Label emailAddress;
        private TextBox txtUsername;
        private Label customerUsername;
        private TextBox txtPassword;
        private Label customerPassword;
        private Label customerAddress;
        private Label customerPhone;
        private Button customerSignupButton;
        private Label label2;
        private RichTextBox rtxtAddress;
        private Panel panel1;
        private Label lblAdminPanel;
        private PictureBox pGoBackIcon;
        private Button btnClear;
        private MaskedTextBox mtxtLicenseNumber;
        private MaskedTextBox mtxtPhoneNumber;
        private Label label1;
        private TextBox txtPostalCode;
    }
}