namespace GUI_PolyCafe
{
    partial class frmLoaiSanPham
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtGhiChuSP = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btThem = new Guna.UI2.WinForms.Guna2Button();
            btSua = new Guna.UI2.WinForms.Guna2Button();
            btXoa = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            txtTenLoaiSP = new TextBox();
            label3 = new Label();
            txtMaLoaiSP = new TextBox();
            label2 = new Label();
            txtTimKiemLoaiSP = new TextBox();
            btnTimKiemLoaiSP = new Button();
            groupBox2 = new GroupBox();
            dgrDanhSachLoaiSP = new Guna.UI2.WinForms.Guna2DataGridView();
            btnTimKiemThe = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btTim = new Button();
            txtTim = new TextBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtGhiChuSP
            // 
            txtGhiChuSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGhiChuSP.Location = new Point(93, 150);
            txtGhiChuSP.Multiline = true;
            txtGhiChuSP.Name = "txtGhiChuSP";
            txtGhiChuSP.Size = new Size(278, 149);
            txtGhiChuSP.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(txtGhiChuSP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenLoaiSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaLoaiSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 423);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Loại ";
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
            btLamMoi.CustomizableEdges = customizableEdges1;
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
            btLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btLamMoi.Size = new Size(90, 36);
            btLamMoi.TabIndex = 12;
            btLamMoi.Text = "Làm mới";
            btLamMoi.Click += btLamMoi_Click;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.BorderRadius = 5;
            btThem.CustomizableEdges = customizableEdges3;
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
            btThem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btThem.Size = new Size(90, 36);
            btThem.TabIndex = 9;
            btThem.Text = "Thêm";
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.BorderRadius = 5;
            btSua.CustomizableEdges = customizableEdges5;
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
            btSua.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btSua.Size = new Size(90, 36);
            btSua.TabIndex = 10;
            btSua.Text = "Sửa";
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.BorderRadius = 5;
            btXoa.CustomizableEdges = customizableEdges7;
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
            btXoa.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btXoa.Size = new Size(90, 36);
            btXoa.TabIndex = 11;
            btXoa.Text = "Xóa";
            btXoa.Click += btXoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(7, 158);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 0;
            label4.Text = "Ghi Chú";
            // 
            // txtTenLoaiSP
            // 
            txtTenLoaiSP.Font = new Font("Segoe UI", 12F);
            txtTenLoaiSP.Location = new Point(93, 97);
            txtTenLoaiSP.Name = "txtTenLoaiSP";
            txtTenLoaiSP.Size = new Size(278, 29);
            txtTenLoaiSP.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 0;
            label3.Text = "Tên Loại";
            // 
            // txtMaLoaiSP
            // 
            txtMaLoaiSP.Font = new Font("Segoe UI", 12F);
            txtMaLoaiSP.Location = new Point(93, 43);
            txtMaLoaiSP.Name = "txtMaLoaiSP";
            txtMaLoaiSP.ReadOnly = true;
            txtMaLoaiSP.Size = new Size(278, 29);
            txtMaLoaiSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(7, 51);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 0;
            label2.Text = "Mã Loại";
            // 
            // txtTimKiemLoaiSP
            // 
            txtTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTimKiemLoaiSP.Location = new Point(1068, 21);
            txtTimKiemLoaiSP.Name = "txtTimKiemLoaiSP";
            txtTimKiemLoaiSP.Size = new Size(213, 23);
            txtTimKiemLoaiSP.TabIndex = 3;
            // 
            // btnTimKiemLoaiSP
            // 
            btnTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemLoaiSP.FlatStyle = FlatStyle.Flat;
            btnTimKiemLoaiSP.Location = new Point(1282, 21);
            btnTimKiemLoaiSP.Name = "btnTimKiemLoaiSP";
            btnTimKiemLoaiSP.Size = new Size(37, 23);
            btnTimKiemLoaiSP.TabIndex = 5;
            btnTimKiemLoaiSP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgrDanhSachLoaiSP);
            groupBox2.Controls.Add(btnTimKiemLoaiSP);
            groupBox2.Controls.Add(btnTimKiemThe);
            groupBox2.Controls.Add(txtTimKiemLoaiSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(429, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(755, 423);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // dgrDanhSachLoaiSP
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgrDanhSachLoaiSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgrDanhSachLoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgrDanhSachLoaiSP.ColumnHeadersHeight = 4;
            dgrDanhSachLoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgrDanhSachLoaiSP.DefaultCellStyle = dataGridViewCellStyle3;
            dgrDanhSachLoaiSP.GridColor = Color.FromArgb(231, 229, 255);
            dgrDanhSachLoaiSP.Location = new Point(12, 22);
            dgrDanhSachLoaiSP.Name = "dgrDanhSachLoaiSP";
            dgrDanhSachLoaiSP.RowHeadersVisible = false;
            dgrDanhSachLoaiSP.Size = new Size(743, 387);
            dgrDanhSachLoaiSP.TabIndex = 6;
            dgrDanhSachLoaiSP.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgrDanhSachLoaiSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgrDanhSachLoaiSP.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgrDanhSachLoaiSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgrDanhSachLoaiSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgrDanhSachLoaiSP.ThemeStyle.BackColor = Color.White;
            dgrDanhSachLoaiSP.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgrDanhSachLoaiSP.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgrDanhSachLoaiSP.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgrDanhSachLoaiSP.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgrDanhSachLoaiSP.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgrDanhSachLoaiSP.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgrDanhSachLoaiSP.ThemeStyle.HeaderStyle.Height = 4;
            dgrDanhSachLoaiSP.ThemeStyle.ReadOnly = false;
            dgrDanhSachLoaiSP.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgrDanhSachLoaiSP.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgrDanhSachLoaiSP.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgrDanhSachLoaiSP.ThemeStyle.RowsStyle.ForeColor = SystemColors.HotTrack;
            dgrDanhSachLoaiSP.ThemeStyle.RowsStyle.Height = 25;
            dgrDanhSachLoaiSP.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgrDanhSachLoaiSP.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgrDanhSachLoaiSP.CellDoubleClick += dgrDanhSachLoaiSP_CellDoubleClick;
            // 
            // btnTimKiemThe
            // 
            btnTimKiemThe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemThe.FlatStyle = FlatStyle.Flat;
            btnTimKiemThe.Location = new Point(1875, 21);
            btnTimKiemThe.Name = "btnTimKiemThe";
            btnTimKiemThe.Size = new Size(37, 24);
            btnTimKiemThe.TabIndex = 4;
            btnTimKiemThe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(448, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 45);
            label1.TabIndex = 9;
            label1.Text = "LOẠI SẢN PHẨM";
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
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.None;
            btTim.Font = new Font("Microsoft Sans Serif", 12F);
            btTim.ForeColor = Color.Black;
            btTim.Location = new Point(1078, 77);
            btTim.Name = "btTim";
            btTim.Size = new Size(100, 36);
            btTim.TabIndex = 13;
            btTim.Text = "Tìm";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.None;
            txtTim.BackColor = Color.White;
            txtTim.Font = new Font("Segoe UI", 11.25F);
            txtTim.Location = new Point(435, 81);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(629, 27);
            txtTim.TabIndex = 12;
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 554);
            Controls.Add(btTim);
            Controls.Add(txtTim);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmLoaiSanPham";
            Text = "frmLoaiSanPham";
            Load += frmLoaiSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtGhiChuSP;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtTenLoaiSP;
        private Label label3;
        private TextBox txtMaLoaiSP;
        private Label label2;
        private TextBox txtTimKiemLoaiSP;
        private Button btnTimKiemLoaiSP;
        private GroupBox groupBox2;
        private Button btnTimKiemThe;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btTim;
        private TextBox txtTim;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btLamMoi;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgrDanhSachLoaiSP;
    }
}