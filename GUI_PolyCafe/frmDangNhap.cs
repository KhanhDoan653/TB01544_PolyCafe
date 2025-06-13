using BLL_PolyCafe;
using DTO_PolyCafe;
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
    public partial class frmDangNhap : Form
    {
        BLLNhanVien bllNhanVien = new BLLNhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = !chkHienMK.Checked;
        }


        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text;
            string password = txtMK.Text;
            //NhanVien nv = BUSNhanVien.DangNhap("admin@gmail.com", "admin123");
            //NhanVien nv = BUSNhanVien.DangNhap("hung.pham@gmail.vn", "hashed_hung789");
            NhanVien nv = bllNhanVien.DangNhap(username, password);
            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài khoản đang tạm khóa, vui lòng viên hệ QTV!!!");
                    return;
                }
                AuthUtil.user = nv;

                frmChinh main = new frmChinh();
                main.Show();
                this.Hide();
            }
        }
    }
}
