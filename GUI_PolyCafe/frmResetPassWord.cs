using BLL_PolyCafe;
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
    public partial class frmResetPassWord : Form
    {
        BLLNhanVien bllNhanVien = new BLLNhanVien();
        public frmResetPassWord()
        {
            InitializeComponent();
        }

        private void frmResetPassWord_Load(object sender, EventArgs e)
        {

        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMKCu.Text))
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!txtMKMoi.Text.Equals(txtXacNhanMK.Text))
                {
                    MessageBox.Show("Mật khẩu mới không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (bllNhanVien.ResetPassword(AuthUtil.user.Email, txtMKMoi.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AuthUtil.user.MatKhau = txtMKMoi.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void chbHienthiMKCU_CheckedChanged(object sender, EventArgs e)
        {
            txtMKCu.UseSystemPasswordChar = !chkHienthiMKCU.Checked;
        }

        private void chbHienthiMKMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMKMoi.UseSystemPasswordChar = !chkHienthiMKMoi.Checked;
        }

        private void chbHienthiXacNhanMK_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMK.UseSystemPasswordChar = !chkHienthiXacNhanMK.Checked;
        }
    }
}
