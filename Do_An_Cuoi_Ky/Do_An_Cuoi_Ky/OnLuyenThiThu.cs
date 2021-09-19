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
    public partial class frmOnLuyenThiThu : Form
    {
        static public int cauHoi;
        static public string dapAnDungHienTai;
        static public int[] diemSo = new int[10];
        static public string[] dapAnDaChon = new string[10];
        static public bool chamDiem = false;

        public frmOnLuyenThiThu()
        {
            InitializeComponent();
        }

        private void frmOnLuyenThiThu_Load(object sender, EventArgs e)
        {
            cauHoi = 1;
            //Load đề vào combobox, load đề theo khối. VD: A gồm Toán, Lý, Hóa.
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                /*//Lấy Khối của Học sinh để hiển thị đề phù hợp.
                string khoi = NguoiDungHienTai.LayKhoi();
                if (khoi == "A00")   //Khoi char(3).
                {
                    var deThi = from de in db.DeThis
                             where de.MaMonHoc == "TH" || de.MaMonHoc == "VL" || de.MaMonHoc == "HH"
                             select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }
                else if(khoi == "A01")
                {
                    var deThi = from de in db.DeThis
                                where de.MaMonHoc == "TH" || de.MaMonHoc == "VL" || de.MaMonHoc == "AV"
                                select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }
                else if(khoi == "B00")
                {
                    var deThi = from de in db.DeThis
                                where de.MaMonHoc == "TH" || de.MaMonHoc == "HH" || de.MaMonHoc == "SH"
                                select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }
                else if(khoi == "C00")
                {
                    var deThi = from de in db.DeThis
                                where de.MaMonHoc == "VH" || de.MaMonHoc == "LS" || de.MaMonHoc == "DL"
                                select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }*/
                //Thí sinh phải có trong danh sách ôn tập.
                //Lấy Stt của thí sinh, kiểm tra xem có trong danh sách không.
                int stt = NguoiDungHienTai.LayID();
                var dsThiSinh = db.KyThiThus.Select(ktt => ktt.DanhSachThiSinh).ToArray();
                string[] ds = new string[dsThiSinh.Count()];
                ds = dsThiSinh[0].Split(',');
                for(int i=0; i<ds.Count(); i++)
                {
                    ds[i] = ds[i].Trim();
                }
                bool tontai = false;
                foreach (string id in ds)
                    if (stt.ToString() == id)
                        tontai = true;
                //Lấy thời hạn ôn tập của thí sinh.
                var ngay = db.KyThiThus.Where(tt => tt.DanhSachThiSinh.Contains(stt.ToString())).Select(tt => tt.DenNgay).ToArray();
                //Kiểm tra ngay có quá ngày hôm nay chưa.
                bool over = false;
                foreach (var n in ngay)
                    if (DateTime.Now.Date > n)
                        over = true;
                if(tontai == false)
                {
                    MessageBox.Show("Bạn không có trong danh sách ôn tập!", "Thông Báo", MessageBoxButtons.OK);
                    this.Close();
                }    
                else if(over == true)
                {
                    MessageBox.Show("Kỳ ôn tập đã kết thúc!", "Thông Báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    //Lấy mã đề mà những thí sinh này được thi.
                    var made = db.KyThiThus.Where(tt => tt.DanhSachThiSinh.Contains(stt.ToString())).Select(tt => tt.DanhSachDeThi).ToArray();
                    //Tách các đề thi trong made ra T_T.
                    string[] tatcade = new string[100];
                    string[] tatca = new string[100];
                    int chiso = 0;
                    for (int i = 0; i < made.Count(); i++)
                    {
                        tatcade = made[i].Split(',');
                        for (int j = 0; j < tatcade.Count(); j++)
                        {
                            tatca[chiso] = tatcade[j].Trim();
                            chiso++;
                        }
                    }
                    string[] madeDistinct = tatca.Distinct().ToArray();
                    cbbChonDe.DataSource = madeDistinct;
                    cbbChonDe.SelectedIndex = 0;
                    LoadDe(cauHoi);
                } 
            }
        }

        public void LoadDe(int cauHoi)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                string IDcauHoi = "";
                //Lấy 1 dòng trong bảng DeThi dựa vào mã đề trên combobox.
                var deThi = db.DeThis.Where(dt => dt.MaDe.CompareTo(cbbChonDe.SelectedValue.ToString()) == 0).ToArray();
                //Lấy ID của CauHoi.
                if (cauHoi == 1)
                    IDcauHoi = deThi[0].Cau01.ToString();
                else if (cauHoi == 2)
                    IDcauHoi = deThi[0].Cau02.ToString();
                else if (cauHoi == 3)
                    IDcauHoi = deThi[0].Cau03.ToString();
                else if (cauHoi == 4)
                    IDcauHoi = deThi[0].Cau04.ToString();
                else if (cauHoi == 5)
                    IDcauHoi = deThi[0].Cau05.ToString();
                else if (cauHoi == 6)
                    IDcauHoi = deThi[0].Cau06.ToString();
                else if (cauHoi == 7)
                    IDcauHoi = deThi[0].Cau07.ToString();
                else if (cauHoi == 8)
                    IDcauHoi = deThi[0].Cau08.ToString();
                else if (cauHoi == 9)
                    IDcauHoi = deThi[0].Cau09.ToString();
                else if (cauHoi == 10)
                    IDcauHoi = deThi[0].Cau10.ToString();
                //Lấy CauHoi, A, B, C, D dựa vào ID.
                var all = db.CauHois.Where(ch => ch.ID.CompareTo(IDcauHoi) == 0).ToArray();
                lblCauHoi.Text = all[0].CauHoi1.ToString();
                lblA.Text = all[0].A.ToString();
                lblB.Text = all[0].B.ToString();
                lblC.Text = all[0].C.ToString();
                lblD.Text = all[0].D.ToString();
                lblStt.Text = cauHoi.ToString();
                lblGoiY.Text = all[0].GoiY.ToString();
                lblGoiY.Hide();
                lblKetQua.Text = all[0].DapAnDung.ToString();
                lblKetQua.Hide();
                dapAnDungHienTai = all[0].DapAnDung.ToString();
            }
        }        

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            ChamDiem();
            if (cauHoi <= 9)
            {
                cauHoi = cauHoi + 1;
                LoadDe(cauHoi);
            }
            else
            {
                chamDiem = true;
                ChamDiem();
            }

            //Refresh lại các radio.
            radioA.Checked = false;
            radioB.Checked = false;
            radioC.Checked = false;
            radioD.Checked = false;
            radioA.Enabled = true;
            radioB.Enabled = true;
            radioC.Enabled = true;
            radioD.Enabled = true;
            //Check vào RadioButton nếu như RadioButton đó đã được check.
            if (dapAnDaChon[cauHoi - 1] != "")
            {
                if (dapAnDaChon[cauHoi - 1] == "A")
                    radioA.Checked = true;
                else if (dapAnDaChon[cauHoi - 1] == "B")
                    radioB.Checked = true;
                else if (dapAnDaChon[cauHoi - 1] == "B")
                    radioC.Checked = true;
                else if (dapAnDaChon[cauHoi - 1] == "D")
                    radioD.Checked = true;
            }
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            ChamDiem();
            if (cauHoi > 1)
            {
                cauHoi = cauHoi - 1;
                LoadDe(cauHoi);
                if(dapAnDaChon[cauHoi - 1] != "")
                {
                    if (dapAnDaChon[cauHoi - 1] == "A")
                        radioA.Checked = true;
                    else if (dapAnDaChon[cauHoi - 1] == "B")
                        radioB.Checked = true;
                    else if (dapAnDaChon[cauHoi - 1] == "B")
                        radioC.Checked = true;
                    else if (dapAnDaChon[cauHoi - 1] == "D")
                        radioD.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Đây đã là câu hỏi đầu tiên rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ChamDiem();
            }
        }

        public void ChamDiem()
        {
            //Ý tưởng: Dùng 1 mảng int để lưu điểm của từng câu.
            //Lấy RadioButton đang được chọn, so sánh với đáp án đúng.
            //Nếu khớp -> phần tử tương ứng trong mảng lưu điểm tăng 1.
            //Có lệnh chấm điểm -> cộng các phần tử trong mảng lại.
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                string dapAn = "";
                if (radioA.Checked == true)
                    dapAn = "A";
                else if (radioB.Checked == true)
                    dapAn = "B";
                else if (radioC.Checked == true)
                    dapAn = "C";
                else if (radioD.Checked == true)
                    dapAn = "D";
                if (dapAn == dapAnDungHienTai)
                    diemSo[cauHoi - 1] = 1;
                else
                    diemSo[cauHoi - 1] = 0;
                dapAnDaChon[cauHoi - 1] = dapAn;
                if(chamDiem == true)
                {
                    int diem = 0;
                    foreach (int d in diemSo)
                        diem = diem + d;
                    DialogResult re = MessageBox.Show(string.Format("Bạn đã hoàn thành bài thi thử! Điểm của bạn là {0}.", diem), "Thông Báo", MessageBoxButtons.OK);
                    if (re == DialogResult.OK)
                        this.Close();
                    cauHoi++;
                }
            }
        }

        private void cbbChonDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cauHoi = 1;
            LoadDe(cauHoi);
        }

        private void frmOnLuyenThiThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
            diemSo = new int[10];
            chamDiem = false;
        }

        private void btnXemGoiY_Click(object sender, EventArgs e)
        {
            lblGoiY.Show();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            lblKetQua.Show();
            MessageBox.Show("Bạn đã xem kết quả nên câu hỏi này không tính điểm nhé!", "Thông Báo", MessageBoxButtons.OK);
            radioA.Checked = false;
            radioB.Checked = false;
            radioC.Checked = false;
            radioD.Checked = false;
            radioA.Enabled = false;
            radioB.Enabled = false;
            radioC.Enabled = false;
            radioD.Enabled = false;

        }

        private void btnDungLam_Click(object sender, EventArgs e)
        {
            //Set cauHienTai == 10 để hàm ChamDiem show ra thông báo.
            chamDiem = true;
            ChamDiem();
            this.Hide();
        }
    }
}
