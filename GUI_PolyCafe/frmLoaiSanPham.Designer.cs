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
            btnSuaLoaiSP = new Button();
            btnThemLoaiSP = new Button();
            txtGhiChuSP = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnMoiLoaiSP = new Button();
            btnXoaLoaiSP = new Button();
            label4 = new Label();
            txtTenLoaiSP = new TextBox();
            label3 = new Label();
            txtMaLoaiSP = new TextBox();
            label2 = new Label();
            txtTimKiemLoaiSP = new TextBox();
            btnTimKiemLoaiSP = new Button();
            groupBox2 = new GroupBox();
            btnTimKiemThe = new Button();
            dgrDanhSachLoaiSP = new DataGridView();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btTim = new Button();
            txtTim = new TextBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSuaLoaiSP
            // 
            btnSuaLoaiSP.Anchor = AnchorStyles.None;
            btnSuaLoaiSP.BackColor = SystemColors.Window;
            btnSuaLoaiSP.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnSuaLoaiSP.ForeColor = Color.DarkOrange;
            btnSuaLoaiSP.Location = new Point(105, 6);
            btnSuaLoaiSP.Name = "btnSuaLoaiSP";
            btnSuaLoaiSP.Size = new Size(75, 41);
            btnSuaLoaiSP.TabIndex = 5;
            btnSuaLoaiSP.Text = "Sửa";
            btnSuaLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaLoaiSP.UseVisualStyleBackColor = false;
            btnSuaLoaiSP.Click += btnSuaLoaiSP_Click;
            // 
            // btnThemLoaiSP
            // 
            btnThemLoaiSP.Anchor = AnchorStyles.None;
            btnThemLoaiSP.BackColor = SystemColors.Window;
            btnThemLoaiSP.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnThemLoaiSP.ForeColor = Color.Green;
            btnThemLoaiSP.Location = new Point(7, 6);
            btnThemLoaiSP.Name = "btnThemLoaiSP";
            btnThemLoaiSP.Size = new Size(81, 41);
            btnThemLoaiSP.TabIndex = 4;
            btnThemLoaiSP.Text = "Thêm";
            btnThemLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemLoaiSP.UseVisualStyleBackColor = false;
            btnThemLoaiSP.Click += btnThemLoaiSP_Click;
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
            groupBox1.Controls.Add(tableLayoutPanel2);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnThemLoaiSP, 0, 0);
            tableLayoutPanel2.Controls.Add(btnMoiLoaiSP, 3, 0);
            tableLayoutPanel2.Controls.Add(btnSuaLoaiSP, 1, 0);
            tableLayoutPanel2.Controls.Add(btnXoaLoaiSP, 2, 0);
            tableLayoutPanel2.Location = new Point(6, 336);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(383, 53);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // btnMoiLoaiSP
            // 
            btnMoiLoaiSP.Anchor = AnchorStyles.None;
            btnMoiLoaiSP.BackColor = SystemColors.Window;
            btnMoiLoaiSP.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnMoiLoaiSP.ForeColor = Color.DarkCyan;
            btnMoiLoaiSP.Location = new Point(292, 6);
            btnMoiLoaiSP.Name = "btnMoiLoaiSP";
            btnMoiLoaiSP.Size = new Size(84, 41);
            btnMoiLoaiSP.TabIndex = 7;
            btnMoiLoaiSP.Text = "Mới";
            btnMoiLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiLoaiSP.UseVisualStyleBackColor = false;
            btnMoiLoaiSP.Click += btnMoiLoaiSP_Click;
            // 
            // btnXoaLoaiSP
            // 
            btnXoaLoaiSP.Anchor = AnchorStyles.None;
            btnXoaLoaiSP.BackColor = SystemColors.Window;
            btnXoaLoaiSP.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnXoaLoaiSP.ForeColor = Color.Red;
            btnXoaLoaiSP.Location = new Point(197, 6);
            btnXoaLoaiSP.Name = "btnXoaLoaiSP";
            btnXoaLoaiSP.Size = new Size(80, 41);
            btnXoaLoaiSP.TabIndex = 6;
            btnXoaLoaiSP.Text = "Xóa";
            btnXoaLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaLoaiSP.UseVisualStyleBackColor = false;
            btnXoaLoaiSP.Click += btnXoaLoaiSP_Click;
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
            groupBox2.Controls.Add(btnTimKiemLoaiSP);
            groupBox2.Controls.Add(btnTimKiemThe);
            groupBox2.Controls.Add(txtTimKiemLoaiSP);
            groupBox2.Controls.Add(dgrDanhSachLoaiSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(429, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(755, 423);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Loại Sản Phẩm";
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
            // dgrDanhSachLoaiSP
            // 
            dgrDanhSachLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachLoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrDanhSachLoaiSP.BackgroundColor = Color.White;
            dgrDanhSachLoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachLoaiSP.Location = new Point(6, 22);
            dgrDanhSachLoaiSP.Name = "dgrDanhSachLoaiSP";
            dgrDanhSachLoaiSP.ReadOnly = true;
            dgrDanhSachLoaiSP.RowHeadersWidth = 51;
            dgrDanhSachLoaiSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachLoaiSP.Size = new Size(743, 395);
            dgrDanhSachLoaiSP.TabIndex = 0;
            dgrDanhSachLoaiSP.CellDoubleClick += dgrDanhSachLoaiSP_CellDoubleClick;
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
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuaLoaiSP;
        private Button btnThemLoaiSP;
        private TextBox txtGhiChuSP;
        private GroupBox groupBox1;
        private Button btnMoiLoaiSP;
        private Button btnXoaLoaiSP;
        private Label label4;
        private TextBox txtTenLoaiSP;
        private Label label3;
        private TextBox txtMaLoaiSP;
        private Label label2;
        private TextBox txtTimKiemLoaiSP;
        private Button btnTimKiemLoaiSP;
        private GroupBox groupBox2;
        private Button btnTimKiemThe;
        private DataGridView dgrDanhSachLoaiSP;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btTim;
        private TextBox txtTim;
    }
}