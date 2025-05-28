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
    }
}
