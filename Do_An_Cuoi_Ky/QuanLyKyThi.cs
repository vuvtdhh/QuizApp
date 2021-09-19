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
    public partial class frmQuanLyKyThi : Form
    {
        int dong = 0, cot = 0;
        string maKyThiHienTai;
        bool chinhSua = false;

        public frmQuanLyKyThi()
        {
            InitializeComponent();
        }

        private void frmQuanLyKyThi_Load(object sender, EventArgs e)
        {
            gvThiSinh.ReadOnly = true;
            gvThiSinh.AllowUserToAddRows = false;
            gvThiSinh.AllowUserToDeleteRows = false;
            gvDeThi.ReadOnly = true;
            gvDeThi.AllowUserToAddRows = false;
            gvDeThi.AllowUserToDeleteRows = false;
            gvKyThi.AllowUserToAddRows = false;
            gvKyThi.AllowUserToDeleteRows = false;
            gvKyThi.AllowUserToAddRows = false;
            gvKyThi.AllowUserToDeleteRows = false;
            LoadThiSinh();
            LoadDeThi();
            LoadKyThi();
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

        public void LoadKyThi()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var kyThi = db.KyThis.Select(kt => kt);
                gvKyThi.DataSource = kyThi;
                gvKyThi.AllowUserToAddRows = false;
                //Sau khi bảng kỳ thi có dữ liệu mới có thể load được dòng bên dưới.
                if(gvKyThi.Rows.Count >= 2)
                    gvKyThi.CurrentCell = gvKyThi.Rows[dong].Cells[cot];
            }
        }

        private void btnTaoKyThi_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                DateTime ngayHienTai = DateTime.Now;
                if (txtMaKyThi.Text == "" || pickerNgayThi.Value == null)
                    MessageBox.Show("Phải nhập đủ Mã Kỳ Thi và Ngày Thi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if(pickerNgayThi.Value.Date < ngayHienTai.Date)
                    MessageBox.Show("Ngày thi không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string maKyThi = txtMaKyThi.Text;
                    DateTime ngayThi = pickerNgayThi.Value;
                    //Lấy MaKyThi để tránh trùng.
                    bool tontai = false;
                    var makythi = db.KyThis.Select(k => k.MaKyThi);
                    foreach (var i in makythi)
                        if (i == maKyThi)
                            tontai = true;
                    if(tontai == true)
                        MessageBox.Show("Mã Kỳ Thi thi đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        KyThi kt = new KyThi();
                        kt.MaKyThi = maKyThi;
                        kt.NgayThi = ngayThi.Date;
                        db.KyThis.InsertOnSubmit(kt);
                        db.SubmitChanges();
                        MessageBox.Show("Tạo kỳ thi mới thành công! Đã có thể thêm đề thi, thí sinh vào kỳ thi!", "Thông Báo", MessageBoxButtons.OK);
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
                var ds = db.KyThis.Where(k => k.MaKyThi.Equals(maKyThi)).Select(k => k.DanhSachThiSinh).ToArray();
                if(ds[0] == null)
                {
                    string tsMoi = gvThiSinh.SelectedCells[0].OwningRow.Cells["Stt"].Value.ToString();
                    KyThi kythi = db.KyThis.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                    kythi.DanhSachThiSinh = tsMoi;
                    db.SubmitChanges();
                    dong = gvKyThi.SelectedCells[0].OwningRow.Index;
                    cot = gvKyThi.SelectedCells[0].OwningColumn.Index;
                    MessageBox.Show(string.Format("Đã thêm thí sinh {0}!", tsMoi), "Thông Báo", MessageBoxButtons.OK);
                    //Thêm thông tin kỳ thi và thí sinh vào bảng lịch thi.
                    LichThi lt = new LichThi();
                    lt.ID = Convert.ToInt32(tsMoi);
                    lt.TaiKhoan = gvThiSinh.SelectedCells[0].OwningRow.Cells["TaiKhoan"].Value.ToString();
                    lt.MonThi = gvDeThi.SelectedCells[0].OwningRow.Cells["MonHoc"].Value.ToString();
                    lt.NgayThi = pickerNgayThi.Value;
                    Random rd = new Random();
                    int sophong = rd.Next(1, 9);
                    string phongthi = "P0" + sophong;
                    lt.PhongThi = phongthi;
                    TimeSpan tp = new TimeSpan(pickerNgayThi.Value.Hour);
                    lt.GioThi = tp;
                    lt.MaKyThi = maKyThi;
                    db.LichThis.InsertOnSubmit(lt);
                    db.SubmitChanges();
                    LoadKyThi();
                }      
                else
                {
                    string tsMoi = gvThiSinh.SelectedCells[0].OwningRow.Cells["Stt"].Value.ToString();
                    //Kiểm tra trùng.
                    bool trung = false;
                    string[] dsm = new string[ds[0].Count()];
                    dsm = ds[0].Split(',');
                    for(int i=0; i<dsm.Count(); i++)
                    {
                        dsm[i] = dsm[i].Trim();
                    }
                    foreach (string t in dsm)
                        if (tsMoi == t)
                            trung = true;
                    if(trung == false)
                    {
                        string dsThiSinhMoi;
                        dsThiSinhMoi = ds[0] + ", " + gvThiSinh.SelectedCells[0].OwningRow.Cells["Stt"].Value.ToString();
                        KyThi kythi = db.KyThis.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                        kythi.DanhSachThiSinh = dsThiSinhMoi;
                        db.SubmitChanges();
                        dong = gvKyThi.SelectedCells[0].OwningRow.Index;
                        cot = gvKyThi.SelectedCells[0].OwningColumn.Index;
                        MessageBox.Show(string.Format("Đã thêm thí sinh {0}!", tsMoi), "Thông Báo", MessageBoxButtons.OK);
                        //Thêm thông tin kỳ thi và thí sinh vào bảng lịch thi.
                        LichThi lt = new LichThi();
                        lt.ID = Convert.ToInt32(tsMoi);
                        lt.TaiKhoan = gvThiSinh.SelectedCells[0].OwningRow.Cells["TaiKhoan"].Value.ToString();
                        lt.MonThi = gvDeThi.SelectedCells[0].OwningRow.Cells["MonHoc"].Value.ToString();
                        lt.NgayThi = pickerNgayThi.Value;
                        lt.MaKyThi = gvKyThi.SelectedCells[0].OwningRow.Cells["MaKyThi"].Value.ToString();
                        Random rd = new Random();
                        int sophong = rd.Next(1, 9);
                        char maphong = (char)rd.Next(65, 90);
                        string phongthi = maphong + sophong.ToString();
                        lt.PhongThi = phongthi;
                        TimeSpan tp = new TimeSpan(pickerNgayThi.Value.Hour);
                        lt.GioThi = tp;
                        db.LichThis.InsertOnSubmit(lt);
                        db.SubmitChanges();
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


        private void gvKyThi_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Bắt đầu chỉnh sửa, lấy MaKyThi.
            maKyThiHienTai = gvKyThi.SelectedCells[0].OwningRow.Cells["MaKyThi"].Value.ToString();
        }

        private void gvKyThi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dong = gvKyThi.SelectedCells[0].RowIndex;
            chinhSua = true;
        }

        private void gvKyThi_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (chinhSua == true)
            {
                DialogResult re = MessageBox.Show("Dữ liệu vừa chỉnh sửa vẫn chưa được lưu, bạn có muốn lưu lại không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    using (DatabaseDataContext db = new DatabaseDataContext())
                    {
                        string maKyThi = gvKyThi.Rows[dong].Cells["MaKyThi"].Value.ToString();
                        DateTime ngayThi = (DateTime)gvKyThi.Rows[dong].Cells["NgayThi"].Value;
                        string dsThiSinh = "";
                        if (gvKyThi.Rows[dong].Cells["DanhSachThiSinh"].Value != null)
                            dsThiSinh = gvKyThi.Rows[dong].Cells["DanhSachThiSinh"].Value.ToString();
                        string dsDeThi = "";
                        if(gvKyThi.Rows[dong].Cells["DanhSachDeThi"].Value != null)
                            dsDeThi = gvKyThi.Rows[dong].Cells["DanhSachDeThi"].Value.ToString();
                        KyThi kt = db.KyThis.Where(k => k.MaKyThi.Equals(maKyThiHienTai)).SingleOrDefault();
                        kt.MaKyThi = maKyThi;
                        kt.NgayThi = ngayThi;
                        kt.DanhSachThiSinh = dsThiSinh;
                        kt.DanhSachDeThi = dsDeThi;
                        db.SubmitChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK);
                        chinhSua = false;
                    }
                }
                else
                    chinhSua = false;
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
                    if(re == DialogResult.Yes)
                    {
                        DateTime ngayThi = (DateTime)gvKyThi.SelectedCells[0].OwningRow.Cells["NgayThi"].Value;
                        if (ngayThi.Date < DateTime.Now.Date)
                            MessageBox.Show("Không được xóa kỳ thi đã diễn ra!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        else
                        {
                            KyThi kt = db.KyThis.Where(k => k.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                            db.KyThis.DeleteOnSubmit(kt);
                            db.SubmitChanges();
                            MessageBox.Show("Đã xóa kỳ thi!", "Thông Báo", MessageBoxButtons.OK);
                            LoadKyThi();
                        }
                    }
                    //Xóa Lịch thi.
                    var lt = db.LichThis.Where(l => l.MaKyThi.Equals(maKyThi)).ToArray();
                    foreach(var l in lt)
                    {
                        db.LichThis.DeleteOnSubmit(l);
                        db.SubmitChanges();
                    }                   
                }
            }
        }

        private void frmQuanLyKyThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
        }

        private void btnThemDe_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                string maKyThi = gvKyThi.SelectedCells[0].OwningRow.Cells["MaKyThi"].Value.ToString();
                var dsDe = db.KyThis.Where(k => k.MaKyThi.Equals(maKyThi)).Select(k => k.DanhSachDeThi).ToArray();
                string deMuonThem = gvDeThi.SelectedCells[0].OwningRow.Cells["MaDe"].Value.ToString(); ;
                bool trung = false;
                if (dsDe[0] == null)
                {
                    KyThi kythi = db.KyThis.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                    kythi.DanhSachDeThi = deMuonThem;
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
                        KyThi kythi = db.KyThis.Where(kt => kt.MaKyThi.Equals(maKyThi)).SingleOrDefault();
                        kythi.DanhSachDeThi = dsDeThiMoi;
                        db.SubmitChanges();
                        dong = gvKyThi.SelectedCells[0].OwningRow.Index;
                        cot = gvKyThi.SelectedCells[0].OwningColumn.Index;
                        MessageBox.Show(string.Format("Đã thêm đề {0}!", deMuonThem), "Thông Báo", MessageBoxButtons.OK);
                        LoadKyThi();
                    }
                }
            }
        }
    }
}
