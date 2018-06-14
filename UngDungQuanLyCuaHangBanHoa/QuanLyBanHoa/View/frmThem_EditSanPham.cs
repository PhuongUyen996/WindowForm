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
    public partial class frmThem_EditSanPham : Form
    {
        bool isInsert = false;
        DBSanPham dbSanPham;

        public frmThem_EditSanPham()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThem_EditSanPham_Load(object sender, EventArgs e)
        {
            dbSanPham = new DBSanPham();
            this.ActiveControl = txtMaSP;

            string[] DVTs = new string[] { "Bông", "Chậu", "Cành" };
            cmDVT.DataSource = DVTs;
        }

        public void ThemSanPham()
        {
            this.Show();
            isInsert = true;
            txtMaSP.Text = dbSanPham.SetNewPrimaryKey();
            txtMaSP.Enabled = false;
        }

        public void SuaSanPham(string maSP, string tenSP, string soLuong, string giaMua, string giaBan, string DVT)
        {
            this.Show();
            txtMaSP.Text = maSP;
            txtTenSP.Text = tenSP;
            txtSoLuong.Text = soLuong;
            txtGiaMua.Text = giaMua;
            txtGiaBan.Text = giaBan;
            cmDVT.Text = DVT;
            txtMaSP.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trường mã sản phẩm không được trống", "Thông báo");
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trường tên sản phẩm không được trống", "Thông báo");
                txtTenSP.Focus();
                return;
            }

            SaveData();
        }

        private void SaveData()
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            int soLuong = int.Parse(txtSoLuong.Text.Trim());
            decimal giaMua = decimal.Parse(txtGiaMua.Text.Trim());
            decimal giaBan = decimal.Parse(txtGiaBan.Text.Trim());
            string dvt = cmDVT.Text.Trim();
            if (isInsert == true)
            {
				if (!dbSanPham.InsertProduct(maSP, tenSP, soLuong, giaMua, giaBan, dvt))
				{
					MessageBox.Show("Thêm sản phẩm không thành công!");
					return;
				}
				else
					isInsert = false;
			}
            else
            {
				if (!dbSanPham.UpdateProduct(maSP, tenSP, soLuong, giaMua, giaBan, dvt))
				{
					MessageBox.Show("Cập nhật sản phẩm không thành công!");
					return;
				}
			}
            this.Close();

            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;
            frmDatHangNCC frm1 = frmDatHangNCC.Instance;
            frm.RefreshDgvDanhMucSanPham(maSP);
            frm1.RefreshDgvDanhMucSanPham(maSP);
        }
    }
}
