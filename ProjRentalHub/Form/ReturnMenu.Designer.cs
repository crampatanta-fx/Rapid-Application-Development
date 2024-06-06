namespace ProjRentalHub
{
    partial class ReturnMenu
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNext = new Button();
            btnPrev = new Button();
            pGoBackIcon = new PictureBox();
            panel1 = new Panel();
            lblAdminPanel = new Label();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1167, 983);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DodgerBlue;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1099, 28);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 31);
            btnNext.TabIndex = 1;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.DodgerBlue;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(1053, 28);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 31);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "<<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // pGoBackIcon
            // 
            pGoBackIcon.Image = Properties.Resources.back;
            pGoBackIcon.Location = new Point(14, 9);
            pGoBackIcon.Margin = new Padding(3, 4, 3, 4);
            pGoBackIcon.Name = "pGoBackIcon";
            pGoBackIcon.Size = new Size(61, 56);
            pGoBackIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pGoBackIcon.TabIndex = 27;
            pGoBackIcon.TabStop = false;
            pGoBackIcon.Click += pGoBackIcon_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lblAdminPanel);
            panel1.Controls.Add(pGoBackIcon);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(btnNext);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 79);
            panel1.TabIndex = 3;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPanel.ForeColor = Color.White;
            lblAdminPanel.Location = new Point(90, 19);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(184, 38);
            lblAdminPanel.TabIndex = 29;
            lblAdminPanel.Text = "Return A Car";
            // 
            // ReturnMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 983);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReturnMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return A Car";
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNext;
        private Button btnPrev;
        private PictureBox pGoBackIcon;
        private Panel panel1;
        private Label lblAdminPanel;
    }
}