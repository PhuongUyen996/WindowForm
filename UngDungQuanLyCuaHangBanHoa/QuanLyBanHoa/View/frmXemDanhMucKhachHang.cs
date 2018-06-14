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
    public partial class frmXemDanhMucKhachHang : Form
    {
        DBKhachHang dbKH;
        public frmXemDanhMucKhachHang()
        {
            InitializeComponent();
        }
        public bool isChonKH { get; set; }
        private void dgvDanhMucKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isChonKH == false)
                return;

            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;
            string loaiKH = dgvDanhMucKhachHang.Rows[e.RowIndex].Cells["MaLoaiKH"].Value.ToString();
            string tenKH = dgvDanhMucKhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            string maKH = dgvDanhMucKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            string ck = "0";
            if (loaiKH == "1")
            {
                frm.ChonKhachHang(maKH, tenKH, "10");
                ck = "10";
            }
            else if (loaiKH == "2")
            {
                ck = "5";
                frm.ChonKhachHang(maKH, tenKH, "5");
            }
            isChonKH = false;
            this.Close();
            if (ck != "0")
                MessageBox.Show($"Đã thiết lập giảm giá {ck}% ");
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string str = txtGiaTriTimKiem.Text;
            string colName = cmCotTimKiem.Text;

            dgvDanhMucKhachHang.DataSource = dbKH.Fillter(colName, str);
            foreach (DataGridViewRow row in dgvDanhMucKhachHang.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucKhachHang.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void frmChonKhachHang_Load(object sender, EventArgs e)
        {
            dbKH = new DBKhachHang();
            dgvDanhMucKhachHang.DataSource = dbKH.GetAllCustomer();
            dgvDanhMucKhachHang.Columns["HoaDon"].Visible = false;
            dgvDanhMucKhachHang.Columns["LoaiKH"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucKhachHang.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucKhachHang.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "TenKH", "MaKH", "DiaChi", "SDT", "GioiTinh", "NgaySinh", "MaLoaiKH" };
        }
    }
}
