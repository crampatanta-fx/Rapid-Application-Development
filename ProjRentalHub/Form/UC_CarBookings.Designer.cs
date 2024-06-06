namespace ProjRentalHub
{
    partial class UC_CarBookings
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
            pCarPicList = new PictureBox();
            lblcarDesc = new Label();
            lblCarID = new Label();
            lblPictureFilename = new Label();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)pCarPicList).BeginInit();
            SuspendLayout();
            // 
            // pCarPicList
            // 
            pCarPicList.Image = Properties.Resources.Renault_Clio_Diesel;
            pCarPicList.Location = new Point(20, 5);
            pCarPicList.Margin = new Padding(3, 4, 3, 4);
            pCarPicList.Name = "pCarPicList";
            pCarPicList.Size = new Size(336, 234);
            pCarPicList.SizeMode = PictureBoxSizeMode.Zoom;
            pCarPicList.TabIndex = 0;
            pCarPicList.TabStop = false;
            // 
            // lblcarDesc
            // 
            lblcarDesc.AutoSize = true;
            lblcarDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarDesc.ForeColor = Color.Red;
            lblcarDesc.Location = new Point(24, 242);
            lblcarDesc.Name = "lblcarDesc";
            lblcarDesc.Size = new Size(191, 28);
            lblcarDesc.TabIndex = 1;
            lblcarDesc.Text = "Renault Clio Diesel";
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(253, 212);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(50, 20);
            lblCarID.TabIndex = 3;
            lblCarID.Text = "label1";
            lblCarID.Visible = false;
            // 
            // lblPictureFilename
            // 
            lblPictureFilename.AutoSize = true;
            lblPictureFilename.Location = new Point(308, 196);
            lblPictureFilename.Name = "lblPictureFilename";
            lblPictureFilename.Size = new Size(50, 20);
            lblPictureFilename.TabIndex = 4;
            lblPictureFilename.Text = "label1";
            lblPictureFilename.Visible = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DodgerBlue;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(253, 250);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(86, 31);
            btnReturn.TabIndex = 33;
            btnReturn.Text = "More Info";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // UC_CarBookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnReturn);
            Controls.Add(lblPictureFilename);
            Controls.Add(lblCarID);
            Controls.Add(lblcarDesc);
            Controls.Add(pCarPicList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_CarBookings";
            Size = new Size(382, 292);
            Load += UC_Cars_Load;
            ((System.ComponentModel.ISupportInitialize)pCarPicList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pCarPicList;
        private Label lblcarDesc;
        private Label lblCarID;
        private Label lblPictureFilename;
        private Button btnReturn;
    }
}
