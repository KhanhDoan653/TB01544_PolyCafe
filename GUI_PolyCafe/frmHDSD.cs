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
    public partial class frmHDSD : Form
    {
        private BLLHDSD bll = new BLLHDSD();
        public frmHDSD()
        {
            InitializeComponent();
        }

        private void frmHDSD_Load(object sender, EventArgs e)
        {
            try
            {
                HDSD hd = bll.LayHuongDan();
                txtHuongDan.Text = hd.NoiDung;
                txtHuongDan.ReadOnly = true;
                txtHuongDan.Font = new Font("Segoe UI", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hướng dẫn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
