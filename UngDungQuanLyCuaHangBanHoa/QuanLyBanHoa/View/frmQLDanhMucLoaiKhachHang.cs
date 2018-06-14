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
    public partial class frmQLDanhMucLoaiKhachHang : Form
    {
        DBLoaiKhachHang dbLoaiKH;
        bool isInsert = false;
        public frmQLDanhMucLoaiKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucLoaiKhachHang_Load(object sender, EventArgs e)
        {
            grThongTinLoaiKH.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        private void SetSelectedRow(string maLoaiKH)
        {
            foreach (DataGridViewRow row in dgvDanhMucLoaiKH.Rows)
            {
                if (row.Cells["MaLoaiKH"].Value.ToString() == maLoaiKH)
                {
                    row.Selected = true;
                    dgvDanhMucLoaiKH.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void DataLoad()
        {
            dbLoaiKH = new DBLoaiKhachHang();
            dgvDanhMucLoaiKH.DataSource = dbLoaiKH.GetAllLoaiKH();
            dgvDanhMucLoaiKH.Columns["KhachHang"].Visible = false;
            foreach (DataGridViewRow row in dgvDanhMucLoaiKH.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucLoaiKH.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] { "MaLoaiKH", "TenLoaiKH", "ChietKhau" };
            DataBind();
        }

        private void DataBind()
        {
            int idx = dgvDanhMucLoaiKH.CurrentCell.RowIndex;
            txtMaLoaiKH.Text = dgvDanhMucLoaiKH.Rows[idx].Cells["MaLoaiKH"].Value.ToString();
            txtTenLoaiKH.Text = dgvDanhMucLoaiKH.Rows[idx].Cells["TenLoaiKH"].Value.ToString();
            txtChietKhau.Text = dgvDanhMucLoaiKH.Rows[idx].Cells["ChietKhau"].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;

            txtMaLoaiKH.ResetText();
            txtTenLoaiKH.ResetText();
            txtChietKhau.ResetText();

            grThongTinLoaiKH.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtMaLoaiKH.Text = dbLoaiKH.SetNewPrimaryKey();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinLoaiKH.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtMaLoaiKH.Enabled = false;
            txtTenLoaiKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucLoaiKH.CurrentCell.RowIndex;
            string maLoaiKH = dgvDanhMucLoaiKH.Rows[idx].Cells["MaLoaiKH"].Value.ToString();

            if (!dbLoaiKH.DeleteLoaiKH(maLoaiKH))
            {
                MessageBox.Show("Xóa loại khách hàng không thành công");
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

            txtMaLoaiKH.Enabled = true;
            txtMaLoaiKH.ResetText();
            txtTenLoaiKH.ResetText();
            txtChietKhau.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLoaiKH = txtMaLoaiKH.Text.Trim();
            if (isInsert == true)
            {
                if (!dbLoaiKH.InsertLoaiKH(maLoaiKH, txtTenLoaiKH.Text.Trim(),
                       int.Parse(txtChietKhau.Text.Trim())))
                {
                    MessageBox.Show("Không thêm được dữ liệu");
                    txtMaLoaiKH.Focus();
                    return;
                }
                else
                    isInsert = false;
            }
            else
            {
                if (!dbLoaiKH.UpdateLoaiKH(maLoaiKH, txtTenLoaiKH.Text.Trim(),
                         int.Parse(txtChietKhau.Text.Trim())))
                {
                    MessageBox.Show("Không thêm được dữ liệu");
                    txtMaLoaiKH.Focus();
                    return;
                }
            }
            DataLoad();
            SetSelectedRow(maLoaiKH);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;
            dgvDanhMucLoaiKH.DataSource = dbLoaiKH.Fillter(colName,strFilter);
            foreach (DataGridViewRow row in dgvDanhMucLoaiKH.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucLoaiKH.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void dgvDanhMucLoaiKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }
    }
}
