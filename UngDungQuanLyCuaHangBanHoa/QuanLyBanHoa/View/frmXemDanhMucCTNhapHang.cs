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
    public partial class frmXemDanhMucCTNhapHang : Form
    {
        DBChiTietNhapHang dbCTNhapHang;
        DataTable dtCTNhapHang;
        public frmXemDanhMucCTNhapHang()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucCTNhapHang_Load(object sender, EventArgs e)
        {
            dbCTNhapHang = new DBChiTietNhapHang();
            dtCTNhapHang = new DataTable();
            dtCTNhapHang = dbCTNhapHang.GetAllChiTietNhapHang().Tables[0];

            dgvDanhMucCTNhapHang.DataSource = dtCTNhapHang;

            foreach (DataGridViewRow row in dgvDanhMucCTNhapHang.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTNhapHang.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            string[] strs = new string[dtCTNhapHang.Columns.Count];
            int idx = 0;
            foreach (DataColumn col in dtCTNhapHang.Columns)
            {
                strs[idx++] += col.ColumnName;
            }
            cmCotTimKiem.DataSource = strs;
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = new DataView(dtCTNhapHang);

            string strFilter = txtGiaTriTimKiem.Text.Trim();

            foreach (DataColumn col in dtCTNhapHang.Columns)
            {
                if (cmCotTimKiem.Text == col.ColumnName)
                {
                    dv.RowFilter = $"{col.ColumnName} LIKE '%{strFilter}%'";
                }
            }

            dgvDanhMucCTNhapHang.DataSource = dv;
            foreach (DataGridViewRow row in dgvDanhMucCTNhapHang.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTNhapHang.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
