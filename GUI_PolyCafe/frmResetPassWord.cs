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
            if (AuthUtil.IsLogin())
            {
                txtCPMaNV.Text = AuthUtil.user.MaNhanVien;
                txtCPTenNv.Text = AuthUtil.user.HoTen;
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập, vui lòng đăng nhập để thực hiện chức năng này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            // Thiết lập mặc định ẩn mật khẩu
            txtMKCu.UseSystemPasswordChar = true;
            txtMKMoi.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;

        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMKCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ chưa đúng!!!");
            }
            else
            {
                if (!txtMKMoi.Text.Equals(txtXacNhanMK.Text))
                {
                    MessageBox.Show(this, "Xác nhận mật khẩu mới chưa trùng khớp!!!");
                }
                else if (txtMKMoi.Text.Equals(txtMKCu.Text))
                {
                    MessageBox.Show(this, "Mật khẩu mới không được trùng với mật khẩu cũ!!!");
                }
                else
                {
                    if (bllNhanVien.ResetPassword(AuthUtil.user.Email, txtMKMoi.Text))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!!!");
                        AuthUtil.user.MatKhau = txtMKMoi.Text;
                        Clear();
                    }
                    else MessageBox.Show("Đổi mật khẩu thất bại, vui lòng kiểm tra lại!!!");
                }
            }
        }

        private void Clear()
        {
            txtMKCu.Clear();
            txtMKMoi.Clear();
            txtXacNhanMK.Clear();
        }
        private void chbHienthiMKCU_CheckedChanged(object sender, EventArgs e)
        {
            txtMKCu.UseSystemPasswordChar = !chkHienthiMKCU.Checked;
        }

        private void chbHienthiMKMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMKMoi.UseSystemPasswordChar = !chkHienthiMKMoi.Checked;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienthiXacNhanMK_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMK.UseSystemPasswordChar = !chkHienthiXacNhanMK.Checked;
        }

        private void chkHienthiMKMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMKMoi.UseSystemPasswordChar = !chkHienthiMKMoi.Checked;
        }

        private void chkHienthiMKCU_CheckedChanged(object sender, EventArgs e)
        {
            txtMKCu.UseSystemPasswordChar = !chkHienthiMKCU.Checked;
        }
    }
}
