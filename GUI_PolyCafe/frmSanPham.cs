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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
            txtDonGia.Mask = "0000000000";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }
        private void ClearForm()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = true;
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            rdHoatDong.Checked = true;
            pbHinhAnh.Image = null;
        }

        private void LoadLoaiSanPham()
        {
            try
            {
                BLLLoaiSanPham bllLoaiSanPham = new BLLLoaiSanPham();
                List<LoaiSanPham> dsLoai = bllLoaiSanPham.GetLoaiSanPhamList();
                cboLoaiSanPham.DataSource = dsLoai;
                cboLoaiSanPham.ValueMember = "MaLoai";
                cboLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSanPham()
        {
            BLLSanPham bllSanPham = new BLLSanPham();
            dgvDanhSachSP.DataSource = null;
            List<SanPham> lstSP = bllSanPham.GetSanPhamList();

            var dataWithImage = lstSP.Select(sp => new
            {
                sp.MaSanPham,
                sp.TenSanPham,
                sp.DonGia,
                sp.MaLoai,
                sp.TrangThai,
                TrangThaiText = sp.TrangThai ? "Hoạt động" : "Ngừng bán",
                HinhAnh = LoadImage(sp.HinhAnh)
            }).ToList();

            dgvDanhSachSP.DataSource = dataWithImage;

            dgvDanhSachSP.Columns["MaSanPham"].HeaderText = "Mã SP";
            dgvDanhSachSP.Columns["TenSanPham"].HeaderText = "Tên SP";
            dgvDanhSachSP.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDanhSachSP.Columns["MaLoai"].HeaderText = "Mã loại";
            dgvDanhSachSP.Columns["TrangThaiText"].HeaderText = "Trạng thái";

            dgvDanhSachSP.Columns["TrangThai"].Visible = false;
            dgvDanhSachSP.Columns["HinhAnh"].HeaderText = "Hình ảnh";
            dgvDanhSachSP.Columns["HinhAnh"].Width = 100;
            ((DataGridViewImageColumn)dgvDanhSachSP.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private Image LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    using (var img = Image.FromFile(imagePath))
                    {
                        return new Bitmap(img);
                    }
                }
            }
            catch { }

            // Trả về ảnh trống nếu không tồn tại
            return new Bitmap(1, 1);
        }

        private void btUpAnh_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn hình ảnh sản phẩm"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    pbHinhAnh.Image = Image.FromFile(filePath);
                    // Lưu đường dẫn hình ảnh vào biến HinhAnh của sản phẩm
                    txtHinhAnh.Text = filePath; // Hoặc lưu vào đối tượng sản phẩm nếu cần
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có hình ảnh nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdHoatDong.Checked;
                string maSP = txtMaSanPham.Text.Trim();

                if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Không tìm thấy mã sản phẩm cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SanPham sp = new SanPham
                {
                    MaSanPham = maSP, // QUAN TRỌNG
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = txtHinhAnh.Text
                };

                BLLSanPham bUSSanPham = new BLLSanPham();
                string result = bUSSanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    ClearForm();
                    LoadDanhSachSanPham();
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
            string maSP = txtMaSanPham.Text.Trim();
            string tenSP = string.Empty;
            string hinhAnh = string.Empty;

            if (string.IsNullOrEmpty(maSP))
            {
                if (dgvDanhSachSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachSP.SelectedRows[0];
                    maSP = selectedRow.Cells["MaSanPham"].Value.ToString();
                    tenSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                    hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tenSP = txtTenSanPham.Text.Trim();
            }

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP} - {tenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLSanPham bus = new BLLSanPham();
                string kq = bus.DeleteSanPham(maSP);

                if (string.IsNullOrEmpty(kq))
                {

                    MessageBox.Show($"Xóa thông tin sản phẩm {maSP} - {tenSP} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdHoatDong.Checked;
                string hinhAnhPath = txtHinhAnh.Text.Trim(); // Đường dẫn ảnh

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai) || string.IsNullOrEmpty(hinhAnhPath))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra tệp hình ảnh có tồn tại hay không
                if (!System.IO.File.Exists(hinhAnhPath))
                {
                    MessageBox.Show("Hình ảnh không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = hinhAnhPath
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BLLSanPham bUSSanPham = new BLLSanPham();
                bUSSanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị sản phẩm trong DataGridView
                LoadDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemSP.Text))
            {
                MessageBox.Show("Vui lòng nhập để tìm kiếm");
                return;
            }

            try
            {
                string keyword = txtTimKiemSP.Text.Trim().ToLower();
                BLLSanPham bllSanPham = new BLLSanPham();
                List<SanPham> ketQua = bllSanPham.GetSanPhamList()
                    .Where(sp => sp.TenSanPham.ToLower().Contains(keyword) || sp.MaSanPham.ToLower().Contains(keyword))
                    .ToList();

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var dataWithImage = ketQua.Select(sp => new
                {
                    sp.MaSanPham,
                    sp.TenSanPham,
                    sp.DonGia,
                    sp.MaLoai,
                    sp.TrangThai,
                    TrangThaiText = sp.TrangThai ? "Hoạt động" : "Ngừng bán",
                    HinhAnh = LoadImage(sp.HinhAnh)
                }).ToList();

                dgvDanhSachSP.DataSource = dataWithImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }

        private void dgvDanhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachSP.Rows[e.RowIndex];
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            txtHinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
            cboLoaiSanPham.SelectedValue = row.Cells["MaLoai"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdHoatDong.Checked = true;
            }
            else
            {
                rdNgungBan.Checked = true;
            }

            // Kiểm tra nếu dữ liệu hình ảnh là Bitmap
            if (row.Cells["HinhAnh"].Value is Bitmap)
            {
                pbHinhAnh.Image = (Bitmap)row.Cells["HinhAnh"].Value;
            }
            else
            {
                string imagePath = row.Cells["HinhAnh"].Value.ToString();
                if (File.Exists(imagePath))
                {
                    pbHinhAnh.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pbHinhAnh.Image = null; // Nếu không tìm thấy ảnh, có thể hiển thị ảnh mặc định
                }
            }

            // Bật nút "Sửa"
            btThem.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }
    }
}
