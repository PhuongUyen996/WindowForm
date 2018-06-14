using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class DBKhachHang
    {
        QuanLyBanHoaEntities context = new QuanLyBanHoaEntities();

        public List<KhachHang> GetAllCustomer()
        {
            List<KhachHang> khs = context.KhachHang.ToList();
            return khs;
        }
        public string SetNewPrimaryKey()
        {
            string nextPrimaryKey = context.KhachHang
                          .Select(e => e.MaKH)
                          .OrderByDescending(p => p)
                          .FirstOrDefault();

            int t = int.Parse(nextPrimaryKey.Substring(2));
            return "KH"+((t + 1) < 10 ? "0" + (t + 1).ToString() : (t + 1).ToString());
        }
        public List<KhachHang> Fillter(string colName, string value)
        {
            List<KhachHang> dv = new List<KhachHang>();
            if (colName == "TenKH")
                dv = context.KhachHang.Where(s => s.TenKH.Contains(value)).ToList();
            if (colName == "MaKH")
                dv = context.KhachHang.Where(s => s.MaKH.Contains(value)).ToList();
            if (colName == "GioiTinh")
                dv = context.KhachHang.Where(s => s.GioiTinh.Contains(value)).ToList();
            if (colName == "DiaChi")
                dv = context.KhachHang.Where(s => s.DiaChi.Contains(value)).ToList();
            if (colName == "SDT")
                dv = context.KhachHang.Where(s => s.SDT.Contains(value)).ToList();
            if (colName == "MaLoaiKH")
                dv = context.KhachHang.Where(s => s.MaLoaiKH.Contains(value)).ToList();
            if (colName == "NgaySinh")
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(value);
                    dv = context.KhachHang.Where(s => s.NgaySinh == dt).ToList();
                }
                catch { }
            }
            return dv;
        }
        public bool InsertCustomer(string maKH, string tenKH,DateTime? ngaySinh,string gioiTinh, string diaChi,string sdt,string maLoaiKH)
        {
          
            try
            {
                KhachHang kh = new KhachHang
                {
                    MaKH = maKH,
                    TenKH = tenKH,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh,
                    DiaChi = diaChi,
                    SDT = sdt,
                    MaLoaiKH = maLoaiKH
                };
                context.KhachHang.Add(kh);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(string maKH, string tenKH, DateTime? ngaySinh, string gioiTinh, string diaChi, string sdt, string maLoaiKH)
        {
            try
            {
                KhachHang kh = context.KhachHang.Single(s => s.MaKH.Equals(maKH));
                kh.TenKH = tenKH;
                kh.NgaySinh = ngaySinh;
                kh.GioiTinh = gioiTinh;
                kh.DiaChi = diaChi;
                kh.SDT = sdt;
                kh.MaLoaiKH = maLoaiKH;

                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(string maKH)
        {
            try
            {
                KhachHang kh = context.KhachHang.Single(s => s.MaKH.Equals(maKH));

                context.KhachHang.Remove(kh);
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
