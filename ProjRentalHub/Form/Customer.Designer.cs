namespace ProjRentalHub
{
    partial class Customer
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
            panel1 = new Panel();
            btnPrev = new Button();
            btnNext = new Button();
            linklblAddNewCust = new LinkLabel();
            lblAdminPanel = new Label();
            pGoBackIcon = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(linklblAddNewCust);
            panel1.Controls.Add(lblAdminPanel);
            panel1.Controls.Add(pGoBackIcon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 69);
            panel1.TabIndex = 0;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.DodgerBlue;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(1067, 18);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 31);
            btnPrev.TabIndex = 32;
            btnPrev.Text = "<<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DodgerBlue;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1113, 18);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 31);
            btnNext.TabIndex = 31;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // linklblAddNewCust
            // 
            linklblAddNewCust.AutoSize = true;
            linklblAddNewCust.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linklblAddNewCust.Location = new Point(478, 21);
            linklblAddNewCust.Name = "linklblAddNewCust";
            linklblAddNewCust.Size = new Size(195, 28);
            linklblAddNewCust.TabIndex = 30;
            linklblAddNewCust.TabStop = true;
            linklblAddNewCust.Text = "Add New Customer";
            linklblAddNewCust.LinkClicked += linklblAddNewCust_LinkClicked;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(79, 15);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(143, 38);
            lblAdminPanel.TabIndex = 29;
            lblAdminPanel.Text = "Customer";
            // 
            // pGoBackIcon
            // 
            pGoBackIcon.Image = Properties.Resources.back;
            pGoBackIcon.Location = new Point(7, 7);
            pGoBackIcon.Margin = new Padding(3, 4, 3, 4);
            pGoBackIcon.Name = "pGoBackIcon";
            pGoBackIcon.Size = new Size(61, 56);
            pGoBackIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pGoBackIcon.TabIndex = 28;
            pGoBackIcon.TabStop = false;
            pGoBackIcon.Click += pGoBackIcon_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 69);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1167, 914);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 983);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pGoBackIcon;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblAdminPanel;
        private LinkLabel linklblAddNewCust;
        private Button btnPrev;
        private Button btnNext;
    }
}