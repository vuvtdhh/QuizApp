using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Do_An_Cuoi_Ky
{
    public partial class frmQuanLyCauHoi : Form
    {
        static public bool ThemCauHoi = false;
        
        public frmQuanLyCauHoi()
        {
            InitializeComponent();
        }

        private void frmQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                cbbTheoMonHoc.DataSource = db.CauHois.Select(ch => ch.MonHoc).Distinct();
                cbbTheoDoKho.DataSource = db.CauHois.Select(ch => ch.DoKho).Distinct();
            }
            LoadCauHoi();
            btnDuyetFile.Enabled = false;
            btnLuuCauHoi.Visible = false;
            gvCauHoi.AllowUserToAddRows = false;
            gvCauHoi.AllowUserToDeleteRows = false;
        }

        public void LoadCauHoi()
        {
            if (gvCauHoi.DataSource != null)
                gvCauHoi.DataSource = null;
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                gvCauHoi.DataSource = db.CauHois.Where(ch => ch.MonHoc.CompareTo(cbbTheoMonHoc.SelectedValue.ToString()) == 0).Where(ch => ch.DoKho.Equals(Convert.ToInt32(cbbTheoDoKho.SelectedValue)));
                gvCauHoi.Columns["ID"].ReadOnly = true;
                gvCauHoi.Columns["SoLanRaDe"].ReadOnly = true;
                gvCauHoi.Columns["SoLanTraLoi"].ReadOnly = true;
                gvCauHoi.Columns["SoLanTraLoiDung"].ReadOnly = true;
            }
            btnDuyetFile.Enabled = false;
            btnLoadLai.Enabled = false;
            ThemCauHoi = false;
        }

        private void cbbTheoMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCauHoi();
        }

        private void cbbTheoDoKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCauHoi();
        }

        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {
            LuuChinhSua();
        }

        public void LuuChinhSua()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                int id = (int)gvCauHoi.SelectedCells[0].OwningRow.Cells["ID"].Value;
                string monHoc = gvCauHoi.SelectedCells[0].OwningRow.Cells["monHoc"].Value.ToString();
                string cauHoi = gvCauHoi.SelectedCells[0].OwningRow.Cells["CauHoi1"].Value.ToString();
                string A = gvCauHoi.SelectedCells[0].OwningRow.Cells["A"].Value.ToString();
                string B = gvCauHoi.SelectedCells[0].OwningRow.Cells["B"].Value.ToString();
                string C = gvCauHoi.SelectedCells[0].OwningRow.Cells["C"].Value.ToString();
                string D = gvCauHoi.SelectedCells[0].OwningRow.Cells["D"].Value.ToString();
                char dapAnDung = (char)gvCauHoi.SelectedCells[0].OwningRow.Cells["DapAnDung"].Value;
                CauHoi ch = db.CauHois.Where(c => c.ID.CompareTo(id) == 0).SingleOrDefault();
                if (gvCauHoi.SelectedCells[0].OwningRow.Cells["GoiY"].Value != null)
                    ch.GoiY = gvCauHoi.SelectedCells[0].OwningRow.Cells["GoiY"].Value.ToString();
                else
                    ch.GoiY = "Không có gợi ý!";
                int doKho = (int)gvCauHoi.SelectedCells[0].OwningRow.Cells["DoKho"].Value;
                ch.MonHoc = monHoc;
                ch.CauHoi1 = cauHoi;
                ch.A = A;
                ch.B = B;
                ch.C = C;
                ch.D = D;
                ch.DapAnDung = dapAnDung;
                ch.DoKho = doKho;
                db.SubmitChanges();
                LoadCauHoi();
            }
        }

        //Sau khi dùng RowLeave, CellEditEnd và dính lỗi, dùng CellValueChanged hơi cùi nhưng ổn nhất.
        private void gvCauHoi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Ưu điểm: chỉnh sửa từng cell tránh quên, nhầm lẫn.
            //Nhược điểm: chỉ sửa được 1 cell sau đó mới sửa được cell khác.
            //Nếu như đang thêm câu hỏi thì disable sự kiện valuechanged
            //để người dùng có thể chính sửa nhiều cell.
            if(ThemCauHoi == false)
            {
                DialogResult re = MessageBox.Show("Ô vừa thay đổi chưa được lưu lại, bạn có muốn lưu không?",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                    LuuChinhSua();
                else
                    LoadCauHoi();
            }
        }

        private void frmQuanLyCauHoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
            this.Hide();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            frmHuongDan huongDan = new frmHuongDan();
            huongDan.Show();
        }

        private void btnDuyetFile_Click(object sender, EventArgs e)
        {
            gvCauHoi.Columns.Clear();
            //Duyệt file.
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn tệp .xml";
            open.Filter = "XML File|*.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {

                //Lấy đường dẫn.
                txtDuongDan.Text = open.FileName;
                if (open.CheckFileExists == true)
                {
                    //Load file.
                    XDocument doc = XDocument.Load(open.FileName);
                    //Truy vấn bằng LINQ TO XML.
                    //Với file XML có Câu hỏi theo cấu trúc Attribute.
                    var cauHoi = from ch in doc.Descendants("CauHoi")
                                 select new
                                 {
                                     MonHoc = (string)ch.Attribute("MonHoc"),
                                     CauHoi = (string)ch.Attribute("CauHoi"),
                                     A = (string)ch.Attribute("A"),
                                     B = (string)ch.Attribute("B"),
                                     C = (string)ch.Attribute("C"),
                                     D = (string)ch.Attribute("D"),
                                     DapAnDung = (string)ch.Attribute("DapAnDung"),
                                     GoiY = (string)ch.Attribute("GoiY"),
                                     DoKho = (string)ch.Attribute("DoKho")
                                 };
                    DataTable table = new DataTable();
                    table.Columns.Add("MonHoc");
                    table.Columns.Add("CauHoi");
                    table.Columns.Add("A");
                    table.Columns.Add("B");
                    table.Columns.Add("C");
                    table.Columns.Add("D");
                    table.Columns.Add("DapAnDung");
                    table.Columns.Add("GoiY");
                    table.Columns.Add("DoKho");
                    foreach (var ch in cauHoi)
                        table.Rows.Add(ch.MonHoc, ch.CauHoi, ch.A, ch.B, ch.C, ch.D, ch.DapAnDung, ch.GoiY, ch.DoKho);
                    gvCauHoi.DataSource = table;
                    if(table.Rows[0][0].ToString() == "")
                    {
                        cauHoi = from ch in doc.Descendants("CauHoi")
                                 select new
                                 {
                                     MonHoc = (string)ch.Element("MonHoc"),
                                     CauHoi = (string)ch.Element("NoiDungCauHoi"),
                                     A = (string)ch.Element("A"),
                                     B = (string)ch.Element("B"),
                                     C = (string)ch.Element("C"),
                                     D = (string)ch.Element("D"),
                                     DapAnDung = (string)ch.Element("DapAnDung"),
                                     GoiY = (string)ch.Element("GoiY"),
                                     DoKho = (string)ch.Element("DoKho")
                                 };
                        DataTable table2 = new DataTable();
                        table2.Columns.Add("MonHoc");
                        table2.Columns.Add("CauHoi");
                        table2.Columns.Add("A");
                        table2.Columns.Add("B");
                        table2.Columns.Add("C");
                        table2.Columns.Add("D");
                        table2.Columns.Add("DapAnDung");
                        table2.Columns.Add("GoiY");
                        table2.Columns.Add("DoKho");
                        foreach (var ch in cauHoi)
                            table2.Rows.Add(ch.MonHoc, ch.CauHoi, ch.A, ch.B, ch.C, ch.D, ch.DapAnDung, ch.GoiY, ch.DoKho);
                        gvCauHoi.DataSource = table2;
                    }               
                }
                else
                    MessageBox.Show("Không tìm thấy tệp XML!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadLai_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            cbbTheoMonHoc.Show();
            cbbTheoDoKho.Show();
            btnLuuCauHoi.Visible = false;
            ThemCauHoi = false;
            gvCauHoi.Columns.Clear();
            LoadCauHoi();
        }

        private void btnLuuCauHoi_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                if(gvCauHoi.SelectedCells[0].OwningRow.Cells["MonHoc"].Value == null || gvCauHoi.SelectedCells[0].OwningRow.Cells["CauHoi"].Value == null ||
                    gvCauHoi.SelectedCells[0].OwningRow.Cells["A"].Value == null || gvCauHoi.SelectedCells[0].OwningRow.Cells["B"].Value == null
                    || gvCauHoi.SelectedCells[0].OwningRow.Cells["C"].Value == null || gvCauHoi.SelectedCells[0].OwningRow.Cells["D"].Value == null ||
                    gvCauHoi.SelectedCells[0].OwningRow.Cells["DapAnDung"].Value == null || gvCauHoi.SelectedCells[0].OwningRow.Cells["DoKho"].Value == null)
                {
                    MessageBox.Show("Dữ liệu chưa được nhập đầy đủ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string monHoc = gvCauHoi.SelectedCells[0].OwningRow.Cells["MonHoc"].Value.ToString();
                    string cauHoi = gvCauHoi.SelectedCells[0].OwningRow.Cells["CauHoi"].Value.ToString();
                    string A = gvCauHoi.SelectedCells[0].OwningRow.Cells["A"].Value.ToString();
                    string B = gvCauHoi.SelectedCells[0].OwningRow.Cells["B"].Value.ToString();
                    string C = gvCauHoi.SelectedCells[0].OwningRow.Cells["C"].Value.ToString();
                    string D = gvCauHoi.SelectedCells[0].OwningRow.Cells["D"].Value.ToString();
                    char dapAnDung = Convert.ToChar(gvCauHoi.SelectedCells[0].OwningRow.Cells["DapAnDung"].Value);
                    string goiY;
                    if (gvCauHoi.SelectedCells[0].OwningRow.Cells["GoiY"].Value == null)
                        goiY = "Không có gợi ý!";
                    else
                        goiY = gvCauHoi.SelectedCells[0].OwningRow.Cells["GoiY"].Value.ToString();
                    int doKho = Convert.ToInt32(gvCauHoi.SelectedCells[0].OwningRow.Cells["DoKho"].Value);
                    //Lấy Câu hỏi trong cơ sử dữ liệu, kiểm tra xem có trùng hay không.
                    var dulieu = db.CauHois.Select(c => c.CauHoi1).Distinct();
                    bool tontai = false;
                    foreach (var dl in dulieu)
                    {
                        if (cauHoi.Equals(dl))
                        {
                            tontai = true;
                        }
                    }
                    if (tontai == false)
                    {
                        CauHoi ch = new CauHoi();
                        ch.MonHoc = monHoc;
                        ch.CauHoi1 = cauHoi;
                        ch.A = A;
                        ch.B = B;
                        ch.C = C;
                        ch.D = D;
                        ch.DapAnDung = dapAnDung;
                        ch.GoiY = goiY;
                        ch.DoKho = doKho;
                        db.CauHois.InsertOnSubmit(ch);
                        db.SubmitChanges();
                        MessageBox.Show("Đã thêm câu hỏi vào cơ sở dữ liệu!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Câu hỏi này đã có trong cơ sở dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            btnDuyetFile.Enabled = true;
            cbbTheoMonHoc.Visible = false;
            cbbTheoDoKho.Visible = false;
            label1.Hide();
            label2.Hide();
            btnLoadLai.Enabled = true;
            btnLuuCauHoi.Visible = true;
            ThemCauHoi = true;
            this.Text = "Thêm Câu Hỏi";
            gvCauHoi.DataSource = null;
            gvCauHoi.Columns.Add("MonHoc", "MonHoc");
            gvCauHoi.Columns.Add("CauHoi", "CauHoi");
            gvCauHoi.Columns.Add("A", "A");
            gvCauHoi.Columns.Add("B", "B");
            gvCauHoi.Columns.Add("C", "C");
            gvCauHoi.Columns.Add("D", "D");
            gvCauHoi.Columns.Add("DapAnDung", "DapAnDung");
            gvCauHoi.Columns.Add("GoiY", "GoiY");
            gvCauHoi.Columns.Add("DoKho", "DoKho");
            gvCauHoi.AllowUserToAddRows = true;
        }
    }
}
