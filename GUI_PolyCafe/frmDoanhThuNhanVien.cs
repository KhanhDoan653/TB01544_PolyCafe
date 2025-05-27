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
    public partial class frmDoanhThuNhanVien : Form
    {
        public frmDoanhThuNhanVien()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maNV = cbxNhanVien.SelectedValue.ToString();
            DateTime bd = dtpTuNgay.Value.Date;
            DateTime kt = dtpDenNgay.Value.Date;

            BLLThongKe bllThongKe = new BLLThongKe();
            List<ThongKeTheoNhanVien> result = bllThongKe.getThongKeNhanVien(maNV, bd, kt);
            dgrThongKeNhanVien.DataSource = result;
        }

        private void frmDoanhThuNhanVien_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }

        private void frmDoanhThuNhanVien_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtpTuNgay.Value = firstDayOfMonth;
            LoadNhanVien();

            btnThongKe_Click(sender, e);
        }
        private void LoadNhanVien()
        {
            try
            {
                BLLNhanVien bllNhanVien = new BLLNhanVien();
                List<NhanVien> dsNhanVien = bllNhanVien.GetNhanViens();
                dsNhanVien.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Tất Cả--") });
                cbxNhanVien.DataSource = dsNhanVien;
                cbxNhanVien.ValueMember = "MaNhanVien";
                cbxNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
