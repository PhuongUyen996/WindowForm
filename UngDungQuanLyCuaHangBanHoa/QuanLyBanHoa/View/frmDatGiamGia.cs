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
    public partial class frmDatGiamGia : Form
    {
        decimal giaBan;
        int ck;
        double thanhTien = 0;
        DataRow row;
        public frmDatGiamGia()
        {
            InitializeComponent();
        }

        public void ShowFrmDatGiamGia(decimal giaBan, int ck, DataRow row)
        {
            this.giaBan = giaBan;
            this.ck = ck;
            this.row = row;
            this.Show();
        }
        private void frmDatGiamGia_Load(object sender, EventArgs e)
        {
            txtDonGiaGoc.Text = giaBan.ToString();
            nudCK.Value = ck;
        }
        private double LamTronSoTien(double soTien)
        {
            if (soTien == 0)
                return 0;

            int p = int.Parse(soTien.ToString().Substring(soTien.ToString().Length - 3));

            if (p < 250)
                return (int)(soTien / 1000) * 1000;
            else if (p >= 250 && p < 750)
                return (int)(soTien / 1000) * 1000 + 500;
            else
                return (int)(soTien / 1000) * 1000 + 1000;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;

            row.BeginEdit();
            row["ChietKhau"] = nudCK.Value;
            row["ThanhTien"] = (decimal)(thanhTien);
            row.EndEdit();

            frm.DtCurrHoaDon.AcceptChanges();
            frm.DgvChiTietHoaDonHienTai_LoadData();

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudCK_ValueChanged(object sender, EventArgs e)
        {
            thanhTien = LamTronSoTien((double)((decimal)row["GiaBan"] * (int)row["SoLuong"] - (((nudCK.Value * (int)row["SoLuong"] * (decimal)row["GiaBan"])) / 100)));
            lblResult.Text = "Giá sau khi giảm " + nudCK.Value + "% là: " + thanhTien;
        }

      
    }
}
