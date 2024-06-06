namespace ProjRentalHub
{
    partial class UC_CustomerBookings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBook = new Button();
            lblUserId = new Label();
            lblLastName = new Label();
            btnBookingHistory = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblfirstName = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNo = new TextBox();
            SuspendLayout();
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.DodgerBlue;
            btnBook.FlatStyle = FlatStyle.Popup;
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(40, 243);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(144, 31);
            btnBook.TabIndex = 25;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserId.ForeColor = Color.DodgerBlue;
            lblUserId.Location = new Point(8, 12);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(73, 28);
            lblUserId.TabIndex = 24;
            lblUserId.Text = "userID";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.DodgerBlue;
            lblLastName.Location = new Point(222, 210);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(102, 28);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Lastname";
            lblLastName.Visible = false;
            // 
            // btnBookingHistory
            // 
            btnBookingHistory.BackColor = Color.DodgerBlue;
            btnBookingHistory.FlatStyle = FlatStyle.Popup;
            btnBookingHistory.ForeColor = Color.White;
            btnBookingHistory.Location = new Point(199, 243);
            btnBookingHistory.Margin = new Padding(3, 4, 3, 4);
            btnBookingHistory.Name = "btnBookingHistory";
            btnBookingHistory.Size = new Size(144, 31);
            btnBookingHistory.TabIndex = 19;
            btnBookingHistory.Text = "Booking History";
            btnBookingHistory.UseVisualStyleBackColor = false;
            btnBookingHistory.Click += btnBookingHistory_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 161);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 18;
            label6.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(11, 109);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 17;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(11, 63);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 16;
            label4.Text = "Name:";
            // 
            // lblfirstName
            // 
            lblfirstName.AutoSize = true;
            lblfirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblfirstName.ForeColor = Color.DodgerBlue;
            lblfirstName.Location = new Point(61, 210);
            lblfirstName.Name = "lblfirstName";
            lblfirstName.Size = new Size(105, 28);
            lblfirstName.TabIndex = 13;
            lblfirstName.Text = "Firstname";
            lblfirstName.Visible = false;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(74, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 30);
            txtName.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(74, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 30);
            txtEmail.TabIndex = 27;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Enabled = false;
            txtPhoneNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNo.Location = new Point(74, 161);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(290, 30);
            txtPhoneNo.TabIndex = 28;
            // 
            // UC_CustomerBookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtPhoneNo);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnBook);
            Controls.Add(lblUserId);
            Controls.Add(lblLastName);
            Controls.Add(btnBookingHistory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblfirstName);
            Name = "UC_CustomerBookings";
            Size = new Size(382, 298);
            Load += UC_CustomerBookings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBook;
        private Label lblUserId;
        private Label lblLastName;
        private Button btnBookingHistory;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblfirstName;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNo;
    }
}
