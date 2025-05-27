namespace GUI_PolyCafe
{
    partial class frmChinh
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            timerSystem = new System.Windows.Forms.Timer(components);
            menuStrip2 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            thongTinTaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            danhMucToolStripMenuItem = new ToolStripMenuItem();
            loaiSanPhamToolStripMenuItem = new ToolStripMenuItem();
            sanPhamToolStripMenuItem = new ToolStripMenuItem();
            banHangToolStripMenuItem = new ToolStripMenuItem();
            theLuuDongToolStripMenuItem = new ToolStripMenuItem();
            phieuBanHangToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            loaiHangToolStripMenuItem = new ToolStripMenuItem();
            tkNhanVienToolStripMenuItem = new ToolStripMenuItem();
            huongDanToolStripMenuItem = new ToolStripMenuItem();
            hdSuDungToolStripMenuItem = new ToolStripMenuItem();
            gioiThieuPhanMemToolStripMenuItem = new ToolStripMenuItem();
            pnMain = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripTimer = new ToolStripStatusLabel();
            toolStripUserName = new ToolStripStatusLabel();
            menuStrip2.SuspendLayout();
            pnMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timerSystem
            // 
            timerSystem.Enabled = true;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.AntiqueWhite;
            menuStrip2.Font = new Font("Times New Roman", 12.75F);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, danhMucToolStripMenuItem, banHangToolStripMenuItem, nhanVienToolStripMenuItem, doanhThuToolStripMenuItem, huongDanToolStripMenuItem });
            menuStrip2.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1212, 28);
            menuStrip2.TabIndex = 13;
            menuStrip2.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, thongTinTaiKhoanToolStripMenuItem, dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            heThongToolStripMenuItem.Image = (Image)resources.GetObject("heThongToolStripMenuItem.Image");
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(107, 24);
            heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Image = Properties.Resources.images_removebg_preview__1_;
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(211, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            doiMatKhauToolStripMenuItem.Click += doiMatKhauToolStripMenuItem_Click_1;
            // 
            // thongTinTaiKhoanToolStripMenuItem
            // 
            thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
            thongTinTaiKhoanToolStripMenuItem.Size = new Size(211, 26);
            thongTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Image = Properties.Resources.logout_icon_template_black_color_editable_log_out_icon_symbol_flat_illustration_for_graphic_and_web_design_free_vector_removebg_preview;
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(211, 26);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Image = Properties.Resources.signs_close_icon_png_removebg_preview;
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(211, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click_1;
            // 
            // danhMucToolStripMenuItem
            // 
            danhMucToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loaiSanPhamToolStripMenuItem, sanPhamToolStripMenuItem });
            danhMucToolStripMenuItem.Image = (Image)resources.GetObject("danhMucToolStripMenuItem.Image");
            danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            danhMucToolStripMenuItem.Size = new Size(109, 24);
            danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // loaiSanPhamToolStripMenuItem
            // 
            loaiSanPhamToolStripMenuItem.Image = Properties.Resources._4866984_200_removebg_preview;
            loaiSanPhamToolStripMenuItem.Name = "loaiSanPhamToolStripMenuItem";
            loaiSanPhamToolStripMenuItem.Size = new Size(179, 26);
            loaiSanPhamToolStripMenuItem.Text = "Loại sản phẩm";
            loaiSanPhamToolStripMenuItem.Click += loaiSanPhamToolStripMenuItem_Click;
            // 
            // sanPhamToolStripMenuItem
            // 
            sanPhamToolStripMenuItem.Image = Properties.Resources.download_removebg_preview1;
            sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            sanPhamToolStripMenuItem.Size = new Size(179, 26);
            sanPhamToolStripMenuItem.Text = "Sản phẩm";
            sanPhamToolStripMenuItem.Click += sanPhamToolStripMenuItem_Click;
            // 
            // banHangToolStripMenuItem
            // 
            banHangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { theLuuDongToolStripMenuItem, phieuBanHangToolStripMenuItem });
            banHangToolStripMenuItem.Image = Properties.Resources.money_in_hand_icon_money_in_hand_sign_and_symbol_free_vector_removebg_preview;
            banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            banHangToolStripMenuItem.Size = new Size(102, 24);
            banHangToolStripMenuItem.Text = "Bán hàng";
            // 
            // theLuuDongToolStripMenuItem
            // 
            theLuuDongToolStripMenuItem.Name = "theLuuDongToolStripMenuItem";
            theLuuDongToolStripMenuItem.Size = new Size(179, 24);
            theLuuDongToolStripMenuItem.Text = "Thẻ lưu động";
            theLuuDongToolStripMenuItem.Click += theLuuDongToolStripMenuItem_Click;
            // 
            // phieuBanHangToolStripMenuItem
            // 
            phieuBanHangToolStripMenuItem.Name = "phieuBanHangToolStripMenuItem";
            phieuBanHangToolStripMenuItem.Size = new Size(179, 24);
            phieuBanHangToolStripMenuItem.Text = "Phiếu bán hàng";
            phieuBanHangToolStripMenuItem.Click += phieuBanHangToolStripMenuItem_Click;
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.Image = Properties.Resources._484619;
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(108, 24);
            nhanVienToolStripMenuItem.Text = "Nhân viên";
            nhanVienToolStripMenuItem.Click += nhanVienToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loaiHangToolStripMenuItem, tkNhanVienToolStripMenuItem });
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(90, 23);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // loaiHangToolStripMenuItem
            // 
            loaiHangToolStripMenuItem.Name = "loaiHangToolStripMenuItem";
            loaiHangToolStripMenuItem.Size = new Size(180, 24);
            loaiHangToolStripMenuItem.Text = "Loại hàng";
            // 
            // tkNhanVienToolStripMenuItem
            // 
            tkNhanVienToolStripMenuItem.Name = "tkNhanVienToolStripMenuItem";
            tkNhanVienToolStripMenuItem.Size = new Size(180, 24);
            tkNhanVienToolStripMenuItem.Text = "Nhân viên";
            tkNhanVienToolStripMenuItem.Click += tkNhanVienToolStripMenuItem_Click;
            // 
            // huongDanToolStripMenuItem
            // 
            huongDanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hdSuDungToolStripMenuItem, gioiThieuPhanMemToolStripMenuItem });
            huongDanToolStripMenuItem.Name = "huongDanToolStripMenuItem";
            huongDanToolStripMenuItem.Size = new Size(94, 23);
            huongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // hdSuDungToolStripMenuItem
            // 
            hdSuDungToolStripMenuItem.Name = "hdSuDungToolStripMenuItem";
            hdSuDungToolStripMenuItem.Size = new Size(220, 24);
            hdSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // gioiThieuPhanMemToolStripMenuItem
            // 
            gioiThieuPhanMemToolStripMenuItem.Name = "gioiThieuPhanMemToolStripMenuItem";
            gioiThieuPhanMemToolStripMenuItem.Size = new Size(220, 24);
            gioiThieuPhanMemToolStripMenuItem.Text = "Giới thiệu phần mềm";
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.AntiqueWhite;
            pnMain.Controls.Add(statusStrip1);
            pnMain.Location = new Point(0, 30);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1212, 593);
            pnMain.TabIndex = 14;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripTimer, toolStripUserName });
            statusStrip1.Location = new Point(0, 571);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1212, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTimer
            // 
            toolStripTimer.Name = "toolStripTimer";
            toolStripTimer.Size = new Size(57, 17);
            toolStripTimer.Text = "Hệ thống";
            // 
            // toolStripUserName
            // 
            toolStripUserName.ImageAlign = ContentAlignment.MiddleRight;
            toolStripUserName.Name = "toolStripUserName";
            toolStripUserName.Size = new Size(1140, 17);
            toolStripUserName.Spring = true;
            toolStripUserName.Text = "UserName";
            toolStripUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 623);
            Controls.Add(pnMain);
            Controls.Add(menuStrip2);
            Name = "frmChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PolyCafe";
            FormClosing += frmChinh_FormClosing;
            Load += frmChinh_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerSystem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem danhMucToolStripMenuItem;
        private ToolStripMenuItem loaiSanPhamToolStripMenuItem;
        private ToolStripMenuItem sanPhamToolStripMenuItem;
        private ToolStripMenuItem banHangToolStripMenuItem;
        private ToolStripMenuItem theLuuDongToolStripMenuItem;
        private ToolStripMenuItem phieuBanHangToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem loaiHangToolStripMenuItem;
        private ToolStripMenuItem tkNhanVienToolStripMenuItem;
        private ToolStripMenuItem huongDanToolStripMenuItem;
        private ToolStripMenuItem hdSuDungToolStripMenuItem;
        private ToolStripMenuItem gioiThieuPhanMemToolStripMenuItem;
        private Panel pnMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripTimer;
        private ToolStripStatusLabel toolStripUserName;
    }
}