using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class DBHopDong
    {
        QuanLyBanHoaEntities context = new QuanLyBanHoaEntities();
        public List<HopDong> GetAllHopDong()
        {
           return context.HopDong.ToList();
        }
        public string SetNewPrimaryKey()
        {
            string nextPrimaryKey = context.HopDong
                          .Select(e => e.SoHopDong)
                          .OrderByDescending(p => p)
                          .FirstOrDefault();

            int t = int.Parse(nextPrimaryKey);
            return  ((t + 1) < 10 ? "0" + (t + 1).ToString() : (t + 1).ToString());
        }
        public List<HopDong> Fillter(string colName, string value)
        {
            List<HopDong> dv = new List<HopDong>();
            if (colName == "SoHopDong")
                dv = context.HopDong.Where(s => s.SoHopDong.Contains(value)).ToList();
            if (colName == "MaNCC")
                dv = context.HopDong.Where(s => s.MaNCC.Contains(value)).ToList();
            if (colName == "NgayKy")
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(value);
                    dv = context.HopDong.Where(s => s.NgayKy == dt).ToList();
                }
                catch { dv = GetAllHopDong(); }
            }

            if (colName == "ThoiHanHopDong")
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(value);
                    dv = context.HopDong.Where(s => s.ThoiHanHopDong == dt).ToList();
                }
                catch { dv = GetAllHopDong(); }
            }
            return dv;
        }
        public bool InsertHopDong(string soHopDong, string maNCC, DateTime? ngayKy, DateTime? thoiHanHopDong)
        {
            try
            {
                HopDong hd = new HopDong
                {
                   SoHopDong = soHopDong,
                   MaNCC = maNCC,
                   NgayKy = ngayKy,
                   ThoiHanHopDong = thoiHanHopDong
                };
                context.HopDong.Add(hd);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHopDong(string soHopDong, string maNCC, DateTime? ngayKy, DateTime? thoiHanHopDong)
        {
            try
            {
                HopDong hd = context.HopDong.Single(s => s.SoHopDong.Equals(soHopDong));
                hd.MaNCC = maNCC;
                hd.NgayKy = ngayKy;
                hd.ThoiHanHopDong = thoiHanHopDong;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteHopDong(string soHopDong)
        {
            try
            {
                HopDong hd = context.HopDong.Single(s => s.SoHopDong.Equals(soHopDong));
                context.HopDong.Remove(hd);
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
