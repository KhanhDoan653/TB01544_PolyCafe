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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien()
        {
            BLLNhanVien bus = new BLLNhanVien();
            dgvDanhSachNV.DataSource = null;
            dgvDanhSachNV.DataSource = bus.GetNhanViens();
        }

        private void ClearForm()
        {

        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtMaNhanVien.Text;
                string hoTen = txtHoTen.Text;
                string email = txtEmail.Text;
                string matKhau = txtMatKhau.Text;
                string xacNhanMatKhau = txtXacNhanMK.Text;
                bool vaiTro;
                if (rbtNhanVien.Checked)
                {
                    vaiTro = true;
                }
                else
                {
                    vaiTro = false;
                }
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if (matKhau != xacNhanMatKhau)
                {
                    MessageBox.Show("Mật khẩu không khớp");
                    return;
                }
                NhanVien nv = new NhanVien();
                {
                    nv.MaNhanVien = maNV;
                    nv.HoTen = hoTen;
                    nv.Email = email;
                    nv.MatKhau = matKhau;
                    nv.VaiTro = vaiTro;
                    nv.TrangThai = true; // Hoặc false tùy thuộc vào yêu cầu
                }
                BLLNhanVien bus = new BLLNhanVien();
                string result = bus.InsertNhanVien(nv);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    LoadDanhSachNhanVien();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
