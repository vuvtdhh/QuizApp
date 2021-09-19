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
    public partial class frmKetQuaThi : Form
    {
        public frmKetQuaThi()
        {
            InitializeComponent();
        }

        private void frmKetQuaThi_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var ketQua = db.KetQuaThis.Where(kq => kq.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0);
                gvKetQuaThi.DataSource = ketQua;
                gvKetQuaThi.Columns["Stt"].Visible = false;
                gvKetQuaThi.Columns["User"].Visible = false;
                gvKetQuaThi.Columns["DeThi"].Visible = false;
                gvKetQuaThi.ReadOnly = true;
                gvKetQuaThi.AllowUserToAddRows = false;
                gvKetQuaThi.AllowUserToDeleteRows = false;
            }
        }

        private void btnQuayVeTrangChu_Click(object sender, EventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
            this.Hide();
        }

        private void frmKetQuaThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmThongTinCaNhan thongTinCaNhan = new frmThongTinCaNhan();
            thongTinCaNhan.Show();
            this.Hide();
        }
    }
}
