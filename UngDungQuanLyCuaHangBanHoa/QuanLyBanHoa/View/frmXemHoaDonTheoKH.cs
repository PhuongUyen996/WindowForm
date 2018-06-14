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
    public partial class frmXemHoaDonTheoKH : Form
    {
        DBKhachHang dbKH;
        DBHoaDon dbHoaDon;
        DataTable dtKH;
        DataTable dtHoaDon;
        public frmXemHoaDonTheoKH()
        {
            InitializeComponent();
        }

        private void frmXemHoaDonTheoKH_Load(object sender, EventArgs e)
        {
            dbKH = new DBKhachHang();
            dtKH = new DataTable();
          
            dtKH = dbKH.GetInfo().Tables[0];
            dgvDanhMucKhachHang.DataSource = dtKH;

            SetDgvHeaderColIndex(dgvDanhMucKhachHang);

            LoadDgvHoaDonData(dgvDanhMucKhachHang.Rows[0].Cells["MaKH"].Value.ToString());
        }

        private void LoadDgvHoaDonData(string maKH)
        {
            dbHoaDon = new DBHoaDon();
            dtHoaDon = new DataTable();

            dtHoaDon = dbHoaDon.GetHoaDonTheoKH(maKH).Tables[0];
            dgvDanhMucHoaDon.DataSource = dtHoaDon;
            SetDgvHeaderColIndex(dgvDanhMucHoaDon);
        }

        private void SetDgvHeaderColIndex(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = new DataView(dtKH);

            string strFilter = txtGiaTriTimKiem.Text.Trim();

            dv.RowFilter = $"TenKH LIKE '%{strFilter}%'";

            dgvDanhMucKhachHang.DataSource = dv;
            SetDgvHeaderColIndex(dgvDanhMucKhachHang);
            try
            {
                LoadDgvHoaDonData(dgvDanhMucKhachHang.Rows[0].Cells["MaKH"].Value.ToString());
            }
            catch { }
        }

        private void dgvDanhMucKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            string maKH = dgvDanhMucKhachHang.Rows[idx].Cells["MaKH"].Value.ToString();

            LoadDgvHoaDonData(maKH);
        }
    }
}
