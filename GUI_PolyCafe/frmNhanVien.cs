using BLL_PolyCafe;
using DAL_PolyCafe;
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
            dgvDanhSachNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvDanhSachNV.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvDanhSachNV.Columns["Email"].HeaderText = "Email";
            dgvDanhSachNV.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgvDanhSachNV.Columns["VaiTroText"].HeaderText = "Vai Trò";
            dgvDanhSachNV.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            dgvDanhSachNV.Columns["VaiTro"].Visible = false;
            dgvDanhSachNV.Columns["TrangThai"].Visible = false;

            dgvDanhSachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btXoa.Enabled = true;
            BLLNhanVien bus = new BLLNhanVien();
            txtMaNhanVien.Text = bus.GenerateMaNhanVien();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtXacNhanMK.Clear();
            txtTim.Clear();
            rbtNhanVien.Checked = true;
            rbtHoatDong.Checked = true;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }


        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMK.Checked;
        }

        private void rbtNgungHD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHienMK2_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMK.UseSystemPasswordChar = !chkHienMK2.Checked;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                MessageBox.Show("Vui lòng nhập để tìm kiếm");
                return;
            }
            try
            {
                string keyword = txtTim.Text.Trim().ToLower();

                BLLNhanVien bllNhanVien = new BLLNhanVien();
                List<NhanVien> danhSach = bllNhanVien.GetNhanViens(); // Lấy toàn bộ để lọc thủ công
                var ketQua = danhSach.Where(nv => nv.MaNhanVien.ToLower().Contains(keyword) ||
                                                  nv.HoTen.ToLower().Contains(keyword) ||
                                                  nv.Email.ToLower().Contains(keyword)).ToList();
                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào phù hợp với từ khóa: " + keyword);
                    return;
                }

                dgvDanhSachNV.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMK = txtXacNhanMK.Text.Trim();
            bool vaiTro;

            if (rbtNhanVien.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rbtHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            if (!matKhau.Equals(xacNhanMK))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BLLNhanVien bus = new BLLNhanVien();
            string result = bus.InsertNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maNV = txtMaNhanVien.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string xacNhanMK = txtXacNhanMK.Text.Trim();
                bool vaiTro = rbtQuanLy.Checked; // Nếu chọn "Quản lý" thì true, nếu chọn "Nhân viên" thì false
                bool trangThai = rbtHoatDong.Checked; // Nếu chọn "Hoạt động" thì true, nếu chọn "Ngừng Hoạt Động" thì false

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhau != xacNhanMK)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = trangThai // Cập nhật đúng trạng thái từ form
                };

                // Gọi BLL để cập nhật nhân viên trong database
                BLLNhanVien bus = new BLLNhanVien();
                string result = bus.UpdateNhanVien(nv);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien(); // Load lại danh sách sau khi cập nhật
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();
            string name = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(maNhanVien))
            {
                if (dgvDanhSachNV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachNV.SelectedRows[0];
                    maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    name = selectedRow.Cells["HoTen"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNhanVien} - {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLNhanVien bus = new BLLNhanVien();
                string kq = bus.DeleteNhanVien(maNhanVien);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {maNhanVien} - {name} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void dgvDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachNV.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txtXacNhanMK.Text = row.Cells["MatKhau"].Value.ToString();

            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro == false)
            {
                rbtNhanVien.Checked = true;
            }
            else
            {
                rbtQuanLy.Checked = true;
            }

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            rbtHoatDong.Checked = trangThai;  // Nếu `true` thì chọn hoạt động
            rbtNgungHD.Checked = !trangThai;  // Nếu `false` thì chọn ngưng hoạt động


            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btXoa.Enabled = true;
            // Tắt chỉnh sửa mã nhân viên
            txtMaNhanVien.Enabled = false;
        }
    }
}
