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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            LoadQueQuan();
            LoadKhoi();
            LoadLoaiTaiKhoan();
        }

        void LoadQueQuan()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //Lamda Syntax.
                var QueQuan = db.QueQuans.Select(q => q.TenTinhThanh);
                cbbQueQuan.DataSource = QueQuan;
            }
        }

        void LoadLoaiTaiKhoan()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //Query Syntax.
                //var LoaiTaiKhoan = (from u in db.Users
                //                    select u.LoaiTaiKhoan).Distinct();
                //cbbLoaiTaiKhoan.DataSource = LoaiTaiKhoan;
                string[] cbb = new string[] { "HocSinh", "GiaoVien" };
                cbbLoaiTaiKhoan.DataSource = cbb;
            }
        }

        void LoadKhoi()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var Khoi = db.Khois.Select(k => k);
                cbbKhoi.DataSource = Khoi;
                cbbKhoi.DisplayMember = "TenKhoi";
                cbbKhoi.ValueMember = "TenKhoi";
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //1. Kiểm tra xem tài khoản đã tồn tại hay chưa?
                var KiemTra = db.Users.Where(u => u.TaiKhoan.CompareTo(txtTaiKhoan.Text) == 0);

                if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtXacNhanMatKhau.Text == "" || txtHoTen.Text == "" || txtLop.Text == "" || txtDienThoai.Text == "")
                    MessageBox.Show("Chưa nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (KiemTra.Any() == true) //KiemTra == null.
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
                    MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    User TaiKhoanMoi = new User();
                    TaiKhoanMoi.TaiKhoan = txtTaiKhoan.Text;
                    TaiKhoanMoi.MatKhau = txtMatKhau.Text;
                    TaiKhoanMoi.HoTen = txtHoTen.Text;
                    TaiKhoanMoi.NgaySinh = dtpNgaySinh.Value;
                    TaiKhoanMoi.QueQuan = cbbQueQuan.SelectedValue.ToString();
                    TaiKhoanMoi.Sdt = txtDienThoai.Text;
                    TaiKhoanMoi.Lop = txtLop.Text;
                    if(string.IsNullOrEmpty(cbbKhoi.SelectedText) == false)
                        TaiKhoanMoi.Khoi = cbbKhoi.SelectedValue.ToString();
                    TaiKhoanMoi.LoaiTaiKhoan = cbbLoaiTaiKhoan.SelectedValue.ToString();
                    db.Users.InsertOnSubmit(TaiKhoanMoi);
                    db.SubmitChanges();
                    MessageBox.Show("Tạo tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }
    }
}
