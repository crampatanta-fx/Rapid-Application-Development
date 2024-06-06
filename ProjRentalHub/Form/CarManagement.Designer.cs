namespace ProjRentalHub
{
    partial class CarManagement
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
            panel1 = new Panel();
            cboCategory = new ComboBox();
            btnClear = new Button();
            pGoBackIcon = new PictureBox();
            btnSearch = new Button();
            cboColor = new ComboBox();
            label4 = new Label();
            cboMaker = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtSearchDesc = new TextBox();
            label1 = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).BeginInit();
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
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(pGoBackIcon);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cboColor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboMaker);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearchDesc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(btnNext);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 79);
            panel1.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(382, 25);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(136, 28);
            cboCategory.TabIndex = 29;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.CornflowerBlue;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(972, 28);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(882, 28);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(767, 27);
            cboColor.Margin = new Padding(3, 4, 3, 4);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(109, 28);
            cboColor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(724, 31);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Color:";
            // 
            // cboMaker
            // 
            cboMaker.FormattingEnabled = true;
            cboMaker.Location = new Point(569, 27);
            cboMaker.Margin = new Padding(3, 4, 3, 4);
            cboMaker.Name = "cboMaker";
            cboMaker.Size = new Size(153, 28);
            cboMaker.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 31);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Maker:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 31);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Category:";
            // 
            // txtSearchDesc
            // 
            txtSearchDesc.BorderStyle = BorderStyle.FixedSingle;
            txtSearchDesc.ForeColor = Color.FromArgb(64, 0, 64);
            txtSearchDesc.Location = new Point(139, 27);
            txtSearchDesc.Margin = new Padding(3, 4, 3, 4);
            txtSearchDesc.Name = "txtSearchDesc";
            txtSearchDesc.Size = new Size(175, 27);
            txtSearchDesc.TabIndex = 4;
            txtSearchDesc.Text = "Key-in car description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.DodgerBlue;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(1063, 28);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 31);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "<<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DodgerBlue;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1109, 28);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 31);
            btnNext.TabIndex = 1;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // CarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1167, 983);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pGoBackIcon).EndInit();
            ResumeLayout(false);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CarYear_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnPrev;
        private Button btnNext;
        private Label label1;
        private TextBox txtSearchDesc;
        private Label label2;
        private ComboBox cboMaker;
        private Label label3;
        private ComboBox cboColor;
        private Label label4;
        private Button btnSearch;
        private PictureBox pGoBackIcon;
        private Button btnClear;
        private ComboBox cboCategory;
    }
}