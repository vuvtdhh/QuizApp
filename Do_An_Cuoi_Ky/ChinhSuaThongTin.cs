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
    public partial class frmChinhSuaThongTin : Form
    {
        public frmChinhSuaThongTin()
        {
            InitializeComponent();
        }

        private void frmChinhSuaThongTin_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //var ThongTin = from u in db.Users
                //               where u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0
                //               select new
                //               {
                //                   u.Stt,
                //                   u.HoTen,
                //                   u.NgaySinh,
                //                   u.Sdt,
                //                   u.QueQuan,
                //                   u.Lop,
                //                   u.Khoi
                //                } into TT select TT;
                //gvChinhSuaThongTin.DataSource = ThongTin;
                //gvChinhSuaThongTin.ReadOnly = false;
                //gvChinhSuaThongTin.BeginEdit(true);
                //DataGridView không cho chỉnh sửa.
                db.DeferredLoadingEnabled = false;
                var ThongTin = from u in db.Users
                         where u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0
                         select u;
                gvChinhSuaThongTin.DataSource = ThongTin;
                gvChinhSuaThongTin.AutoGenerateColumns = true;
                gvChinhSuaThongTin.RowHeadersVisible = false;
                //Không cho sửa các cột.
                gvChinhSuaThongTin.Columns["TaiKhoan"].ReadOnly = true;
                gvChinhSuaThongTin.Columns["LoaiTaiKhoan"].ReadOnly = true;
                gvChinhSuaThongTin.Columns["Khoi"].ReadOnly = true;
                gvChinhSuaThongTin.Columns["Lop"].ReadOnly = true;
                //Không cho hiện các cột.
                gvChinhSuaThongTin.Columns["Stt"].Visible = false;
                gvChinhSuaThongTin.Columns["MatKhau"].Visible = false;
                //Nó truy vấn luôn cả khóa ngoại thành 1 cột mới???
                gvChinhSuaThongTin.Columns["Khoi1"].Visible = false;
                gvChinhSuaThongTin.Columns["QueQuan1"].Visible = false;
            }
        }

        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                if(NguoiDungHienTai.LayLoai().Trim() == "HocSinh")
                {
                    int stt = (int)gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["Stt"].Value;
                    string hoTen = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["HoTen"].Value.ToString();
                    DateTime ngaySinh = (DateTime)gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value;
                    string sdt = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["Sdt"].Value.ToString();
                    string queQuan = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["QueQuan"].Value.ToString();
                    string lop = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["Lop"].Value.ToString();
                    string khoi = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["Khoi"].Value.ToString();
                    User chinhSua = db.Users.Where(u => u.Stt.Equals(stt)).SingleOrDefault();
                    chinhSua.HoTen = hoTen;
                    chinhSua.NgaySinh = ngaySinh;
                    chinhSua.Sdt = sdt;
                    chinhSua.QueQuan = queQuan;
                    chinhSua.Lop = lop;
                    chinhSua.Khoi = khoi;
                    db.SubmitChanges();
                    frmChinhSuaThongTin_Load(sender, e);
                }
                else
                {
                    int stt = (int)gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["Stt"].Value;
                    string hoTen = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["HoTen"].Value.ToString();
                    DateTime ngaySinh = (DateTime)gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value;
                    string sdt = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["Sdt"].Value.ToString();
                    string queQuan = gvChinhSuaThongTin.SelectedCells[0].OwningRow.Cells["QueQuan"].Value.ToString();
                    User chinhSua = db.Users.Where(u => u.Stt.Equals(stt)).SingleOrDefault();
                    chinhSua.HoTen = hoTen;
                    chinhSua.NgaySinh = ngaySinh;
                    chinhSua.Sdt = sdt;
                    chinhSua.QueQuan = queQuan;
                    db.SubmitChanges();
                    frmChinhSuaThongTin_Load(sender, e);
                }
            }
        }

        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
            this.Hide();
        }

        private void frmChinhSuaThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmThongTinCaNhan thongTinCaNhan = new frmThongTinCaNhan();
            thongTinCaNhan.Show();
            this.Hide();
        }
    }
}
