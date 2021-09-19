
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Cuoi_Ky
{
    public class NguoiDungHienTai
    {
        public static string TaiKhoan;

        public static int LayID()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var ID = (db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0)).Select(u => u.Stt).ToArray();
                return ID[0];
            }
        }

        public static string LayHoTen()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var HoTen = (db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0)).Select(u => u.HoTen).ToArray();
                return HoTen[0];
            }
        }

        public static string LayLop()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var Lop = (db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0)).Select(u => u.Lop).ToArray();
                return Lop[0];
            }
        }

        public static DateTime? LayNgaySinh()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var NgaySinh = (db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0)).Select(u => u.NgaySinh).ToArray();
                return NgaySinh[0];
            }
        }

        public static string LayQueQuan()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var QueQuan = (db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0)).Select(u => u.QueQuan).ToArray();
                return QueQuan[0];
            }
        }

        public static string LayDienThoai()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var DienThoai = (db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0)).Select(u => u.Sdt).ToList();
                return DienThoai[0];
            }
        }

        public static string LayKhoi()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var Khoi = (db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0)).Select(u => u.Khoi).ToList();
                return Khoi[0];
            }
        }

        public static string LayLoai()
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var Loai = db.Users.Where(u => u.TaiKhoan.CompareTo(NguoiDungHienTai.TaiKhoan) == 0).Select(u => u.LoaiTaiKhoan).ToList();
                return Loai[0];
            }
        }
    }
}
