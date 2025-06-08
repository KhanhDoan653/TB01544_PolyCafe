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
    public partial class frmChiNhanh : Form
    {
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSach();
        }
        private void ClearForm()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = true;
            BLLChiNhanh busChiNhanh = new BLLChiNhanh();
            txtMaCN.Text = busChiNhanh.GenerateChiNhanh();
            txtTenCN.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTim.Clear(); // Thêm dòng này
            rdHoatDong.Checked = true;
            rdNgungBan.Checked = false;
            txtTim.Clear();
        }

        private void LoadDanhSach()
        {
            BLLChiNhanh bll = new BLLChiNhanh();
            dgrDanhSachChiNhanh.DataSource = null;
            dgrDanhSachChiNhanh.Columns.Clear(); // Thêm dòng này để xóa sạch cấu trúc cũ
            List<ChiNhanh> lst = bll.GetChiNhanhs();

            var data = lst.Select(cn => new
            {
                cn.MaChiNhanh,
                cn.TenChiNhanh,
                cn.DiaChi,
                cn.SoDienThoai,
                TrangThai = cn.TrangThai ? "Hoạt động" : "Ngừng hoạt động",
            }).ToList();

            dgrDanhSachChiNhanh.DataSource = data;
            dgrDanhSachChiNhanh.Columns["MaChiNhanh"].HeaderText = "Mã Chi Nhánh";
            dgrDanhSachChiNhanh.Columns["TenChiNhanh"].HeaderText = "Tên Chi Nhánh";
            dgrDanhSachChiNhanh.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgrDanhSachChiNhanh.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgrDanhSachChiNhanh.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgrDanhSachChiNhanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maChiNhanh = txtMaCN.Text.Trim(); // Lấy mã sản phẩm từ txtMaSanPham
                string tenChiNhanh = txtTenCN.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                bool trangThai = rdHoatDong.Checked;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maChiNhanh) || string.IsNullOrEmpty(tenChiNhanh) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diachi))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Kiểm tra xem mã chi nhánh đã tồn tại chưa
                BLLChiNhanh bll = new BLLChiNhanh();
                if (bll.GetChiNhanhs().Any(cn => cn.MaChiNhanh == maChiNhanh))
                {
                    MessageBox.Show("Mã chi nhánh đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{9,11}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChiNhanh cn = new ChiNhanh
                {
                    MaChiNhanh = maChiNhanh,
                    TenChiNhanh = tenChiNhanh,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    TrangThai = trangThai
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                bll.InsertChiNhanh(cn);

                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form và tải lại danh sách sản phẩm
                ClearForm();
                LoadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maChiNhanh = txtMaCN.Text.Trim();
                string tenChiNhanh = txtTenCN.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                bool trangThai = rdHoatDong.Checked;

                if (string.IsNullOrEmpty(maChiNhanh))
                {
                    MessageBox.Show("Không tìm thấy chi nhánh cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrEmpty(tenChiNhanh) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{9,11}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChiNhanh cn = new ChiNhanh
                {
                    MaChiNhanh = maChiNhanh,
                    TenChiNhanh = tenChiNhanh,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    TrangThai = trangThai
                };
                BLLChiNhanh bll = new BLLChiNhanh();
                string result = bll.UpdateChiNhanh(cn);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    ClearForm();
                    LoadDanhSach();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maChiNhanh = txtMaCN.Text.Trim();
            string tenChiNhanh = txtTenCN.Text.Trim();
            if (string.IsNullOrEmpty(maChiNhanh) || string.IsNullOrEmpty(tenChiNhanh))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi nhánh này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BLLChiNhanh bll = new BLLChiNhanh();
                string message = bll.DeleteChiNhanh(maChiNhanh);
                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Xóa chi nhánh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSach();
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSach();
        }

        private void dgrDanhSachChiNhanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgrDanhSachChiNhanh.Rows[e.RowIndex];
            txtMaCN.Text = row.Cells["MaChiNhanh"].Value.ToString();
            txtTenCN.Text = row.Cells["TenChiNhanh"].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            bool trangThai = row.Cells["TrangThai"].Value?.ToString().Trim().ToLower() == "hoạt động";
            if (trangThai)
            {
                rdHoatDong.Checked = true;
            }
            else
            {
                rdNgungBan.Checked = true;
            }
            // Bật nút "Sửa"
            btThem.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTim.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDanhSach(); // Tải lại danh sách gốc nếu từ khóa rỗng
                    return;
                }

                BLLChiNhanh bll = new BLLChiNhanh();
                List<ChiNhanh> lst = bll.GetChiNhanhs();

                // Lọc danh sách theo từ khóa
                var ketQua = lst.Where(cn =>
                    (!string.IsNullOrEmpty(cn.MaChiNhanh) && cn.MaChiNhanh.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(cn.TenChiNhanh) && cn.TenChiNhanh.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(cn.DiaChi) && cn.DiaChi.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(cn.SoDienThoai) && cn.SoDienThoai.ToLower().Contains(keyword)) ||
                    (cn.TrangThai ? "hoạt động" : "ngừng hoạt động").ToLower().Contains(keyword)
                ).Select(cn => new
                {
                    cn.MaChiNhanh,
                    cn.TenChiNhanh,
                    cn.DiaChi,
                    cn.SoDienThoai,
                    TrangThai = cn.TrangThai ? "Hoạt động" : "Ngừng hoạt động"
                }).ToList();

                // Cập nhật DataGridView
                dgrDanhSachChiNhanh.DataSource = null;
                dgrDanhSachChiNhanh.Columns.Clear();
                dgrDanhSachChiNhanh.DataSource = ketQua;

                // Định dạng lại các cột
                if (ketQua.Count > 0)
                {
                    dgrDanhSachChiNhanh.Columns["MaChiNhanh"].HeaderText = "Mã Chi Nhánh";
                    dgrDanhSachChiNhanh.Columns["TenChiNhanh"].HeaderText = "Tên Chi Nhánh";
                    dgrDanhSachChiNhanh.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    dgrDanhSachChiNhanh.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                    dgrDanhSachChiNhanh.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    dgrDanhSachChiNhanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Hiển thị thông báo nếu không tìm thấy
                if (ketQua.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy chi nhánh nào phù hợp với từ khóa '{keyword}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
