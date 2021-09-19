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
    public partial class frmChungGiaoVienHocSinh : Form
    {
        public frmChungGiaoVienHocSinh()
        {
            InitializeComponent();
        }

        private void frmChungGiaoVienHocSinh_Load(object sender, EventArgs e)
        {

            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                lblHoTen.Text = NguoiDungHienTai.LayHoTen();
                lblLop.Text = NguoiDungHienTai.LayLop();
                string LoaiTaiKhoan = NguoiDungHienTai.LayLoai();
                if(LoaiTaiKhoan.Trim() == "HocSinh")
                {
                    btnQuanLyCauHoi.Hide();
                    btnQuanLyDeThi.Hide();
                    btnQuanLyHocSinh.Hide();
                    btnQuanLyKyThiThuOnTap.Hide();
                    btnQuanLyKyThi.Hide();
                    btnQuanLyNguoiDung.Hide();
                    frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
                    this.Text = "Học Sinh";
                    //this.Width = 450;
                    this.Height = 270;
                    picboxBanner.Height = 180;
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                }
                else if(LoaiTaiKhoan.Trim() == "GiaoVien")
                {
                    btnQuanLyNguoiDung.Visible = false;
                    this.Text = "Giáo Viên";
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                }
                else if(LoaiTaiKhoan.Trim() == "Admin")
                {
                    this.Text = "Admin";
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                }
            }
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan thongTinCaNhan = new frmThongTinCaNhan();
            thongTinCaNhan.Show();
            this.Hide();
        }

        private void btnOnLuyenThiThu_Click(object sender, EventArgs e)
        {
            frmOnLuyenThiThu onLuyenThiThu = new frmOnLuyenThiThu();
            this.Hide();
            onLuyenThiThu.Show();
        }

        private void btnLamBaiTracNghiem_Click(object sender, EventArgs e)
        {
            frmLamBaiTracNghiem lamBaiTracNghiem = new frmLamBaiTracNghiem();
            lamBaiTracNghiem.Show();
            this.Hide();
        }

        private void frmChungGiaoVienHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            DialogResult re = MessageBox.Show("Bạn đã đăng xuất khỏi phần mềm! Bạn có muốn đăng nhập lại không?", "Thông Báo", MessageBoxButtons.YesNo);
            if(re == DialogResult.Yes)
            {
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.Show();
            }
        }

        private void btnQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            frmQuanLyCauHoi quanLyCauHoi = new frmQuanLyCauHoi();
            quanLyCauHoi.Show();
            this.Hide();
        }

        private void btnQuanLyDeThi_Click(object sender, EventArgs e)
        {
            frmQuanLyDeThi quanLyDeThi = new frmQuanLyDeThi();
            quanLyDeThi.Show();
            this.Hide();
        }

        private void btnQuanLyKyThi_Click(object sender, EventArgs e)
        {
            frmQuanLyKyThi quanLyKyThi = new frmQuanLyKyThi();
            quanLyKyThi.Show();
            this.Hide();
        }

        private void btnQuanLyKyThiThuOnTap_Click(object sender, EventArgs e)
        {
            frmQuanLyKyThiThu quanLyKyThiThu = new frmQuanLyKyThiThu();
            quanLyKyThiThu.Show();
            this.Hide();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            frmQuanLyHocSinh quanLyHocSinh = new frmQuanLyHocSinh();
            quanLyHocSinh.Show();
            this.Hide();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung quanLyNguoiDung = new frmQuanLyNguoiDung();
            quanLyNguoiDung.Show();
            this.Hide();
        }
    }
}
