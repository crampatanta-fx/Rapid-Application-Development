namespace ProjRentalHub
{
    partial class UC_CarBookingHistory
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
            lblDailyRate_m = new Label();
            pCar_m = new PictureBox();
            lblcarDesc_m = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblpicture_m = new Label();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            txtAmountPaid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pCar_m).BeginInit();
            SuspendLayout();
            // 
            // lblDailyRate_m
            // 
            lblDailyRate_m.AutoSize = true;
            lblDailyRate_m.Location = new Point(324, 171);
            lblDailyRate_m.Name = "lblDailyRate_m";
            lblDailyRate_m.Size = new Size(39, 20);
            lblDailyRate_m.TabIndex = 26;
            lblDailyRate_m.Text = "CAD";
            lblDailyRate_m.Visible = false;
            // 
            // pCar_m
            // 
            pCar_m.Location = new Point(10, 36);
            pCar_m.Margin = new Padding(3, 4, 3, 4);
            pCar_m.Name = "pCar_m";
            pCar_m.Size = new Size(354, 150);
            pCar_m.SizeMode = PictureBoxSizeMode.Zoom;
            pCar_m.TabIndex = 22;
            pCar_m.TabStop = false;
            // 
            // lblcarDesc_m
            // 
            lblcarDesc_m.AutoSize = true;
            lblcarDesc_m.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarDesc_m.ForeColor = Color.Red;
            lblcarDesc_m.Location = new Point(101, 1);
            lblcarDesc_m.Name = "lblcarDesc_m";
            lblcarDesc_m.Size = new Size(179, 31);
            lblcarDesc_m.TabIndex = 17;
            lblcarDesc_m.Text = "Car Description";
            lblcarDesc_m.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 267);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 27;
            label3.Text = "Amount Paid:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 200);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 29;
            label5.Text = "Start Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 235);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 31;
            label6.Text = "End Date:";
            // 
            // lblpicture_m
            // 
            lblpicture_m.AutoSize = true;
            lblpicture_m.Location = new Point(16, 171);
            lblpicture_m.Name = "lblpicture_m";
            lblpicture_m.Size = new Size(50, 20);
            lblpicture_m.TabIndex = 33;
            lblpicture_m.Text = "label1";
            lblpicture_m.Visible = false;
            // 
            // txtStartDate
            // 
            txtStartDate.Enabled = false;
            txtStartDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtStartDate.Location = new Point(108, 193);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(242, 30);
            txtStartDate.TabIndex = 34;
            // 
            // txtEndDate
            // 
            txtEndDate.Enabled = false;
            txtEndDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEndDate.Location = new Point(108, 228);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(242, 30);
            txtEndDate.TabIndex = 35;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Enabled = false;
            txtAmountPaid.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmountPaid.Location = new Point(108, 262);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(242, 30);
            txtAmountPaid.TabIndex = 36;
            // 
            // UC_CarBookingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtAmountPaid);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(lblpicture_m);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblDailyRate_m);
            Controls.Add(pCar_m);
            Controls.Add(lblcarDesc_m);
            Name = "UC_CarBookingHistory";
            Size = new Size(382, 298);
            Load += UC_BookedCar_Load;
            ((System.ComponentModel.ISupportInitialize)pCar_m).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDailyRate_m;
        private PictureBox pCar_m;
        private Label lblcarDesc_m;
        private Label lblAmtPaid_m;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label lblpicture_m;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private TextBox txtAmountPaid;
    }
}
