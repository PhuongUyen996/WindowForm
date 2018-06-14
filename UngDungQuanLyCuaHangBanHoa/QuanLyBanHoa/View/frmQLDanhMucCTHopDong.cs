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
    public partial class frmQLDanhMucCTHopDong : Form
    {
        DBCTHopDong dbCTHopDong;
        bool isInsert = false;
        public frmQLDanhMucCTHopDong()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucCTHopDong_Load(object sender, EventArgs e)
        {
            grThongTinChiTietHopDong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        public void DataLoad()
        {
            dbCTHopDong = new DBCTHopDong();
            dgvDanhMucCTHopDong.DataSource = dbCTHopDong.GetAllCTHopDong();
            dgvDanhMucCTHopDong.Columns["HopDong"].Visible = false;
            dgvDanhMucCTHopDong.Columns["SanPham"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucCTHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            if (dgvDanhMucCTHopDong.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            cmSoHopDong.DataSource = new DBHopDong().GetAllHopDong();
            cmSoHopDong.DisplayMember = "SoHopDong";
            cmSoHopDong.ValueMember = "SoHopDong";

            cmMaSP.DataSource = new DBSanPham().GetAllProduct();
            cmMaSP.DisplayMember = "MaSP";
            cmMaSP.ValueMember = "MaSP";

            cmCotTimKiem.DataSource = new string[] { "SoHopDong", "MaSP" };
            DataBind();
        }
        private void DataBind()
        {
            int idx = dgvDanhMucCTHopDong.CurrentCell.RowIndex;
            cmSoHopDong.Text = dgvDanhMucCTHopDong.Rows[idx].Cells["SoHopDong"].Value.ToString();
            cmMaSP.Text = dgvDanhMucCTHopDong.Rows[idx].Cells["MaSP"].Value.ToString();
            try
            {
                txtDonGia.Text = dgvDanhMucCTHopDong.Rows[idx].Cells["DonGia"].Value.ToString();
            }
            catch { txtDonGia.Text = ""; }
            try
            {
                txtSoLuong.Text = dgvDanhMucCTHopDong.Rows[idx].Cells["SoLuong"].Value.ToString();
            }
            catch { txtSoLuong.Text = ""; }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;
            grThongTinChiTietHopDong.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            cmSoHopDong.ResetText();
            cmMaSP.ResetText();
            txtSoLuong.Text = "1";
            cmSoHopDong.Enabled = true;
            cmMaSP.Enabled = true;
        }

        private void SetSelectedRow(string soHopDong, string maSP)
        {
            foreach (DataGridViewRow row in dgvDanhMucCTHopDong.Rows)
            {
                if (row.Cells["SoHopDong"].Value.ToString() == soHopDong && row.Cells["MaSP"].Value.ToString() == maSP)
                {
                    row.Selected = true;
                    dgvDanhMucCTHopDong.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmSoHopDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trường số hợp đồng không được trống.");
                return;
            }
            if (cmMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trường mã sản phẩm không được trống.");
                return;
            }
            string soHopDong = cmSoHopDong.Text.Trim();
            string maSP = cmMaSP.Text.Trim();
            int soLuong = txtSoLuong.Text.Trim() == "" ? 0 : int.Parse(txtSoLuong.Text.Trim());
            decimal donGia = txtDonGia.Text.Trim() == "" ? 0 : decimal.Parse(txtDonGia.Text.Trim());
            string err = "";
            if (isInsert == true)
            {
                if (!dbCTHopDong.InsertCTHopDong(ref err, soHopDong, maSP, soLuong, donGia))
                {
                    MessageBox.Show("Không thêm được dữ liệu\n" + err, "Lỗi");
                    cmSoHopDong.Focus();
                    return;
                }
                else isInsert = false;
            }
            else
            {
                if (!dbCTHopDong.UpdateCTHopDong(soHopDong, maSP, soLuong, donGia))
                {
                    MessageBox.Show("Không cập nhật được dữ liệu", "Lỗi");
                    return;
                }
            }

            DataLoad();
            SetSelectedRow(soHopDong, maSP);
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            cmSoHopDong.Enabled = false;
            cmMaSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chi chi tiết hợp đồng hiện tại không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucCTHopDong.CurrentCell.RowIndex;
            string soHopDong = dgvDanhMucCTHopDong.Rows[idx].Cells["SoHopDong"].Value.ToString();
            string maSP = dgvDanhMucCTHopDong.Rows[idx].Cells["MaSP"].Value.ToString();

            dbCTHopDong.DeleteCTHopDong(soHopDong, maSP);
            DataLoad();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinChiTietHopDong.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtSoLuong.Focus();
            cmSoHopDong.Enabled = false;
            cmMaSP.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cmSoHopDong.ResetText();
            cmMaSP.ResetText();
            txtSoLuong.ResetText();
            txtDonGia.ResetText();

            isInsert = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            cmSoHopDong.Enabled = false;
            cmMaSP.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string colName = cmCotTimKiem.Text;
            string strFilter = txtGiaTriTimKiem.Text.Trim();

            dgvDanhMucCTHopDong.DataSource = dbCTHopDong.Fillter(colName,strFilter);
            foreach (DataGridViewRow row in dgvDanhMucCTHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTHopDong.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void dgvDanhMucCTHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }
    }
}
