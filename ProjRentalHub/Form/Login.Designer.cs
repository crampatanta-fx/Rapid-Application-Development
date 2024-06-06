namespace ProjRentalHub
{
    partial class Login : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUserName = new TextBox();
            txtpassword = new TextBox();
            btnOK = new Button();
            label3 = new Label();
            label4 = new Label();
            lblSignUp = new LinkLabel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.LightGray;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.FromArgb(128, 128, 255);
            txtUserName.Location = new Point(90, 620);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter User ID";
            txtUserName.Size = new Size(309, 27);
            txtUserName.TabIndex = 0;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.LightGray;
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(128, 128, 255);
            txtpassword.Location = new Point(490, 620);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Enter System Password";
            txtpassword.Size = new Size(309, 27);
            txtpassword.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.DodgerBlue;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Location = new Point(90, 673);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(117, 31);
            btnOK.TabIndex = 2;
            btnOK.Text = "LOGIN";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 627);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "User ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(407, 625);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 8;
            label4.Text = "Password:";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.Location = new Point(214, 679);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(195, 20);
            lblSignUp.TabIndex = 9;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "Not a member yet? Signup";
            lblSignUp.LinkClicked += lblSignUp_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 69);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(158, 13);
            label1.Name = "label1";
            label1.Size = new Size(619, 41);
            label1.TabIndex = 10;
            label1.Text = "RENTAL HUB APPLICATION SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 92);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(858, 573);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(891, 716);
            ControlBox = false;
            Controls.Add(lblSignUp);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(btnOK);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(txtpassword);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN PAGE";
            Load += frmLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtpassword;
        private Button btnOK;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private LinkLabel lblSignUp;
        private PictureBox pictureBox1;
    }
}