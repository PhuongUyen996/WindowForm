using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class DBCTHopDong
    {
        QuanLyBanHoaEntities context = new QuanLyBanHoaEntities();
        public List<ChiTietHopDong> GetAllCTHopDong()
        {
            return context.ChiTietHopDong.ToList();
        }
        public List<ChiTietHopDong> Fillter(string colName, string value)
        {
            List<ChiTietHopDong> dv = new List<ChiTietHopDong>();
            if (colName == "SoHopDong")
                dv = context.ChiTietHopDong.Where(s => s.SoHopDong.Contains(value)).ToList();
            if (colName == "MaSP")
                dv = context.ChiTietHopDong.Where(s => s.MaSP.Contains(value)).ToList();
            return dv;
        }
        public bool InsertCTHopDong(ref string err, string soHopDong, string maSP, int soLuong, decimal? donGia)
        {
            try
            {
                ChiTietHopDong cthd = new ChiTietHopDong
                {
                    SoHopDong = soHopDong,
                    MaSP = maSP,
                    SoLuong = soLuong,
                    DonGia = donGia,
                };
                context.ChiTietHopDong.Add(cthd);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }
        public bool UpdateCTHopDong(string soHopDong, string maSP, int soLuong, decimal? donGia)
        {
            try
            {
                ChiTietHopDong cthd = context.ChiTietHopDong.Single(s => s.SoHopDong.Equals(soHopDong) && s.MaSP.Equals(maSP));
                cthd.SoLuong = soLuong;
                cthd.DonGia = donGia;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCTHopDong(string soHopDong, string maSP)
        {
            try
            {
                ChiTietHopDong cthd = context.ChiTietHopDong.Single(s => s.SoHopDong.Equals(soHopDong) && s.MaSP.Equals(maSP));
                context.ChiTietHopDong.Remove(cthd);
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
