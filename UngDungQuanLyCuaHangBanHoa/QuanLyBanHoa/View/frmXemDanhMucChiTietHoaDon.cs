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
    public partial class frmXemDanhMucChiTietHoaDon : Form
    {
        DBChiTietHoaDon dbCTHoaDon;
        public frmXemDanhMucChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dbCTHoaDon = new DBChiTietHoaDon();
            dgvDanhMucCTHoaDon.DataSource = dbCTHoaDon.GetAllCTHoaDon();
            dgvDanhMucCTHoaDon.Columns["HoaDon"].Visible = false;
            dgvDanhMucCTHoaDon.Columns["SanPham"].Visible = false;
            foreach (DataGridViewRow row in dgvDanhMucCTHoaDon.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTHoaDon.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] {"MaHoaDon", "MaSP" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string str = txtGiaTriTimKiem.Text;
            string colName = cmCotTimKiem.Text;

            dgvDanhMucCTHoaDon.DataSource = dbCTHoaDon.Fillter(colName,str);
            foreach (DataGridViewRow row in dgvDanhMucCTHoaDon.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTHoaDon.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
