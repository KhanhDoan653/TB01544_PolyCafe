namespace GUI_PolyCafe
{
    partial class frmTheLuuDong
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
            label7 = new Label();
            textBox6 = new TextBox();
            btTim = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dtgDanhSachNV = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            btLamMoi = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaNhanVien = new TextBox();
            txtHoTen = new TextBox();
            checkBox1 = new CheckBox();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachNV).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(335, 30);
            label7.Name = "label7";
            label7.Size = new Size(304, 32);
            label7.TabIndex = 11;
            label7.Text = "QUẢN LÝ THẺ LƯU ĐỘNG";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(9, 9);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(327, 23);
            textBox6.TabIndex = 0;
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.None;
            btTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btTim.ForeColor = Color.Black;
            btTim.Location = new Point(362, 3);
            btTim.Name = "btTim";
            btTim.Size = new Size(82, 36);
            btTim.TabIndex = 1;
            btTim.Text = "Tìm";
            btTim.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btTim, 1, 0);
            tableLayoutPanel4.Controls.Add(textBox6, 0, 0);
            tableLayoutPanel4.Location = new Point(498, 98);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(461, 42);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dtgDanhSachNV);
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(498, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 281);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách";
            // 
            // dtgDanhSachNV
            // 
            dtgDanhSachNV.BackgroundColor = SystemColors.Control;
            dtgDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachNV.Location = new Point(6, 22);
            dtgDanhSachNV.Name = "dtgDanhSachNV";
            dtgDanhSachNV.Size = new Size(449, 191);
            dtgDanhSachNV.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btThem, 0, 0);
            tableLayoutPanel3.Controls.Add(btSua, 1, 0);
            tableLayoutPanel3.Controls.Add(btXoa, 2, 0);
            tableLayoutPanel3.Controls.Add(btLamMoi, 3, 0);
            tableLayoutPanel3.Location = new Point(6, 237);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(449, 38);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.ForeColor = Color.Green;
            btThem.Location = new Point(15, 3);
            btThem.Name = "btThem";
            btThem.Size = new Size(82, 32);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Location = new Point(127, 3);
            btSua.Name = "btSua";
            btSua.Size = new Size(82, 32);
            btSua.TabIndex = 1;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.ForeColor = Color.Red;
            btXoa.Location = new Point(239, 3);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(82, 32);
            btXoa.TabIndex = 2;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Location = new Point(351, 3);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(82, 32);
            btLamMoi.TabIndex = 3;
            btLamMoi.Text = "Làm Mới";
            btLamMoi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(46, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 197);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1481476F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.85185F));
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMaNhanVien, 1, 0);
            tableLayoutPanel1.Controls.Add(txtHoTen, 1, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 1, 2);
            tableLayoutPanel1.Location = new Point(8, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(432, 164);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 108);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 2;
            label3.Text = "Trạng Thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 1;
            label2.Text = "Chủ Sở Hữu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Thẻ";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(103, 3);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(326, 23);
            txtMaNhanVien.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(103, 57);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(326, 23);
            txtHoTen.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(103, 111);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Hoạt động";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(971, 439);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTheLuuDong";
            Text = "frmTheLuuDong";
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachNV).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBox6;
        private Button btTim;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private DataGridView dtgDanhSachNV;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaNhanVien;
        private TextBox txtHoTen;
        private CheckBox checkBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private Button btLamMoi;
    }
}