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
   public class DBLoaiKH
    {
        DBLayer db;
        public DBLoaiKH()
        {
            db = new DBLayer();
        }
        public DataSet GetAllLoaiKH()
        {
            return db.GetData("SELECT * FROM LoaiKH");
        }

        public bool InsertLoaiKhachHang(ref string err, string maLoaiKH, string tenLoaiKH, int chietKhau)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@MaLoaiKH", maLoaiKH), new SqlParameter("@TenLoaiKH", tenLoaiKH),
            new SqlParameter("@ChietKhau",chietKhau)};

            return db.ExecuteNonQuery(ref err, "spInsertLoaiKhachHang", CommandType.StoredProcedure, ps);
        }
        public bool UpdateLoaiKhachHang(ref string err, string maLoaiKH, string tenLoaiKH, int chietKhau)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@MaLoaiKH", maLoaiKH), new SqlParameter("@TenLoaiKH", tenLoaiKH),
            new SqlParameter("@ChietKhau",chietKhau)};

            return db.ExecuteNonQuery(ref err, "spUpdateLoaiKhachHang", CommandType.StoredProcedure, ps);
        }
        public bool DeleteLoaiKhachHang(ref string err, string maLoaiKH)
        {
            SqlParameter[] ps = new SqlParameter[] { new SqlParameter("@MaLoaiKH", maLoaiKH) };

            return db.ExecuteNonQuery(ref err, "spDeleteLoaiKhachHang", CommandType.StoredProcedure, ps);
        }
    }
}
