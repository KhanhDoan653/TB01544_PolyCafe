namespace GUI_PolyCafe
{
    partial class frmResetPassWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassWord));
            btDoiMK = new Button();
            btThoat = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtCPMaNV = new TextBox();
            chkHienthiMKMoi = new CheckBox();
            txtMKCu = new TextBox();
            txtXacNhanMK = new TextBox();
            txtMKMoi = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            chkHienthiMKCU = new CheckBox();
            chkHienthiXacNhanMK = new CheckBox();
            txtCPTenNv = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btDoiMK
            // 
            btDoiMK.Anchor = AnchorStyles.None;
            btDoiMK.FlatStyle = FlatStyle.Flat;
            btDoiMK.ForeColor = Color.DarkCyan;
            btDoiMK.Location = new Point(79, 8);
            btDoiMK.Name = "btDoiMK";
            btDoiMK.Size = new Size(110, 37);
            btDoiMK.TabIndex = 16;
            btDoiMK.Text = "Đổi mật khẩu";
            btDoiMK.UseVisualStyleBackColor = true;
            btDoiMK.Click += btDoiMK_Click;
            // 
            // btThoat
            // 
            btThoat.Anchor = AnchorStyles.None;
            btThoat.FlatStyle = FlatStyle.Flat;
            btThoat.ForeColor = Color.Red;
            btThoat.Location = new Point(347, 8);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(110, 37);
            btThoat.TabIndex = 17;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.40594F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.59406F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel5.Controls.Add(txtCPMaNV, 1, 0);
            tableLayoutPanel5.Controls.Add(chkHienthiMKMoi, 2, 3);
            tableLayoutPanel5.Controls.Add(txtMKCu, 1, 2);
            tableLayoutPanel5.Controls.Add(txtXacNhanMK, 1, 4);
            tableLayoutPanel5.Controls.Add(txtMKMoi, 1, 3);
            tableLayoutPanel5.Controls.Add(label9, 0, 3);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(label7, 0, 2);
            tableLayoutPanel5.Controls.Add(label8, 0, 1);
            tableLayoutPanel5.Controls.Add(label10, 0, 4);
            tableLayoutPanel5.Controls.Add(chkHienthiMKCU, 2, 2);
            tableLayoutPanel5.Controls.Add(chkHienthiXacNhanMK, 2, 4);
            tableLayoutPanel5.Controls.Add(txtCPTenNv, 1, 1);
            tableLayoutPanel5.Location = new Point(31, 161);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(536, 247);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // txtCPMaNV
            // 
            txtCPMaNV.Font = new Font("Segoe UI", 12F);
            txtCPMaNV.Location = new Point(153, 3);
            txtCPMaNV.Name = "txtCPMaNV";
            txtCPMaNV.ReadOnly = true;
            txtCPMaNV.Size = new Size(278, 29);
            txtCPMaNV.TabIndex = 16;
            // 
            // chkHienthiMKMoi
            // 
            chkHienthiMKMoi.AutoSize = true;
            chkHienthiMKMoi.Font = new Font("Segoe UI", 11.25F);
            chkHienthiMKMoi.Location = new Point(439, 150);
            chkHienthiMKMoi.Name = "chkHienthiMKMoi";
            chkHienthiMKMoi.Size = new Size(80, 24);
            chkHienthiMKMoi.TabIndex = 13;
            chkHienthiMKMoi.Text = "Hiển thị";
            chkHienthiMKMoi.UseVisualStyleBackColor = true;
            // 
            // txtMKCu
            // 
            txtMKCu.Anchor = AnchorStyles.Left;
            txtMKCu.BackColor = Color.FloralWhite;
            txtMKCu.Location = new Point(153, 111);
            txtMKCu.Name = "txtMKCu";
            txtMKCu.Size = new Size(278, 23);
            txtMKCu.TabIndex = 11;
            txtMKCu.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Anchor = AnchorStyles.Left;
            txtXacNhanMK.BackColor = Color.FloralWhite;
            txtXacNhanMK.Location = new Point(153, 210);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(278, 23);
            txtXacNhanMK.TabIndex = 10;
            txtXacNhanMK.UseSystemPasswordChar = true;
            // 
            // txtMKMoi
            // 
            txtMKMoi.Anchor = AnchorStyles.Left;
            txtMKMoi.BackColor = Color.FloralWhite;
            txtMKMoi.Location = new Point(153, 160);
            txtMKMoi.Name = "txtMKMoi";
            txtMKMoi.Size = new Size(278, 23);
            txtMKMoi.TabIndex = 9;
            txtMKMoi.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(3, 161);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 7;
            label9.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(3, 14);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 1;
            label6.Text = "Mã nhân viên";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(3, 112);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 3;
            label7.Text = "Mật khẩu cũ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(3, 63);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 2;
            label8.Text = "Tên nhân viên";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(3, 211);
            label10.Name = "label10";
            label10.Size = new Size(134, 20);
            label10.TabIndex = 8;
            label10.Text = "Xác nhận mật khẩu";
            // 
            // chkHienthiMKCU
            // 
            chkHienthiMKCU.AutoSize = true;
            chkHienthiMKCU.Font = new Font("Segoe UI", 11.25F);
            chkHienthiMKCU.Location = new Point(439, 101);
            chkHienthiMKCU.Name = "chkHienthiMKCU";
            chkHienthiMKCU.Size = new Size(80, 24);
            chkHienthiMKCU.TabIndex = 12;
            chkHienthiMKCU.Text = "Hiển thị";
            chkHienthiMKCU.UseVisualStyleBackColor = true;
            // 
            // chkHienthiXacNhanMK
            // 
            chkHienthiXacNhanMK.AutoSize = true;
            chkHienthiXacNhanMK.Font = new Font("Segoe UI", 11.25F);
            chkHienthiXacNhanMK.Location = new Point(439, 199);
            chkHienthiXacNhanMK.Name = "chkHienthiXacNhanMK";
            chkHienthiXacNhanMK.Size = new Size(80, 24);
            chkHienthiXacNhanMK.TabIndex = 14;
            chkHienthiXacNhanMK.Text = "Hiển thị";
            chkHienthiXacNhanMK.UseVisualStyleBackColor = true;
            chkHienthiXacNhanMK.CheckedChanged += chkHienthiXacNhanMK_CheckedChanged;
            // 
            // txtCPTenNv
            // 
            txtCPTenNv.Font = new Font("Segoe UI", 12F);
            txtCPTenNv.Location = new Point(153, 52);
            txtCPTenNv.Name = "txtCPTenNv";
            txtCPTenNv.ReadOnly = true;
            txtCPTenNv.Size = new Size(278, 29);
            txtCPTenNv.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btThoat, 1, 0);
            tableLayoutPanel1.Controls.Add(btDoiMK, 0, 0);
            tableLayoutPanel1.Location = new Point(31, 441);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(536, 53);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // frmResetPassWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(594, 495);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Name = "frmResetPassWord";
            Text = "PolyCafe-Đổi mật khẩu";
            Load += frmResetPassWord_Load;
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btDoiMK;
        private Button btThoat;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtCPMaNV;
        private CheckBox chkHienthiMKMoi;
        private TextBox txtMKCu;
        private TextBox txtXacNhanMK;
        private TextBox txtMKMoi;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private CheckBox chkHienthiMKCU;
        private CheckBox chkHienthiXacNhanMK;
        private TextBox txtCPTenNv;
        private TableLayoutPanel tableLayoutPanel1;
    }
}