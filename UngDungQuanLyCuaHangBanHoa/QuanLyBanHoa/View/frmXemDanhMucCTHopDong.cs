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
    public partial class frmXemDanhMucCTHopDong : Form
    {
        DBCTHopDong dbCTHopDong;
        public frmXemDanhMucCTHopDong()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucCTHopDong_Load(object sender, EventArgs e)
        {
            dbCTHopDong = new DBCTHopDong();
            dgvDanhMucCTHopDong.DataSource = dbCTHopDong.GetAllCTHopDong();
            dgvDanhMucCTHopDong.Columns["HopDong"].Visible = false;
            dgvDanhMucCTHopDong.Columns["SanPham"].Visible = false;
            foreach (DataGridViewRow row in dgvDanhMucCTHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "SoHopDong", "MaSP" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string colName = cmCotTimKiem.Text;
            string strFilter = txtGiaTriTimKiem.Text.Trim();

            dgvDanhMucCTHopDong.DataSource = dbCTHopDong.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucCTHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
