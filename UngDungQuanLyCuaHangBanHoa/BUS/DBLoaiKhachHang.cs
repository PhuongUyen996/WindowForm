using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DBLoaiKhachHang
    {
        QuanLyBanHoaEntities context = new QuanLyBanHoaEntities();

        public List<LoaiKH> GetAllLoaiKH()
        {
            return context.LoaiKH.ToList();
        }
        public string SetNewPrimaryKey()
        {
            string nextPrimaryKey = context.LoaiKH
                          .Select(e => e.MaLoaiKH)
                          .OrderByDescending(p => p)
                          .FirstOrDefault();

            int t = int.Parse(nextPrimaryKey);
            return ((t + 1) < 10 ? "0" + (t + 1).ToString() : (t + 1).ToString());
        }

        public List<LoaiKH> Fillter(string colName, string value)
        {
            List<LoaiKH> dv = new List<LoaiKH>();
            if (colName == "MaLoaiKH")
                dv = context.LoaiKH.Where(s => s.MaLoaiKH.Contains(value)).ToList();
            if (colName == "TenLoaiKH")
                dv = context.LoaiKH.Where(s => s.TenLoaiKH.Contains(value)).ToList();
            if (colName == "ChietKhau")
            {
                try
                {
                    int sl = int.Parse(value);
                    dv = context.LoaiKH.Where(s => s.ChietKhau.Equals(sl)).ToList();
                }
                catch { }
            }
            return dv;
        }
        public bool InsertLoaiKH(string maLoaiKH,string tenLoaiKH, int chietKhau)
        {
            try
            {
                LoaiKH lkh = new LoaiKH
                {
                    MaLoaiKH = maLoaiKH,
                    TenLoaiKH = tenLoaiKH,
                    ChietKhau = chietKhau
                };
                context.LoaiKH.Add(lkh);
                context.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool UpdateLoaiKH(string maLoaiKH, string tenLoaiKH, int chietKhau)
        {
            try
            {
                LoaiKH lkh = context.LoaiKH.Single(s => s.MaLoaiKH.Equals(maLoaiKH));
                lkh.TenLoaiKH = tenLoaiKH;
                lkh.ChietKhau = chietKhau;
                context.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool DeleteLoaiKH(string maLoaiKH)
        {
            try
            {
                LoaiKH lkh = context.LoaiKH.Single(s => s.MaLoaiKH.Equals(maLoaiKH));
                context.LoaiKH.Remove(lkh);
                context.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
