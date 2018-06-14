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
    public partial class frmQLDanhMucSanPham : Form
    {
        bool isInsert = false;
        DBSanPham dbSanPham;

        public frmQLDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucSanPham_Load(object sender, EventArgs e)
        {
            grThongTinSanPham.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        private void SetSelectedRow(string maSP)
        {
            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSP)
                {
                    row.Selected = true;
                    dgvDanhMucSanPham.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void DataLoad()
        {
            dbSanPham = new DBSanPham();
            dgvDanhMucSanPham.DataSource = dbSanPham.GetAllProduct();
            dgvDanhMucSanPham.Columns["ChiTietHoaDon"].Visible = false;
            dgvDanhMucSanPham.Columns["ChiTietHopDong"].Visible = false;
            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmDonViTinh.DataSource = new string[] { "Bông", "Chậu", "Cành" };

            cmCotTimKiem.DataSource = new string[] { "TenSP", "MaSP", "DonViTinh", "SoLuong", "GiaBan", "GiaMua" };

            DataBind();
        }
        private void DataBind()
        {
            int idx = dgvDanhMucSanPham.CurrentCell.RowIndex;
            txtMaSP.Text = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvDanhMucSanPham.Rows[idx].Cells["TenSP"].Value.ToString();
            txtGiaMua.Text = dgvDanhMucSanPham.Rows[idx].Cells["GiaMua"].Value.ToString();
            txtGiaBan.Text = dgvDanhMucSanPham.Rows[idx].Cells["GiaBan"].Value.ToString();
            cmDonViTinh.Text = dgvDanhMucSanPham.Rows[idx].Cells["DonViTinh"].Value.ToString();
            nudSoLuong.Text = dgvDanhMucSanPham.Rows[idx].Cells["SoLuong"].Value.ToString();
        }

        private void dgvDanhMucSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;
            txtMaSP.Text = dbSanPham.SetNewPrimaryKey();
            txtTenSP.ResetText();
            txtGiaMua.ResetText();
            txtGiaBan.ResetText();
            nudSoLuong.Value = 0;

            grThongTinSanPham.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinSanPham.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtMaSP.Enabled = false;
            txtTenSP.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucSanPham.CurrentCell.RowIndex;
            string maSP = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();

            if (!dbSanPham.DeleteProduct(maSP))
            {
                MessageBox.Show("Không xóa được sản phẩm");
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

            txtMaSP.Enabled = true;
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtGiaMua.ResetText();
            txtGiaBan.ResetText();
            nudSoLuong.Value = 0;
            cmDonViTinh.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string dvt = cmDonViTinh.SelectedValue.ToString();
            int soLuong;
            decimal giaMua, giaBan;
            try
            {
                soLuong = (int)nudSoLuong.Value;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số");
                nudSoLuong.Focus();
                return;
            }
            try
            {
                giaMua = decimal.Parse(txtGiaMua.Text.Trim());
                giaBan = decimal.Parse(txtGiaBan.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số");
                txtGiaMua.Focus();
                return;
            }

            if (isInsert == true)
            {
                if (!dbSanPham.InsertProduct(maSP, tenSP, soLuong, giaMua, giaBan, dvt))
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");
                    txtTenSP.Focus();
                    return;
                }
                else isInsert = false;
            }
            else
            {
                if (!dbSanPham.UpdateProduct(maSP, tenSP, soLuong, giaMua, giaBan, dvt))
                {
                    MessageBox.Show("Cập nhật sản phẩm không thành công");
                    txtTenSP.Focus();
                    return;
                }
            }

            DataLoad();
            SetSelectedRow(maSP);
            DataBind();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSP.Enabled = true;
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;

            dgvDanhMucSanPham.DataSource = dbSanPham.Fillter(colName, strFilter);
            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
