namespace GUI_PolyCafe
{
    partial class frmCoSoVatChat
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label5 = new Label();
            txtMaCS = new TextBox();
            groupBox1 = new GroupBox();
            cboChiNhanh = new Guna.UI2.WinForms.Guna2ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btThem = new Guna.UI2.WinForms.Guna2Button();
            btSua = new Guna.UI2.WinForms.Guna2Button();
            btXoa = new Guna.UI2.WinForms.Guna2Button();
            txtSoLuong = new TextBox();
            label4 = new Label();
            txtTenCS = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgrDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            btnTimKiemThe = new Button();
            btnTimKiemLoaiSP = new Button();
            txtTimKiemLoaiSP = new TextBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnLoc = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtTim = new TextBox();
            btTim = new Guna.UI2.WinForms.Guna2Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSach).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(7, 210);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 40;
            label5.Text = "Mã chi nhánh";
            // 
            // txtMaCS
            // 
            txtMaCS.Font = new Font("Segoe UI", 12F);
            txtMaCS.Location = new Point(113, 43);
            txtMaCS.Name = "txtMaCS";
            txtMaCS.ReadOnly = true;
            txtMaCS.Size = new Size(258, 29);
            txtMaCS.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cboChiNhanh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenCS);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaCS);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 423);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cboChiNhanh
            // 
            cboChiNhanh.BackColor = Color.Transparent;
            cboChiNhanh.CustomizableEdges = customizableEdges15;
            cboChiNhanh.DrawMode = DrawMode.OwnerDrawFixed;
            cboChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChiNhanh.FocusedColor = Color.FromArgb(94, 148, 255);
            cboChiNhanh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboChiNhanh.Font = new Font("Segoe UI", 10F);
            cboChiNhanh.ForeColor = Color.FromArgb(68, 88, 112);
            cboChiNhanh.ItemHeight = 30;
            cboChiNhanh.Location = new Point(113, 210);
            cboChiNhanh.Name = "cboChiNhanh";
            cboChiNhanh.ShadowDecoration.CustomizableEdges = customizableEdges16;
            cboChiNhanh.Size = new Size(258, 36);
            cboChiNhanh.TabIndex = 41;
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
            tableLayoutPanel3.Location = new Point(6, 356);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(384, 61);
            tableLayoutPanel3.TabIndex = 39;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.BorderRadius = 5;
            btLamMoi.CustomizableEdges = customizableEdges17;
            btLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btLamMoi.FillColor = Color.White;
            btLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Image = Properties.Resources.icons8_refresh_50;
            btLamMoi.Location = new Point(291, 12);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btLamMoi.Size = new Size(90, 36);
            btLamMoi.TabIndex = 12;
            btLamMoi.Text = "Làm mới";
            btLamMoi.Click += btLamMoi_Click;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.BorderRadius = 5;
            btThem.CustomizableEdges = customizableEdges19;
            btThem.DisabledState.BorderColor = Color.DarkGray;
            btThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btThem.FillColor = Color.White;
            btThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btThem.ForeColor = Color.Green;
            btThem.Image = Properties.Resources.icons8_add_24;
            btThem.Location = new Point(3, 12);
            btThem.Name = "btThem";
            btThem.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btThem.Size = new Size(90, 36);
            btThem.TabIndex = 9;
            btThem.Text = "Thêm";
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.BorderRadius = 5;
            btSua.CustomizableEdges = customizableEdges21;
            btSua.DisabledState.BorderColor = Color.DarkGray;
            btSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btSua.FillColor = Color.White;
            btSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Image = Properties.Resources.icons8_fix_50__1_;
            btSua.Location = new Point(99, 12);
            btSua.Name = "btSua";
            btSua.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btSua.Size = new Size(90, 36);
            btSua.TabIndex = 10;
            btSua.Text = "Sửa";
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.BorderRadius = 5;
            btXoa.CustomizableEdges = customizableEdges23;
            btXoa.DisabledState.BorderColor = Color.DarkGray;
            btXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btXoa.FillColor = Color.White;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.ForeColor = Color.Red;
            btXoa.Image = Properties.Resources.icons8_remove_30;
            btXoa.Location = new Point(195, 12);
            btXoa.Name = "btXoa";
            btXoa.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btXoa.Size = new Size(90, 36);
            btXoa.TabIndex = 11;
            btXoa.Text = "Xóa";
            btXoa.Click += btXoa_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(113, 150);
            txtSoLuong.Multiline = true;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(258, 26);
            txtSoLuong.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(7, 158);
            label4.Name = "label4";
            label4.Size = new Size(67, 18);
            label4.TabIndex = 0;
            label4.Text = "Số lượng";
            // 
            // txtTenCS
            // 
            txtTenCS.Font = new Font("Segoe UI", 12F);
            txtTenCS.Location = new Point(113, 97);
            txtTenCS.Name = "txtTenCS";
            txtTenCS.Size = new Size(258, 29);
            txtTenCS.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(78, 18);
            label3.TabIndex = 0;
            label3.Text = "Tên CSVC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(7, 51);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 0;
            label2.Text = "Mã CSVC";
            // 
            // dgrDanhSach
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgrDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgrDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgrDanhSach.ColumnHeadersHeight = 20;
            dgrDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgrDanhSach.DefaultCellStyle = dataGridViewCellStyle6;
            dgrDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgrDanhSach.Location = new Point(12, 22);
            dgrDanhSach.Name = "dgrDanhSach";
            dgrDanhSach.RowHeadersVisible = false;
            dgrDanhSach.Size = new Size(743, 387);
            dgrDanhSach.TabIndex = 6;
            dgrDanhSach.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgrDanhSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgrDanhSach.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgrDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgrDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgrDanhSach.ThemeStyle.BackColor = Color.White;
            dgrDanhSach.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgrDanhSach.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgrDanhSach.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgrDanhSach.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgrDanhSach.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgrDanhSach.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgrDanhSach.ThemeStyle.HeaderStyle.Height = 20;
            dgrDanhSach.ThemeStyle.ReadOnly = false;
            dgrDanhSach.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgrDanhSach.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgrDanhSach.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgrDanhSach.ThemeStyle.RowsStyle.ForeColor = SystemColors.HotTrack;
            dgrDanhSach.ThemeStyle.RowsStyle.Height = 25;
            dgrDanhSach.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgrDanhSach.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgrDanhSach.CellDoubleClick += dgrDanhSach_CellDoubleClick;
            // 
            // btnTimKiemThe
            // 
            btnTimKiemThe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemThe.FlatStyle = FlatStyle.Flat;
            btnTimKiemThe.Location = new Point(2985, 21);
            btnTimKiemThe.Name = "btnTimKiemThe";
            btnTimKiemThe.Size = new Size(37, 24);
            btnTimKiemThe.TabIndex = 4;
            btnTimKiemThe.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemLoaiSP
            // 
            btnTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemLoaiSP.FlatStyle = FlatStyle.Flat;
            btnTimKiemLoaiSP.Location = new Point(2392, 21);
            btnTimKiemLoaiSP.Name = "btnTimKiemLoaiSP";
            btnTimKiemLoaiSP.Size = new Size(37, 23);
            btnTimKiemLoaiSP.TabIndex = 5;
            btnTimKiemLoaiSP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemLoaiSP
            // 
            txtTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTimKiemLoaiSP.Location = new Point(2178, 21);
            txtTimKiemLoaiSP.Name = "txtTimKiemLoaiSP";
            txtTimKiemLoaiSP.Size = new Size(213, 23);
            txtTimKiemLoaiSP.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgrDanhSach);
            groupBox2.Controls.Add(btnTimKiemLoaiSP);
            groupBox2.Controls.Add(btnTimKiemThe);
            groupBox2.Controls.Add(txtTimKiemLoaiSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(429, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(755, 423);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(443, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 45);
            label1.TabIndex = 9;
            label1.Text = "CƠ SỞ VẬT CHẤT";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1172, 46);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnLoc
            // 
            btnLoc.BorderRadius = 10;
            btnLoc.CustomizableEdges = customizableEdges25;
            btnLoc.DisabledState.BorderColor = Color.DarkGray;
            btnLoc.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLoc.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLoc.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLoc.Font = new Font("Segoe UI", 9F);
            btnLoc.ForeColor = Color.White;
            btnLoc.Image = Properties.Resources.filter_144px;
            btnLoc.ImageSize = new Size(30, 30);
            btnLoc.Location = new Point(544, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnLoc.Size = new Size(86, 36);
            btnLoc.TabIndex = 24;
            btnLoc.Click += btnLoc_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.4660339F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5339651F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel4.Controls.Add(txtTim, 0, 0);
            tableLayoutPanel4.Controls.Add(btnLoc, 1, 0);
            tableLayoutPanel4.Controls.Add(btTim, 2, 0);
            tableLayoutPanel4.Location = new Point(429, 71);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(755, 42);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.None;
            txtTim.Location = new Point(3, 9);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(535, 23);
            txtTim.TabIndex = 0;
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.None;
            btTim.BorderRadius = 10;
            btTim.CustomizableEdges = customizableEdges27;
            btTim.DisabledState.BorderColor = Color.DarkGray;
            btTim.DisabledState.CustomBorderColor = Color.DarkGray;
            btTim.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btTim.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btTim.FillColor = Color.White;
            btTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTim.ForeColor = Color.Black;
            btTim.Image = Properties.Resources.icons8_search_50;
            btTim.Location = new Point(644, 5);
            btTim.Name = "btTim";
            btTim.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btTim.Size = new Size(99, 32);
            btTim.TabIndex = 8;
            btTim.Text = "Tìm";
            btTim.Click += btTim_Click;
            // 
            // frmCoSoVatChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1196, 554);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCoSoVatChat";
            Text = "frmCoSoVatChat";
            Load += frmCoSoVatChat_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrDanhSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private TextBox txtMaCS;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btLamMoi;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private TextBox txtSoLuong;
        private Label label4;
        private TextBox txtTenCS;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgrDanhSach;
        private Button btnTimKiemThe;
        private Button btnTimKiemLoaiSP;
        private TextBox txtTimKiemLoaiSP;
        private GroupBox groupBox2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboChiNhanh;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2Button btnLoc;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtTim;
        private Guna.UI2.WinForms.Guna2Button btTim;
    }
}