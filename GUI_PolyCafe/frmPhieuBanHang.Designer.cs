namespace GUI_PolyCafe
{
    partial class frmPhieuBanHang
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
            groupBox2 = new GroupBox();
            dgvDanhSachPhieu = new DataGridView();
            btLamMoi = new Button();
            btXoa = new Button();
            label5 = new Label();
            btThem = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtMaPhieu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpNgayTao = new DateTimePicker();
            cboNhanVien = new ComboBox();
            cboMaTheLuuDong = new ComboBox();
            btSua = new Button();
            rdChoXacNhan = new RadioButton();
            rdChuaThanhToan = new RadioButton();
            txtTim = new TextBox();
            btTim = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tan;
            groupBox2.Controls.Add(dgvDanhSachPhieu);
            groupBox2.Location = new Point(30, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1134, 286);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgvDanhSachPhieu
            // 
            dgvDanhSachPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhieu.BackgroundColor = Color.White;
            dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieu.Location = new Point(10, 22);
            dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            dgvDanhSachPhieu.Size = new Size(1118, 258);
            dgvDanhSachPhieu.TabIndex = 10;
            dgvDanhSachPhieu.CellClick += dgvDanhSachPhieu_CellClick;
            dgvDanhSachPhieu.CellContentClick += dgvDanhSachPhieu_CellContentClick;
            dgvDanhSachPhieu.CellDoubleClick += dgvDanhSachPhieu_CellDoubleClick;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Location = new Point(409, 11);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(100, 36);
            btLamMoi.TabIndex = 13;
            btLamMoi.Text = "Làm Mới";
            btLamMoi.UseVisualStyleBackColor = true;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btXoa.ForeColor = Color.Red;
            btXoa.Location = new Point(277, 11);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(100, 36);
            btXoa.TabIndex = 12;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(32, 176);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 8;
            label5.Text = "Trạng thái";
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btThem.ForeColor = Color.Green;
            btThem.Location = new Point(15, 11);
            btThem.Name = "btThem";
            btThem.Size = new Size(100, 36);
            btThem.TabIndex = 10;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0911846F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.90881F));
            tableLayoutPanel1.Controls.Add(txtMaPhieu, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(dtpNgayTao, 1, 3);
            tableLayoutPanel1.Controls.Add(cboNhanVien, 1, 2);
            tableLayoutPanel1.Controls.Add(cboMaTheLuuDong, 1, 0);
            tableLayoutPanel1.Location = new Point(32, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(525, 147);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Segoe UI", 11.25F);
            txtMaPhieu.Location = new Point(160, 39);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(304, 27);
            txtMaPhieu.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã thẻ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày tạo";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CustomFormat = "dd/MM/yyyy";
            dtpNgayTao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.Location = new Point(160, 111);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(304, 27);
            dtpNgayTao.TabIndex = 8;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(160, 75);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(304, 28);
            cboNhanVien.TabIndex = 9;
            // 
            // cboMaTheLuuDong
            // 
            cboMaTheLuuDong.Font = new Font("Segoe UI", 11.25F);
            cboMaTheLuuDong.FormattingEnabled = true;
            cboMaTheLuuDong.Location = new Point(160, 3);
            cboMaTheLuuDong.Name = "cboMaTheLuuDong";
            cboMaTheLuuDong.Size = new Size(304, 28);
            cboMaTheLuuDong.TabIndex = 10;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Location = new Point(146, 11);
            btSua.Name = "btSua";
            btSua.Size = new Size(100, 36);
            btSua.TabIndex = 14;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // rdChoXacNhan
            // 
            rdChoXacNhan.AutoSize = true;
            rdChoXacNhan.Font = new Font("Microsoft Sans Serif", 12F);
            rdChoXacNhan.Location = new Point(167, 174);
            rdChoXacNhan.Name = "rdChoXacNhan";
            rdChoXacNhan.Size = new Size(124, 24);
            rdChoXacNhan.TabIndex = 10;
            rdChoXacNhan.TabStop = true;
            rdChoXacNhan.Text = "Chờ xác nhận";
            rdChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // rdChuaThanhToan
            // 
            rdChuaThanhToan.AutoSize = true;
            rdChuaThanhToan.Font = new Font("Microsoft Sans Serif", 12F);
            rdChuaThanhToan.Location = new Point(339, 174);
            rdChuaThanhToan.Name = "rdChuaThanhToan";
            rdChuaThanhToan.Size = new Size(129, 24);
            rdChuaThanhToan.TabIndex = 11;
            rdChuaThanhToan.TabStop = true;
            rdChuaThanhToan.Text = "Đã thanh toán";
            rdChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.None;
            txtTim.BackColor = Color.White;
            txtTim.Font = new Font("Segoe UI", 11.25F);
            txtTim.Location = new Point(584, 28);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(412, 27);
            txtTim.TabIndex = 9;
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.None;
            btTim.Font = new Font("Microsoft Sans Serif", 12F);
            btTim.ForeColor = Color.Black;
            btTim.Location = new Point(1010, 24);
            btTim.Name = "btTim";
            btTim.Size = new Size(100, 36);
            btTim.TabIndex = 11;
            btTim.Text = "Tìm";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Tan;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(btTim);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(rdChuaThanhToan);
            groupBox1.Controls.Add(rdChoXacNhan);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(30, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1134, 205);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(401, 0);
            label6.Name = "label6";
            label6.Size = new Size(332, 27);
            label6.TabIndex = 11;
            label6.Text = "QUẢN LÝ PHIẾU BÁN HÀNG";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Location = new Point(30, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1134, 27);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btLamMoi, 3, 0);
            tableLayoutPanel3.Controls.Add(btXoa, 2, 0);
            tableLayoutPanel3.Controls.Add(btSua, 1, 0);
            tableLayoutPanel3.Controls.Add(btThem, 0, 0);
            tableLayoutPanel3.Location = new Point(584, 115);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(526, 58);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // frmPhieuBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Table_Of_Content;
            ClientSize = new Size(1196, 554);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmPhieuBanHang";
            Text = "frmPhieuBanHang";
            Load += frmPhieuBanHang_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dgvDanhSachPhieu;
        private Button btLamMoi;
        private Button btXoa;
        private Label label5;
        private Button btThem;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtMaPhieu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNgayTao;
        private Button btSua;
        private RadioButton rdChoXacNhan;
        private RadioButton rdChuaThanhToan;
        private TextBox txtTim;
        private Button btTim;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cboNhanVien;
        private ComboBox cboMaTheLuuDong;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}