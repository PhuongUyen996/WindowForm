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
    public partial class frmXemDanhMucHoaDon : Form
    {
        DBHoaDon dbHoaDon;
        public frmXemDanhMucHoaDon()
        {
            InitializeComponent();
        }

        private void frmChonHoaDon_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void DataLoad()
        {

            dbHoaDon = new DBHoaDon();
            dgvDanhMucHoaDon.DataSource = dbHoaDon.GetAllHoaDon();
            dgvDanhMucHoaDon.Columns["ChiTietHoaDon"].Visible = false;
            dgvDanhMucHoaDon.Columns["KhachHang"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucHoaDon.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucHoaDon.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            cmCotTimKiem.DataSource = new string[] { "MaHoaDon", "MaKH", "NgayLap", "NhanVien" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;

            dgvDanhMucHoaDon.DataSource = dbHoaDon.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucHoaDon.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucHoaDon.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
