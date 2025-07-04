﻿namespace GUI_PolyCafe
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
            chiNhánhToolStripMenuItem = new ToolStripMenuItem();
            cơSởVậtChấtToolStripMenuItem = new ToolStripMenuItem();
            pnMain = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripTimer = new ToolStripStatusLabel();
            toolStripUserName = new ToolStripStatusLabel();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            pnMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            guna2ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timerSystem
            // 
            timerSystem.Enabled = true;
            timerSystem.Tick += timerSystem_Tick;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.AntiqueWhite;
            menuStrip2.Font = new Font("Times New Roman", 12.75F);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, danhMucToolStripMenuItem, banHangToolStripMenuItem, nhanVienToolStripMenuItem, doanhThuToolStripMenuItem, huongDanToolStripMenuItem, chiNhánhToolStripMenuItem, cơSởVậtChấtToolStripMenuItem });
            menuStrip2.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1212, 28);
            menuStrip2.TabIndex = 13;
            menuStrip2.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            heThongToolStripMenuItem.Image = (Image)resources.GetObject("heThongToolStripMenuItem.Image");
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(107, 24);
            heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Image = Properties.Resources.images_removebg_preview__1_;
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(172, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            doiMatKhauToolStripMenuItem.Click += doiMatKhauToolStripMenuItem_Click_1;
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Image = Properties.Resources.icons8_log_out_30;
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(172, 26);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Image = (Image)resources.GetObject("thoatToolStripMenuItem.Image");
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(172, 26);
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
            theLuuDongToolStripMenuItem.Image = Properties.Resources.icons8_online_shop_card_payment_50;
            theLuuDongToolStripMenuItem.Name = "theLuuDongToolStripMenuItem";
            theLuuDongToolStripMenuItem.Size = new Size(183, 26);
            theLuuDongToolStripMenuItem.Text = "Thẻ lưu động";
            theLuuDongToolStripMenuItem.Click += theLuuDongToolStripMenuItem_Click;
            // 
            // phieuBanHangToolStripMenuItem
            // 
            phieuBanHangToolStripMenuItem.Image = Properties.Resources.icons8_bill_24;
            phieuBanHangToolStripMenuItem.Name = "phieuBanHangToolStripMenuItem";
            phieuBanHangToolStripMenuItem.Size = new Size(183, 26);
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
            doanhThuToolStripMenuItem.Image = Properties.Resources.icons8_total_sales_32;
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(110, 24);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // loaiHangToolStripMenuItem
            // 
            loaiHangToolStripMenuItem.Image = Properties.Resources.icons8_coffee_cup_48;
            loaiHangToolStripMenuItem.Name = "loaiHangToolStripMenuItem";
            loaiHangToolStripMenuItem.Size = new Size(149, 26);
            loaiHangToolStripMenuItem.Text = "Loại hàng";
            loaiHangToolStripMenuItem.Click += loaiHangToolStripMenuItem_Click;
            // 
            // tkNhanVienToolStripMenuItem
            // 
            tkNhanVienToolStripMenuItem.Image = Properties.Resources.icons8_member_32;
            tkNhanVienToolStripMenuItem.Name = "tkNhanVienToolStripMenuItem";
            tkNhanVienToolStripMenuItem.Size = new Size(149, 26);
            tkNhanVienToolStripMenuItem.Text = "Nhân viên";
            tkNhanVienToolStripMenuItem.Click += tkNhanVienToolStripMenuItem_Click;
            // 
            // huongDanToolStripMenuItem
            // 
            huongDanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hdSuDungToolStripMenuItem, gioiThieuPhanMemToolStripMenuItem });
            huongDanToolStripMenuItem.Image = Properties.Resources.icons8_help_50;
            huongDanToolStripMenuItem.Name = "huongDanToolStripMenuItem";
            huongDanToolStripMenuItem.Size = new Size(114, 24);
            huongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // hdSuDungToolStripMenuItem
            // 
            hdSuDungToolStripMenuItem.Image = Properties.Resources.icons8_instructions_50;
            hdSuDungToolStripMenuItem.Name = "hdSuDungToolStripMenuItem";
            hdSuDungToolStripMenuItem.Size = new Size(224, 26);
            hdSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            hdSuDungToolStripMenuItem.Click += hdSuDungToolStripMenuItem_Click;
            // 
            // gioiThieuPhanMemToolStripMenuItem
            // 
            gioiThieuPhanMemToolStripMenuItem.Image = (Image)resources.GetObject("gioiThieuPhanMemToolStripMenuItem.Image");
            gioiThieuPhanMemToolStripMenuItem.Name = "gioiThieuPhanMemToolStripMenuItem";
            gioiThieuPhanMemToolStripMenuItem.Size = new Size(224, 26);
            gioiThieuPhanMemToolStripMenuItem.Text = "Giới thiệu phần mềm";
            gioiThieuPhanMemToolStripMenuItem.Click += gioiThieuPhanMemToolStripMenuItem_Click;
            // 
            // chiNhánhToolStripMenuItem
            // 
            chiNhánhToolStripMenuItem.Image = Properties.Resources.chinhanh;
            chiNhánhToolStripMenuItem.Name = "chiNhánhToolStripMenuItem";
            chiNhánhToolStripMenuItem.Size = new Size(108, 24);
            chiNhánhToolStripMenuItem.Text = "Chi nhánh";
            chiNhánhToolStripMenuItem.Click += chiNhánhToolStripMenuItem_Click;
            // 
            // cơSởVậtChấtToolStripMenuItem
            // 
            cơSởVậtChấtToolStripMenuItem.Image = Properties.Resources.icons8_furniture_store_24;
            cơSởVậtChấtToolStripMenuItem.Name = "cơSởVậtChấtToolStripMenuItem";
            cơSởVậtChấtToolStripMenuItem.Size = new Size(136, 24);
            cơSởVậtChấtToolStripMenuItem.Text = "Cơ sở vật chất";
            cơSởVậtChấtToolStripMenuItem.Click += cơSởVậtChấtToolStripMenuItem_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.AntiqueWhite;
            pnMain.Controls.Add(statusStrip1);
            pnMain.Location = new Point(0, 30);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1212, 593);
            pnMain.TabIndex = 14;
            pnMain.Paint += pnMain_Paint;
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
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(181, 70);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // frmChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 623);
            ControlBox = false;
            Controls.Add(pnMain);
            Controls.Add(menuStrip2);
            MaximumSize = new Size(1228, 662);
            MinimumSize = new Size(1228, 662);
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
            guna2ContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerSystem;
        private MenuStrip menuStrip2;
        private Panel pnMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripTimer;
        private ToolStripStatusLabel toolStripUserName;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
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
        private ToolStripMenuItem chiNhánhToolStripMenuItem;
        private ToolStripMenuItem cơSởVậtChấtToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}