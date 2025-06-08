namespace GUI_PolyCafe
{
    partial class frmChiTietPhieu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnXoaChiTiet = new Button();
            btnThemChiTiet = new Button();
            dgrSanPham = new DataGridView();
            label9 = new Label();
            groupBox1 = new GroupBox();
            txtPhanTram = new TextBox();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            txtDichVu = new TextBox();
            txtTong = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgrChiTiet = new DataGridView();
            label4 = new Label();
            lbMaPhieu = new Label();
            label3 = new Label();
            lbChuSoHuu = new Label();
            lbNgayLap = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoaChiTiet
            // 
            btnXoaChiTiet.Location = new Point(572, 258);
            btnXoaChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.Size = new Size(53, 22);
            btnXoaChiTiet.TabIndex = 18;
            btnXoaChiTiet.Text = ">>";
            btnXoaChiTiet.UseVisualStyleBackColor = true;
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Location = new Point(572, 197);
            btnThemChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(53, 22);
            btnThemChiTiet.TabIndex = 19;
            btnThemChiTiet.Text = "<<";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // dgrSanPham
            // 
            dgrSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            dgrSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrSanPham.Location = new Point(651, 117);
            dgrSanPham.Margin = new Padding(3, 2, 3, 2);
            dgrSanPham.Name = "dgrSanPham";
            dgrSanPham.ReadOnly = true;
            dgrSanPham.RowHeadersWidth = 51;
            dgrSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrSanPham.Size = new Size(503, 359);
            dgrSanPham.TabIndex = 17;
            dgrSanPham.CellDoubleClick += dgrSanPham_CellDoubleClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 63);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 3;
            label9.Text = "%";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPhanTram);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtDichVu);
            groupBox1.Controls.Add(txtTong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(47, 350);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(496, 126);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thanh Toán";
            // 
            // txtPhanTram
            // 
            txtPhanTram.Location = new Point(107, 60);
            txtPhanTram.Margin = new Padding(3, 2, 3, 2);
            txtPhanTram.Name = "txtPhanTram";
            txtPhanTram.Size = new Size(56, 23);
            txtPhanTram.TabIndex = 2;
            txtPhanTram.TextChanged += txtPhanTram_TextChanged;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(107, 96);
            txtThanhTien.Margin = new Padding(3, 2, 3, 2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(368, 23);
            txtThanhTien.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(201, 60);
            txtGiamGia.Margin = new Padding(3, 2, 3, 2);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.ReadOnly = true;
            txtGiamGia.Size = new Size(274, 23);
            txtGiamGia.TabIndex = 1;
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(389, 22);
            txtDichVu.Margin = new Padding(3, 2, 3, 2);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.ReadOnly = true;
            txtDichVu.Size = new Size(86, 23);
            txtDichVu.TabIndex = 1;
            txtDichVu.TextChanged += txtDichVu_TextChanged;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(92, 22);
            txtTong.Margin = new Padding(3, 2, 3, 2);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(216, 23);
            txtTong.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(13, 99);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 0;
            label8.Text = "Thành Tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(13, 62);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 0;
            label7.Text = "Giảm Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(314, 25);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 0;
            label6.Text = "Dịch Vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(13, 23);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 0;
            label5.Text = "Tổng :";
            // 
            // dgrChiTiet
            // 
            dgrChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrChiTiet.BackgroundColor = SystemColors.ButtonHighlight;
            dgrChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrChiTiet.Location = new Point(47, 117);
            dgrChiTiet.Margin = new Padding(3, 2, 3, 2);
            dgrChiTiet.Name = "dgrChiTiet";
            dgrChiTiet.RowHeadersWidth = 51;
            dgrChiTiet.Size = new Size(496, 217);
            dgrChiTiet.TabIndex = 15;
            dgrChiTiet.CellEndEdit += dgrChiTiet_CellEndEdit;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(847, 90);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày Lập:";
            // 
            // lbMaPhieu
            // 
            lbMaPhieu.AutoSize = true;
            lbMaPhieu.Font = new Font("Microsoft Sans Serif", 12F);
            lbMaPhieu.ForeColor = Color.Maroon;
            lbMaPhieu.Location = new Point(615, 90);
            lbMaPhieu.Name = "lbMaPhieu";
            lbMaPhieu.Size = new Size(75, 20);
            lbMaPhieu.TabIndex = 10;
            lbMaPhieu.Text = "Mã Phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(525, 90);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 11;
            label3.Text = "Mã Phiếu:";
            // 
            // lbChuSoHuu
            // 
            lbChuSoHuu.AutoSize = true;
            lbChuSoHuu.Font = new Font("Microsoft Sans Serif", 12F);
            lbChuSoHuu.ForeColor = Color.Maroon;
            lbChuSoHuu.Location = new Point(261, 90);
            lbChuSoHuu.Name = "lbChuSoHuu";
            lbChuSoHuu.Size = new Size(75, 20);
            lbChuSoHuu.TabIndex = 12;
            lbChuSoHuu.Text = "Mã Phiếu";
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Microsoft Sans Serif", 12F);
            lbNgayLap.ForeColor = Color.Maroon;
            lbNgayLap.Location = new Point(937, 90);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(75, 20);
            lbNgayLap.TabIndex = 13;
            lbNgayLap.Text = "Mã Phiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(154, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 14;
            label2.Text = "Chủ Sở Hữu:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(371, 2);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 8;
            label1.Text = "CHI TIẾT PHIẾU BÁN HÀNG";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(47, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1107, 41);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BorderRadius = 10;
            btnXacNhan.CustomizableEdges = customizableEdges1;
            btnXacNhan.DisabledState.BorderColor = Color.DarkGray;
            btnXacNhan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXacNhan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXacNhan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXacNhan.Font = new Font("Segoe UI", 9F);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(47, 481);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXacNhan.Size = new Size(180, 45);
            btnXacNhan.TabIndex = 21;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // frmChiTietPhieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 554);
            Controls.Add(btnXacNhan);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnXoaChiTiet);
            Controls.Add(btnThemChiTiet);
            Controls.Add(dgrSanPham);
            Controls.Add(groupBox1);
            Controls.Add(dgrChiTiet);
            Controls.Add(label4);
            Controls.Add(lbMaPhieu);
            Controls.Add(label3);
            Controls.Add(lbChuSoHuu);
            Controls.Add(lbNgayLap);
            Controls.Add(label2);
            Name = "frmChiTietPhieu";
            Text = "frmChiTietPhieu";
            Load += frmChiTietPhieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoaChiTiet;
        private Button btnThemChiTiet;
        private DataGridView dgrSanPham;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox txtPhanTram;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private TextBox txtDichVu;
        private TextBox txtTong;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgrChiTiet;
        private Label label4;
        private Label lbMaPhieu;
        private Label label3;
        private Label lbChuSoHuu;
        private Label lbNgayLap;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
    }
}