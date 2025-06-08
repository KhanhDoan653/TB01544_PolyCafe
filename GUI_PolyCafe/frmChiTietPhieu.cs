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
using static BLL_PolyCafe.BLLChiTietPhieu;

namespace GUI_PolyCafe
{
    public partial class frmChiTietPhieu : Form
    {
        private TheLuuDong theLuuDong;
        private PhieuBanHang phieuBanHang;
        private NhanVien nhanVien;
        private List<ChiTietPhieu> lstChiTiet;
        private List<SanPham> lstSanPham;
        bool isActive = true;
        public frmChiTietPhieu(TheLuuDong the, PhieuBanHang phieu, NhanVien nv)
        {
            InitializeComponent();
            theLuuDong = the;
            phieuBanHang = phieu;
            nhanVien = nv;
            lstChiTiet = new List<ChiTietPhieu>();
            lstSanPham = new List<SanPham>();
            isActive = phieu.TrangThai;
        }

        private void activeTranfer()
        {
            if (isActive)
            {
                btnThemChiTiet.Enabled = false;
                btnXoaChiTiet.Enabled = false;
                txtPhanTram.Enabled = false;
            }
        }

        private void LoadInfo()
        {
            lbChuSoHuu.Text = $"{theLuuDong.MaThe} - {theLuuDong.ChuSoHuu}";
            lbMaPhieu.Text = phieuBanHang.MaPhieu;
            lbNgayLap.Text = phieuBanHang.NgayTao.ToString("dd/MM/yyyy");
            txtPhanTram.Text = phieuBanHang.PhanTramGiam.ToString("N2"); // Hiển thị PhanTramGiam
        }

        private void frmChiTietPhieu_Load(object sender, EventArgs e)
        {
            loadThanhToan();
            LoadInfo();
            loadSanPham();
            loadChiTietPhieu(phieuBanHang.MaPhieu);
            activeTranfer();
            TinhTongTien();
        }
        private void loadSanPham()
        {
            BLLSanPham sp = new BLLSanPham();
            lstSanPham = sp.GetSanPhamList(1);
            dgrSanPham.DataSource = lstSanPham;
            dgrSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgrSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgrSanPham.Columns["DonGia"].HeaderText = "Đơn Gía";
            dgrSanPham.Columns["TenLoai"].HeaderText = "Loại Sản Phẩm";
            dgrSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";


            dgrSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadChiTietPhieu(string maPhieu)
        {
            BLLChiTietPhieu bllChiTietPhieu = new BLLChiTietPhieu();
            lstChiTiet = bllChiTietPhieu.GetChiTietPhieuList(maPhieu);
            dgrChiTiet.DataSource = lstChiTiet;
            dgrChiTiet.Columns["MaChiTiet"].Visible = false;
            dgrChiTiet.Columns["MaPhieu"].Visible = false;
            dgrChiTiet.Columns["MaSanPham"].Visible = false;
            dgrChiTiet.Columns["TenSanPham"].HeaderText = "Sản Phẩm";
            dgrChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgrChiTiet.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgrChiTiet.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgrChiTiet.Columns["SoLuong"].ReadOnly = false;

            dgrChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dgrChiTiet.Columns)
            {
                col.ReadOnly = true;
            }
            dgrChiTiet.Columns["SoLuong"].ReadOnly = false;
        }

        private void dgrSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgrSanPham.Rows[e.RowIndex];

                // Tạo đối tượng từ dữ liệu hàng
                SanPham sanPham = new SanPham
                {
                    MaSanPham = row.Cells["MaSanPham"].Value.ToString(),
                    TenSanPham = row.Cells["TenSanPham"].Value.ToString(),
                    DonGia = Convert.ToInt32(row.Cells["DonGia"].Value)
                };

