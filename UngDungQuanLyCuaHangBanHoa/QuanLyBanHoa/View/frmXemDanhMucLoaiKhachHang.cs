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
    public partial class frmXemDanhMucLoaiKhachHang : Form
    {
        DBLoaiKhachHang dbLoaiKH;
        public frmXemDanhMucLoaiKhachHang()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucLoaiKhachHang_Load(object sender, EventArgs e)
        {
            dbLoaiKH = new DBLoaiKhachHang();
            dgvDanhMucLoaiKH.DataSource = dbLoaiKH.GetAllLoaiKH();
            dgvDanhMucLoaiKH.Columns["KhachHang"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucLoaiKH.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucLoaiKH.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "MaLoaiKH", "TenLoaiKH", "ChietKhau" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;
            dgvDanhMucLoaiKH.DataSource = dbLoaiKH.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucLoaiKH.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucLoaiKH.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
