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
    public partial class frmQuanLyKyThiThu : Form
    {
        int dong = 0, cot = 0;

        public frmQuanLyKyThiThu()
        {
            InitializeComponent();
        }

        private void frmQuanLyKyThiThu_Load(object sender, EventArgs e)
        {
            LoadThiSinh();
            LoadDeThi();
            LoadKyThi();
        }

        private void frmQuanLyKyThiThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
        }

        public void LoadKyThi()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var kyThi = db.KyThiThus.Select(kt => kt);
                gvKyThi.DataSource = kyThi;
                gvKyThi.AllowUserToAddRows = false;
                //Sau khi bảng kỳ thi có dữ liệu mới có thể load được dòng bên dưới.
                if(gvKyThi.Rows.Count >= 2)
                    gvKyThi.CurrentCell = gvKyThi.Rows[dong].Cells[cot];
            }
        }

        public void LoadThiSinh()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var thiSinh = from u in db.Users
                              where u.LoaiTaiKhoan == "HocSinh"
                              select new
                              {
                                  u.Stt,
                                  u.TaiKhoan,
                                  u.HoTen,
                                  u.Lop,
                                  u.Khoi
                              };
                gvThiSinh.DataSource = thiSinh;
                gvThiSinh.ReadOnly = true;
            }
        }

        public void LoadDeThi()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var deThi = from dt in db.DeThis
                            select new
                            {
                                dt.MaDe,
                                dt.MaMonHoc,
                                dt.MonHoc
                            };
                gvDeThi.DataSource = deThi;
                gvDeThi.ReadOnly = true;
            }
        }

        private void btnTaoKyThiThu_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                if (txtMaKyThi.Text != null)
                {
                    if (pickerTuNgay.Value >= pickerDenNgay.Value || pickerDenNgay.Value <= DateTime.Now)
                        MessageBox.Show("Dữ liệu thời gian không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        string maKyThi = txtMaKyThi.Text;
                        //Kiểm tra trùng mã.
                        bool tontai = false;
                        var dsMa = db.KyThiThus.Select(ktt => ktt.MaKyThi);
                        foreach (var ma in dsMa)
                            if (maKyThi == ma)
                                tontai = true;
                        if (tontai == false)
                        {
                            KyThiThu kythithu = new KyThiThu();
                            kythithu.MaKyThi = maKyThi;
                            kythithu.TuNgay = pickerTuNgay.Value.Date;
                            kythithu.DenNgay = pickerDenNgay.Value.Date;
                            db.KyThiThus.InsertOnSubmit(kythithu);
                            db.SubmitChanges();
                            MessageBox.Show("Tạo kỳ thi thử thành công! Đã có thể cập nhật thí sinh, đề thi!", "Thông Báo", MessageBoxButtons.OK);
                            LoadKyThi();
                        }
                        else
                            MessageBox.Show("Mã kỳ thi đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Mã kỳ thi không được để trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 

        private void btnXoaKyThi_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                if (gvKyThi.SelectedCells[0].OwningRow.Cells["MaKyThi"].Value != null)
                {
                    string maKyThi = gvKyThi.SelectedCells[0].OwningRow.Cells["MaKyThi"].Value.ToString();
                    DialogResult re = MessageBox.Show(string.Format("Xóa kỳ thi {0}?", maKyThi), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        DateTime ngayThi = (DateTime)gvKyThi.SelectedCells[0].OwningRow.Cells["DenNgay"].Value;
                        if (ngayThi < DateTime.Now)
                            MessageBox.Show("Không được xóa kỳ thi đã diễn ra!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        else
                        {
                            KyThiThu ktt = db.KyThiThus.Where(k => k.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                            db.KyThiThus.DeleteOnSubmit(ktt);
                            db.SubmitChanges();
                            MessageBox.Show("Đã xóa kỳ thi!", "Thông Báo", MessageBoxButtons.OK);
                            LoadKyThi();
                        }
                    }
                }
            }
        }

        private void btnThemDe_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                string maKyThi = gvKyThi.SelectedCells[0].OwningRow.Cells["MaKyThi"].Value.ToString();
                var dsDe = db.KyThiThus.Where(k => k.MaKyThi.Equals(maKyThi)).Select(k => k.DanhSachDeThi).ToArray();
                string deMuonThem = gvDeThi.SelectedCells[0].OwningRow.Cells["MaDe"].Value.ToString(); ;
                bool trung = false;
                if (dsDe[0] == null)
                {
                    KyThiThu kythithu = db.KyThiThus.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                    kythithu.DanhSachDeThi = deMuonThem;
                    db.SubmitChanges();
                    dong = gvKyThi.SelectedCells[0].OwningRow.Index;
                    cot = gvKyThi.SelectedCells[0].OwningColumn.Index;
                    MessageBox.Show(string.Format("Đã thêm đề {0}!", deMuonThem), "Thông Báo", MessageBoxButtons.OK);
                    LoadKyThi();
                }
                else
                {
                    string dsDeThiMoi = null;
                    //Kiểm tra đề muốn thêm đã có trong danh sách chưa.
                    string[] dsm = new string[dsDe[0].Count()];
                    //Tách đề.
                    dsm = dsDe[0].Split(',');
                    //Xóa khoảng trắng.
                    for (int i = 0; i < dsm.Count(); i++)
                    {
                        dsm[i] = dsm[i].Trim();
                    }
                    //Kiểm tra trùng đề.
                    foreach (string d in dsm)
                    {
                        if (deMuonThem == d)
                            trung = true;
                    }
                    if (trung == true)
                    {
                        MessageBox.Show(string.Format("Đề {0} đã có sẵn trong danh sách đề!", deMuonThem), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        trung = false;
                    }
                    else
                    {
                        dsDeThiMoi = dsDe[0] + ", " + gvDeThi.SelectedCells[0].OwningRow.Cells["MaDe"].Value.ToString();
                        KyThiThu kythithu = db.KyThiThus.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                        kythithu.DanhSachDeThi = dsDeThiMoi;
                        db.SubmitChanges();
                        dong = gvKyThi.SelectedCells[0].OwningRow.Index;
                        cot = gvKyThi.SelectedCells[0].OwningColumn.Index;
                        MessageBox.Show(string.Format("Đã thêm đề {0}!", deMuonThem), "Thông Báo", MessageBoxButtons.OK);
                        LoadKyThi();
                    }
                }
            }
        }

        private void btnThemThiSinh_Click(object sender, EventArgs e)
        {
            //Lấy DanhSachThi sinh + "," + thí sinh mới.
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //Lấy mã kỳ thi hiện tại để cập nhật danh sách thí sinh.
                string maKyThi = gvKyThi.SelectedCells[0].OwningRow.Cells["MaKyThi"].Value.ToString();
                var ds = db.KyThiThus.Where(k => k.MaKyThi.Equals(maKyThi)).Select(k => k.DanhSachThiSinh).ToArray();
                if (ds[0] == null)
                {
                    string tsMoi = gvThiSinh.SelectedCells[0].OwningRow.Cells["Stt"].Value.ToString();
                    KyThiThu kythithu = db.KyThiThus.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                    kythithu.DanhSachThiSinh = tsMoi;
                    db.SubmitChanges();
                    dong = gvKyThi.SelectedCells[0].OwningRow.Index;
                    cot = gvKyThi.SelectedCells[0].OwningColumn.Index;
                    MessageBox.Show(string.Format("Đã thêm thí sinh {0}!", tsMoi), "Thông Báo", MessageBoxButtons.OK);
                    LoadKyThi();
                }
                else
                {
                    string tsMoi = gvThiSinh.SelectedCells[0].OwningRow.Cells["Stt"].Value.ToString();
                    //Kiểm tra trùng.
                    bool trung = false;
                    string[] dsm = new string[ds[0].Count()];
                    dsm = ds[0].Split(',');
                    for (int i = 0; i < dsm.Count(); i++)
                    {
                        dsm[i] = dsm[i].Trim();
                    }
                    foreach (string t in dsm)
                        if (tsMoi == t)
                            trung = true;
                    if (trung == false)
                    {
                        string dsThiSinhMoi;
                        dsThiSinhMoi = ds[0] + ", " + gvThiSinh.SelectedCells[0].OwningRow.Cells["Stt"].Value.ToString();
                        KyThiThu kythithu = db.KyThiThus.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                        kythithu.DanhSachThiSinh = dsThiSinhMoi;
                        db.SubmitChanges();
                        dong = gvKyThi.SelectedCells[0].OwningRow.Index;
                        cot = gvKyThi.SelectedCells[0].OwningColumn.Index;
                        MessageBox.Show(string.Format("Đã thêm thí sinh {0}!", tsMoi), "Thông Báo", MessageBoxButtons.OK);
                        LoadKyThi();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Thí sinh {0} đã có sẵn trong danh sách!", tsMoi), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        trung = false;
                    }
                }
            }
        }
    }
}
