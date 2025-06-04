using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            CheckPermission();
        }


        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResetPassWord change = new frmResetPassWord();
            change.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResetPassWord resetPassword = new frmResetPassWord();
            resetPassword.Show();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doiMatKhauToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmResetPassWord resetPassword = new frmResetPassWord();
            resetPassword.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form currentFormChild;
        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void theLuuDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheLuuDong());
        }
        private void VaiTroNhanVien()
        {
            danhMucToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;
        }
        private void CheckPermission()
        {
            if (AuthUtil.IsLogin())
            {
                toolStripUserName.Text = AuthUtil.user.HoTen;
                danhMucToolStripMenuItem.Visible = true;
                banHangToolStripMenuItem.Visible = true;
                nhanVienToolStripMenuItem.Visible = true;
                doanhThuToolStripMenuItem.Visible = true;
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
            }
            else
            {
                heThongToolStripMenuItem.Visible = true; // Xác định xem điều khiển có hiển thị trên giao diện hay không.
                dangXuatToolStripMenuItem.Enabled = false; // Xác định xem điều khiển có thể tương tác hay không.
                thongTinTaiKhoanToolStripMenuItem.Enabled = false;
                danhMucToolStripMenuItem.Visible = false;
                banHangToolStripMenuItem.Visible = false;
                nhanVienToolStripMenuItem.Visible = false;
                doanhThuToolStripMenuItem.Visible = false;
            }
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //e.Cancel = true;
                Application.Exit();
            }
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhMucToolStripMenuItem.Visible = false;
            banHangToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;

            this.Hide();
            AuthUtil.user = null;
            frmDangNhap login = new frmDangNhap();
            login.Show();
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void phieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuBanHang());
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiSanPham());
        }

        private void tkNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuNhanVien());
        }

        private void KhuyenMaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KhuyenMaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmKhuyenMai());
        }

        private void loaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuTheoSanPham());
        }
    }
}
