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
    public partial class frmChinh : Form
    {
        public frmChinh(DTO_PolyCafe.NhanVien nv)
        {
            InitializeComponent();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResetPassWord resetPassword = new frmResetPassWord();
            resetPassword.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResetPassWord resetPassword = new frmResetPassWord();
            resetPassword.Show();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doiMatKhauToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmResetPassWord resetPassword = new frmResetPassWord();
            resetPassword.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form currentFormChild;
        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }
    }
}
