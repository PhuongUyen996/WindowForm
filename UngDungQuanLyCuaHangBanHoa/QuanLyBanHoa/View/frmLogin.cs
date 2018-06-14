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
    public partial class frmLogin : Form
    {
        DBTaiKhoan dbTaiKhoan;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dbTaiKhoan = new DBTaiKhoan();
            this.ActiveControl = txtUser;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.ResetText();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.ResetText();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9)
                txtPassword.Focus();
        }

        private void Login()
        {
            if (txtUser.Text.Trim().Length == 0)
            {
                lblError.Text = "Trường tên đăng nhập không được trống!";
                this.ActiveControl = txtUser;
                return;
            }
            else lblError.ResetText();

            if (txtPassword.Text.Trim().Length == 0)
            {
                lblError.Text = "Trường mật khẩu không được trống!";
                this.ActiveControl = txtPassword;
                return;
            }
            else lblError.ResetText();

            string user = txtUser.Text.Trim();
            string pass = txtPassword.Text.Trim();


            if (dbTaiKhoan.LoginHandle(user, pass) == true)
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowFrmMain(user, pass);
            }
            else
            {
                lblError.Text = "Đăng nhập không thành công";
                txtUser.ResetText();
                txtPassword.ResetText();
                txtUser.Focus();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Login();

            if (e.KeyChar == 9)
                btnLogin.Focus();
        }
    }
}
