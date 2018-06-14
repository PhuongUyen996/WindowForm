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
    public partial class frmQLDanhMucKhachHang : Form
    {
        DBKhachHang dbKH;
        DBLoaiKhachHang dbLoaiKH;
        bool isInsert = false;
        public frmQLDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            grThongTinKhachHang.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            DataLoad();
        }
        public void DataLoad()
        {
            dbKH = new DBKhachHang();
            dbLoaiKH = new DBLoaiKhachHang();

            dgvDanhMucKhachHang.DataSource = dbKH.GetAllCustomer();
            dgvDanhMucKhachHang.Columns["HoaDon"].Visible = false;
            dgvDanhMucKhachHang.Columns["LoaiKH"].Visible = false;


            foreach (DataGridViewRow row in dgvDanhMucKhachHang.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucKhachHang.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            cmMaLoaiKH.DataSource = dbLoaiKH.GetAllLoaiKH(); ;
            cmMaLoaiKH.DisplayMember = "TenLoaiKH";
            cmMaLoaiKH.ValueMember = "MaLoaiKH";

            DataBind();
           
            cmCotTimKiem.DataSource = new string[] {"TenKH","MaKH","DiaChi","SDT","GioiTinh", "NgaySinh","MaLoaiKH"};

            if (dgvDanhMucKhachHang.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
            }
          
        }

        private void DataBind()
        {
            int idx = dgvDanhMucKhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgvDanhMucKhachHang.Rows[idx].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvDanhMucKhachHang.Rows[idx].Cells["TenKH"].Value.ToString();
            try
            {
                cmMaLoaiKH.Text = dgvDanhMucKhachHang.Rows[idx].Cells["MaLoaiKH"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                cmMaLoaiKH.Text = "";
            }
            try
            {
                txtDiaChi.Text = dgvDanhMucKhachHang.Rows[idx].Cells["DiaChi"].Value.ToString();
            }
            catch(NullReferenceException )
            {
                txtDiaChi.Text = "";
            }
            try
            {
                txtSDT.Text = dgvDanhMucKhachHang.Rows[idx].Cells["SDT"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                txtSDT.Text = "";
            }
            try
            {
                dtpNgaySinh.Text = dgvDanhMucKhachHang.Rows[idx].Cells["NgaySinh"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                dtpNgaySinh.Text = "";
            }
            try
            {
                bool isNam = dgvDanhMucKhachHang.Rows[idx].Cells["GioiTinh"].Value.ToString() == "Nam" ? true : false;
                if (isNam == true)
                    rdNam.Checked = true;
                bool isNu = dgvDanhMucKhachHang.Rows[idx].Cells["GioiTinh"].Value.ToString() == "Nữ" ? true : false;
                if (isNu == true)
                    rdNu.Checked = true;
            }
            catch { }
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;

            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtTenKH.ResetText();

            grThongTinKhachHang.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            this.ActiveControl = txtTenKH;

            txtMaKH.Text = dbKH.SetNewPrimaryKey();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grThongTinKhachHang.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            this.ActiveControl = txtTenKH;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString());
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string maLoaiKH = cmMaLoaiKH.SelectedValue.ToString();


            string gioiTinh = "Nữ";
            if (rdNam.Checked == true)
                gioiTinh = "Nam";

            if (isInsert == true)
            {
              if(!dbKH.InsertCustomer(maKH,tenKH,ngaySinh,gioiTinh,diaChi,sdt,maLoaiKH))
                {
                    MessageBox.Show("Thêm khách hàng không thành công");
                    return;
                }
               else isInsert = false;
            }
            else
            {
                if (!dbKH.UpdateCustomer(maKH, tenKH, ngaySinh, gioiTinh, diaChi, sdt, maLoaiKH))
                {
                    MessageBox.Show("Cập nhật khách hàng không thành công");
                    return;
                }
            }

            DataLoad();
            SetSelectedRow(maKH);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isInsert = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idx = dgvDanhMucKhachHang.CurrentCell.RowIndex;
            string maKH = dgvDanhMucKhachHang.Rows[idx].Cells["MaKH"].Value.ToString();

            if (!dbKH.DeleteCustomer(maKH))
            {
                MessageBox.Show("Xóa không thành công -----Lỗi: Khóa ngoại");
                return;
            }

            DataLoad();
        }
        private void SetSelectedRow(string maKH)
        {
            foreach (DataGridViewRow row in dgvDanhMucKhachHang.Rows)
            {
                if (row.Cells["MaKH"].Value.ToString() == maKH)
                {
                    row.Selected = true;
                    dgvDanhMucKhachHang.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void dgvDanhMucKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
              DataLoad();
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
    }
}
