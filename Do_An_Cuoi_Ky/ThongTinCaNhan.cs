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
    public partial class frmThongTinCaNhan : Form
    {
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = NguoiDungHienTai.LayHoTen();
            lblNgaySinh.Text = NguoiDungHienTai.LayNgaySinh().ToString();
            lblDienThoai.Text = NguoiDungHienTai.LayDienThoai();
            lblKhoi.Text = NguoiDungHienTai.LayKhoi();
            lblQueQuan.Text = NguoiDungHienTai.LayQueQuan();
        }

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            frmChinhSuaThongTin chinhSuaThongTin = new frmChinhSuaThongTin();
            chinhSuaThongTin.Show();
            this.Hide();
        }

        private void btnXemLichThi_Click(object sender, EventArgs e)
        {
            frmLichThi lichThi = new frmLichThi();
            lichThi.Show();
            this.Hide();
        }

        private void btnXemKetQuaThi_Click(object sender, EventArgs e)
        {
            frmKetQuaThi ketQuaThi = new frmKetQuaThi();
            ketQuaThi.Show();
            this.Hide();
        }

        private void frmThongTinCaNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
            this.Hide();
        }
    }
}
