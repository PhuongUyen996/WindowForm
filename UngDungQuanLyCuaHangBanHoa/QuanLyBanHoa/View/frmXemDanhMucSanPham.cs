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
    public partial class frmXemDanhMucSanPham : Form
    {
        DBSanPham dbSanPham;
        public frmXemDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucSanPham_Load(object sender, EventArgs e)
        {
            dbSanPham = new DBSanPham();
            dgvDanhMucSanPham.DataSource = dbSanPham.GetAllProduct();
            dgvDanhMucSanPham.Columns["ChiTietHoaDon"].Visible = false;
            dgvDanhMucSanPham.Columns["ChiTietHopDong"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "TenSP", "MaSP", "DonViTinh", "SoLuong", "GiaBan", "GiaMua" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;

            dgvDanhMucSanPham.DataSource = dbSanPham.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
