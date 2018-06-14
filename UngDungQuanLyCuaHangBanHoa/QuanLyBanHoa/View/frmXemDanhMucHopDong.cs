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
    public partial class frmXemDanhMucHopDong : Form
    {
        DBHopDong dbHopDong;
        public frmXemDanhMucHopDong()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucHopDong_Load(object sender, EventArgs e)
        {
            dbHopDong = new DBHopDong();
            dgvDanhMucHopDong.DataSource = dbHopDong.GetAllHopDong();
            dgvDanhMucHopDong.Columns["NhaCungCap"].Visible = false;
            dgvDanhMucHopDong.Columns["ChiTietHopDong"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "SoHopDong", "MaNCC", "NgayKy", "ThoiHanHopDong" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;

            dgvDanhMucHopDong.DataSource = dbHopDong.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
