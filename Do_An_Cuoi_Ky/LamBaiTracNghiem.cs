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
    public partial class frmLamBaiTracNghiem : Form
    {
        static public int cauHoi;
        static public int soCauConLai = 10;
        static public int soCauDaHoanThanh = 0;
        static public string[] dapAnDaChon = new string[10];
        static public string dapAnDungHienTai;
        static public int SttKetQuaThi;
        static public int idCauHoi;
        static public string MaKyThi;

        public frmLamBaiTracNghiem()
        {
            InitializeComponent();
        }

        private void frmLamBaiTracNghiem_Load(object sender, EventArgs e)
        {
            dapAnDaChon = new string[10];
            soCauConLai = 10;
            soCauDaHoanThanh = 0;
            lblSoCauConLai.Text = soCauConLai.ToString();
            lblSoCauDaHoanThanh.Text = soCauDaHoanThanh.ToString();
            lblThoiGianThi.Text = "45";
            lblPhut.Text = lblThoiGianThi.Text;
            cauHoi = 1;
            //Load đề vào combobox, load đề theo khối. VD: A gồm Toán, Lý, Hóa.
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //Lấy Khối của Học sinh để hiển thị đề phù hợp.
                /*string khoi = NguoiDungHienTai.LayKhoi();
                if (khoi == "A00")   //Khoi char(3).
                {
                    var deThi = from de in db.DeThis
                                where de.MaMonHoc == "TH" || de.MaMonHoc == "VL" || de.MaMonHoc == "HH"
                                select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }
                else if (khoi == "A01")
                {
                    var deThi = from de in db.DeThis
                                where de.MaMonHoc == "TH" || de.MaMonHoc == "VL" || de.MaMonHoc == "AV"
                                select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }
                else if (khoi == "B00")
                {
                    var deThi = from de in db.DeThis
                                where de.MaMonHoc == "TH" || de.MaMonHoc == "HH" || de.MaMonHoc == "SH"
                                select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }
                else if (khoi == "C00")
                {
                    var deThi = from de in db.DeThis
                                where de.MaMonHoc == "VH" || de.MaMonHoc == "LS" || de.MaMonHoc == "DL"
                                select de.MaDe;
                    cbbChonDe.DataSource = deThi;
                }*/

                //Thí sinh phải có trong danh sách thi.
                //Lấy Stt của thí sinh, kiểm tra xem có trong danh sách không.
                int stt = NguoiDungHienTai.LayID();
                //var dsThiSinh = db.KyThis.Select(kt => kt.DanhSachThiSinh).ToArray();
                //string[] ds = new string[dsThiSinh.Count()];
                //ds = dsThiSinh[0].Split(',');
                //for (int i = 0; i < ds.Count(); i++)
                //{
                //    ds[i] = ds[i].Trim();
                //}
                //bool tontai = false;
                //foreach (string id in ds)
                //    if (stt.ToString() == id)
                //        tontai = true;
                bool tontai = true;
                var thiSinh = db.KyThis.Where(kt => kt.DanhSachThiSinh.Contains(stt.ToString())).Where(kt => kt.NgayThi == DateTime.Now.Date);
                if (thiSinh.Count() == 0)
                    tontai = false;
                //Lấy ngày thi.
                var ngay = db.KyThis.Where(tt => tt.DanhSachThiSinh.Contains(stt.ToString())).Select(tt => tt.NgayThi).ToArray();
                //Kiểm tra ngay có quá ngày hôm nay chưa.
                bool over = true;
                foreach (var n in ngay)
                    if (DateTime.Now.Date == n)
                        over = false;
                //Nếu là GiaoVien thì có thể vào LamBaiTracNghiem bất cứ lúc nào.
                if(NguoiDungHienTai.LayLoai().Trim() == "GiaoVien")
                {
                    tontai = true;
                    over = false;
                }
                if (tontai == false)
                {
                    MessageBox.Show("Bạn không có trong danh sách thi!", "Thông Báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (over == true)
                {
                    MessageBox.Show("Hôm nay không diễn ra kỳ thi!", "Thông Báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    if(NguoiDungHienTai.LayLoai().Trim() == "GiaoVien")
                    {
                        var madegv = db.DeThis.Select(dt => dt.MaDe).ToArray();
                        cbbChonDe.DataSource = madegv;
                    }
                    else
                    {
                        //Lấy mã đề mà những thí sinh này được thi.
                        var made = db.KyThis.Where(tt => tt.DanhSachThiSinh.Contains(stt.ToString())).Where(tt => tt.NgayThi == DateTime.Now.Date).Select(tt => tt.DanhSachDeThi).ToArray();
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
                        //string[] madeDistinct = tatca.Distinct().ToArray();
                        //cbbChonDe.DataSource = madeDistinct;
                        cbbChonDe.DataSource = tatca.ToArray();
                        cbbChonDe.SelectedIndex = 0;
                        LoadDe(cauHoi);
                    }  
                }
            }
            //Ẩn các nút trước khi thí sinh ấn Bắt đầu làm bài.
            btnCauTruoc.Enabled = false;
            btnCauSau.Enabled = false;
            btnNopBaiSom.Enabled = false;
            radioA.Enabled = false;
            radioB.Enabled = false;
            radioC.Enabled = false;
            radioD.Enabled = false;
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
                idCauHoi = Convert.ToInt32(IDcauHoi);
                var all = db.CauHois.Where(ch => ch.ID.CompareTo(IDcauHoi) == 0).ToArray();
                lblCauHoi.Text = all[0].CauHoi1.ToString();
                lblA.Text = all[0].A.ToString();
                lblB.Text = all[0].B.ToString();
                lblC.Text = all[0].C.ToString();
                lblD.Text = all[0].D.ToString();
                lblStt.Text = cauHoi.ToString();
                lblTenMon.Text = all[0].MonHoc.ToString();
                dapAnDungHienTai = all[0].DapAnDung.ToString();
            }
        }

        private void tmThoiGian_Tick(object sender, EventArgs e)
        {
            tmThoiGian.Interval = 1000;
            int phut = int.Parse(lblPhut.Text);
            int giay = int.Parse(lblGiay.Text);
            giay--;
            if(giay < 0)
            {
                giay = 59;
                phut--;
            }
            if (giay < 10)
                lblGiay.Text = "0" + giay;
            else
                lblGiay.Text = giay + "";
            if (phut < 10)
                lblPhut.Text = "0" + phut;
            else
                lblPhut.Text = phut + "";
        }

        private void btnBatDauLamBai_Click(object sender, EventArgs e)
        {
            tmThoiGian.Start();
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                //Tạo 1 dòng table lưu kết quả.
                //Truy xuất bằng giá trị STT -> duy nhất.
                KetQuaThi kqt = new KetQuaThi();
                kqt.ID = NguoiDungHienTai.LayID();
                kqt.TaiKhoan = NguoiDungHienTai.TaiKhoan;
                kqt.MaDe = cbbChonDe.SelectedItem.ToString();
                db.KetQuaThis.InsertOnSubmit(kqt);
                db.SubmitChanges();
                //Lưu Stt của bài làm vào 1 biến để truy vấn khi chấm điểm.
                SttKetQuaThi = kqt.Stt;
            }
            btnCauTruoc.Enabled = true;
            btnCauSau.Enabled = true;
            btnNopBaiSom.Enabled = true;
            radioA.Enabled = true;
            radioB.Enabled = true;
            radioC.Enabled = true;
            radioD.Enabled = true;
            cbbChonDe.Enabled = false;
        }

        public void ChamDiem()
        {
            //Lấy vị trí RadioButton được chọn.
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
                if (string.IsNullOrEmpty(dapAn) == false)
                {
                    KetQuaThi kqt = db.KetQuaThis.Where(kq => kq.Stt.CompareTo(SttKetQuaThi) == 0).SingleOrDefault();
                    CauHoi ch = db.CauHois.Where(c => c.ID.Equals(idCauHoi)).SingleOrDefault();
                    if (cauHoi == 1)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }                         
                        kqt.Cau01 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 2)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau02 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 3)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau03 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 4)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau04 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 5)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau05 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 6)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau06 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 7)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau07 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 8)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau08 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 9)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau09 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    else if (cauHoi == 10)
                    {
                        char dapAnChon;
                        dapAnChon = Convert.ToChar(dapAn);
                        int diemThi;
                        int? solantrl, solandung;
                        diemThi = kqt.DiemThi;
                        solantrl = ch.SoLanTraLoi;
                        solandung = ch.SoLanTraLoiDung;
                        if (solantrl == null)
                            solantrl = 1;
                        else if (solantrl != null)
                            solantrl = Convert.ToInt32(solantrl) + 1;
                        if (solandung == null)
                            solandung = 0;
                        if (dapAn == dapAnDungHienTai)
                        {
                            diemThi = diemThi + 1;
                            solandung = solandung + 1;
                        }
                        kqt.Cau10 = dapAnChon;
                        kqt.DiemThi = diemThi;
                        ch.SoLanTraLoi = solantrl;
                        ch.SoLanTraLoiDung = solandung;
                        db.SubmitChanges();
                    }
                    if(cauHoi == 10 - soCauConLai + 1)
                    {
                        soCauConLai--;
                        soCauDaHoanThanh++;
                    }   
                    lblSoCauConLai.Text = soCauConLai.ToString();
                    lblSoCauDaHoanThanh.Text = soCauDaHoanThanh.ToString();
                }
                dapAnDaChon[cauHoi - 1] = dapAn;              
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
            else if(cauHoi == 10)
            {
                DialogResult re = MessageBox.Show("Bạn đã hoàn thành bài thi! Bạn có muốn nộp bài không?", "Thông Báo", MessageBoxButtons.YesNo);
                if(re == DialogResult.Yes)
                {
                    MessageBox.Show("Kết quả của bạn đã được lưu lại!", "Thông Báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else if(lblPhut.Text == "00" && lblGiay.Text == "00")
            {
                MessageBox.Show("Thời gian làm bài đã hết! Kết quả của bài thi của bạn sẽ được lưu lại!", "Thông Báo", MessageBoxButtons.OK);
                this.Close();
            }

            //Refresh lại các radio.
            radioA.Checked = false;
            radioB.Checked = false;
            radioC.Checked = false;
            radioD.Checked = false;

            //Check vào RadioButton nếu RadioButton đó đã được check.
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
                if (dapAnDaChon[cauHoi - 1] != "")
                {
                    if (dapAnDaChon[cauHoi - 1] == "A")
                        radioA.Checked = true;
                    else if (dapAnDaChon[cauHoi - 1] == "B")
                        radioB.Checked = true;
                    else if (dapAnDaChon[cauHoi - 1] == "C")
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

        private void cbbChonDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cauHoi = 1;
            LoadDe(cauHoi);
        }

        private void btnNopBaiSom_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn DỪNG làm bài không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(re == DialogResult.OK)
            {
                frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
                giaoVienHocSinh.Show();
                this.Hide();
            }
        }

        private void frmLamBaiTracNghiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChungGiaoVienHocSinh giaoVienHocSinh = new frmChungGiaoVienHocSinh();
            giaoVienHocSinh.Show();
        }
    }
}
