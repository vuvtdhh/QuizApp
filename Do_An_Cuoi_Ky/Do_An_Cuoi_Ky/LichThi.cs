using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Cuoi_Ky
{
    public partial class frmLichThi : Form
    {
        public frmLichThi()
        {
            InitializeComponent();
        }

        private void frmLichThi_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var lichThi = db.LichThis.Where(lt => lt.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0);
                gvLichThi.DataSource = lichThi;
                gvLichThi.RowHeadersVisible = false;
                gvLichThi.Columns["User"].Visible = false;
                gvLichThi.ReadOnly = true;
            }
        }

        private void frmLichThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmThongTinCaNhan thongTinCaNhan = new frmThongTinCaNhan();
            thongTinCaNhan.Show();
            this.Hide();
        }

        private void btnQuayVeTrangChu_Click(object sender, EventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
            this.Hide();
        }
    }
}
