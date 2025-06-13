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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label3 = new Label();
            chkHienMK = new CheckBox();
            txtMK = new Guna.UI2.WinForms.Guna2TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btDangNhap = new Guna.UI2.WinForms.Guna2Button();
            btThoat = new Guna.UI2.WinForms.Guna2Button();
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
            pictureBox2.Location = new Point(734, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 131);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(chkHienMK, 0, 4);
            tableLayoutPanel1.Controls.Add(txtMK, 0, 3);
            tableLayoutPanel1.ForeColor = SystemColors.ScrollBar;
            tableLayoutPanel1.Location = new Point(387, 174);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(367, 211);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Fira Sans", 9.749999F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(3, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(361, 36);
            txtEmail.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Fira Sans", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(45, 18);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Fira Sans", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Chocolate;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.BackColor = Color.Transparent;
            chkHienMK.Font = new Font("Fira Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHienMK.ForeColor = Color.White;
            chkHienMK.Location = new Point(3, 171);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(105, 18);
            chkHienMK.TabIndex = 16;
            chkHienMK.Text = "Hiện mật khẩu";
            chkHienMK.UseVisualStyleBackColor = false;
            chkHienMK.CheckedChanged += chkHienMK_CheckedChanged;
            // 
            // txtMK
            // 
            txtMK.CustomizableEdges = customizableEdges3;
            txtMK.DefaultText = "";
            txtMK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMK.Font = new Font("Fira Sans", 9.749999F);
            txtMK.ForeColor = Color.Black;
            txtMK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMK.Location = new Point(3, 129);
            txtMK.Name = "txtMK";
            txtMK.PlaceholderText = "";
            txtMK.SelectedText = "";
            txtMK.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMK.Size = new Size(361, 36);
            txtMK.TabIndex = 17;
            txtMK.UseSystemPasswordChar = true;
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
            tableLayoutPanel2.Location = new Point(387, 391);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(367, 51);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // btDangNhap
            // 
            btDangNhap.Anchor = AnchorStyles.None;
            btDangNhap.BorderRadius = 10;
            btDangNhap.CustomizableEdges = customizableEdges5;
            btDangNhap.DisabledState.BorderColor = Color.DarkGray;
            btDangNhap.DisabledState.CustomBorderColor = Color.DarkGray;
            btDangNhap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btDangNhap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btDangNhap.FillColor = Color.DarkCyan;
            btDangNhap.Font = new Font("Fira Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDangNhap.ForeColor = Color.White;
            btDangNhap.Location = new Point(3, 7);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btDangNhap.Size = new Size(177, 37);
            btDangNhap.TabIndex = 16;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.Click += btDangNhap_Click;
            // 
            // btThoat
            // 
            btThoat.Anchor = AnchorStyles.None;
            btThoat.BorderRadius = 10;
            btThoat.CustomizableEdges = customizableEdges7;
            btThoat.DisabledState.BorderColor = Color.DarkGray;
            btThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btThoat.FillColor = Color.FromArgb(192, 0, 0);
            btThoat.Font = new Font("Fira Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThoat.ForeColor = Color.White;
            btThoat.Location = new Point(186, 5);
            btThoat.Name = "btThoat";
            btThoat.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btThoat.Size = new Size(178, 41);
            btThoat.TabIndex = 17;
            btThoat.Text = "Thoát";
            btThoat.Click += btThoat_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Fira Sans", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(472, 111);
            label1.Name = "label1";
            label1.Size = new Size(187, 38);
            label1.TabIndex = 13;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1036, 494);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            ForeColor = Color.SaddleBrown;
            MaximumSize = new Size(1052, 533);
            MinimumSize = new Size(1052, 533);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PolyCafe-Đăng nhập";
            FormClosing += frmDangNhap_FormClosing;
            Load += frmDangNhap_Load;
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
        private CheckBox chkHienMK;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMK;
        private Guna.UI2.WinForms.Guna2Button btDangNhap;
        private Guna.UI2.WinForms.Guna2Button btThoat;
    }
}