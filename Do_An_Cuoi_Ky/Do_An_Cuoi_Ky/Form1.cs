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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //Lưu dữ liệu người dùng vừa đăng nhập để sử dụng lại.
                NguoiDungHienTai.TaiKhoan = txtTaiKhoan.Text;

                //1. Kiểm tra Tài khoản có trong csdl không?
                //2. Nếu có => kiểm tra Mật khẩu có khớp không?
                var LayTaiKhoan = db.Users.Where(u => u.TaiKhoan.CompareTo(txtTaiKhoan.Text) == 0);
                var LayMatKhau = from u in db.Users
                                 where u.TaiKhoan.CompareTo(txtTaiKhoan.Text) == 0
                                 select new
                                 {
                                     u.MatKhau
                                 } into MK
                                 where MK.MatKhau.CompareTo(txtMatKhau.Text) == 0
                                 select MK;

                if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                    MessageBox.Show("Chưa nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (LayTaiKhoan.Any() == false)
                    MessageBox.Show("Tài khoản chưa được đăng ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (LayMatKhau.Any() == false)
                    MessageBox.Show("Sai mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
                    giaoVienHocSinh.Show();
                    this.Hide();
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.Show();
            this.Hide();
        }
    }
}
