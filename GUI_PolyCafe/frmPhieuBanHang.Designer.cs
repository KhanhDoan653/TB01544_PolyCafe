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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tan;
            groupBox2.Controls.Add(dgvDanhSachPhieu);
            groupBox2.Location = new Point(30, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(907, 188);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgvDanhSachPhieu
            // 
            dgvDanhSachPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhieu.BackgroundColor = SystemColors.Control;
            dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieu.Location = new Point(10, 22);
            dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            dgvDanhSachPhieu.Size = new Size(891, 155);
            dgvDanhSachPhieu.TabIndex = 10;
            dgvDanhSachPhieu.CellClick += dgvDanhSachPhieu_CellClick;
            dgvDanhSachPhieu.CellContentClick += dgvDanhSachPhieu_CellContentClick;
            dgvDanhSachPhieu.CellDoubleClick += dgvDanhSachPhieu_CellDoubleClick;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Location = new Point(782, 131);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(82, 36);
            btLamMoi.TabIndex = 13;
            btLamMoi.Text = "Làm Mới";
            btLamMoi.UseVisualStyleBackColor = true;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.ForeColor = Color.Red;
            btXoa.Location = new Point(678, 131);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(82, 36);
            btXoa.TabIndex = 12;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(32, 176);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 8;
            label5.Text = "Trạng thái";
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.ForeColor = Color.Green;
            btThem.Location = new Point(470, 131);
            btThem.Name = "btThem";
            btThem.Size = new Size(82, 36);
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
            tableLayoutPanel1.Size = new Size(374, 147);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(115, 39);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(227, 23);
            txtMaPhieu.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã thẻ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 3;
            label4.Text = "Ngày tạo";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CustomFormat = "dd/MM/yyyy";
            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.Location = new Point(115, 111);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(200, 23);
            dtpNgayTao.TabIndex = 8;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(115, 75);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(227, 23);
            cboNhanVien.TabIndex = 9;
            // 
            // cboMaTheLuuDong
            // 
            cboMaTheLuuDong.FormattingEnabled = true;
            cboMaTheLuuDong.Location = new Point(115, 3);
            cboMaTheLuuDong.Name = "cboMaTheLuuDong";
            cboMaTheLuuDong.Size = new Size(227, 23);
            cboMaTheLuuDong.TabIndex = 10;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Location = new Point(574, 131);
            btSua.Name = "btSua";
            btSua.Size = new Size(82, 36);
            btSua.TabIndex = 14;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // rdChoXacNhan
            // 
            rdChoXacNhan.AutoSize = true;
            rdChoXacNhan.Font = new Font("Segoe UI", 9.75F);
            rdChoXacNhan.Location = new Point(147, 174);
            rdChoXacNhan.Name = "rdChoXacNhan";
            rdChoXacNhan.Size = new Size(104, 21);
            rdChoXacNhan.TabIndex = 10;
            rdChoXacNhan.TabStop = true;
            rdChoXacNhan.Text = "Chờ xác nhận";
            rdChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // rdChuaThanhToan
            // 
            rdChuaThanhToan.AutoSize = true;
            rdChuaThanhToan.Font = new Font("Segoe UI", 9.75F);
            rdChuaThanhToan.Location = new Point(284, 176);
            rdChuaThanhToan.Name = "rdChuaThanhToan";
            rdChuaThanhToan.Size = new Size(108, 21);
            rdChuaThanhToan.TabIndex = 11;
            rdChuaThanhToan.TabStop = true;
            rdChuaThanhToan.Text = "Đã thanh toán";
            rdChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.None;
            txtTim.BackColor = Color.White;
            txtTim.Location = new Point(470, 25);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(306, 23);
            txtTim.TabIndex = 9;
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.None;
            btTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btTim.ForeColor = Color.Black;
            btTim.Location = new Point(782, 19);
            btTim.Name = "btTim";
            btTim.Size = new Size(82, 33);
            btTim.TabIndex = 11;
            btTim.Text = "Tìm";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Tan;
            groupBox1.Controls.Add(btTim);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(rdChuaThanhToan);
            groupBox1.Controls.Add(rdChoXacNhan);
            groupBox1.Controls.Add(btSua);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(btThem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btXoa);
            groupBox1.Controls.Add(btLamMoi);
            groupBox1.Location = new Point(30, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(907, 199);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 1);
            label6.Name = "label6";
            label6.Size = new Size(263, 25);
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
            tableLayoutPanel2.Size = new Size(907, 27);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // frmPhieuBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Table_Of_Content;
            ClientSize = new Size(971, 439);
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
    }
}