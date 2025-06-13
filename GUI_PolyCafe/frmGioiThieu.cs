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
    public partial class frmGioiThieu : Form
    {
        private BLLGioiThieu bll = new BLLGioiThieu();
        public frmGioiThieu()
        {
            InitializeComponent();
        }

        private void frmGioiThieu_Load(object sender, EventArgs e)
        {
            try
            {
                GioiThieu gt = bll.LayGioiThieu();
                txtGioiThieu.Text = gt.NoiDung;
                txtGioiThieu.ReadOnly = true;
                txtGioiThieu.Font = new Font("Segoe UI", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nội dung giới thiệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

    }
}
