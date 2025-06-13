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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox2 = new GroupBox();
            dgvDanhSachPhieu = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtPhanTramGiam = new TextBox();
            txtMaPhieu = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpNgayTao = new DateTimePicker();
            cboNhanVien = new ComboBox();
            cboMaTheLuuDong = new ComboBox();
            rdChoXacNhan = new RadioButton();
            rdDaThanhToan = new RadioButton();
            txtTim = new TextBox();
            groupBox1 = new GroupBox();
            btTim = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btThem = new Guna.UI2.WinForms.Guna2Button();
            btSua = new Guna.UI2.WinForms.Guna2Button();
            btXoa = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            dataGridViewCellStyle7.BackColor = Color.White;
            dgvDanhSachPhieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvDanhSachPhieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvDanhSachPhieu.ColumnHeadersHeight = 20;
            dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvDanhSachPhieu.DefaultCellStyle = dataGridViewCellStyle9;
            dgvDanhSachPhieu.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachPhieu.Location = new Point(6, 22);
            dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            dgvDanhSachPhieu.RowHeadersVisible = false;
            dgvDanhSachPhieu.Size = new Size(1122, 258);
            dgvDanhSachPhieu.TabIndex = 0;
            dgvDanhSachPhieu.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDanhSachPhieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDanhSachPhieu.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDanhSachPhieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDanhSachPhieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDanhSachPhieu.ThemeStyle.BackColor = Color.White;
            dgvDanhSachPhieu.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachPhieu.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDanhSachPhieu.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhSachPhieu.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSachPhieu.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDanhSachPhieu.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDanhSachPhieu.ThemeStyle.HeaderStyle.Height = 20;
            dgvDanhSachPhieu.ThemeStyle.ReadOnly = false;
            dgvDanhSachPhieu.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDanhSachPhieu.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachPhieu.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSachPhieu.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSachPhieu.ThemeStyle.RowsStyle.Height = 25;
            dgvDanhSachPhieu.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachPhieu.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSachPhieu.CellClick += dgvDanhSachPhieu_CellClick;
            dgvDanhSachPhieu.CellDoubleClick += dgvDanhSachPhieu_CellDoubleClick;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0911846F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.90881F));
            tableLayoutPanel1.Controls.Add(txtPhanTramGiam, 1, 4);
            tableLayoutPanel1.Controls.Add(txtMaPhieu, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(dtpNgayTao, 1, 3);
            tableLayoutPanel1.Controls.Add(cboNhanVien, 1, 2);
            tableLayoutPanel1.Controls.Add(cboMaTheLuuDong, 1, 0);
            tableLayoutPanel1.Location = new Point(32, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(525, 147);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // txtPhanTramGiam
            // 
            txtPhanTramGiam.Anchor = AnchorStyles.Left;
            txtPhanTramGiam.BackColor = Color.White;
            txtPhanTramGiam.Font = new Font("Segoe UI", 11.25F);
            txtPhanTramGiam.Location = new Point(160, 127);
            txtPhanTramGiam.Name = "txtPhanTramGiam";
            txtPhanTramGiam.Size = new Size(304, 27);
            txtPhanTramGiam.TabIndex = 12;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Segoe UI", 11.25F);
            txtMaPhieu.Location = new Point(160, 34);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(304, 27);
            txtMaPhieu.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(3, 124);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 11;
            label7.Text = "Phần trăm giảm";
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
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(3, 62);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(3, 93);
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
            dtpNgayTao.Location = new Point(160, 96);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(304, 27);
            dtpNgayTao.TabIndex = 8;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(160, 65);
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
            // rdChoXacNhan
            // 
            rdChoXacNhan.AutoSize = true;
            rdChoXacNhan.Font = new Font("Microsoft Sans Serif", 12F);
            rdChoXacNhan.Location = new Point(192, 174);
            rdChoXacNhan.Name = "rdChoXacNhan";
            rdChoXacNhan.Size = new Size(124, 24);
            rdChoXacNhan.TabIndex = 10;
            rdChoXacNhan.TabStop = true;
            rdChoXacNhan.Text = "Chờ xác nhận";
            rdChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // rdDaThanhToan
            // 
            rdDaThanhToan.AutoSize = true;
            rdDaThanhToan.Font = new Font("Microsoft Sans Serif", 12F);
            rdDaThanhToan.Location = new Point(367, 174);
            rdDaThanhToan.Name = "rdDaThanhToan";
            rdDaThanhToan.Size = new Size(129, 24);
            rdDaThanhToan.TabIndex = 11;
            rdDaThanhToan.TabStop = true;
            rdDaThanhToan.Text = "Đã thanh toán";
            rdDaThanhToan.UseVisualStyleBackColor = true;
            rdDaThanhToan.CheckedChanged += rdDaThanhToan_CheckedChanged;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.Tan;
            groupBox1.Controls.Add(btTim);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(rdDaThanhToan);
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
            // btTim
            // 
            btTim.BorderRadius = 10;
            btTim.CustomizableEdges = customizableEdges21;
            btTim.DisabledState.BorderColor = Color.DarkGray;
            btTim.DisabledState.CustomBorderColor = Color.DarkGray;
            btTim.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btTim.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btTim.FillColor = Color.White;
            btTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTim.ForeColor = Color.Black;
            btTim.Image = Properties.Resources.icons8_search_50;
            btTim.Location = new Point(1012, 22);
            btTim.Name = "btTim";
            btTim.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btTim.Size = new Size(95, 36);
            btTim.TabIndex = 40;
            btTim.Text = "Tìm";
            btTim.Click += btTim_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btLamMoi, 3, 0);
            tableLayoutPanel3.Controls.Add(btThem, 0, 0);
            tableLayoutPanel3.Controls.Add(btSua, 1, 0);
            tableLayoutPanel3.Controls.Add(btXoa, 2, 0);
            tableLayoutPanel3.Location = new Point(584, 130);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(526, 43);
            tableLayoutPanel3.TabIndex = 39;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.BorderRadius = 5;
            btLamMoi.CustomizableEdges = customizableEdges23;
            btLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btLamMoi.FillColor = Color.White;
            btLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Image = Properties.Resources.icons8_refresh_50;
            btLamMoi.Location = new Point(407, 5);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btLamMoi.Size = new Size(104, 33);
            btLamMoi.TabIndex = 12;
            btLamMoi.Text = "Làm mới";
            btLamMoi.Click += btLamMoi_Click;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.BorderRadius = 5;
            btThem.CustomizableEdges = customizableEdges25;
            btThem.DisabledState.BorderColor = Color.DarkGray;
            btThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btThem.FillColor = Color.White;
            btThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btThem.ForeColor = Color.Green;
            btThem.Image = Properties.Resources.icons8_add_24;
            btThem.Location = new Point(14, 5);
            btThem.Name = "btThem";
            btThem.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btThem.Size = new Size(102, 33);
            btThem.TabIndex = 9;
            btThem.Text = "Thêm";
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.BorderRadius = 5;
            btSua.CustomizableEdges = customizableEdges27;
            btSua.DisabledState.BorderColor = Color.DarkGray;
            btSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btSua.FillColor = Color.White;
            btSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Image = Properties.Resources.icons8_fix_50__1_;
            btSua.Location = new Point(145, 5);
            btSua.Name = "btSua";
            btSua.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btSua.Size = new Size(102, 33);
            btSua.TabIndex = 10;
            btSua.Text = "Sửa";
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.BorderRadius = 5;
            btXoa.CustomizableEdges = customizableEdges29;
            btXoa.DisabledState.BorderColor = Color.DarkGray;
            btXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btXoa.FillColor = Color.White;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.ForeColor = Color.Red;
            btXoa.Image = Properties.Resources.icons8_remove_30;
            btXoa.Location = new Point(276, 5);
            btXoa.Name = "btXoa";
            btXoa.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btXoa.Size = new Size(102, 33);
            btXoa.TabIndex = 11;
            btXoa.Text = "Xóa";
            btXoa.Click += btXoa_Click;
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
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtMaPhieu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNgayTao;
        private RadioButton rdChoXacNhan;
        private RadioButton rdDaThanhToan;
        private TextBox txtTim;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cboNhanVien;
        private ComboBox cboMaTheLuuDong;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachPhieu;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btLamMoi;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2Button btTim;
        private TextBox txtPhanTramGiam;
        private Label label7;
    }
}