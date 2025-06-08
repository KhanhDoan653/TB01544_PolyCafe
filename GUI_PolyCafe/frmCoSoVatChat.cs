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
    public partial class frmCoSoVatChat : Form
    {
        public frmCoSoVatChat()
        {
            InitializeComponent();
        }
        public void ClearForm()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = true;

            // Gọi GenerateMaSanPham để tạo mã sản phẩm mới
            BLLCoSoVatChat bll = new BLLCoSoVatChat();
            txtMaCS.Text = bll.GenerateMaCoSo(); // Hiển thị mã sản phẩm mới lên txtMaSanPham

            txtTenCS.Clear();
            txtSoLuong.Clear();
            cboChiNhanh.SelectedIndex = -1;
            txtTim.Clear();
        }
        public void LoadChiNhanh()
        {
            BLLChiNhanh bllChiNhanh = new BLLChiNhanh();
            List<ChiNhanh> dsChiNhanh = bllChiNhanh.GetChiNhanhs();
            dsChiNhanh.Insert(0, new ChiNhanh() { MaChiNhanh = string.Empty, TenChiNhanh = string.Format("--Chọn Chi Nhánh--") });
            cboChiNhanh.DataSource = dsChiNhanh;
            cboChiNhanh.DisplayMember = "TenChiNhanh";
            cboChiNhanh.ValueMember = "MaChiNhanh";
        }

        private void LoadDanhSach()
        {
            BLLCoSoVatChat bllCoSo = new BLLCoSoVatChat();
            BLLChiNhanh bllChiNhanh = new BLLChiNhanh();

            // Lấy danh sách
            List<CoSoVatChat> coSoList = bllCoSo.GetCoSoVatChats();
            List<ChiNhanh> chiNhanhList = bllChiNhanh.GetChiNhanhs();

            if (coSoList == null || chiNhanhList == null)
            {
                MessageBox.Show("Không thể tải danh sách dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gộp dữ liệu từ CoSoVatChat và ChiNhanh để hiện TenChiNhanh
            var dataHienThi = coSoList.Select(cs => new
            {
                MaCoSo = cs.MaCoSo,
                TenCoSo = cs.TenCoSo,
                SoLuong = cs.SoLuong,
                TenChiNhanh = chiNhanhList.FirstOrDefault(cn => cn.MaChiNhanh == cs.MaChiNhanh)?.TenChiNhanh ?? "Không xác định"
            }).ToList();

            // Gán vào DataGridView
            dgrDanhSach.AutoGenerateColumns = true;
            dgrDanhSach.DataSource = dataHienThi;

            // Đặt tiêu đề cột
            dgrDanhSach.Columns["MaCoSo"].HeaderText = "Mã Cơ Sở Vật Chất";
            dgrDanhSach.Columns["TenCoSo"].HeaderText = "Tên Cơ Sở Vật Chất";
            dgrDanhSach.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgrDanhSach.Columns["TenChiNhanh"].HeaderText = "Chi Nhánh";
        }

        private void frmCoSoVatChat_Load(object sender, EventArgs e)
        {
            LoadChiNhanh();
            ClearForm();
            LoadDanhSach();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maCS = txtMaCS.Text.Trim();
                string tenCS = txtTenCS.Text.Trim();
                string soLuong = txtSoLuong.Text.Trim();
                string maCN = cboChiNhanh.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(maCS) || string.IsNullOrEmpty(tenCS) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(maCN))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(soLuong, out int soLuongInt) || soLuongInt < 0)
                {
                    MessageBox.Show("Số lượng phải là một số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Tạo đối tượng sản phẩm
                CoSoVatChat cs = new CoSoVatChat
                {
                    MaCoSo = maCS,
                    TenCoSo = tenCS,
                    SoLuong = soLuongInt,
                    MaChiNhanh = maCN
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BLLCoSoVatChat bll = new BLLCoSoVatChat();
                bll.InsertCoSoVatChat(cs);

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
                string maCS = txtMaCS.Text.Trim();
                string tenCS = txtTenCS.Text.Trim();
                string soLuongText = txtSoLuong.Text.Trim();
                string maCN = cboChiNhanh.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(maCS) || string.IsNullOrEmpty(tenCS) || string.IsNullOrEmpty(soLuongText) || string.IsNullOrEmpty(maCN))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(soLuongText, out int soLuong) || soLuong < 0)
                {
                    MessageBox.Show("Số lượng phải là một số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CoSoVatChat cs = new CoSoVatChat
                {
                    MaCoSo = maCS,
                    TenCoSo = tenCS,
                    SoLuong = soLuong,
                    MaChiNhanh = maCN
                };

                BLLCoSoVatChat bll = new BLLCoSoVatChat();
                string result = bll.UpdateCoSoVatChat(cs);

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
            string maCS = txtMaCS.Text.Trim();
            string tenCS = txtTenCS.Text.Trim();
            string soLuongText = txtSoLuong.Text.Trim();
            string maCN = cboChiNhanh.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(soLuongText))
            {
                MessageBox.Show("Vui lòng chọn cơ sở vật chất cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(maCN))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa CSVC này không? {maCN} - {maCN}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLSanPham bus = new BLLSanPham();
                string kq = bus.DeleteSanPham(maCN);

                if (string.IsNullOrEmpty(kq))
                {

                    MessageBox.Show($"Xóa thông tin {maCN} - {tenCS} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSach();
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
            LoadDanhSach();
        }

        private void dgrDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgrDanhSach.Rows[e.RowIndex];

            if (row != null)
            {
                txtMaCS.Text = row.Cells["MaCoSo"].Value.ToString();
                txtTenCS.Text = row.Cells["TenCoSo"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                // Tìm kiếm mã chi nhánh tương ứng
                string tenChiNhanh = row.Cells["TenChiNhanh"].Value.ToString();
                BLLChiNhanh bllChiNhanh = new BLLChiNhanh();
                var chiNhanh = bllChiNhanh.GetChiNhanhs().FirstOrDefault(cn => cn.TenChiNhanh == tenChiNhanh);

                if (chiNhanh != null)
                {
                    cboChiNhanh.SelectedValue = chiNhanh.MaChiNhanh;
                }

                btThem.Enabled = false;
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
        }
        private void TimKiem()
        {
            string keyword = txtTim.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                // Có thể chọn xóa kết quả tìm nếu ô trống
                dgrDanhSach.DataSource = null;
                return;
            }

            try
            {
                BLLCoSoVatChat bll = new BLLCoSoVatChat();
                List<CoSoVatChat> ketQua = bll.GetCoSoVatChats()
                    .Where(sp => sp.TenCoSo.ToLower().Contains(keyword) || sp.MaCoSo.ToLower().Contains(keyword))
                    .ToList();

                BLLChiNhanh bllChiNhanh = new BLLChiNhanh();
                dgrDanhSach.AutoGenerateColumns = true;
                dgrDanhSach.DataSource = ketQua.Select(cs => new
                {
                    MaCoSo = cs.MaCoSo,
                    TenCoSo = cs.TenCoSo,
                    SoLuong = cs.SoLuong,
                    TenChiNhanh = bllChiNhanh.GetChiNhanhs().FirstOrDefault(cn => cn.MaChiNhanh == cs.MaChiNhanh)?.TenChiNhanh ?? "Không xác định"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                string maChiNhanh = cboChiNhanh.SelectedValue?.ToString();
                int soLuongMin = 0;
                int.TryParse(txtSoLuong.Text, out soLuongMin);

                BLLCoSoVatChat bll = new BLLCoSoVatChat();
                List<CoSoVatChat> danhSach = bll.GetCoSoVatChats();

                // Lọc nâng cao
                var ketQua = danhSach.Where(cs =>
                    (string.IsNullOrEmpty(maChiNhanh) || cs.MaChiNhanh == maChiNhanh) &&
                    cs.SoLuong >= soLuongMin
                ).ToList();

                BLLChiNhanh bllChiNhanh = new BLLChiNhanh();
                dgrDanhSach.AutoGenerateColumns = true;
                dgrDanhSach.DataSource = ketQua.Select(cs => new
                {
                    MaCoSo = cs.MaCoSo,
                    TenCoSo = cs.TenCoSo,
                    SoLuong = cs.SoLuong,
                    TenChiNhanh = bllChiNhanh.GetChiNhanhs().FirstOrDefault(cn => cn.MaChiNhanh == cs.MaChiNhanh)?.TenChiNhanh ?? "Không xác định"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtTim.Text.Trim().ToLower();
                BLLCoSoVatChat bll = new BLLCoSoVatChat();
                List<CoSoVatChat> danhSach = bll.GetCoSoVatChats();

                // Lấy danh sách chi nhánh để đối chiếu tên
                BLLChiNhanh bllChiNhanh = new BLLChiNhanh();
                var danhSachChiNhanh = bllChiNhanh.GetChiNhanhs();

                // Tách từ khóa tìm kiếm thành nhiều từ nếu có nhập
                var tuKhoaList = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Nếu không nhập gì, hiển thị toàn bộ
                List<CoSoVatChat> ketQua;
                if (tuKhoaList.Length == 0)
                {
                    ketQua = danhSach;
                }
                else
                {
                    ketQua = danhSach.Where(sp =>
                    {
                        string tenChiNhanh = danhSachChiNhanh
                            .FirstOrDefault(cn => cn.MaChiNhanh == sp.MaChiNhanh)?.TenChiNhanh?.ToLower() ?? "";

                        return tuKhoaList.All(tuKhoa =>
                            (sp.MaCoSo?.ToLower().Contains(tuKhoa) ?? false) ||
                            (sp.TenCoSo?.ToLower().Contains(tuKhoa) ?? false) ||
                            tenChiNhanh.Contains(tuKhoa)
                        );
                    }).ToList();
                }

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị kết quả tìm được
                dgrDanhSach.AutoGenerateColumns = true;
                dgrDanhSach.DataSource = ketQua.Select(cs => new
                {
                    MaCoSo = cs.MaCoSo,
                    TenCoSo = cs.TenCoSo,
                    SoLuong = cs.SoLuong,
                    TenChiNhanh = danhSachChiNhanh
                        .FirstOrDefault(cn => cn.MaChiNhanh == cs.MaChiNhanh)?.TenChiNhanh ?? "Không xác định"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
