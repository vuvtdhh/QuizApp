using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Cuoi_Ky
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung quanLyNguoiDung = new frmQuanLyNguoiDung();
            quanLyNguoiDung.Show();
            this.Hide();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            DialogResult re = MessageBox.Show("Bạn đã đăng xuất khỏi phần mềm! Bạn có muốn đăng nhập lại không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.Show();
            }
        }
    }
}
