using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHoa.View
{
    public partial class frmDoiGiaBan : Form
    {
        public frmDoiGiaBan()
        {
            InitializeComponent();
        }

        decimal giaBan;
        DataRow row;

        public void ShowFrmDoiGiaBan(decimal giaBan, DataRow row)
        {
            this.giaBan = giaBan;
            this.row = row;
            this.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;

            row.BeginEdit();
            row["GiaBan"] = txtGiaBan.Text.Trim();
            row["ThanhTien"] = decimal.Parse(txtGiaBan.Text.Trim()) * (int)row["SoLuong"] - (((int)row["ChietKhau"] * (int)row["SoLuong"] * decimal.Parse(txtGiaBan.Text.Trim())) / 100);
            row.EndEdit();

            frm.DtCurrHoaDon.AcceptChanges();
            frm.DgvChiTietHoaDonHienTai_LoadData();

            this.Close();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiGiaBan_Load(object sender, EventArgs e)
        {
            txtGiaBan.Text = giaBan.ToString();
            txtGiaBan.Focus();
        }
    }
}
