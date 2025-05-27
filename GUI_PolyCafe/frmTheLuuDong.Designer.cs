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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLuuDong));
            label7 = new Label();
            txtTim = new TextBox();
            btTim = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dgvDanhSachTheLuuDong = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            btLamMoi = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            txtMaThe = new TextBox();
            txtChuSoHuu = new TextBox();
            cbkHoatDong = new CheckBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTheLuuDong).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Goldenrod;
            label7.Location = new Point(409, 20);
            label7.Name = "label7";
            label7.Size = new Size(340, 37);
            label7.TabIndex = 11;
            label7.Text = "QUẢN LÝ THẺ LƯU ĐỘNG";
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.None;
            txtTim.Location = new Point(9, 9);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(426, 23);
            txtTim.TabIndex = 0;
            // 
            // btTim
            // 
            btTim.Anchor = AnchorStyles.None;
            btTim.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTim.ForeColor = Color.Black;
            btTim.Location = new Point(472, 3);
            btTim.Name = "btTim";
            btTim.Size = new Size(82, 36);
            btTim.TabIndex = 1;
            btTim.Text = "Tìm";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.46048F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5395184F));
            tableLayoutPanel4.Controls.Add(btTim, 1, 0);
            tableLayoutPanel4.Controls.Add(txtTim, 0, 0);
            tableLayoutPanel4.Location = new Point(602, 98);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(582, 42);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgvDanhSachTheLuuDong);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(596, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 396);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách";
            // 
            // dgvDanhSachTheLuuDong
            // 
            dgvDanhSachTheLuuDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachTheLuuDong.BackgroundColor = Color.White;
            dgvDanhSachTheLuuDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachTheLuuDong.Location = new Point(6, 22);
            dgvDanhSachTheLuuDong.Name = "dgvDanhSachTheLuuDong";
            dgvDanhSachTheLuuDong.Size = new Size(576, 368);
            dgvDanhSachTheLuuDong.TabIndex = 5;
            dgvDanhSachTheLuuDong.CellDoubleClick += dgvDanhSachTheLuuDong_CellDoubleClick;
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
            tableLayoutPanel3.Location = new Point(11, 25);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(514, 50);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.None;
            btThem.Font = new Font("Microsoft Sans Serif", 11.25F);
            btThem.ForeColor = Color.Green;
            btThem.Location = new Point(23, 9);
            btThem.Name = "btThem";
            btThem.Size = new Size(82, 32);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.None;
            btSua.Font = new Font("Microsoft Sans Serif", 11.25F);
            btSua.ForeColor = Color.DarkOrange;
            btSua.Location = new Point(151, 9);
            btSua.Name = "btSua";
            btSua.Size = new Size(82, 32);
            btSua.TabIndex = 1;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.None;
            btXoa.Font = new Font("Microsoft Sans Serif", 11.25F);
            btXoa.ForeColor = Color.Red;
            btXoa.Location = new Point(279, 9);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(82, 32);
            btXoa.TabIndex = 2;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btLamMoi
            // 
            btLamMoi.Anchor = AnchorStyles.None;
            btLamMoi.Font = new Font("Microsoft Sans Serif", 11.25F);
            btLamMoi.ForeColor = Color.DarkCyan;
            btLamMoi.Location = new Point(408, 9);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(82, 32);
            btLamMoi.TabIndex = 3;
            btLamMoi.Text = "Làm Mới";
            btLamMoi.UseVisualStyleBackColor = true;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 243);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1481476F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.85185F));
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtMaThe, 1, 0);
            tableLayoutPanel1.Controls.Add(txtChuSoHuu, 1, 1);
            tableLayoutPanel1.Controls.Add(cbkHoatDong, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(473, 209);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 138);
            label3.Name = "label3";
            label3.Size = new Size(78, 18);
            label3.TabIndex = 2;
            label3.Text = "Trạng Thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 1;
            label2.Text = "Chủ Sở Hữu";
            // 
            // txtMaThe
            // 
            txtMaThe.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtMaThe.Location = new Point(112, 3);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.Size = new Size(311, 24);
            txtMaThe.TabIndex = 5;
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtChuSoHuu.Location = new Point(112, 72);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.Size = new Size(311, 24);
            txtChuSoHuu.TabIndex = 6;
            // 
            // cbkHoatDong
            // 
            cbkHoatDong.AutoSize = true;
            cbkHoatDong.Font = new Font("Microsoft Sans Serif", 11.25F);
            cbkHoatDong.ForeColor = Color.Black;
            cbkHoatDong.Location = new Point(112, 141);
            cbkHoatDong.Name = "cbkHoatDong";
            cbkHoatDong.Size = new Size(96, 22);
            cbkHoatDong.TabIndex = 7;
            cbkHoatDong.Text = "Hoạt động";
            cbkHoatDong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 0;
            label1.Text = "Mã Thẻ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Location = new Point(12, 404);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(531, 75);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Location = new Point(20, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1158, 78);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // frmTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1196, 554);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "frmTheLuuDong";
            Text = "frmTheLuuDong";
            Load += frmTheLuuDong_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTheLuuDong).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private TextBox txtTim;
        private Button btTim;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private DataGridView dgvDanhSachTheLuuDong;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaThe;
        private TextBox txtChuSoHuu;
        private CheckBox cbkHoatDong;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private Button btLamMoi;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel2;
    }
}