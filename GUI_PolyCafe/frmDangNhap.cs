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

namespace GUI_PolyCafe
{
    public partial class frmDangNhap : Form
    {
        BLLNhanVien bllNhanVien = new BLLNhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtMK.Text;
            NhanVien nv = bllNhanVien.DangNhap(email, password);
            if(nv == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                frmChinh main = new frmChinh(nv);
                main.Show();
                this.Hide();
            }    
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = !chkHienMK.Checked;
        }



        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
