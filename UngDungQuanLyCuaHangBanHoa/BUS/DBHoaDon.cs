using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DBHoaDon
    {
        QuanLyBanHoaEntities context = new QuanLyBanHoaEntities();
        public List<HoaDon> GetAllHoaDon()
        {
            return context.HoaDon.ToList();
        }
        public string SetNewPrimaryKey()
        {
            string nextPrimaryKey = context.HoaDon
                          .Select(e => e.MaHoaDon)
                          .OrderByDescending(p => p)
                          .FirstOrDefault();

            int t = int.Parse(nextPrimaryKey);
            return ((t + 1) < 10 ? "0" + (t + 1).ToString() : (t + 1).ToString());
        }
        public List<HoaDon> Fillter(string colName, string value)
        {
            List<HoaDon> dv = new List<HoaDon>();
            if (colName == "MaHoaDon")
                dv = context.HoaDon.Where(s => s.MaHoaDon.Contains(value)).ToList();
            if (colName == "MaKH")
                dv = context.HoaDon.Where(s => s.MaKH.Contains(value)).ToList();
            if (colName == "NhanVien")
                dv = context.HoaDon.Where(s => s.NhanVien.Contains(value)).ToList();
         
            if (colName == "NgayLap")
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(value);
                    dv = context.HoaDon.Where(s => s.NgayLap == dt).ToList();
                }
                catch { }
            }
            return dv;
        }
        public bool InsertHoaDon(string maHoaDon, string maKH, DateTime? ngayLap, decimal? tienHang,
                                decimal? giamGia, decimal? thue, decimal? tongTien, string nhanVien)
        {
            try
            {
                HoaDon hoadon = new HoaDon
                {
                    MaHoaDon = maHoaDon,
                    MaKH = maKH,
                    NgayLap = ngayLap,
                    TienHang = tienHang,
                    GiamGia = giamGia,
                    Thue = thue,
                    TongTien = tongTien,
                    NhanVien = nhanVien
                };
                context.HoaDon.Add(hoadon);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHoaDon(string maHoaDon, string maKH, DateTime? ngayLap, decimal? tienHang,
                                  decimal? giamGia, decimal? thue, decimal? tongTien, string nhanVien)
        {
            try
            {
                HoaDon hoadon = context.HoaDon.Single(s => s.MaHoaDon.Equals(maHoaDon));

                hoadon.MaKH = maKH;
                hoadon.NgayLap = ngayLap;
                hoadon.TienHang = tienHang;
                hoadon.GiamGia = giamGia;
                hoadon.Thue = thue;
                hoadon.TongTien = tongTien;
                hoadon.NhanVien = nhanVien;

                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteHoaDon(string maHoaDon)
        {
            try
            {
                HoaDon hoadon = context.HoaDon.Single(s => s.MaHoaDon.Equals(maHoaDon));

                context.HoaDon.Remove(hoadon);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
