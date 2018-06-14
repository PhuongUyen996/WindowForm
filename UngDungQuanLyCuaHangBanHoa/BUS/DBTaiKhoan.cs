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
    public class DBTaiKhoan
    {
        QuanLyBanHoaEntities context;
        public DBTaiKhoan()
        {
            context = new QuanLyBanHoaEntities();
        }

        public bool LoginHandle(string user, string pass)
        {
            return (context.TaiKhoan.Where(tk => tk.TenDangNhap == user && tk.MatKhau == pass).Count()) > 0 ? true : false;
        }
         public bool ChangePassword(ref string err , string user, string newPass)
        {
            try
            {
                TaiKhoan tk = context.TaiKhoan.Single(s => s.TenDangNhap.Equals(user));
                tk.MatKhau = newPass;
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                err = e.Message;
                return false;
            }
        }

    
    }
}
