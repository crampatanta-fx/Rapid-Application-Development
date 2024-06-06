namespace ProjRentalHub
{
    partial class UC_CustomerEdit
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
            lblfirstName = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEdit = new Button();
            lblLastName = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNo = new TextBox();
            lblUserId = new Label();
            SuspendLayout();
            // 
            // lblfirstName
            // 
            lblfirstName.AutoSize = true;
            lblfirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblfirstName.ForeColor = Color.DodgerBlue;
            lblfirstName.Location = new Point(271, 195);
            lblfirstName.Name = "lblfirstName";
            lblfirstName.Size = new Size(105, 28);
            lblfirstName.TabIndex = 0;
            lblfirstName.Text = "Firstname";
            lblfirstName.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(7, 66);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 122);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 177);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 5;
            label6.Text = "Phone:";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(124, 242);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 31);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.DodgerBlue;
            lblLastName.Location = new Point(274, 223);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(102, 28);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Lastname";
            lblLastName.Visible = false;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = Color.DodgerBlue;
            txtName.Location = new Point(67, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 30);
            txtName.TabIndex = 13;
            txtName.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DodgerBlue;
            txtEmail.Location = new Point(67, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 30);
            txtEmail.TabIndex = 14;
            txtEmail.Text = "Email";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Enabled = false;
            txtPhoneNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNo.ForeColor = Color.DodgerBlue;
            txtPhoneNo.Location = new Point(67, 173);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(294, 30);
            txtPhoneNo.TabIndex = 15;
            txtPhoneNo.Text = "Phone No";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserId.ForeColor = Color.DodgerBlue;
            lblUserId.Location = new Point(6, 15);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(72, 28);
            lblUserId.TabIndex = 16;
            lblUserId.Text = "UserId";
            lblUserId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_CustomerEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblUserId);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblLastName);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblfirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_CustomerEdit";
            Size = new Size(383, 296);
            Load += UC_Users_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblfirstName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEdit;
        private Label lblLastName;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNo;
        private Label lblUserId;
    }
}
