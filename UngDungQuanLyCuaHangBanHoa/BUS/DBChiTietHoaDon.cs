using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DBChiTietHoaDon
    {
        QuanLyBanHoaEntities context = new QuanLyBanHoaEntities();
        public List<ChiTietHoaDon> GetAllCTHoaDon()
        {
            return context.ChiTietHoaDon.ToList();
        }
        
        public List<ChiTietHoaDon> Fillter(string colName, string value)
        {
            List<ChiTietHoaDon> dv = new List<ChiTietHoaDon>();
            if (colName == "MaHoaDon")
                dv = context.ChiTietHoaDon.Where(s => s.MaHoaDon.Contains(value)).ToList();
            if (colName == "MaSP")
                dv = context.ChiTietHoaDon.Where(s => s.MaSP.Contains(value)).ToList();
            return dv;
        }
        public bool InsertCTHoaDon(ref string err, string maHoaDon, string maSP,int soLuong, decimal? donGia, int ck)                   
        {
            try
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon {
                    MaHoaDon = maHoaDon,
                    MaSP = maSP,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    ChietKhau = ck
                };
                context.ChiTietHoaDon.Add(cthd);
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                err = e.Message;
                return false;
            }
        }
        public bool UpdateCTHoaDon(string maHoaDon, string maSP, int soLuong, decimal? donGia, int ck)
        {
            try
            {
                ChiTietHoaDon cthd = context.ChiTietHoaDon.Single(s => s.MaHoaDon.Equals(maHoaDon) && s.MaSP.Equals(maSP));
                cthd.SoLuong = soLuong;
                cthd.DonGia = donGia;
                cthd.ChietKhau = ck;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCTHoaDon(string maHoaDon, string maSP)
        {
            try
            {
                ChiTietHoaDon cthd = context.ChiTietHoaDon.Single(s => s.MaHoaDon.Equals(maHoaDon) && s.MaSP.Equals(maSP));
                context.ChiTietHoaDon.Remove(cthd);
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
