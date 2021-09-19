using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Do_An_Cuoi_Ky
{
    public partial class frmQuanLyNguoiDung : Form
    {
        bool chinhsua = false;
        string stt;
        int dong = 0, cot = 0;
        bool themnguoidung = false;

        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        public void LoadDuLieu()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var users = db.Users.Select(u => u);
                gvThongTin.DataSource = users;
                gvThongTin.AllowUserToAddRows = false;
                gvThongTin.Columns["TaiKhoan"].ReadOnly = true;
                gvThongTin.Columns["MatKhau"].ReadOnly = true;
                gvThongTin.Columns["Stt"].ReadOnly = true;
                gvThongTin.Columns["QueQuan1"].Visible = false;
                gvThongTin.Columns["Khoi1"].Visible = false;
                //if (gvThongTin.RowCount >= 2)
                //    gvThongTin.CurrentCell = gvThongTin.Rows[dong].Cells[cot];
            }
        }

        private void btnLoadNguoiDung_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        public void LuuThongTin()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                User u = db.Users.Where(a => a.Stt.Equals(stt)).SingleOrDefault();
                if (gvThongTin.SelectedCells[0].OwningRow.Cells["LoaiTaiKhoan"].Value == null || gvThongTin.SelectedCells[0].OwningRow.Cells["HoTen"].Value == null
                    || gvThongTin.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value == null || gvThongTin.SelectedCells[0].OwningRow.Cells["QueQuan"].Value == null
                    || gvThongTin.SelectedCells[0].OwningRow.Cells["Lop"].Value == null || gvThongTin.SelectedCells[0].OwningRow.Cells["Khoi"].Value == null)
                    MessageBox.Show("Không được để trống thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string loaiTK = gvThongTin.Rows[dong].Cells["LoaiTaiKhoan"].Value.ToString();
                    string hoten = gvThongTin.Rows[dong].Cells["HoTen"].Value.ToString();
                    DateTime ngaysinh = (DateTime)gvThongTin.Rows[dong].Cells["NgaySinh"].Value;
                    string quequan = gvThongTin.Rows[dong].Cells["QueQuan"].Value.ToString();
                    string sdt = gvThongTin.Rows[dong].Cells["Sdt"].Value.ToString();
                    string lop = gvThongTin.Rows[dong].Cells["Lop"].Value.ToString();
                    string khoi = gvThongTin.Rows[dong].Cells["Khoi"].Value.ToString();
                    u.LoaiTaiKhoan = loaiTK;
                    u.HoTen = hoten;
                    u.NgaySinh = ngaysinh;
                    u.QueQuan = quequan;
                    u.Sdt = sdt;
                    u.Lop = lop;
                    u.Khoi = khoi;
                    db.SubmitChanges();
                }
            }
        }

        private void gvThongTin_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            chinhsua = true;
        }

        private void gvThongTin_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (chinhsua == true && themnguoidung == false)
            {
                DialogResult re = MessageBox.Show("Dữ liệu vừa thay đổi vẫn chưa được lưu! Bạn có muốn lưu chỉnh sửa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    chinhsua = false;
                    using (DatabaseDataContext db = new DatabaseDataContext())
                    {
                        User u = db.Users.Where(a => a.Stt.Equals(stt)).SingleOrDefault();
                        if (gvThongTin.SelectedCells[0].OwningRow.Cells["LoaiTaiKhoan"].Value == null || gvThongTin.SelectedCells[0].OwningRow.Cells["HoTen"].Value == null
                            || gvThongTin.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value == null || gvThongTin.SelectedCells[0].OwningRow.Cells["QueQuan"].Value == null)
                            MessageBox.Show("Không được để trống thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            string loaiTK = gvThongTin.Rows[dong].Cells["LoaiTaiKhoan"].Value.ToString();
                            string hoten = gvThongTin.Rows[dong].Cells["HoTen"].Value.ToString();
                            DateTime ngaysinh = (DateTime)gvThongTin.Rows[dong].Cells["NgaySinh"].Value;
                            string quequan = gvThongTin.Rows[dong].Cells["QueQuan"].Value.ToString();
                            string sdt = gvThongTin.Rows[dong].Cells["Sdt"].Value.ToString();
                            if(gvThongTin.Rows[dong].Cells["Lop"].Value != null)
                                u.Lop = gvThongTin.Rows[dong].Cells["Lop"].Value.ToString();
                            if(gvThongTin.Rows[dong].Cells["Khoi"].Value != null)
                                u.Khoi = gvThongTin.Rows[dong].Cells["Khoi"].Value.ToString();
                            u.LoaiTaiKhoan = loaiTK;
                            u.HoTen = hoten;
                            u.NgaySinh = ngaysinh;
                            u.QueQuan = quequan;
                            u.Sdt = sdt;
                            db.SubmitChanges();
                            MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    frmQuanLyNguoiDung quanLyNguoiDung = new frmQuanLyNguoiDung();
                    quanLyNguoiDung.Show();
                    this.Hide();
                }
            }
        }

        private void btnLoadLai_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            btnThemNguoiDung.Visible = true;
            btnThemTatCa.Visible = false;
            themnguoidung = false;
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            btnThemTatCa.Visible = false;
            LoadDuLieu();
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            frmThemNguoiDung themNguoiDung = new frmThemNguoiDung();
            themNguoiDung.Show();
        }

        private void btnFileXML_Click(object sender, EventArgs e)
        {
            themnguoidung = true;
            btnThemTatCa.Visible = true;
            btnThemNguoiDung.Visible = false;
            //Duyệt file.
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn tệp .xml";
            open.Filter = "XML File|*.xml";
            if(open.ShowDialog() == DialogResult.OK)
            {
                if(open.CheckFileExists == true)
                {
                    //Load file.
                    XDocument doc = XDocument.Load(open.FileName);
                    //Truy vấn bằng LINQ TO XML.
                    //Với file XML có Câu hỏi theo cấu trúc Attribute.
                    var users = from ch in doc.Descendants("NguoiDung")
                                 select new
                                 {
                                     TaiKhoan = (string)ch.Attribute("TaiKhoan"),
                                     MatKhau = (string)ch.Attribute("MatKhau"),
                                     LoaiTaiKhoan = (string)ch.Attribute("LoaiTaiKhoan"),
                                     HoTen = (string)ch.Attribute("HoTen"),
                                     NgaySinh = (string)ch.Attribute("NgaySinh"),
                                     QueQuan = (string)ch.Attribute("QueQuan"),
                                     Sdt = (string)ch.Attribute("Sdt"),
                                     Khoi = (string)ch.Attribute("Khoi"),
                                     Lop = (string)ch.Attribute("Lop")
                                 };
                    DataTable table = new DataTable();
                    table.Columns.Add("TaiKhoan");
                    table.Columns.Add("MatKhau");
                    table.Columns.Add("LoaiTaiKhoan");
                    table.Columns.Add("HoTen");
                    table.Columns.Add("NgaySinh");
                    table.Columns.Add("QueQuan");
                    table.Columns.Add("Sdt");
                    table.Columns.Add("Khoi");
                    table.Columns.Add("Lop");
                    foreach (var u in users)
                        table.Rows.Add(u.TaiKhoan, u.MatKhau, u.LoaiTaiKhoan, u.HoTen, u.NgaySinh, u.QueQuan, u.Sdt, u.Khoi, u.Lop);
                    gvThongTin.DataSource = table;
                    if (table.Rows[0][0].ToString() == "")
                    {
                        users = from ch in doc.Descendants("NguoiDung")
                                 select new
                                 {
                                     TaiKhoan = (string)ch.Element("TaiKhoan"),
                                     MatKhau = (string)ch.Element("MatKhau"),
                                     LoaiTaiKhoan = (string)ch.Element("LoaiTaiKhoan"),
                                     HoTen = (string)ch.Element("HoTen"),
                                     NgaySinh = (string)ch.Element("NgaySinh"),
                                     QueQuan = (string)ch.Element("QueQuan"),
                                     Sdt = (string)ch.Element("Sdt"),
                                     Khoi = (string)ch.Element("Khoi"),
                                     Lop = (string)ch.Element("Lop")
                                 };
                        DataTable table2 = new DataTable();
                        table2.Columns.Add("TaiKhoan");
                        table2.Columns.Add("MatKhau");
                        table2.Columns.Add("LoaiTaiKhoan");
                        table2.Columns.Add("HoTen");
                        table2.Columns.Add("NgaySinh");
                        table2.Columns.Add("QueQuan");
                        table2.Columns.Add("Sdt");
                        table2.Columns.Add("Khoi");
                        table2.Columns.Add("Lop");
                        foreach (var u in users)
                            table2.Rows.Add(u.TaiKhoan, u.MatKhau, u.LoaiTaiKhoan, u.HoTen, u.NgaySinh, u.QueQuan, u.Sdt, u.Khoi, u.Lop);
                        gvThongTin.DataSource = table2;
                    }
                }
                else
                    MessageBox.Show("Không tìm thấy tệp XML!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemTatCa_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Thêm tất cả trên lưới vào CSDL? Những học sinh hoặc giáo viên có dữ liệu trùng lắp sẽ không được thêm!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(re == DialogResult.Yes)
            {
                using (DatabaseDataContext db = new DatabaseDataContext())
                {
                    bool ok = false;
                    foreach (DataGridViewRow row in gvThongTin.Rows)
                    {
                        if (gvThongTin.Rows[row.Index].Cells["TaiKhoan"].Value.ToString() == "" || gvThongTin.Rows[row.Index].Cells["MatKhau"].Value.ToString() == "" ||
                            gvThongTin.Rows[row.Index].Cells["LoaiTaiKhoan"].Value.ToString() == "" || gvThongTin.Rows[row.Index].Cells["HoTen"].Value.ToString() == "" ||
                            gvThongTin.Rows[row.Index].Cells["QueQuan"].Value.ToString() == "" || gvThongTin.Rows[row.Index].Cells["Sdt"].Value.ToString() == "")
                        {
                            MessageBox.Show(string.Format("Dòng {0} chưa cung cấp đủ thông tin!", row.Index), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        var tatca = db.Users.Select(us => us.TaiKhoan);
                        bool tontai = false;
                        foreach (var tk in tatca)
                            if (gvThongTin.Rows[row.Index].Cells["TaiKhoan"].Value.ToString().Equals(tk.Trim()))
                                tontai = true;
                        if(tontai == true)
                        {
                            MessageBox.Show(string.Format("Tài khoản {0} tại dòng {1} đã tồn tại! Tài khoản này sẽ không được thêm vào CSDL!", gvThongTin.Rows[row.Index].Cells["TaiKhoan"].Value.ToString(), row.Index + 1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            User u = new User();
                            u.TaiKhoan = gvThongTin.Rows[row.Index].Cells["TaiKhoan"].Value.ToString();
                            u.MatKhau = gvThongTin.Rows[row.Index].Cells["MatKhau"].Value.ToString();
                            u.LoaiTaiKhoan = gvThongTin.Rows[row.Index].Cells["LoaiTaiKhoan"].Value.ToString();
                            u.HoTen = gvThongTin.Rows[row.Index].Cells["HoTen"].Value.ToString();
                            u.NgaySinh = Convert.ToDateTime(gvThongTin.Rows[row.Index].Cells["NgaySinh"].Value.ToString());
                            u.Sdt = gvThongTin.Rows[row.Index].Cells["Sdt"].Value.ToString();
                            if (gvThongTin.Rows[row.Index].Cells["Khoi"].Value.ToString() != "")
                                u.Khoi = gvThongTin.Rows[row.Index].Cells["Khoi"].Value.ToString();
                            if (gvThongTin.Rows[row.Index].Cells["Lop"].Value != null)
                                u.Lop = gvThongTin.Rows[row.Index].Cells["Lop"].Value.ToString();
                            db.Users.InsertOnSubmit(u);
                            db.SubmitChanges();
                            ok = true;
                        }
                    }
                    if (ok == true)
                        MessageBox.Show("Đã thêm!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void frmQuanLyNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
        }

        private void gvThongTin_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(themnguoidung == false)
            {
                stt = gvThongTin.SelectedCells[0].OwningRow.Cells["Stt"].Value.ToString();
                dong = gvThongTin.SelectedCells[0].RowIndex;
                cot = gvThongTin.SelectedCells[0].ColumnIndex;
            }
        }
    }
}
