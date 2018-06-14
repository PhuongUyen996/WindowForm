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
    public class DBNhaCC
    {
        DBLayer db;
        public DBNhaCC()
        {
            db = new DBLayer();
        }
        public DataSet GetAllNhaCC()
        {
            return db.GetData("SELECT * FROM NhaCungCap");
        }
        public bool InsertNhaCC(ref string err, string maNCC, string tenNCC, string diaChi, string sdt)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@MaNCC", maNCC), new SqlParameter("@TenNCC", tenNCC),
                new SqlParameter("@DiaChi",diaChi == "" ? (object)DBNull.Value:diaChi),new SqlParameter("@SDT",sdt ==""? (object)DBNull.Value:sdt) };

            return db.ExecuteNonQuery(ref err, "spInsertNhaCC", CommandType.StoredProcedure, ps);
        }
        public bool UpdateNhaCC(ref string err, string maNCC, string tenNCC, string diaChi, string sdt)
        {
            SqlParameter[] ps = new SqlParameter[]{new SqlParameter("@MaNCC", maNCC), new SqlParameter("@TenNCC", tenNCC),
                new SqlParameter("@DiaChi",diaChi == "" ? (object)DBNull.Value:diaChi),new SqlParameter("@SDT",sdt ==""? (object)DBNull.Value:sdt) };

            return db.ExecuteNonQuery(ref err, "spUpdateNhaCC", CommandType.StoredProcedure, ps);
        }
        public bool DeleteNhaCC(ref string err, string maNCC)
        {
            SqlParameter[] ps = new SqlParameter[] { new SqlParameter("@MaNCC", maNCC) };

            return db.ExecuteNonQuery(ref err, "spDeleteNhaCC", CommandType.StoredProcedure, ps);
        }

    }
}
