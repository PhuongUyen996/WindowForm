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
    public partial class frmXemDanhMucNCC : Form
    {
        DBNhaCungCap dbNCC;
        public frmXemDanhMucNCC()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucNCC_Load(object sender, EventArgs e)
        {
            dbNCC = new DBNhaCungCap();
            dgvDanhMucNCC.DataSource = dbNCC.GetAllNhaCC();
            dgvDanhMucNCC.Columns["HopDong"].Visible = false;
            foreach (DataGridViewRow row in dgvDanhMucNCC.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNCC.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "MaNCC", "TenNCC", "DiaChi", "SDT" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;

            dgvDanhMucNCC.DataSource = dbNCC.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucNCC.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNCC.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
