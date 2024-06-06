namespace ProjRentalHub
{
    partial class UC_CarReturnUser
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
            lblpicture_m = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            pCar_m = new PictureBox();
            label1 = new Label();
            lblcarDesc_m = new Label();
            lblcarID_m = new Label();
            label4 = new Label();
            btnMoreInfo = new Button();
            label2 = new Label();
            txtDailyRate = new TextBox();
            txtNoOfDays = new TextBox();
            txtAmtPaid = new TextBox();
            txtStatus = new TextBox();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pCar_m).BeginInit();
            SuspendLayout();
            // 
            // lblpicture_m
            // 
            lblpicture_m.AutoSize = true;
            lblpicture_m.Location = new Point(15, 148);
            lblpicture_m.Name = "lblpicture_m";
            lblpicture_m.Size = new Size(50, 20);
            lblpicture_m.TabIndex = 44;
            lblpicture_m.Text = "label1";
            lblpicture_m.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 213);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 42;
            label6.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 180);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 40;
            label5.Text = "Start Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 131);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 38;
            label3.Text = "Amount Paid:";
            label3.Visible = false;
            // 
            // pCar_m
            // 
            pCar_m.Location = new Point(10, 35);
            pCar_m.Margin = new Padding(3, 4, 3, 4);
            pCar_m.Name = "pCar_m";
            pCar_m.Size = new Size(363, 133);
            pCar_m.SizeMode = PictureBoxSizeMode.Zoom;
            pCar_m.TabIndex = 36;
            pCar_m.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 87);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 47;
            label1.Text = "No. of Days:";
            label1.Visible = false;
            // 
            // lblcarDesc_m
            // 
            lblcarDesc_m.AutoSize = true;
            lblcarDesc_m.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarDesc_m.ForeColor = Color.DodgerBlue;
            lblcarDesc_m.Location = new Point(104, 3);
            lblcarDesc_m.Name = "lblcarDesc_m";
            lblcarDesc_m.Size = new Size(158, 28);
            lblcarDesc_m.TabIndex = 34;
            lblcarDesc_m.Text = "Car Description";
            lblcarDesc_m.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblcarID_m
            // 
            lblcarID_m.AutoSize = true;
            lblcarID_m.Location = new Point(15, 38);
            lblcarID_m.Name = "lblcarID_m";
            lblcarID_m.Size = new Size(69, 20);
            lblcarID_m.TabIndex = 51;
            lblcarID_m.Text = "CAR0000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 43);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 52;
            label4.Text = "Daily Rate:";
            label4.Visible = false;
            // 
            // btnMoreInfo
            // 
            btnMoreInfo.BackColor = Color.DodgerBlue;
            btnMoreInfo.FlatStyle = FlatStyle.Popup;
            btnMoreInfo.ForeColor = Color.White;
            btnMoreInfo.Location = new Point(152, 252);
            btnMoreInfo.Margin = new Padding(3, 4, 3, 4);
            btnMoreInfo.Name = "btnMoreInfo";
            btnMoreInfo.Size = new Size(86, 31);
            btnMoreInfo.TabIndex = 53;
            btnMoreInfo.Text = "Return";
            btnMoreInfo.UseVisualStyleBackColor = false;
            btnMoreInfo.Click += btnMoreInfo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 54;
            label2.Text = "Status:";
            label2.Visible = false;
            // 
            // txtDailyRate
            // 
            txtDailyRate.Enabled = false;
            txtDailyRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDailyRate.Location = new Point(303, 39);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(69, 30);
            txtDailyRate.TabIndex = 55;
            txtDailyRate.Visible = false;
            // 
            // txtNoOfDays
            // 
            txtNoOfDays.AcceptsReturn = true;
            txtNoOfDays.Enabled = false;
            txtNoOfDays.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoOfDays.Location = new Point(303, 84);
            txtNoOfDays.Name = "txtNoOfDays";
            txtNoOfDays.Size = new Size(69, 30);
            txtNoOfDays.TabIndex = 56;
            txtNoOfDays.Visible = false;
            // 
            // txtAmtPaid
            // 
            txtAmtPaid.AcceptsReturn = true;
            txtAmtPaid.Enabled = false;
            txtAmtPaid.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmtPaid.Location = new Point(303, 128);
            txtAmtPaid.Name = "txtAmtPaid";
            txtAmtPaid.Size = new Size(69, 30);
            txtAmtPaid.TabIndex = 57;
            txtAmtPaid.Visible = false;
            // 
            // txtStatus
            // 
            txtStatus.AcceptsReturn = true;
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtStatus.Location = new Point(104, 87);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(69, 30);
            txtStatus.TabIndex = 58;
            txtStatus.Visible = false;
            // 
            // txtStartDate
            // 
            txtStartDate.AcceptsReturn = true;
            txtStartDate.Enabled = false;
            txtStartDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtStartDate.Location = new Point(94, 175);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(240, 30);
            txtStartDate.TabIndex = 59;
            // 
            // txtEndDate
            // 
            txtEndDate.AcceptsReturn = true;
            txtEndDate.Enabled = false;
            txtEndDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEndDate.Location = new Point(94, 208);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(240, 30);
            txtEndDate.TabIndex = 60;
            // 
            // UC_CarReturnUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtStatus);
            Controls.Add(txtAmtPaid);
            Controls.Add(txtNoOfDays);
            Controls.Add(txtDailyRate);
            Controls.Add(label2);
            Controls.Add(btnMoreInfo);
            Controls.Add(label4);
            Controls.Add(lblcarID_m);
            Controls.Add(label1);
            Controls.Add(lblpicture_m);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pCar_m);
            Controls.Add(lblcarDesc_m);
            Name = "UC_CarReturnUser";
            Size = new Size(382, 294);
            Load += UC_CarReturn_Load;
            ((System.ComponentModel.ISupportInitialize)pCar_m).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblpicture_m;
        private Label label6;
        private Label label5;
        private Label label3;
        private PictureBox pCar_m;
        private Label lblcarDesc_m;
        private Label label1;
        private Label lblcarID_m;
        private Label label4;
        private Button btnMoreInfo;
        private Label label2;
        private TextBox txtDailyRate;
        private TextBox txtNoOfDays;
        private TextBox txtAmtPaid;
        private TextBox txtStatus;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
    }
}
