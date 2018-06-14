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
    public partial class frmDatSoLuong : Form
    {
        DBSanPham dbSanPham;
        int currsl;
        DataRow row;
        int state;
        int luongTon;
        public frmDatSoLuong()
        {
            InitializeComponent();
        }

        public void ShowFrmDatSoLuong(int soLuong, DataRow row, int state, int lt)
        {
            this.currsl = soLuong;
            this.row = row;
            this.state = state;
            luongTon = lt;
            this.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;
            frmDatHangNCC frm1 = frmDatHangNCC.Instance;

            row.BeginEdit();
            row["SoLuong"] = nudSoLuong.Value;
            if (state == 1)// ban hang
            {
                // kiem tra so luong
                if(nudSoLuong.Value > luongTon)
                {
                    MessageBox.Show($"Mặt hàng \"{row["MaSP"].ToString()} - {row["TenSP"].ToString()}\" không đủ số lượng, trong kho chỉ còn {luongTon}");
                    return;
                }
                row["ThanhTien"] = (nudSoLuong.Value) * (decimal)row["GiaBan"] - (((int)row["ChietKhau"] * (decimal)row["GiaBan"] * nudSoLuong.Value) / 100);

                // giam so luong sp
                dbSanPham.UpdateProductAmount(row["MaSP"].ToString(), (-1) * ((int)nudSoLuong.Value - currsl));
            }
            else
            {
                row["ThanhTien"] = (nudSoLuong.Value) * (decimal)row["GiaMua"];
                // tang so luong sp
                dbSanPham.UpdateProductAmount(row["MaSP"].ToString(),(int)nudSoLuong.Value- currsl);
            }
            row.EndEdit();

            if (state == 1)
            {
                frm.DtCurrHoaDon.AcceptChanges();
                frm.DgvChiTietHoaDonHienTai_LoadData();
                frm.RefreshDgvDanhMucSanPham(row["MaSP"].ToString());
            }
            else
            {
                frm1.DtCurrCTHopDong.AcceptChanges();
                frm1.DgvChiTietHopDong_LoadData();
            }

            this.Close();
        }

        private void frmDatSoLuong_Load(object sender, EventArgs e)
        {
            nudSoLuong.Value = currsl;
            dbSanPham = new DBSanPham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
