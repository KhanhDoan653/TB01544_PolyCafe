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
    public partial class frmDoanhThuTheoSanPham : Form
    {
        public frmDoanhThuTheoSanPham()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            BLLThongKe bllThongKe = new BLLThongKe();
            dgrThongKeSanPham.DataSource = null;
            dgrThongKeSanPham.DataSource = bllThongKe.getThongKeLoaiSP(string.Empty, dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
            dgrThongKeSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgrThongKeSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgrThongKeSanPham.Columns["SoLy"].HeaderText = "Số Lượng";
            dgrThongKeSanPham.Columns["SoLuongPhieu"].HeaderText = "Số Lượng Phiếu";
            dgrThongKeSanPham.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dgrThongKeSanPham.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgrThongKeSanPham.Columns["DaThanhToan"].HeaderText = "Đã Thanh Toán";
            dgrThongKeSanPham.Columns["TongTien"].DefaultCellStyle.Format = "N0"; // Định dạng số
        }
        private void LoadLoaiSanPham()
        {
            try
            {
                BLLLoaiSanPham bllLoaiSanPham = new BLLLoaiSanPham();
                List<LoaiSanPham> dsLoai = bllLoaiSanPham.GetLoaiSanPhamList();

                dsLoai.Insert(0, new LoaiSanPham() { MaLoai = string.Empty, TenLoai = string.Format("--Tất Cả--") });
                cbxLoaiSanPham.DataSource = dsLoai;
                cbxLoaiSanPham.ValueMember = "MaLoai";
                cbxLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DoanhThuTheoSanPham_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtpTuNgay.Value = firstDayOfMonth;
            LoadLoaiSanPham();
            btnThongKe_Click(sender, e);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(dtpDenNgay.Value.Date < dtpTuNgay.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string loai = cbxLoaiSanPham.SelectedValue.ToString();
            DateTime bd = dtpTuNgay.Value.Date;
            DateTime kt = dtpDenNgay.Value.Date;

            BLLThongKe busThongKe = new BLLThongKe();
            List<ThongKeTheoLoaiSanPham> result = busThongKe.getThongKeLoaiSP(loai, bd, kt);
            dgrThongKeSanPham.DataSource = result;
        }

        private void DoanhThuTheoSanPham_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }
    }
}
