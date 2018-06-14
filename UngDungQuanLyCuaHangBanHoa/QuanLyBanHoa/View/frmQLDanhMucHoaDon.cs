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
    public partial class frmQLDanhMucHoaDon : Form
    {
        private static frmQLDanhMucHoaDon _instance;
        DBHoaDon dbHoaDon;
        bool isInsert = false;
        public static frmQLDanhMucHoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmQLDanhMucHoaDon();
                return _instance;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _instance = null;
        }
        public frmQLDanhMucHoaDon()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucHoaDon_Load(object sender, EventArgs e)
        {
            grThongTinHoaDon.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        private void SetSelectedRow(string maHoaDon)
        {
            foreach (DataGridViewRow row in dgvDanhMucHoaDon.Rows)
            {
                if (row.Cells["MaHoaDon"].Value.ToString() == maHoaDon)
                {
                    row.Selected = true;
                    dgvDanhMucHoaDon.CurrentCell = row.Cells[0];
                    break;
                }
            }
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

            cmNhanVien.DataSource = new DBNhanVien().GetAllEmployee();
            cmNhanVien.DisplayMember = "MaNV";
            cmNhanVien.ValueMember = "MaNV";

            cmCotTimKiem.DataSource = new string[] { "MaHoaDon", "MaKH", "NgayLap", "NhanVien" };

            cmMaKH.DataSource = new DBKhachHang().GetAllCustomer();
            cmMaKH.DisplayMember = "MaKH";
            cmMaKH.ValueMember = "MaKH";

            DataBind();
        }

        private void DataBind()
        {
            int idx = dgvDanhMucHoaDon.CurrentCell.RowIndex;
            txtMaHoaDon.Text = dgvDanhMucHoaDon.Rows[idx].Cells["MaHoaDon"].Value.ToString();
            try
            {
                cmMaKH.Text = dgvDanhMucHoaDon.Rows[idx].Cells["MaKH"].Value.ToString();
            }
            catch { cmMaKH.Text = ""; }
            try
            {
                cmNhanVien.Text = dgvDanhMucHoaDon.Rows[idx].Cells["NhanVien"].Value.ToString();
            }
            catch { cmMaKH.Text = ""; }
            txtTienHang.Text = dgvDanhMucHoaDon.Rows[idx].Cells["TienHang"].Value.ToString();
            txtGiamGia.Text = dgvDanhMucHoaDon.Rows[idx].Cells["GiamGia"].Value.ToString();
            txtThue.Text = dgvDanhMucHoaDon.Rows[idx].Cells["Thue"].Value.ToString();
            txtTongTien.Text = dgvDanhMucHoaDon.Rows[idx].Cells["TongTien"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;
            cmMaKH.ResetText();

            grThongTinHoaDon.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtTongTien.ResetText();
            txtThue.ResetText();
            txtGiamGia.ResetText();
            txtTienHang.ResetText();

            txtMaHoaDon.Text = dbHoaDon.SetNewPrimaryKey();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinHoaDon.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            cmMaKH.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucHoaDon.CurrentCell.RowIndex;
            string maHoaDon = dgvDanhMucHoaDon.Rows[idx].Cells["MaHoaDon"].Value.ToString();

            if (!dbHoaDon.DeleteHoaDon(maHoaDon))
            {
                MessageBox.Show("Không xóa được dữ liệu");
                return;
            }
            DataLoad();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isInsert = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            cmMaKH.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();
            string maKH = cmMaKH.SelectedValue.ToString();

            DateTime ngayLap = dtpNgayLap.Value;
            string nhanVien = cmNhanVien.SelectedValue.ToString();
            decimal tienHang = 0;
            decimal giamGia = 0;
            decimal thue = 0;
            decimal tongTien = 0;
            try
            {
                tienHang = decimal.Parse(txtTienHang.Text);
                giamGia = decimal.Parse(txtGiamGia.Text);
                thue = decimal.Parse(txtThue.Text);
                tongTien = decimal.Parse(txtTongTien.Text);
            }
            catch { }

            if (isInsert == true)
            {
                if (!dbHoaDon.InsertHoaDon(maHoaDon, maKH, ngayLap, tienHang, giamGia, thue, tongTien, nhanVien))
                {
                    MessageBox.Show("Thêm dữ liệu không thành công");
                    cmMaKH.Focus();
                    return;
                }
                else
                    isInsert = false;
            }
            else
            {
                if (!dbHoaDon.UpdateHoaDon(maHoaDon, maKH, ngayLap, tienHang, giamGia, thue, tongTien, nhanVien))
                {
                    MessageBox.Show("Cập nhật dữ liệu không thành công");
                    cmMaKH.Focus();
                    return;
                }
            }

            DataLoad();
            SetSelectedRow(maHoaDon);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;
         
            dgvDanhMucHoaDon.DataSource = dbHoaDon.Fillter(colName,strFilter);
            foreach (DataGridViewRow row in dgvDanhMucHoaDon.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucHoaDon.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            DataBind();
        }

        private void dgvDanhMucHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }
    }
}
