namespace GUI_PolyCafe
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            txtMK = new TextBox();
            chkHienMK = new CheckBox();
            txtEmail = new TextBox();
            btDangNhap = new Button();
            btThoat = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(298, 133);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.5858F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtMK, 0, 3);
            tableLayoutPanel1.Controls.Add(chkHienMK, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 0, 1);
            tableLayoutPanel1.ForeColor = SystemColors.ScrollBar;
            tableLayoutPanel1.Location = new Point(326, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(304, 199);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Chocolate;
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.AntiqueWhite;
            txtMK.BorderStyle = BorderStyle.FixedSingle;
            txtMK.Location = new Point(3, 135);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(298, 23);
            txtMK.TabIndex = 3;
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.BackColor = Color.Transparent;
            chkHienMK.ForeColor = Color.Black;
            chkHienMK.Location = new Point(3, 179);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(104, 17);
            chkHienMK.TabIndex = 16;
            chkHienMK.Text = "Hiện mật khẩu";
            chkHienMK.UseVisualStyleBackColor = false;
            chkHienMK.CheckedChanged += chkHienMK_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.AntiqueWhite;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(3, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 23);
            txtEmail.TabIndex = 4;
            // 
            // btDangNhap
            // 
            btDangNhap.Anchor = AnchorStyles.None;
            btDangNhap.BackColor = Color.SteelBlue;
            btDangNhap.FlatStyle = FlatStyle.Flat;
            btDangNhap.Font = new Font("Segoe UI", 11.25F);
            btDangNhap.ForeColor = Color.White;
            btDangNhap.Location = new Point(3, 5);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(146, 34);
            btDangNhap.TabIndex = 4;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.UseVisualStyleBackColor = false;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // btThoat
            // 
            btThoat.Anchor = AnchorStyles.None;
            btThoat.BackColor = Color.Firebrick;
            btThoat.FlatStyle = FlatStyle.Flat;
            btThoat.Font = new Font("Segoe UI", 11.25F);
            btThoat.ForeColor = Color.White;
            btThoat.Location = new Point(155, 5);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(146, 34);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btDangNhap, 0, 0);
            tableLayoutPanel2.Controls.Add(btThoat, 1, 0);
            tableLayoutPanel2.ForeColor = Color.Sienna;
            tableLayoutPanel2.Location = new Point(336, 280);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(304, 44);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(402, 23);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 13;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(663, 368);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pictureBox2);
            ForeColor = Color.SaddleBrown;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            FormClosing += frmDangNhap_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private TextBox txtMK;
        private TextBox txtEmail;
        private Button btDangNhap;
        private Button btThoat;
        private CheckBox chkHienMK;
        private TableLayoutPanel tableLayoutPanel2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label1;
    }
}