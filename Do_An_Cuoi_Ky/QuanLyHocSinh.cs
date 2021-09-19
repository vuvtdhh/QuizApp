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
    public partial class frmQuanLyHocSinh : Form
    {
        public frmQuanLyHocSinh()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                this.Text = "Thống Kê Học Sinh";
                var hs = from kq in db.KetQuaThis
                         select new
                         {
                             kq.ID,
                             kq.TaiKhoan,
                             kq.MaDe,
                             kq.DiemThi,
                             kq.Cau01,
                             kq.Cau02,
                             kq.Cau03,
                             kq.Cau04,
                             kq.Cau05,
                             kq.Cau06,
                             kq.Cau07,
                             kq.Cau08,
                             kq.Cau09,
                             kq.Cau10,
                         };
                gvThongKe.DataSource = hs;
            }
        }

        private void btnKyThi_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                this.Text = "Thống Kê Kỳ Thi";
                var kt = db.KyThis.Select(k => k);
                gvThongKe.DataSource = kt;
            }
        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                this.Text = "Thông Kê Câu Hỏi";
                var ch = from c in db.CauHois
                         select new
                         {
                             c.ID,
                             c.CauHoi1,
                             c.SoLanRaDe,
                             c.SoLanTraLoi,
                             c.SoLanTraLoiDung
                         };
                gvThongKe.DataSource = ch;
            }
        }

        private void frmQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            gvThongKe.ReadOnly = true;
            gvThongKe.AllowUserToAddRows = false;
            gvThongKe.AllowUserToDeleteRows = false;
        }

        private void frmQuanLyHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
            this.Hide();
        }
    }
}
