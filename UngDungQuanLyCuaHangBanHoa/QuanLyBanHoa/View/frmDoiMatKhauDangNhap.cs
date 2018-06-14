using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QuanLyBanHoa.View
{
    public partial class frmDoiMatKhauDangNhap : Form
    {
        DBTaiKhoan dbTaiKhoan;
        string user;
        string pass;
        public frmDoiMatKhauDangNhap()
        {
            InitializeComponent();
        }
        public void DoiMatKhau(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
            this.Show();
        }

        private void frmDoiMatKhauDangNhap_Load(object sender, EventArgs e)
        {
            dbTaiKhoan = new DBTaiKhoan();
            lblUser.Text = user;
            this.ActiveControl = txtMatKhauCu;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            if (matKhauCu != pass)
            {
                MessageBox.Show("Mật khẩu cũ không đúng, mời bạn nhập lại");
                txtMatKhauCu.Focus();
                return;
            }

            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string nhapLai = txtNhapLai.Text.Trim();

            if (matKhauMoi != nhapLai)
            {
                MessageBox.Show("Trường mật khẩu mới và trường nhập lại không khớp, xin nhập lại");
                txtNhapLai.Focus();
                return;
            }
            string err = "";
            if (dbTaiKhoan.ChangePassword(ref err, user, matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
                MessageBox.Show("Đổi mật khẩu không thành công\n"  + err);



        }
    }
}
