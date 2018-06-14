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
    public partial class frmQLDanhMucHopDong : Form
    {
        DBHopDong dbHopDong;
        bool isInsert = false;
        public frmQLDanhMucHopDong()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucHopDong_Load(object sender, EventArgs e)
        {
            grThongTinHopDong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        private void SetSelectedRow(string soHopDong)
        {
            foreach (DataGridViewRow row in dgvDanhMucHopDong.Rows)
            {
                if (row.Cells["SoHopDong"].Value.ToString() == soHopDong)
                {
                    row.Selected = true;
                    dgvDanhMucHopDong.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void DataLoad()
        {
            dbHopDong = new DBHopDong();
            dgvDanhMucHopDong.DataSource = dbHopDong.GetAllHopDong();
            dgvDanhMucHopDong.Columns["NhaCungCap"].Visible = false;
            dgvDanhMucHopDong.Columns["ChiTietHopDong"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmMaNCC.DataSource = new DBNhaCungCap().GetAllNhaCC();
            cmMaNCC.DisplayMember = "MaNCC";
            cmMaNCC.ValueMember = "MaNCC";

            cmCotTimKiem.DataSource = new string[] { "SoHopDong", "MaNCC", "NgayKy", "ThoiHanHopDong" };
            DataBind();
        }

        private void DataBind()
        {
            int idx = dgvDanhMucHopDong.CurrentCell.RowIndex;
            txtSoHopDong.Text = dgvDanhMucHopDong.Rows[idx].Cells["SoHopDong"].Value.ToString();
            try
            {
                cmMaNCC.Text = dgvDanhMucHopDong.Rows[idx].Cells["MaNCC"].Value.ToString();
            }
            catch { cmMaNCC.Text = ""; }
            try
            {
                dtpThoiHanHopDong.Text = dgvDanhMucHopDong.Rows[idx].Cells["ThoiHanHopDong"].Value.ToString();
            }
            catch { dtpThoiHanHopDong.Text = null; }
            try
            {
                dtpNgayKy.Text = dgvDanhMucHopDong.Rows[idx].Cells["NgayKy"].Value.ToString();
            }
            catch { dtpNgayKy.Text = ""; }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;

            cmMaNCC.Focus();
            txtSoHopDong.Enabled = false;
            grThongTinHopDong.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtSoHopDong.Text = dbHopDong.SetNewPrimaryKey();
            cmMaNCC.ResetText();
            dtpNgayKy.ResetText();
            dtpThoiHanHopDong.ResetText();
            this.ActiveControl = cmMaNCC;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinHopDong.Enabled = true;
            cmMaNCC.Focus();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtSoHopDong.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hợp đồng đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucHopDong.CurrentCell.RowIndex;
            string soHopDong = dgvDanhMucHopDong.Rows[idx].Cells["SoHopDong"].Value.ToString();

            dbHopDong.DeleteHopDong(soHopDong);
            DataLoad();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isInsert = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string soHopDong = txtSoHopDong.Text.Trim();
            if (isInsert == true)
            {
                if (!dbHopDong.InsertHopDong(soHopDong, cmMaNCC.SelectedValue.ToString(), dtpNgayKy.Value, dtpThoiHanHopDong.Value))
                {
                    MessageBox.Show("Không thêm được dữ liệu", "Lỗi");
                    return;
                }
                else
                    isInsert = false;
            }
            else
            {
                if (!dbHopDong.UpdateHopDong(soHopDong, cmMaNCC.SelectedValue.ToString(), dtpNgayKy.Value, dtpThoiHanHopDong.Value))
                {
                    MessageBox.Show("Không cập nhật được dữ liệu", "Lỗi");
                    return;
                }
            }
            DataLoad();
            SetSelectedRow(soHopDong);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtGiaTriTimKiem.Text.Trim();
            string colName = cmCotTimKiem.Text;

            dgvDanhMucHopDong.DataSource = dbHopDong.Fillter(colName,strFilter);
            foreach (DataGridViewRow row in dgvDanhMucHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void dgvDanhMucHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }
    }
}
