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
    public partial class frmTheLuuDong : Form
    {
        public frmTheLuuDong()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();

            bool trangThai;

            if (cbkHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BLLTheLuuDong bus = new BLLTheLuuDong();
            string result = bus.InsertTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void frmTheLuuDong_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachThe();
        }
        private void LoadDanhSachThe()
        {
            BLLTheLuuDong bUSTheLuuDong = new BLLTheLuuDong();
            dgvDanhSachTheLuuDong.DataSource = null;
            dgvDanhSachTheLuuDong.DataSource = bUSTheLuuDong.GetTheLuuDongList();
            dgvDanhSachTheLuuDong.Columns["MaThe"].HeaderText = "Mã thẻ lưu động";
            dgvDanhSachTheLuuDong.Columns["ChuSoHuu"].HeaderText = "Chủ sở hữu";
            dgvDanhSachTheLuuDong.Columns["TrangThaiText"].HeaderText = "Trạng thái";
            dgvDanhSachTheLuuDong.Columns["TrangThai"].Visible = false;
        }

        private void ClearForm()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = true;
            txtChuSoHuu.Clear();
            txtChuSoHuu.Clear();
            cbkHoatDong.Checked = true;
        }

        private void dgvDanhSachTheLuuDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachTheLuuDong.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
            txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            cbkHoatDong.Checked = trangThai;

            // Bật nút "Sửa"
            btThem.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtMaThe.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();

            bool trangThai;

            if (cbkHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }
            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BLLTheLuuDong bus = new BLLTheLuuDong();
            string result = bus.UpdateTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();
            if (string.IsNullOrEmpty(maThe))
            {
                if (dgvDanhSachTheLuuDong.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachTheLuuDong.SelectedRows[0];
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thẻ lưu động để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thẻ lưu động {maThe} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLTheLuuDong bus = new BLLTheLuuDong();
                string kq = bus.DeleteTheLuuDong(maThe);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin thẻ lưu động {maThe} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachThe();
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
            LoadDanhSachThe();
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
                BLLTheLuuDong bus = new BLLTheLuuDong();
                List<TheLuuDong> ketQua = bus.GetTheLuuDongList()
                    .Where(t => t.MaThe.ToLower().Contains(keyword) || t.ChuSoHuu.ToLower().Contains(keyword))
                    .ToList();

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào phù hợp với từ khóa: " + keyword);
                    return;
                }

                dgvDanhSachTheLuuDong.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
