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
    public partial class frmXemHoaDonTheoNhanVien : Form
    {
        DBNhanVien dbNV;
        DBHoaDon dbHoaDon;
        DataTable dtNV;
        DataTable dtHoaDon;
        public frmXemHoaDonTheoNhanVien()
        {
            InitializeComponent();
        }

        private void HoaDonTheoSanPham_Load(object sender, EventArgs e)
        {
            dbNV = new DBNhanVien();
            dtNV = new DataTable();

            dtNV = dbNV.GetAllNhanVien().Tables[0];
            dgvDanhMucNhanVien.DataSource = dtNV;

            SetDgvHeaderColIndex(dgvDanhMucNhanVien);

            LoadDgvHoaDonData(dgvDanhMucNhanVien.Rows[0].Cells["MaNV"].Value.ToString());

        }
        private void LoadDgvHoaDonData(string maNV)
        {
            dbHoaDon = new DBHoaDon();
            dtHoaDon = new DataTable();

            dtHoaDon = dbHoaDon.GetHoaDonTheoNhanVien(maNV).Tables[0];
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
            DataView dv = new DataView(dtNV);

            string strFilter = txtGiaTriTimKiem.Text.Trim();

            dv.RowFilter = $"HoTenNV LIKE '%{strFilter}%'";

            dgvDanhMucNhanVien.DataSource = dv;
            SetDgvHeaderColIndex(dgvDanhMucNhanVien);
                try
            {
                LoadDgvHoaDonData(dgvDanhMucNhanVien.Rows[0].Cells["MaNV"].Value.ToString());
            }
            catch { }
        }

    

        private void dgvDanhMucNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            string maNV = dgvDanhMucNhanVien.Rows[idx].Cells["MaNV"].Value.ToString();

            LoadDgvHoaDonData(maNV);
        }
    }
}
