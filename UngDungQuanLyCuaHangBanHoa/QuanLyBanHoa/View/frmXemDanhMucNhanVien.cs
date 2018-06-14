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
    public partial class frmXemDanhMucNhanVien : Form
    {
        DBNhanVien dbNhanVien;
        public frmXemDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void frmXemDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            dbNhanVien = new DBNhanVien();
            dgvDanhMucNhanVien.DataSource = dbNhanVien.GetAllEmployee();

            foreach (DataGridViewRow row in dgvDanhMucNhanVien.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNhanVien.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "HoTenNV", "MaNV", "DiaChi", "SDT", "GioiTinh", "NgaySinh" };
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string colName = cmCotTimKiem.Text;
            string strFilter = txtGiaTriTimKiem.Text.Trim();

            dgvDanhMucNhanVien.DataSource = dbNhanVien.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucNhanVien.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNhanVien.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
