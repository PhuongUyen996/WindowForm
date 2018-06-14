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
   public class DBChiTietNhapHang
    {
        DBLayer db;
        public DBChiTietNhapHang()
        {
            db = new DBLayer();
        }
        public DataSet GetAllChiTietNhapHang()
        {
            return db.GetData("SELECT * FROM ChiTietNhapHang");
        }

        public bool InsertCTNhapHang(ref string err,string maNhapHang, string soHopDong, string maSP, int soLuong, DateTime ngayNhapHang)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@MaNhapHang", maNhapHang), new SqlParameter("@SoHopDong", soHopDong),
                new SqlParameter("@MaSP", maSP),new SqlParameter("@SoLuong",soLuong), new SqlParameter("@NgayNhapHang",ngayNhapHang )};

            return db.ExecuteNonQuery(ref err, "spInsertCTNhapHang", CommandType.StoredProcedure, ps);
        }
        public bool UpdateCTNhapHang(ref string err, string maNhapHang, string soHopDong, string maSP, int soLuong, DateTime ngayNhapHang)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@MaNhapHang", maNhapHang), new SqlParameter("@SoHopDong", soHopDong),
                new SqlParameter("@MaSP", maSP),new SqlParameter("@SoLuong",soLuong), new SqlParameter("@NgayNhapHang",ngayNhapHang)};

            return db.ExecuteNonQuery(ref err, "spUpdateCTNhapHang", CommandType.StoredProcedure, ps);
        }
        public bool DeleteCTNhapHang(ref string err, string maNhapHang)
        {
            SqlParameter[] ps = new SqlParameter[] { new SqlParameter("@MaNhapHang", maNhapHang)};

            return db.ExecuteNonQuery(ref err, "spDeleteCTHNhapHang", CommandType.StoredProcedure, ps);
        }
    }
}
