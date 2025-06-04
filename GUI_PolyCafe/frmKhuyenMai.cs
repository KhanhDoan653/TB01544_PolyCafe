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
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachKhuyenMai();
        }
        private void ClearForm()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = true;

            txtMaKM.Clear();
            txtTenKM.Clear();

            numPhanTramGiam.Value = 0; // sửa từ .Clear() sang đặt giá trị mặc định

            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;

            chkTrangThai.Checked = true;
        }

        private void LoadDanhSachKhuyenMai()
        {
            BLLKhuyenMai bllKhuyenMai = new BLLKhuyenMai();
            dgvDanhSachKM.DataSource = null;
            List<KhuyenMai> lstSP = bllKhuyenMai.GetKhuyenMaiList();

            var dataWithImage = lstSP.Select(sp => new
            {
                sp.MaKM,
                sp.TenKM,
                sp.PhanTramGiam,
                sp.NgayBatDau,
                sp.NgayKetThuc,
                sp.TrangThai,
                TrangThaiText = sp.TrangThai ? "Đang được áp dụng" : "Hết khuyến mãi",
            }).ToList();

            dgvDanhSachKM.DataSource = dataWithImage;

            dgvDanhSachKM.Columns["MaKM"].HeaderText = "Mã KM";
            dgvDanhSachKM.Columns["TenKM"].HeaderText = "Tên KM";
            dgvDanhSachKM.Columns["PhanTramGiam"].HeaderText = "Phần trăm giảm";
            dgvDanhSachKM.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            dgvDanhSachKM.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            dgvDanhSachKM.Columns["TrangThaiText"].HeaderText = "Trạng thái";

            dgvDanhSachKM.Columns["TrangThai"].Visible = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrWhiteSpace(txtTenKM.Text) || numPhanTramGiam.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ thông tin khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng KhuyenMai từ dữ liệu nhập
                KhuyenMai km = new KhuyenMai
                {
                    MaKM = txtMaKM.Text.Trim(),
                    TenKM = txtTenKM.Text.Trim(),
                    PhanTramGiam = Convert.ToDecimal(numPhanTramGiam.Value),
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = dtpNgayKetThuc.Value,
                    TrangThai = chkTrangThai.Checked
                };

                // Khởi tạo đối tượng xử lý BLLKhuyenMai
                BLLKhuyenMai bllKhuyenMai = new BLLKhuyenMai();

                // Thêm khuyến mãi vào CSDL
                string message;
                bool isSuccess = bllKhuyenMai.InsertKhuyenMai(km, out message);

                if (isSuccess)
                {
                    MessageBox.Show("Thêm khuyến mãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachKhuyenMai();
                }
                else
                {
                    MessageBox.Show($"Thêm khuyến mãi thất bại: {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maKM = txtMaKM.Text.Trim();
            string tenKM = txtTenKM.Text.Trim();
            bool trangThai = chkTrangThai.Checked;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maKM))
            {
                MessageBox.Show("Mã khuyến mãi không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tenKM))
            {
                MessageBox.Show("Vui lòng nhập tên khuyến mãi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ngày bắt đầu & ngày kết thúc hợp lệ
            if (dtpNgayBatDau.Value < new DateTime(1753, 1, 1) || dtpNgayKetThuc.Value < new DateTime(1753, 1, 1))
            {
                MessageBox.Show("Ngày không hợp lệ! Vui lòng chọn ngày từ 01/01/1753 trở đi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhuyenMai khuyenMai = new KhuyenMai
            {
                MaKM = maKM,
                TenKM = tenKM,
                PhanTramGiam = Convert.ToDecimal(numPhanTramGiam.Value), // Bổ sung phần trăm giảm
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                TrangThai = trangThai
            };

            BLLKhuyenMai bus = new BLLKhuyenMai();
            string message;
            bool isSuccess = bus.UpdateKhuyenMai(khuyenMai, out message);

            if (isSuccess)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDanhSachKhuyenMai();
            }
            else
            {
                MessageBox.Show($"Lỗi: {message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachKM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachKM.Rows[e.RowIndex];
            txtMaKM.Text = row.Cells["MaKM"].Value.ToString();
            txtTenKM.Text = row.Cells["TenKM"].Value.ToString();
            numPhanTramGiam.Text = row.Cells["PhanTramGiam"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            chkTrangThai.Checked = trangThai;
            dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
            dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);

            // Bật nút "Sửa"
            btThem.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachKhuyenMai();
            ClearForm();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maKM = txtMaKM.Text.Trim();
            // Kiểm tra mã khuyến mãi
            if (string.IsNullOrEmpty(maKM))
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Xác nhận xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khuyến mãi '{maKM}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BLLKhuyenMai bllKhuyenMai = new BLLKhuyenMai();
                string message;
                bool isSuccess = bllKhuyenMai.DeleteKhuyenMai(maKM, out message);
                if (isSuccess)
                {
                    MessageBox.Show("Xóa khuyến mãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachKhuyenMai();
                }
                else
                {
                    MessageBox.Show($"Xóa khuyến mãi thất bại: {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim().ToLower();

            // Kiểm tra nếu ô tìm kiếm trống
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BLLKhuyenMai bLL = new BLLKhuyenMai();
                List<KhuyenMai> ketQua = bLL.GetKhuyenMaiList()
                    .Where(km => km.TenKM.ToLower().Contains(keyword) || km.MaKM.ToLower().Contains(keyword))
                    .ToList();

                // Kiểm tra nếu không có kết quả
                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khuyến mãi nào phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDanhSachKM.DataSource = null; // Đảm bảo danh sách trống
                    return;
                }

                // Hiển thị kết quả tìm kiếm
                dgvDanhSachKM.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
