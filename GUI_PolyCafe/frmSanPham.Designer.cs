namespace GUI_PolyCafe
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            groupBox1 = new GroupBox();
            txtHinhAnh = new MaskedTextBox();
            label8 = new Label();
            rdNgungBan = new RadioButton();
            label2 = new Label();
            rdHoatDong = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenSanPham = new TextBox();
            txtDonGia = new MaskedTextBox();
            cboLoaiSanPham = new ComboBox();
            txtMaSanPham = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            btLamMoi = new Button();
            pbHinhAnh = new PictureBox();
            btUpAnh = new Button();
            groupBox2 = new GroupBox();
            btTim = new Button();
            txtTimKiemSP = new TextBox();
            dgvDanhSachSP = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.FromArgb(232, 220, 204);
            groupBox1.Controls.Add(txtHinhAnh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(rdNgungBan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdHoatDong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(pbHinhAnh);
            groupBox1.Controls.Add(btUpAnh);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 384);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Font = new Font("Segoe UI", 12F);
            txtHinhAnh.Location = new Point(247, 298);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(126, 29);
            txtHinhAnh.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(37, 173);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 32;
            label8.Text = "Trạng Thái";
            // 
            // rdNgungBan
            // 
            rdNgungBan.AutoSize = true;
            rdNgungBan.Font = new Font("Segoe UI", 10F);
            rdNgungBan.ForeColor = Color.Maroon;
            rdNgungBan.Location = new Point(288, 176);
            rdNgungBan.Name = "rdNgungBan";
            rdNgungBan.Size = new Size(96, 23);
            rdNgungBan.TabIndex = 35;
            rdNgungBan.Text = "Ngừng Bán";
            rdNgungBan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(37, 33);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 26;
            label2.Text = "Mã Sản Phẩm";
            // 
            // rdHoatDong
            // 
            rdHoatDong.AutoSize = true;
            rdHoatDong.BackColor = Color.Transparent;
            rdHoatDong.Checked = true;
            rdHoatDong.Font = new Font("Segoe UI", 9F);
            rdHoatDong.ForeColor = Color.Maroon;
            rdHoatDong.Location = new Point(144, 176);
            rdHoatDong.Name = "rdHoatDong";
            rdHoatDong.Size = new Size(83, 19);
            rdHoatDong.TabIndex = 34;
            rdHoatDong.TabStop = true;
            rdHoatDong.Text = "Hoạt Động";
            rdHoatDong.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(37, 68);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 27;
            label3.Text = "Tên Sản Phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(37, 103);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 28;
            label4.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(37, 138);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 29;
            label5.Text = "Loại Sản Phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Segoe UI", 12F);
            txtTenSanPham.Location = new Point(144, 68);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(279, 29);
            txtTenSanPham.TabIndex = 30;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.Location = new Point(144, 103);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(279, 29);
            txtDonGia.TabIndex = 33;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Font = new Font("Segoe UI", 11F);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(144, 138);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(279, 28);
            cboLoaiSanPham.TabIndex = 36;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Segoe UI", 12F);
            txtMaSanPham.Location = new Point(144, 33);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(279, 29);
            txtMaSanPham.TabIndex = 31;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btThem, 0, 0);
            tableLayoutPanel2.Controls.Add(btSua, 1, 0);
            tableLayoutPanel2.Controls.Add(btXoa, 2, 0);
            tableLayoutPanel2.Controls.Add(btLamMoi, 3, 0);
            tableLayoutPanel2.Location = new Point(30, 333);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(393, 47);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.BackColor = SystemColors.Window;
            btThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btThem.ForeColor = Color.Green;
            btThem.Location = new Point(9, 3);
            btThem.Name = "btThem";
            btThem.Size = new Size(80, 41);
            btThem.TabIndex = 3;
            btThem.Text = "Thêm";
            btThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.BackColor = SystemColors.Window;
            btSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Location = new Point(107, 3);
            btSua.Name = "btSua";
            btSua.Size = new Size(80, 41);
            btSua.TabIndex = 3;
            btSua.Text = "Sửa";
            btSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.BackColor = SystemColors.Window;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.ForeColor = Color.Red;
            btXoa.Location = new Point(205, 3);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(80, 41);
            btXoa.TabIndex = 3;
            btXoa.Text = "Xóa";
            btXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.BackColor = SystemColors.Window;
            btLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Location = new Point(303, 3);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(80, 41);
            btLamMoi.TabIndex = 3;
            btLamMoi.Text = "Mới";
            btLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btLamMoi.UseVisualStyleBackColor = false;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            pbHinhAnh.Location = new Point(30, 202);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(215, 125);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinhAnh.TabIndex = 24;
            pbHinhAnh.TabStop = false;
            // 
            // btUpAnh
            // 
            btUpAnh.BackColor = SystemColors.Window;
            btUpAnh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btUpAnh.Location = new Point(376, 300);
            btUpAnh.Name = "btUpAnh";
            btUpAnh.Size = new Size(75, 26);
            btUpAnh.TabIndex = 23;
            btUpAnh.Text = "Chọn ảnh";
            btUpAnh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btUpAnh.UseVisualStyleBackColor = false;
            btUpAnh.Click += btUpAnh_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(232, 220, 204);
            groupBox2.Controls.Add(btTim);
            groupBox2.Controls.Add(txtTimKiemSP);
            groupBox2.Controls.Add(dgvDanhSachSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(469, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 384);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản phẩm";
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btTim.FlatStyle = FlatStyle.Flat;
            btTim.ForeColor = SystemColors.HotTrack;
            btTim.Location = new Point(414, 24);
            btTim.Name = "btTim";
            btTim.Size = new Size(76, 24);
            btTim.TabIndex = 8;
            btTim.Text = "Tìm kiếm";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemSP.Location = new Point(6, 25);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(402, 23);
            txtTimKiemSP.TabIndex = 6;
            // 
            // dgvDanhSachSP
            // 
            dgvDanhSachSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSP.Location = new Point(6, 54);
            dgvDanhSachSP.Name = "dgvDanhSachSP";
            dgvDanhSachSP.ReadOnly = true;
            dgvDanhSachSP.RowHeadersWidth = 51;
            dgvDanhSachSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachSP.Size = new Size(484, 324);
            dgvDanhSachSP.TabIndex = 0;
            dgvDanhSachSP.CellDoubleClick += dgvDanhSachSP_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(391, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 7;
            label1.Text = "SẢN PHẨM";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(977, 439);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btTim;
        private TextBox txtTimKiemSP;
        private DataGridView dgvDanhSachSP;
        private Label label8;
        private RadioButton rdNgungBan;
        private Label label2;
        private RadioButton rdHoatDong;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTenSanPham;
        private MaskedTextBox txtDonGia;
        private ComboBox cboLoaiSanPham;
        private TextBox txtMaSanPham;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pbHinhAnh;
        private Button btUpAnh;
        private Label label1;
        private MaskedTextBox txtHinhAnh;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private Button btLamMoi;
    }
}