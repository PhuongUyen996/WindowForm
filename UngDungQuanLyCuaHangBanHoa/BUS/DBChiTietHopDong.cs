using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BUS
{
    public class DBChiTietHopDong
    {
        DBLayer db;
        public DBChiTietHopDong()
        {
            db = new DBLayer();
        }
        public DataSet GetAllChiTietHopDong()
        {
            return db.GetData("SELECT * FROM ChiTietHopDong");
        }
        public DataSet GetInfo()
        {
            string str = "SELECT SoHopDong,cthd.MaSP,TenSP,cthd.SoLuong,cthd.DonGia " +
                         "FROM ChiTietHopDong  cthd left outer join SanPham sp ON cthd.MaSP = sp.MaSP ";

            return db.GetData(str);
        }
    
        public bool InsertCTHopDong(ref string err, string soHopDong, string maSP, int soLuong, decimal donGia)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@SoHopDong", soHopDong), new SqlParameter("@MaSP", maSP),
                                 new SqlParameter("@SoLuong",soLuong),new SqlParameter("@DonGia",donGia)};

            return db.ExecuteNonQuery(ref err, "spInsertCTHopDong", CommandType.StoredProcedure, ps);
        }
        public bool UpdateCTHopDong(ref string err, string soHopDong, string maSP, int soLuong, decimal donGia)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@SoHopDong", soHopDong), new SqlParameter("@MaSP", maSP),
                                 new SqlParameter("@SoLuong",soLuong),new SqlParameter("@DonGia",donGia)};

            return db.ExecuteNonQuery(ref err, "spUpdateCTHopDong", CommandType.StoredProcedure, ps);
        }
        public bool DeleteCTHopDong(ref string err, string soHppDong, string maSP)
        {
            SqlParameter[] ps = new SqlParameter[] { new SqlParameter("@SoHopDong", soHppDong), new SqlParameter("@MaSP", maSP) };

            return db.ExecuteNonQuery(ref err, "spDeleteCTHopDong", CommandType.StoredProcedure, ps);
        }
    }
}