                transfer(sanPham);
            }
        }

        private void transfer(SanPham sp, int soLuong = 1)
        {
            if (isActive)
            {
                return;
            }
            if (sp != null)
            {
                BLLChiTietPhieu bllChiTietPhieu = new BLLChiTietPhieu();
                ChiTietPhieu existingItem = lstChiTiet.FirstOrDefault(item => item.MaSanPham == sp.MaSanPham);
                if (existingItem != null)
                {
                    existingItem.SoLuong += soLuong;
                    string result = bllChiTietPhieu.UpdateSoLuong(existingItem);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ChiTietPhieu ct = new ChiTietPhieu()
                    {
                        MaPhieu = phieuBanHang.MaPhieu,
                        MaSanPham = sp.MaSanPham,
                        SoLuong = soLuong,
                        DonGia = sp.DonGia,
                    };
                    string result = bllChiTietPhieu.InsertChiTietPhieu(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                loadChiTietPhieu(phieuBanHang.MaPhieu);
                TinhTongTien();

            }
        }
        private void deleteChiTiet()
        {
            if (dgrChiTiet.CurrentRow != null)
            {
                string id = Convert.ToString(dgrChiTiet.CurrentRow.Cells["MaChiTiet"].Value);
                string name = Convert.ToString(dgrChiTiet.CurrentRow.Cells["TenSanPham"].Value);
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phầm {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BLLChiTietPhieu bllChiTietPhieu = new BLLChiTietPhieu();
                    string kq = bllChiTietPhieu.DeleteChiTiet(id); ;
                    if (string.IsNullOrEmpty(kq))
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                        TinhTongTien();

                    }
                }
            }
        }

        private void dgrChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BLLChiTietPhieu bllChiTietPhieu = new BLLChiTietPhieu();
                ChiTietPhieu ct = lstChiTiet[e.RowIndex];
                int newQuantity;
                if (int.TryParse(dgrChiTiet.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString(), out newQuantity))
                {
                    ct.SoLuong = newQuantity;
                    string result = bllChiTietPhieu.UpdateSoLuong(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Đảm bảo ko lỗi khi đang edit mà chuyển ô
                    this.BeginInvoke((Action)(() =>
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                        TinhTongTien();
                    }));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            deleteChiTiet();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (dgrSanPham.CurrentRow != null)
            {
                string id = Convert.ToString(dgrSanPham.CurrentRow.Cells["MaSanPham"].Value);
                string ten = Convert.ToString(dgrSanPham.CurrentRow.Cells["TenSanPham"].Value);
                decimal dongia = Convert.ToDecimal(dgrSanPham.CurrentRow.Cells["DonGia"].Value);
                SanPham sanPham = new SanPham
                {
                    MaSanPham = id,
                    TenSanPham = ten,
                    DonGia = dongia
                };

                transfer(sanPham);
            }
        }
        private void loadThanhToan()
        {
            txtTong.Text = "0";
            txtGiamGia.Text = "0";
            txtPhanTram.Text = "0";
            txtThanhTien.Text = "0";
            txtDichVu.Text = "0";
        }
        private void TinhTongTien()
        {
            decimal tong = lstChiTiet.Sum(ct => ct.ThanhTien);
            decimal giamGia = 0;
            ChiTietPhieuService service = new ChiTietPhieuService();
            decimal phanTram = decimal.TryParse(txtPhanTram.Text, out var pt) ? pt : 0;
            decimal dichVu = decimal.TryParse(txtDichVu.Text, out var dv) ? dv : 0;

            decimal thanhTien = service.TinhTongTien(lstChiTiet, phanTram, dichVu);
            txtThanhTien.Text = thanhTien.ToString("N0");

            giamGia = tong * (phanTram / 100);
            thanhTien = tong - giamGia + dichVu;

            txtTong.Text = tong.ToString("N0");
            txtGiamGia.Text = giamGia.ToString("N0");
            txtThanhTien.Text = thanhTien.ToString("N0");
        }

        private void txtDichVu_TextChanged(object sender, EventArgs e)
        {
            if (!isActive)
                TinhTongTien();
        }

        private void txtPhanTram_TextChanged(object sender, EventArgs e)
        {
            if (!isActive)
            {
                decimal value;
                if (decimal.TryParse(txtPhanTram.Text, out value))
                {
                    if (value < 0 || value > 100)
                    {
                        MessageBox.Show("Phần trăm giảm giá phải từ 0 đến 100!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPhanTram.Text = "0";
                        return;
                    }
                }
                else if (!string.IsNullOrEmpty(txtPhanTram.Text))
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhanTram.Text = "0";
                    return;
                }

                TinhTongTien();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!isActive)
            {
                decimal phanTram;
                if (!decimal.TryParse(txtPhanTram.Text, out phanTram) || phanTram < 0 || phanTram > 100)
                {
                    MessageBox.Show("Vui lòng nhập phần trăm giảm giá hợp lệ (0-100)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật PhanTramGiam vào PhieuBanHang
                phieuBanHang.PhanTramGiam = phanTram;
                BLLPhieuBanHang bllPhieuBanHang = new BLLPhieuBanHang();
                string result = bllPhieuBanHang.UpdatePhanTramGiam(phieuBanHang); // Sử dụng UpdatePhanTramGiam

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi lưu
                }
                else
                {
                    MessageBox.Show("Lỗi: " + result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
