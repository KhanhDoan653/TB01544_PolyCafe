namespace GUI_PolyCafe
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtMaNhanVien = new TextBox();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtXacNhanMK = new TextBox();
            txtMatKhau = new TextBox();
            chkHienMK = new CheckBox();
            chkHienMK2 = new CheckBox();
            label6 = new Label();
            rbtNhanVien = new RadioButton();
            rbtQuanLy = new RadioButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvDanhSachNV = new DataGridView();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label8 = new Label();
            rbtHoatDong = new RadioButton();
            rbtNgungHD = new RadioButton();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox6 = new TextBox();
            btTim = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            btLamMoi = new Button();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.8553467F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.14465F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 212F));
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtMaNhanVien, 1, 0);
            tableLayoutPanel1.Controls.Add(txtHoTen, 1, 1);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(txtXacNhanMK, 1, 4);
            tableLayoutPanel1.Controls.Add(txtMatKhau, 1, 3);
            tableLayoutPanel1.Controls.Add(chkHienMK, 2, 3);
            tableLayoutPanel1.Controls.Add(chkHienMK2, 2, 4);
            tableLayoutPanel1.Location = new Point(37, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(849, 134);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Goldenrod;
            label5.Location = new Point(3, 104);
            label5.Name = "label5";
            label5.Size = new Size(130, 17);
            label5.TabIndex = 4;
            label5.Text = "Xác Nhận Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(3, 52);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 1;
            label2.Text = "Họ Và Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Goldenrod;
            label4.Location = new Point(3, 78);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 3;
            label4.Text = "Mật Khẩu";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Anchor = AnchorStyles.None;
            txtMaNhanVien.BackColor = Color.White;
            txtMaNhanVien.Location = new Point(142, 3);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(491, 23);
            txtMaNhanVien.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.None;
            txtHoTen.BackColor = Color.White;
            txtHoTen.Location = new Point(142, 29);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(491, 23);
            txtHoTen.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(142, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(491, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Anchor = AnchorStyles.None;
            txtXacNhanMK.BackColor = Color.White;
            txtXacNhanMK.Location = new Point(142, 107);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(491, 23);
            txtXacNhanMK.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.None;
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.Location = new Point(142, 81);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(491, 23);
            txtMatKhau.TabIndex = 9;
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            chkHienMK.ForeColor = Color.Goldenrod;
            chkHienMK.Location = new Point(639, 81);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(119, 20);
            chkHienMK.TabIndex = 10;
            chkHienMK.Text = "Hiện Mật Khẩu";
            chkHienMK.UseVisualStyleBackColor = true;
            // 
            // chkHienMK2
            // 
            chkHienMK2.AutoSize = true;
            chkHienMK2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            chkHienMK2.ForeColor = Color.Goldenrod;
            chkHienMK2.Location = new Point(639, 107);
            chkHienMK2.Name = "chkHienMK2";
            chkHienMK2.Size = new Size(119, 21);
            chkHienMK2.TabIndex = 11;
            chkHienMK2.Text = "Hiện Mật Khẩu";
            chkHienMK2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Goldenrod;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 1;
            label6.Text = "Vai trò";
            // 
            // rbtNhanVien
            // 
            rbtNhanVien.AutoSize = true;
            rbtNhanVien.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rbtNhanVien.ForeColor = Color.Goldenrod;
            rbtNhanVien.Location = new Point(304, 3);
            rbtNhanVien.Name = "rbtNhanVien";
            rbtNhanVien.Size = new Size(89, 21);
            rbtNhanVien.TabIndex = 2;
            rbtNhanVien.TabStop = true;
            rbtNhanVien.Text = "Nhân viên";
            rbtNhanVien.UseVisualStyleBackColor = true;
            // 
            // rbtQuanLy
            // 
            rbtQuanLy.AutoSize = true;
            rbtQuanLy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rbtQuanLy.ForeColor = Color.Goldenrod;
            rbtQuanLy.Location = new Point(145, 3);
            rbtQuanLy.Name = "rbtQuanLy";
            rbtQuanLy.Size = new Size(74, 21);
            rbtQuanLy.TabIndex = 3;
            rbtQuanLy.TabStop = true;
            rbtQuanLy.Text = "Quản lý";
            rbtQuanLy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.72556F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7279148F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.546524F));
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(rbtQuanLy, 1, 0);
            tableLayoutPanel2.Controls.Add(rbtNhanVien, 2, 0);
            tableLayoutPanel2.Location = new Point(37, 149);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2142868F));
            tableLayoutPanel2.Size = new Size(849, 31);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // dgvDanhSachNV
            // 
            dgvDanhSachNV.BackgroundColor = SystemColors.ControlLight;
            dgvDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNV.Location = new Point(6, 19);
            dgvDanhSachNV.Name = "dgvDanhSachNV";
            dgvDanhSachNV.Size = new Size(506, 162);
            dgvDanhSachNV.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(35, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 210);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(rbtHoatDong);
            panel1.Controls.Add(rbtNgungHD);
            panel1.Location = new Point(37, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 28);
            panel1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Goldenrod;
            label8.Location = new Point(9, 6);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 7;
            label8.Text = "Trạng Thái";
            // 
            // rbtHoatDong
            // 
            rbtHoatDong.AutoSize = true;
            rbtHoatDong.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rbtHoatDong.ForeColor = Color.Goldenrod;
            rbtHoatDong.Location = new Point(142, 4);
            rbtHoatDong.Name = "rbtHoatDong";
            rbtHoatDong.Size = new Size(92, 21);
            rbtHoatDong.TabIndex = 9;
            rbtHoatDong.TabStop = true;
            rbtHoatDong.Text = "Hoạt động";
            rbtHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtNgungHD
            // 
            rbtNgungHD.AutoSize = true;
            rbtNgungHD.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rbtNgungHD.ForeColor = Color.Goldenrod;
            rbtNgungHD.Location = new Point(304, 4);
            rbtNgungHD.Name = "rbtNgungHD";
            rbtNgungHD.Size = new Size(137, 21);
            rbtNgungHD.TabIndex = 8;
            rbtNgungHD.TabStop = true;
            rbtNgungHD.Text = "Ngừng hoạt động";
            rbtNgungHD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Controls.Add(dgvDanhSachNV);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(35, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(906, 187);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(textBox6, 0, 0);
            tableLayoutPanel4.Controls.Add(btTim, 1, 0);
            tableLayoutPanel4.Location = new Point(518, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(368, 42);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BackColor = Color.White;
            textBox6.Location = new Point(3, 9);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(270, 23);
            textBox6.TabIndex = 0;
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.None;
            btTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btTim.ForeColor = Color.Black;
            btTim.Location = new Point(281, 3);
            btTim.Name = "btTim";
            btTim.Size = new Size(82, 36);
            btTim.TabIndex = 1;
            btTim.Text = "Tìm";
            btTim.UseVisualStyleBackColor = true;
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
            tableLayoutPanel3.Location = new Point(518, 139);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(368, 42);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.ForeColor = Color.Green;
            btThem.Location = new Point(5, 3);
            btThem.Name = "btThem";
            btThem.Size = new Size(82, 36);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Location = new Point(97, 3);
            btSua.Name = "btSua";
            btSua.Size = new Size(82, 36);
            btSua.TabIndex = 1;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.ForeColor = Color.Red;
            btXoa.Location = new Point(189, 3);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(82, 36);
            btXoa.TabIndex = 2;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Location = new Point(281, 3);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(82, 36);
            btLamMoi.TabIndex = 3;
            btLamMoi.Text = "Làm Mới";
            btLamMoi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Tan;
            label7.Location = new Point(434, 9);
            label7.Name = "label7";
            label7.Size = new Size(150, 32);
            label7.TabIndex = 8;
            label7.Text = "NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(971, 439);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtMaNhanVien;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtXacNhanMK;
        private TextBox txtMatKhau;
        private Label label6;
        private RadioButton rbtNhanVien;
        private RadioButton rbtQuanLy;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvDanhSachNV;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkHienMK;
        private CheckBox chkHienMK2;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox6;
        private Button btTim;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private Button btLamMoi;
        private Panel panel1;
        private Label label8;
        private RadioButton rbtHoatDong;
        private RadioButton rbtNgungHD;
    }
}