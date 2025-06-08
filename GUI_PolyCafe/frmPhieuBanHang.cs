using BLL_PolyCafe;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;
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
    public partial class frmPhieuBanHang : Form
    {
        private bool isLoadingTheLuuDongData = true;
        public frmPhieuBanHang()
        {
            InitializeComponent();
        }

        private void frmPhieuBanHang_Load(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }

        private void ClearForm(string msThe)
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = true;
            BLLPhieuBanHang bll = new BLLPhieuBanHang();
            txtMaPhieu.Text = bll.GenerateMaPhieu();
            cboNhanVien.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdChoXacNhan.Enabled = true;
            rdDaThanhToan.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdChoXacNhan.Checked = true;
            txtTim.Clear();
        }

        private void LoadNhanVien()
        {
            try
            {
                BLLNhanVien bllNhanVien = new BLLNhanVien();
                List<NhanVien> dsLoai = bllNhanVien.GetNhanViens();
                if (AuthUtil.user.VaiTro)
                {
                    dsLoai.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Vui lòng chọn nhân viên--") });
                }
                else
                {
                    dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                    cboNhanVien.Enabled = false;
                }
                cboNhanVien.DataSource = dsLoai;
                cboNhanVien.ValueMember = "MaNhanVien";
                cboNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLuuDong()
        {
            BLLTheLuuDong bllTheLuuDong = new BLLTheLuuDong();
            List<TheLuuDong> lst = bllTheLuuDong.GetTheLuuDongList();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            cboMaTheLuuDong.DataSource = lst;
            cboMaTheLuuDong.ValueMember = "MaThe";
            cboMaTheLuuDong.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }

        private void LoadDanhSachPhieu(string maThe)
        {
            BLLPhieuBanHang bllPhieuBanHang = new BLLPhieuBanHang();
            List<PhieuBanHang> lst = bllPhieuBanHang.GetListPhieuBanHang(maThe);
            if (!AuthUtil.user.VaiTro)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                cboNhanVien.Enabled = false;
            }
            dgvDanhSachPhieu.DataSource = lst;
            dgvDanhSachPhieu.Columns["MaThe"].HeaderText = "Mã thẻ";
            dgvDanhSachPhieu.Columns["MaPhieu"].HeaderText = "Mã phiếu bán hàng";
            dgvDanhSachPhieu.Columns["ChuSoHuu"].HeaderText = "Chủ sở hữu thẻ";
            dgvDanhSachPhieu.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvDanhSachPhieu.Columns["HoTen"].HeaderText = "Tên nhân viên";
            dgvDanhSachPhieu.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dgvDanhSachPhieu.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dgvDanhSachPhieu.Columns["TrangThaiText"].HeaderText = "Trạng thái";
            dgvDanhSachPhieu.Columns["PhanTramGiam"].HeaderText = "Giảm giá (%)"; // Thêm cột Giảm giá
            dgvDanhSachPhieu.Columns["PhanTramGiam"].DefaultCellStyle.Format = "N2"; // Định dạng số thập phân
            dgvDanhSachPhieu.Columns["TrangThai"].Visible = false;
        }

        private void dgvDanhSachPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdDaThanhToan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string maNhanVien = cboNhanVien.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdChoXacNhan.Checked)
            {
                trangThai = false; // Trạng thái "chờ xác nhận"
            }
            else
            {
                trangThai = true; // Trạng thái "đã thanh toán"
            }

            decimal phanTramGiam;
            if (!decimal.TryParse(txtPhanTramGiam.Text, out phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm giá hợp lệ (0-100)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai,
                PhanTramGiam = phanTramGiam // Lấy giá trị từ txtPhanTramGiam
            };

            BLLPhieuBanHang bll = new BLLPhieuBanHang();
            string result = bll.InsertPhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm phiếu bán hàng thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cboMaTheLuuDong.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string maPhieu = txtMaPhieu.Text;
            string maNhanVien = cboNhanVien.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdChoXacNhan.Checked)
            {
                trangThai = false; // Trạng thái "chờ xác nhận"
            }
            else
            {
                trangThai = true; // Trạng thái "đã thanh toán"
            }

            decimal phanTramGiam;
            if (!decimal.TryParse(txtPhanTramGiam.Text, out phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm giá hợp lệ (0-100)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe) || string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai,
                PhanTramGiam = phanTramGiam // Lấy giá trị từ txtPhanTramGiam
            };

            BLLPhieuBanHang bll = new BLLPhieuBanHang();
            string result = bll.UpdatePhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật phiếu bán hàng thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cboMaTheLuuDong.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string chuSoHuu = cboMaTheLuuDong.Text;
            if (string.IsNullOrEmpty(maPhieu))
            {
                if (dgvDanhSachPhieu.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachPhieu.SelectedRows[0];
                    maPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin phiếu bán hàng cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu bán hàng {maPhieu} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLPhieuBanHang bll = new BLLPhieuBanHang();
                string kq = bll.DeletePhieuBanHang(maPhieu);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin phiếu bán hàng {maPhieu} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(maThe);
                    LoadTheLuuDong();
                    LoadNhanVien();
                    LoadDanhSachPhieu("");

                    cboMaTheLuuDong.SelectedValue = maThe;
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                MessageBox.Show("Vui lòng nhập để tìm kiếm");
                return;
            }
            try
            {
                string keyword = txtTim.Text.Trim().ToLower();

                BLLPhieuBanHang bllPhieuBanHang = new BLLPhieuBanHang();
                List<PhieuBanHang> danhSach = bllPhieuBanHang.GetListPhieuBanHang("");

                var ketQua = danhSach.Where(p =>
                    (!string.IsNullOrEmpty(p.MaPhieu) && p.MaPhieu.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.MaThe) && p.MaThe.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.MaNhanVien) && p.MaNhanVien.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.HoTen) && p.HoTen.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.ChuSoHuu) && p.ChuSoHuu.ToLower().Contains(keyword)) ||
                    p.NgayTao.ToString("dd/MM/yyyy HH:mm:ss").ToLower().Contains(keyword) ||
                    p.TrangThaiText.ToLower().Contains(keyword)
                ).ToList();

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào phù hợp với từ khóa '" + txtTim.Text + "'");
                    return;
                }

                dgvDanhSachPhieu.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDanhSachPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieu = dgvDanhSachPhieu.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            string maThe = dgvDanhSachPhieu.Rows[e.RowIndex].Cells["MaThe"].Value.ToString();
            string maNV = dgvDanhSachPhieu.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
            PhieuBanHang phieu = (PhieuBanHang)dgvDanhSachPhieu.CurrentRow.DataBoundItem;
            TheLuuDong the = new TheLuuDong();
            NhanVien nv = new NhanVien();
            foreach (TheLuuDong item in cboMaTheLuuDong.Items)
            {
                if (item.MaThe == maThe)
                {
                    the = item;
                    break;
                }
            }

            foreach (NhanVien item in cboNhanVien.Items)
            {
                if (item.MaNhanVien == maNV)
                {
                    nv = item;
                    break;
                }
            }
            frmChiTietPhieu frmChiTiet = new frmChiTietPhieu(the, phieu, nv);
            frmChiTiet.ShowDialog();

        }

        private void dgvDanhSachPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Bỏ qua nếu nhấp vào header

            isLoadingTheLuuDongData = true;
            DataGridViewRow row = dgvDanhSachPhieu.Rows[e.RowIndex];
            cboMaTheLuuDong.SelectedValue = row.Cells["MaThe"].Value.ToString();
            cboNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
            dtpNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();
            txtPhanTramGiam.Text = row.Cells["PhanTramGiam"].Value.ToString(); // Hiển thị PhanTramGiam

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdDaThanhToan.Checked = true;
                rdDaThanhToan.Enabled = false;
                rdChoXacNhan.Enabled = false;
                cboNhanVien.Enabled = false;
                dtpNgayTao.Enabled = false;
                btThem.Enabled = false;
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            else
            {
                rdDaThanhToan.Checked = false;
                rdDaThanhToan.Enabled = true;
                rdChoXacNhan.Enabled = true;
                cboNhanVien.Enabled = true;
                rdChoXacNhan.Checked = true;
                rdChoXacNhan.Enabled = true;
                dtpNgayTao.Enabled = true;
                btThem.Enabled = false;
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
        }
    }
}
