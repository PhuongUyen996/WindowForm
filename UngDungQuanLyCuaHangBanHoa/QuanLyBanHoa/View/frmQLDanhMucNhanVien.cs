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
    public partial class frmQLDanhMucNhanVien : Form
    {
        DBNhanVien dbNhanVien;
        bool isInsert = false;
        public frmQLDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            grThongTinNhanVien.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }

        public void DataLoad()
        {
            dbNhanVien = new DBNhanVien();
            dgvDanhMucNhanVien.DataSource = dbNhanVien.GetAllEmployee();

            foreach (DataGridViewRow row in dgvDanhMucNhanVien.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNhanVien.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            DataBind();

            cmCotTimKiem.DataSource = new string[] { "HoTenNV", "MaNV", "DiaChi", "SDT", "GioiTinh", "NgaySinh" };
            if (dgvDanhMucNhanVien.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void DataBind()
        {
            int idx = dgvDanhMucNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvDanhMucNhanVien.Rows[idx].Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dgvDanhMucNhanVien.Rows[idx].Cells["HoTenNV"].Value.ToString();
            try
            {
                txtDiaChi.Text = dgvDanhMucNhanVien.Rows[idx].Cells["DiaChi"].Value.ToString();
            }
            catch { txtDiaChi.Text = ""; }
            try
            {
                txtSDT.Text = dgvDanhMucNhanVien.Rows[idx].Cells["SDT"].Value.ToString();
            }
            catch { txtSDT.Text = ""; }
            try
            {
                txtLuong.Text = dgvDanhMucNhanVien.Rows[idx].Cells["Luong"].Value.ToString();
            }
            catch { txtLuong.Text = ""; }
            try
            {
                dtpNgaySinh.Text = dgvDanhMucNhanVien.Rows[idx].Cells["NgaySinh"].Value.ToString();
            }
            catch { dtpNgaySinh.Text = ""; }

            try
            {
                bool isNam = dgvDanhMucNhanVien.Rows[idx].Cells["GioiTinh"].Value.ToString() == "Nam" ? true : false;
                if (isNam == true)
                    rdNam.Checked = true;
                else rdNu.Checked = true;
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;

            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtTenNV.ResetText();
            txtLuong.ResetText();
            txtTenNV.Focus();

            grThongTinNhanVien.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtTenNV.Focus();

            txtMaNV.Text = dbNhanVien.SetNewPrimaryKey();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinNhanVien.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string hoTenNV = txtTenNV.Text.Trim();
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString());
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            decimal luong = 0;
            try
            {
                luong = decimal.Parse(txtLuong.Text.Trim());
            }
            catch { }
            string gioiTinh = "Nữ";
            if (rdNam.Checked == true)
                gioiTinh = "Nam";

            if (isInsert == true)
            {
                if (!dbNhanVien.InsertEmployee(maNV, hoTenNV,
                    ngaySinh, gioiTinh, diaChi, sdt, luong))
                {
                    MessageBox.Show("Không thêm được dữ liệu!", "Lỗi");
                    txtTenNV.Focus();
                    return;
                }
                else
                    isInsert = false;
            }
            else
            {
                if (!dbNhanVien.UpdateEmployee(maNV, hoTenNV,
                   ngaySinh, gioiTinh, diaChi, sdt, luong))
                {
                    MessageBox.Show("Không cập nhật được dữ liệu!", "Lỗi");
                    txtTenNV.Focus();
                    return;
                }
            }
            DataLoad();
            SetSelectedRow(maNV);
            DataBind();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void SetSelectedRow(string maNV)
        {
            foreach (DataGridViewRow row in dgvDanhMucNhanVien.Rows)
            {
                if (row.Cells["MaNV"].Value.ToString() == maNV)
                {
                    row.Selected = true;
                    dgvDanhMucNhanVien.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void dgvDanhMucNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             DataBind();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string colName = cmCotTimKiem.Text;
            string strFilter = txtGiaTriTimKiem.Text.Trim();

            dgvDanhMucNhanVien.DataSource = dbNhanVien.Fillter(colName,strFilter);
            foreach (DataGridViewRow row in dgvDanhMucNhanVien.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNhanVien.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucNhanVien.CurrentCell.RowIndex;
            string maNV = dgvDanhMucNhanVien.Rows[idx].Cells["MaNV"].Value.ToString();

            if(!dbNhanVien.DeleteEmployee( maNV))
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Lỗi");
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

            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtLuong.ResetText();
        }
    }
}
