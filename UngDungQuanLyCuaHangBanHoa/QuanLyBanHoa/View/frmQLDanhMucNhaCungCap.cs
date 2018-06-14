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
    public partial class frmQLDanhMucNhaCungCap : Form
    {
        DBNhaCungCap dbNCC;
        bool isInsert = false;
        public frmQLDanhMucNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
            grThongTinNCC.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        private void SetSelectedRow(string maNCC)
        {
            foreach (DataGridViewRow row in dgvDanhMucNCC.Rows)
            {
                if (row.Cells["MaNCC"].Value.ToString() == maNCC)
                {
                    row.Selected = true;
                    dgvDanhMucNCC.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void DataLoad()
        {
            dbNCC = new DBNhaCungCap();
            dgvDanhMucNCC.DataSource = dbNCC.GetAllNhaCC();
            dgvDanhMucNCC.Columns["HopDong"].Visible = false;
            foreach (DataGridViewRow row in dgvDanhMucNCC.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNCC.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmCotTimKiem.DataSource = new string[] {"MaNCC", "TenNCC", "DiaChi","SDT"};
            DataBind();
        }

        private void DataBind()
        {
            int idx = dgvDanhMucNCC.CurrentCell.RowIndex;
            txtMaNCC.Text = dgvDanhMucNCC.Rows[idx].Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dgvDanhMucNCC.Rows[idx].Cells["TenNCC"].Value.ToString();
            try
            {
                txtDiaChi.Text = dgvDanhMucNCC.Rows[idx].Cells["DiaChi"].Value.ToString();
            }
            catch { txtDiaChi.Text = ""; }
            try
            {
                txtSDT.Text = dgvDanhMucNCC.Rows[idx].Cells["SDT"].Value.ToString();
            }
            catch { txtSDT.Text = ""; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;

            txtTenNCC.ResetText();
            txtMaNCC.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();

            grThongTinNCC.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
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
            grThongTinNCC.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtMaNCC.Enabled = false;
            txtTenNCC.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucNCC.CurrentCell.RowIndex;
            string maNCC = dgvDanhMucNCC.Rows[idx].Cells["MaNCC"].Value.ToString();

            dbNCC.DeleteNhaCC(maNCC);
            DataLoad();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isInsert = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            txtMaNCC.Enabled = true;
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();

            if (isInsert == true)
            {
               if(!dbNCC.InsertNhaCC(maNCC, txtTenNCC.Text.Trim(),
                       txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
                {
                    MessageBox.Show("Không thêm được dữ liệu.n", "Lỗi");
                    txtMaNCC.Focus();
                    return;
                }
                else
                    isInsert = false;
            }
            else
            {
               if(!dbNCC.UpdateNhaCC( maNCC, txtTenNCC.Text.Trim(),
                      txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
                {
                    MessageBox.Show("Không cập nhật được dữ liệu.", "Lỗi");
                    txtTenNCC.Focus();
                    return;
                }
            }
            DataLoad();
            SetSelectedRow(maNCC);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = true;
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;

            dgvDanhMucNCC.DataSource = dbNCC.Fillter(colName,strFilter);
            foreach (DataGridViewRow row in dgvDanhMucNCC.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucNCC.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void dgvDanhMucNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }
    }
}
