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
    public partial class frmQLDanhMucCTNhapHang : Form
    {
        DBChiTietNhapHang dbCTNhapHang;
        DataTable dtCTNhapHang;
       
        bool isInsert = false;
        public frmQLDanhMucCTNhapHang()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucCTNhapHang_Load(object sender, EventArgs e)
        {
            grThongTinChiTietNhapHang.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        public void DataLoad()
        {
            dbCTNhapHang = new DBChiTietNhapHang();
            dtCTNhapHang = new DataTable();
            dtCTNhapHang = dbCTNhapHang.GetAllChiTietNhapHang().Tables[0];

            dgvDanhMucCTNhapHang.DataSource = dtCTNhapHang;

            foreach (DataGridViewRow row in dgvDanhMucCTNhapHang.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTNhapHang.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            DBSanPham dbSanPham;
            DataSet dsSanPham;
            dbSanPham = new DBSanPham();
            dsSanPham = new DataSet();
            dsSanPham = dbSanPham.GetGiaBan();

            DBHopDong dbHopDong = new DBHopDong();
            DataSet dsHopDong = new DataSet();

            dsHopDong = dbHopDong.GetSoHopDong();
            cmSoHopDong.DataSource = dsHopDong.Tables[0];
            cmSoHopDong.DisplayMember = "SoHopDong";
            cmSoHopDong.ValueMember = "SoHopDong";
            cmMaSP.DataSource = dsSanPham.Tables[0];
            cmMaSP.DisplayMember = "MaSP";
            cmMaSP.ValueMember = "MaSP";

            txtMaNhapHang.DataBindings.Clear();
            cmSoHopDong.DataBindings.Clear();
            cmMaSP.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            dtpNgayNhapHang.DataBindings.Clear();

            txtMaNhapHang.DataBindings.Add("Text", dtCTNhapHang, "MaNhapHang");
            cmSoHopDong.DataBindings.Add("Text", dtCTNhapHang, "SoHopDong");
            cmMaSP.DataBindings.Add("Text", dtCTNhapHang, "MaSP");
            txtSoLuong.DataBindings.Add("Text", dtCTNhapHang, "SoLuong");
            dtpNgayNhapHang.DataBindings.Add("Text", dtCTNhapHang, "NgayNhapHang");

            if (dgvDanhMucCTNhapHang.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            string[] strs = new string[dtCTNhapHang.Columns.Count];
            int idx = 0;
            foreach (DataColumn col in dtCTNhapHang.Columns)
            {
                strs[idx++] += col.ColumnName;
            }
            cmCotTimKiem.DataSource = strs;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;
            grThongTinChiTietNhapHang.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtSoLuong.Text = "1";

            int maNhapHang = 0;
            try
            {
                maNhapHang = int.Parse(dtCTNhapHang.Rows[dtCTNhapHang.Rows.Count - 1]["MaNhapHang"].ToString());
            }
            catch { }
            if (maNhapHang == 0)
                txtMaNhapHang.Text = "01";
            else
                txtMaNhapHang.Text = (maNhapHang + 1) < 10 ? "0" + (maNhapHang + 1).ToString() : (maNhapHang + 1).ToString();
        }

        private void SetSelectedRow(string maNhapHang)
        {
            foreach (DataGridViewRow row in dgvDanhMucCTNhapHang.Rows)
            {
                if (row.Cells["MaNhapHang"].Value.ToString() == maNhapHang)
                {
                    row.Selected = true;
                    dgvDanhMucCTNhapHang.CurrentCell = row.Cells[0];
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

            string maNhapHang = txtMaNhapHang.Text.Trim();
            string soHopDong = cmSoHopDong.Text.Trim();
            string maSP = cmMaSP.Text.Trim();
            int soLuong = txtSoLuong.Text.Trim() == "" ? 0 : int.Parse(txtSoLuong.Text.Trim());
            DateTime ngayNhapHang = dtpNgayNhapHang.Value;

            string err = "";
            if (isInsert == true)
            {
                dbCTNhapHang.InsertCTNhapHang(ref err, maNhapHang, soHopDong, maSP, soLuong, ngayNhapHang);
                if (err != "")
                {
                    MessageBox.Show("Không thêm được dữ liệu\n"+err, "Lỗi");
                    return;
                }
                else isInsert = false;
            }
            else
            {
                dbCTNhapHang.UpdateCTNhapHang(ref err, maNhapHang, soHopDong, maSP, soLuong, ngayNhapHang);
                if (err != "")
                {
                    MessageBox.Show("Không cập nhật được dữ liệu\n"+err, "Lỗi");
                    return;
                }
            }

            if (err == "")
            {
                DataLoad();
                SetSelectedRow(maNhapHang);
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chi chi tiết nhập hàng hiện tại không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucCTNhapHang.CurrentCell.RowIndex;
            string maNhapHang = dgvDanhMucCTNhapHang.Rows[idx].Cells["MaNhapHang"].Value.ToString();

            string err = "";
            dbCTNhapHang.DeleteCTNhapHang(ref err, maNhapHang);
            if (err != "")
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Lỗi");
                return;
            }
            DataLoad();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinChiTietNhapHang.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtSoLuong.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isInsert = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            grThongTinChiTietNhapHang.Enabled = false;

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void txtGiaTriTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = new DataView(dtCTNhapHang);

            string strFilter = txtGiaTriTimKiem.Text.Trim();

            foreach (DataColumn col in dtCTNhapHang.Columns)
            {
                if (cmCotTimKiem.Text == col.ColumnName)
                {
                    dv.RowFilter = $"{col.ColumnName} LIKE '%{strFilter}%'";
                }
            }

            dgvDanhMucCTNhapHang.DataSource = dv;
            foreach (DataGridViewRow row in dgvDanhMucCTNhapHang.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTNhapHang.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
