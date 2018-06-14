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
using DAL;

namespace QuanLyBanHoa.View
{
    public partial class frmQLDanhMucCTHoaDon : Form
    {
        private static frmQLDanhMucCTHoaDon _instance;

        DBChiTietHoaDon dbCTHoaDon;
        bool isInsert = false;

        public static frmQLDanhMucCTHoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmQLDanhMucCTHoaDon();
                return _instance;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _instance = null;
        }
        public frmQLDanhMucCTHoaDon()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucCTHoaDon_Load(object sender, EventArgs e)
        {
            grThongTinChiTietHoaDon.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }

        public void DataLoad()
        {
            dbCTHoaDon = new DBChiTietHoaDon();
            dgvDanhMucCTHoaDon.DataSource = dbCTHoaDon.GetAllCTHoaDon();
            dgvDanhMucCTHoaDon.Columns["HoaDon"].Visible = false;
            dgvDanhMucCTHoaDon.Columns["SanPham"].Visible = false;
            foreach (DataGridViewRow row in dgvDanhMucCTHoaDon.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucCTHoaDon.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            if (dgvDanhMucCTHoaDon.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            cmMaHoaDon.DataSource = new DBHoaDon().GetAllHoaDon();
            cmMaHoaDon.DisplayMember = "MaHoaDon";
            cmMaHoaDon.ValueMember = "MaHoaDon";

            cmMaSP.DataSource = new DBSanPham().GetAllProduct();
            cmMaSP.DisplayMember = "MaSP";
            cmMaSP.ValueMember = "MaSP";

            DataBind();
        }

        private void DataBind()
        {
            int idx = dgvDanhMucCTHoaDon.CurrentCell.RowIndex;
            cmMaHoaDon.Text = dgvDanhMucCTHoaDon.Rows[idx].Cells["MaHoaDon"].Value.ToString();
            cmMaSP.Text = dgvDanhMucCTHoaDon.Rows[idx].Cells["MaSP"].Value.ToString();
            txtSoLuong.Text = dgvDanhMucCTHoaDon.Rows[idx].Cells["SoLuong"].Value.ToString();
            txtChietKhau.Text = dgvDanhMucCTHoaDon.Rows[idx].Cells["ChietKhau"].Value.ToString();
            txtDonGia.Text = dgvDanhMucCTHoaDon.Rows[idx].Cells["DonGia"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;
            grThongTinChiTietHoaDon.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            cmMaHoaDon.ResetText();
            cmMaSP.ResetText();
            txtSoLuong.Text = "1";
            txtChietKhau.Text = "0";
            cmMaHoaDon.Enabled = true;
            cmMaSP.Enabled = true;
        }

        private void SetSelectedRow(string maHD, string maSP)
        {
            foreach (DataGridViewRow row in dgvDanhMucCTHoaDon.Rows)
            {
                if (row.Cells["MaHoaDon"].Value.ToString() == maHD && row.Cells["MaSP"].Value.ToString() == maSP)
                {
                    row.Selected = true;
                    dgvDanhMucCTHoaDon.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmMaHoaDon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trường mã hóa đơn không được trống.");
                return;
            }
            if (cmMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trường mã sản phẩm không được trống.");
                return;
            }
            string err = "";
            string maHD = cmMaHoaDon.Text.Trim();
            string maSP = cmMaSP.Text.Trim();
            int soLuong = txtSoLuong.Text.Trim() == "" ? 0 : int.Parse(txtSoLuong.Text.Trim());  // so luong can them hoac sua
            decimal donGia = txtDonGia.Text.Trim() == "" ? 0 : decimal.Parse(txtDonGia.Text.Trim());
            int ck = txtChietKhau.Text.Trim() == "" ? 0 : int.Parse(txtChietKhau.Text.Trim());

            if (isInsert == true)
            {
                if (!dbCTHoaDon.InsertCTHoaDon(ref err, maHD, maSP, soLuong, donGia, ck))
                {
                    MessageBox.Show("Thêm dữ liệu không thành công\n" + err);
                    cmMaHoaDon.Focus();
                    return;
                }
                else isInsert = false;
            }
            else
            {
                if (!dbCTHoaDon.UpdateCTHoaDon(maHD, maSP, soLuong, donGia, ck))
                {
                    MessageBox.Show("Cập nhật dữ liệu không thành công");
                    cmMaHoaDon.Focus();
                    return;
                }
            }
            DataLoad();
            SetSelectedRow(maHD, maSP);
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            cmMaHoaDon.Enabled = false;
            cmMaSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chi chi tiết hóa đơn hiện tại không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucCTHoaDon.CurrentCell.RowIndex;
            string maHD = dgvDanhMucCTHoaDon.Rows[idx].Cells["MaHoaDon"].Value.ToString();
            string maSP = dgvDanhMucCTHoaDon.Rows[idx].Cells["MaSP"].Value.ToString();

            dbCTHoaDon.DeleteCTHoaDon(maHD, maSP);
            DataLoad();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinChiTietHoaDon.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtSoLuong.Focus();
            cmMaHoaDon.Enabled = false;
            cmMaSP.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cmMaHoaDon.ResetText();
            cmMaSP.ResetText();
            txtSoLuong.ResetText();
            txtChietKhau.ResetText();
            txtDonGia.ResetText();

            isInsert = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            cmMaHoaDon.Enabled = false;
            cmMaSP.Enabled = false;

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }
        private decimal LamTronSoTien(decimal soTien)
        {
            if (soTien == 0)
                return 0;

            int p = int.Parse(soTien.ToString().Substring(soTien.ToString().Length - 3));

            if (p < 250)
                return (decimal)((int)(soTien / 1000) * 1000);
            else if (p >= 250 && p < 750)
                return (decimal)((int)(soTien / 1000) * 1000 + 500);
            else
                return (decimal)((int)(soTien / 1000) * 1000 + 1000);
        }
        decimal giaBan = 0;
        private void cmMaSP_TextChanged(object sender, EventArgs e)
        {
            foreach (SanPham sp in new QuanLyBanHoaEntities().SanPham)
            {
                if (sp.MaSP == cmMaSP.Text.ToString())
                {
                    giaBan = (decimal)sp.GiaBan;
                    txtDonGia.Text = giaBan.ToString();
                    break;
                }
            }
        }

        private void txtChietKhau_KeyUp(object sender, KeyEventArgs e)
        {
            int ck = 0;
            try
            {
                ck = int.Parse(txtChietKhau.Text);
            }
            catch { }
            decimal currDonGia = giaBan * int.Parse(txtSoLuong.Text);
            decimal donGia = currDonGia - LamTronSoTien(currDonGia * ck / 100);
            txtDonGia.Text = donGia.ToString();
        }

        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            int soLuong = 0;
            try
            {
                soLuong = int.Parse(txtSoLuong.Text.ToString());
            }
            catch { }
            txtDonGia.Text = (giaBan * soLuong).ToString();
        }

        private void dgvDanhMucCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }
    }
}
