namespace GUI
{
    partial class frmSPKD
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
            label1 = new Label();
            customButton3 = new CustomButton();
            customButton2 = new CustomButton();
            customButton1 = new CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxCustom2 = new Components.Textboxs.TextBoxCustom();
            checkBox1 = new CheckBox();
            textBoxCustom1 = new Components.Textboxs.TextBoxCustom();
            panel2 = new Panel();
            dgvSpkd = new DataGridView();
            maKhoXuat = new DataGridViewTextBoxColumn();
            tenKhoXuat = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpkd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(customButton3);
            panel1.Controls.Add(customButton2);
            panel1.Controls.Add(customButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 1;
            label1.Text = "Sản phẩm kinh doanh";
            // 
            // customButton3
            // 
            customButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton3.BackColor = Color.FromArgb(255, 128, 0);
            customButton3.BackgroundColor = Color.FromArgb(255, 128, 0);
            customButton3.BorderColor = Color.Orange;
            customButton3.BorderRadius = 5;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.White;
            customButton3.Image = Properties.Resources.addNew25;
            customButton3.ImageAlign = ContentAlignment.MiddleLeft;
            customButton3.Location = new Point(489, 6);
            customButton3.Name = "customButton3";
            customButton3.Padding = new Padding(0, 0, 5, 0);
            customButton3.Size = new Size(100, 35);
            customButton3.TabIndex = 0;
            customButton3.Text = "Thêm";
            customButton3.TextAlign = ContentAlignment.MiddleRight;
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton2.BackColor = Color.FromArgb(0, 192, 0);
            customButton2.BackgroundColor = Color.FromArgb(0, 192, 0);
            customButton2.BorderColor = Color.Orange;
            customButton2.BorderRadius = 5;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.Image = Properties.Resources.update25;
            customButton2.ImageAlign = ContentAlignment.MiddleLeft;
            customButton2.Location = new Point(595, 6);
            customButton2.Name = "customButton2";
            customButton2.Padding = new Padding(0, 0, 15, 0);
            customButton2.Size = new Size(100, 35);
            customButton2.TabIndex = 0;
            customButton2.Text = "Sửa";
            customButton2.TextAlign = ContentAlignment.MiddleRight;
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton1_Click;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton1.BackColor = Color.Red;
            customButton1.BackgroundColor = Color.Red;
            customButton1.BorderColor = Color.Orange;
            customButton1.BorderRadius = 5;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Image = Properties.Resources.delete25;
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(701, 6);
            customButton1.Name = "customButton1";
            customButton1.Padding = new Padding(0, 0, 15, 0);
            customButton1.Size = new Size(100, 35);
            customButton1.TabIndex = 0;
            customButton1.Text = "Xóa";
            customButton1.TextAlign = ContentAlignment.MiddleRight;
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.Controls.Add(textBoxCustom2, 1, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxCustom1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(790, 70);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxCustom2
            // 
            textBoxCustom2.AllowNull = false;
            textBoxCustom2.AllowWhiteSpace = true;
            textBoxCustom2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCustom2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            textBoxCustom2.BackColor = Color.White;
            textBoxCustom2.Error = "";
            textBoxCustom2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCustom2.Label = "Phạm vi tìm kiếm";
            textBoxCustom2.Location = new Point(215, 2);
            textBoxCustom2.Margin = new Padding(2);
            textBoxCustom2.MaximumSize = new Size(1000, 66);
            textBoxCustom2.MinimumSize = new Size(0, 66);
            textBoxCustom2.Multiline = false;
            textBoxCustom2.Name = "textBoxCustom2";
            textBoxCustom2.ReadOnly = false;
            textBoxCustom2.Size = new Size(209, 66);
            textBoxCustom2.TabIndex = 1;
            textBoxCustom2.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(429, 15);
            checkBox1.Margin = new Padding(3, 15, 3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 52);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Đang kinh doanh";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxCustom1
            // 
            textBoxCustom1.AllowNull = false;
            textBoxCustom1.AllowWhiteSpace = true;
            textBoxCustom1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            textBoxCustom1.BackColor = Color.White;
            textBoxCustom1.Dock = DockStyle.Fill;
            textBoxCustom1.Error = "";
            textBoxCustom1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCustom1.Label = "Nội dung tìm kiếm";
            textBoxCustom1.Location = new Point(2, 2);
            textBoxCustom1.Margin = new Padding(2);
            textBoxCustom1.MaximumSize = new Size(1000, 66);
            textBoxCustom1.MinimumSize = new Size(0, 66);
            textBoxCustom1.Multiline = false;
            textBoxCustom1.Name = "textBoxCustom1";
            textBoxCustom1.ReadOnly = false;
            textBoxCustom1.Size = new Size(209, 66);
            textBoxCustom1.TabIndex = 3;
            textBoxCustom1.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.OnlyLetter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvSpkd);
            panel2.Location = new Point(12, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 401);
            panel2.TabIndex = 2;
            // 
            // dgvSpkd
            // 
            dgvSpkd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSpkd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpkd.BackgroundColor = Color.Gainsboro;
            dgvSpkd.BorderStyle = BorderStyle.None;
            dgvSpkd.Columns.AddRange(new DataGridViewColumn[] { maKhoXuat, tenKhoXuat, moTa });
            dgvSpkd.Location = new Point(13, 14);
            dgvSpkd.Name = "dgvSpkd";
            dgvSpkd.ReadOnly = true;
            dgvSpkd.RowTemplate.Height = 25;
            dgvSpkd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpkd.Size = new Size(764, 375);
            dgvSpkd.TabIndex = 1;
            // 
            // maKhoXuat
            // 
            maKhoXuat.DataPropertyName = "maKhoXuat";
            maKhoXuat.HeaderText = "Mã Kho Xuất";
            maKhoXuat.Name = "maKhoXuat";
            maKhoXuat.ReadOnly = true;
            // 
            // tenKhoXuat
            // 
            tenKhoXuat.DataPropertyName = "tenKhoXuat";
            tenKhoXuat.HeaderText = "Tên Kho Xuất";
            tenKhoXuat.Name = "tenKhoXuat";
            tenKhoXuat.ReadOnly = true;
            // 
            // moTa
            // 
            moTa.DataPropertyName = "moTa";
            moTa.HeaderText = "Mô Tả";
            moTa.Name = "moTa";
            moTa.ReadOnly = true;
            // 
            // frmSPKD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(814, 545);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSPKD";
            Text = "frmSPKD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpkd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private DataGridView dgvSpkd;
        private DataGridViewTextBoxColumn maKhoXuat;
        private DataGridViewTextBoxColumn tenKhoXuat;
        private DataGridViewTextBoxColumn moTa;
        private Components.Textboxs.TextBoxCustom textBoxCustom2;
        private CheckBox checkBox1;
        private Components.Textboxs.TextBoxCustom textBoxCustom1;
    }
}