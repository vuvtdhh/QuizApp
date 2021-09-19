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
    public partial class frmQuanLyDeThi : Form
    {
        int dong, cot = -1;

        public frmQuanLyDeThi()
        {
            InitializeComponent();
        }

        private void frmQuanLyDeThi_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                cbbTheoMonHoc.DataSource = db.CauHois.Select(ch => ch.MonHoc).Distinct();
                cbbTheoDoKho.DataSource = db.CauHois.Select(ch => ch.DoKho).Distinct();
            }
            LoadCauHoi();
            gvCauHoi.AllowUserToAddRows = false;
            LoadDe();
        }

        public void LoadCauHoi()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                gvCauHoi.DataSource = db.CauHois.Where(ch => ch.MonHoc.CompareTo(cbbTheoMonHoc.SelectedValue.ToString()) == 0).Where(ch => ch.DoKho.Equals(Convert.ToInt32(cbbTheoDoKho.SelectedValue)));
                gvCauHoi.Columns["ID"].ReadOnly = true;
            }
        }

        private void cbbTheoMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCauHoi();
        }

        private void cbbTheoDoKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCauHoi();
        }

        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            //Tạo sườn Đề thi, lưu vào CSDL.
            //Lấy thông tin mã đề đã có của môn học hiện tại trên combobox
            //-> tạo mã đề tự động.
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var soDe = db.DeThis.Where(dt => dt.MonHoc.CompareTo(cbbTheoMonHoc.SelectedValue.ToString()) == 0).Count();
                var maDe = db.DeThis.Where(dt => dt.MonHoc.CompareTo(cbbTheoMonHoc.SelectedValue.ToString()) == 0).Select(dt => dt.MaDe).FirstOrDefault();
                var maMH = db.DeThis.Where(dt => dt.MonHoc.CompareTo(cbbTheoMonHoc.SelectedValue.ToString()) == 0).Select(dt => dt.MaMonHoc).FirstOrDefault();
                string maDeMoi = maDe.ToString().Substring(0, 2) + "0" + (soDe + 1).ToString();
                string monHoc = cbbTheoMonHoc.SelectedValue.ToString();
                string maMonHoc = maMH.ToString();
                DeThi de = new DeThi();
                de.MaDe = maDeMoi;
                de.MaMonHoc = maMonHoc;
                de.MonHoc = monHoc;
                db.DeThis.InsertOnSubmit(de);
                db.SubmitChanges();
                LoadDe();
            }
        }
        
        public void LoadDe()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var dethi = from d in db.DeThis
                            select new
                            {
                                d.MaDe,
                                d.MaMonHoc,
                                d.MonHoc,
                                d.Cau01,
                                d.Cau02,
                                d.Cau03,
                                d.Cau04,
                                d.Cau05,
                                d.Cau06,
                                d.Cau07,
                                d.Cau08,
                                d.Cau09,
                                d.Cau10
                            };
                gvDeThi.DataSource = dethi;
                if(cot<gvDeThi.ColumnCount - 1)
                    gvDeThi.CurrentCell = gvDeThi.Rows[dong].Cells[cot + 1];
            }
        }

        private void btnLoadDe_Click(object sender, EventArgs e)
        {
            LoadDe();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            frmHuongDanQuanLyDeThi huongDanQuanLyDeThi = new frmHuongDanQuanLyDeThi();
            huongDanQuanLyDeThi.Show();
        }

        private void frmQuanLyDeThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            //Lấy id của câu hỏi, lấy id của đề đang được chọn trong gridview
            //-> cập nhật thông tin vào csdl -> load lại.
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //ID câu hỏi trên gvCauHoi.
                int id = Convert.ToInt32(gvCauHoi.SelectedCells[0].OwningRow.Cells["ID"].Value);
                //Cập nhật số lần ra đề vào bảng câu hỏi khi câu hỏi được chọn để thêm vào đề.
                //Lấy số lần trong csdl + 1.
                CauHoi ch = db.CauHois.Where(c => c.ID.Equals(id)).SingleOrDefault();
                int? solan;
                if (ch.SoLanRaDe == null)
                    solan = 1;
                else
                    solan = ch.SoLanRaDe + 1;
                ch.SoLanRaDe = solan;
                label3.Text = solan.ToString();
                db.SubmitChanges();
                //MaDe trên gvDeThi.
                string maDe = gvDeThi.SelectedCells[0].OwningRow.Cells["MaDe"].Value.ToString();
                DeThi de = db.DeThis.Where(d => d.MaDe.Equals(maDe)).SingleOrDefault();
                string tenCot = gvDeThi.SelectedCells[0].OwningColumn.HeaderText;
                if(tenCot == "Cau01")
                {
                    de.Cau01 = id;
                    db.SubmitChanges();
                }
                else if(tenCot == "Cau02")
                {
                    de.Cau02 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau03")
                {
                    de.Cau03 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau04")
                {
                    de.Cau04 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau05")
                {
                    de.Cau05 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau06")
                {
                    de.Cau06 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau07")
                {
                    de.Cau07 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau08")
                {
                    de.Cau08 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau09")
                {
                    de.Cau09 = id;
                    db.SubmitChanges();
                }
                else if (tenCot == "Cau10")
                {
                    de.Cau10 = id;
                    db.SubmitChanges();
                }
                MessageBox.Show(string.Format("Câu hỏi có ID: {0} đã được thêm vào " +
                        "đề thi tại {1}", id, tenCot), "Thông Báo", MessageBoxButtons.OK);
                //Lấy vị trí của dòng và cột mới được thêm, để di chuyển sang cell bên cạnh.
                dong = gvDeThi.CurrentRow.Index;
                cot = gvDeThi.CurrentCell.ColumnIndex;
                LoadDe();
            }
        }
    }
}
