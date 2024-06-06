namespace ProjRentalHub
{
    partial class UC_CarReturnAdmin
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
            label4 = new Label();
            lblStatus = new Label();
            pCar_m = new PictureBox();
            label1 = new Label();
            btnReturnEdit = new Button();
            txtStatus = new TextBox();
            txtCarID = new TextBox();
            lblModel = new Label();
            lblDailyRate = new Label();
            lblYear = new Label();
            lblPicture = new Label();
            lblCarDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pCar_m).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 162);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Daily Rate:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(10, 258);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(70, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // pCar_m
            // 
            pCar_m.Location = new Point(10, 36);
            pCar_m.Margin = new Padding(3, 4, 3, 4);
            pCar_m.Name = "pCar_m";
            pCar_m.Size = new Size(361, 192);
            pCar_m.SizeMode = PictureBoxSizeMode.Zoom;
            pCar_m.TabIndex = 6;
            pCar_m.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 223);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 15;
            label1.Text = "Car ID:";
            // 
            // btnReturnEdit
            // 
            btnReturnEdit.BackColor = Color.DodgerBlue;
            btnReturnEdit.FlatStyle = FlatStyle.Popup;
            btnReturnEdit.ForeColor = Color.White;
            btnReturnEdit.Location = new Point(265, 247);
            btnReturnEdit.Margin = new Padding(3, 4, 3, 4);
            btnReturnEdit.Name = "btnReturnEdit";
            btnReturnEdit.Size = new Size(86, 31);
            btnReturnEdit.TabIndex = 17;
            btnReturnEdit.Text = "Return";
            btnReturnEdit.UseVisualStyleBackColor = false;
            btnReturnEdit.Click += btnReturnEdit_Click;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtStatus.Location = new Point(78, 257);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(151, 30);
            txtStatus.TabIndex = 19;
            // 
            // txtCarID
            // 
            txtCarID.Enabled = false;
            txtCarID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCarID.ForeColor = Color.Red;
            txtCarID.Location = new Point(78, 222);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(151, 30);
            txtCarID.TabIndex = 20;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(19, 201);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(51, 20);
            lblModel.TabIndex = 9;
            lblModel.Text = "Camry";
            lblModel.Visible = false;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Location = new Point(77, 202);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(25, 20);
            lblDailyRate.TabIndex = 11;
            lblDailyRate.Text = "90";
            lblDailyRate.Visible = false;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(264, 202);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(41, 20);
            lblYear.TabIndex = 10;
            lblYear.Text = "2019";
            lblYear.Visible = false;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Location = new Point(311, 202);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(54, 20);
            lblPicture.TabIndex = 16;
            lblPicture.Text = "Picture";
            lblPicture.Visible = false;
            // 
            // lblCarDesc
            // 
            lblCarDesc.AutoSize = true;
            lblCarDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarDesc.ForeColor = Color.DodgerBlue;
            lblCarDesc.Location = new Point(118, 4);
            lblCarDesc.Name = "lblCarDesc";
            lblCarDesc.Size = new Size(143, 28);
            lblCarDesc.TabIndex = 21;
            lblCarDesc.Text = "Toyota Camry";
            lblCarDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_CarReturnAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblCarDesc);
            Controls.Add(txtCarID);
            Controls.Add(txtStatus);
            Controls.Add(btnReturnEdit);
            Controls.Add(lblPicture);
            Controls.Add(label1);
            Controls.Add(lblDailyRate);
            Controls.Add(lblYear);
            Controls.Add(lblModel);
            Controls.Add(pCar_m);
            Controls.Add(lblStatus);
            Controls.Add(label4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_CarReturnAdmin";
            Size = new Size(382, 293);
            Load += ModifyItem_Load;
            ((System.ComponentModel.ISupportInitialize)pCar_m).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label lblStatus;
        private PictureBox pCar_m;
        private Label label1;
        private Button btnReturnEdit;
        private TextBox txtStatus;
        private TextBox txtCarID;
        private Label lblModel;
        private Label lblDailyRate;
        private Label lblYear;
        private Label lblPicture;
        private Label lblCarDesc;
    }
}
