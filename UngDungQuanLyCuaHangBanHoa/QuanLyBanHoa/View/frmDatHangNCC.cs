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
    public partial class frmDatHangNCC : Form
    {
        static frmDatHangNCC _instance;

        DBSanPham dbSanPham;
        DBHopDong dbHopDong;
        DBNhaCungCap dbNCC;

        DataTable dtCurrCTHopDong;
        public frmDatHangNCC()
        {
            InitializeComponent();
        }

        public static frmDatHangNCC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmDatHangNCC();
                return _instance;
            }
        }

        public DataTable DtCurrCTHopDong
        {
            get
            {
                return dtCurrCTHopDong;
            }

            set
            {
                dtCurrCTHopDong = value;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _instance = null;
        }

        private void frmDatHangNCC_Load(object sender, EventArgs e)
        {
            DataLoad();
            toolStrip2.Location = new Point(521, 145);
        }
        private void SetMaHopDong()
        {
            dbHopDong = new DBHopDong();
            txtSoPhieu.Text = dbHopDong.SetNewPrimaryKey();
        }
        public void DataLoad()
        {
            dbSanPham = new DBSanPham();
            dbNCC = new DBNhaCungCap();
            dbHopDong = new DBHopDong();

            BuidHopDong();
            SetMaHopDong();

            dgvDanhMucSanPham.DataSource = dbSanPham.GetAllProduct();
            dgvDanhMucSanPham.Columns["ChiTietHoaDon"].Visible = false;
            dgvDanhMucSanPham.Columns["ChiTietHopDong"].Visible = false;
            dgvDanhMucSanPham.Columns["GiaBan"].Visible = false;

            // Tạo số thứ tự đầu dòng của dgvDanhMucSanPham và tự auto size 
            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            var numbers = from n in Enumerable.Range(1, 20)
                          select n;

            cmSoLuong.DataSource = numbers.ToList();

            cmNhaCC.DataSource = dbNCC.GetAllNhaCC();
            cmNhaCC.DisplayMember = "TenNCC";
            cmNhaCC.ValueMember = "MaNCC";
            cmNhaCC.Text = "";
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";

            btnGiamSP.Enabled = false;
            btnXoaSP.Enabled = false;
            btnThanhToan.Enabled = false;
            toolStrip2.Enabled = false;
        }

        private void cmNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = cmNhaCC.SelectedValue.ToString();
            txtTenNCC.Text = cmNhaCC.Text;
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            (new frmThem_EditSanPham()).ThemSanPham();
            DataLoad();
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            int idx = dgvDanhMucSanPham.CurrentCell.RowIndex;

            string maSP = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();
            string tenSP = dgvDanhMucSanPham.Rows[idx].Cells["TenSP"].Value.ToString();
            string soLuong = dgvDanhMucSanPham.Rows[idx].Cells["SoLuong"].Value.ToString();
            string giaMua = dgvDanhMucSanPham.Rows[idx].Cells["GiaMua"].Value.ToString();
            string giaBan = dgvDanhMucSanPham.Rows[idx].Cells["GiaBan"].Value.ToString();
            string dvt = dgvDanhMucSanPham.Rows[idx].Cells["DonViTinh"].Value.ToString();

            (new frmThem_EditSanPham()).SuaSanPham(maSP, tenSP, soLuong, giaMua, giaBan, dvt);
            DataLoad();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            int idx = dgvDanhMucSanPham.CurrentCell.RowIndex;
            string maSP = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();

            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!dbSanPham.DeleteProduct(maSP))
                    MessageBox.Show("Xóa sản phẩm không thành công");
                DataLoad();
            }

        }
        public void RefreshDgvDanhMucSanPham(string maSP)
        {
            dbSanPham = new DBSanPham();
            dgvDanhMucSanPham.DataSource = dbSanPham.GetAllProduct();
            dgvDanhMucSanPham.Columns["GiaMua"].Visible = false;
            dgvDanhMucSanPham.Columns["ChiTietHoaDons"].Visible = false;
            dgvDanhMucSanPham.Columns["ChiTietHopDongs"].Visible = false;

            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSP)
                {
                    row.Selected = true;
                    dgvDanhMucSanPham.CurrentCell = dgvDanhMucSanPham.Rows[row.Index].Cells[0];
                    break;
                }
            }
        }
        private void btnRefreshSanPham_Click(object sender, EventArgs e)
        {
            txtFilter.ResetText();
            DataLoad();
        }

        private void txtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            string strFilter = txtFilter.Text.Trim();

            dgvDanhMucSanPham.DataSource = dbSanPham.Fillter("TenSP", strFilter);
            foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        public void BuidHopDong()
        {
            DtCurrCTHopDong = new DataTable("HoaDonMoi");
            DtCurrCTHopDong.Columns.Add("MaSP", typeof(string));
            DtCurrCTHopDong.Columns.Add("TenSP", typeof(string));
            DtCurrCTHopDong.Columns.Add("DonViTinh", typeof(string));
            DtCurrCTHopDong.Columns.Add("SoLuong", typeof(int));
            DtCurrCTHopDong.Columns.Add("GiaMua", typeof(decimal));
            DtCurrCTHopDong.Columns.Add("ThanhTien", typeof(decimal));
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            toolStrip2.Enabled = true;
            btnGiamSP.Enabled = true;
            btnXoaSP.Enabled = true;
            btnThanhToan.Enabled = true;


            // Xác định sản phẩm cần thêm
            int idx = dgvDanhMucSanPham.CurrentCell.RowIndex;
            string maSP = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();
            DataRow row = DtCurrCTHopDong.NewRow();

            // Kiểm tra xem đã có sản phẩm này trong hóa đơn chưa?
            bool hasProduct = false;
            int proidx = -1;
            foreach (DataGridViewRow r in dgvChiTietHopDong.Rows)
            {
                if (r.Cells["MaSPHD"].Value.ToString() == maSP)
                {
                    hasProduct = true;
                    proidx = r.Index;
                    break;
                }
            }

            int soLuong = int.Parse(cmSoLuong.Text);
            if (hasProduct == false) // Nếu chưa có sản phẩm này trong hóa đơn
            {
                row.BeginEdit();

                row["MaSP"] = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();
                row["TenSP"] = dgvDanhMucSanPham.Rows[idx].Cells["TenSP"].Value.ToString();
                row["DonViTinh"] = dgvDanhMucSanPham.Rows[idx].Cells["DonViTinh"].Value.ToString();
                row["GiaMua"] = dgvDanhMucSanPham.Rows[idx].Cells["GiaMua"].Value.ToString();
                row["SoLuong"] = soLuong;

                decimal thanhTien = soLuong * decimal.Parse(dgvDanhMucSanPham.Rows[idx].Cells["GiaMua"].Value.ToString());
                row["ThanhTien"] = thanhTien;
                row.EndEdit();

                DtCurrCTHopDong.Rows.Add(row);
            }
            else // nếu đã tồn tại rồi
            {
                foreach (DataRow r in DtCurrCTHopDong.Rows)
                {
                    if (r["maSP"].ToString() == maSP)
                        row = r;
                }
                row.BeginEdit();

                soLuong += int.Parse(dgvChiTietHopDong.Rows[proidx].Cells["SoLuongHD"].Value.ToString());

                row["SoLuong"] = soLuong;

                decimal thanhTien = soLuong * decimal.Parse(dgvChiTietHopDong.Rows[proidx].Cells["GiaMuaHD"].Value.ToString());
                row["ThanhTien"] = thanhTien;

                row.EndEdit();
            }

            DtCurrCTHopDong.AcceptChanges();

            RefreshDgvChiTietHopDong(maSP);
            cmSoLuong.Text = "1";
        }

        public void RefreshDgvChiTietHopDong(string maSP)
        {
            DgvChiTietHopDong_LoadData();

            foreach (DataGridViewRow row in dgvChiTietHopDong.Rows)
            {
                if (row.Cells["MaSPHD"].Value.ToString() == maSP)
                {
                    row.Selected = true;
                    dgvChiTietHopDong.CurrentCell = dgvChiTietHopDong.Rows[row.Index].Cells[0];
                    break;
                }
            }
        }
        public void DgvChiTietHopDong_LoadData()
        {
            dgvChiTietHopDong.DataSource = DtCurrCTHopDong;

            // Tạo số thứ tự đầu dòng của dgvDanhMucSanPham và tự auto size 
            foreach (DataGridViewRow row in dgvChiTietHopDong.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            TinhTien();
            SetMaHopDong();

            if (dgvChiTietHopDong.Rows.Count == 0)
            {
                btnGiamSP.Enabled = false;
                btnXoaSP.Enabled = false;
                toolStrip2.Enabled = false;
                btnThanhToan.Enabled = false;
            }
        }

        private void TinhTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvChiTietHopDong.Rows)
            {
                tongTien += double.Parse(row.Cells["ThanhTien"].Value.ToString());
            }

            txtTienHang.Text = tongTien.ToString();

            double tienGiamGia = LamTronSoTien(Math.Round(((double)(nudGiamGia.Value) * tongTien) / 100));
            tongTien -= tienGiamGia;
            double tienThue = LamTronSoTien(Math.Round(((double)(nudThue.Value) * tongTien) / 100));
            tongTien += tienThue;

            txtTienGiamGia.Text = tienGiamGia.ToString();
            txtTienThue.Text = tienThue.ToString();
            txtTongTien.Text = tongTien.ToString();
        }
        private double LamTronSoTien(double soTien)
        {
            if (soTien == 0)
                return 0;

            int p = 0;
            try
            {
                p = int.Parse(soTien.ToString().Substring(soTien.ToString().Length - 3));
            }
            catch { }

            if (p < 250)
                return (int)(soTien / 1000) * 1000;
            else if (p >= 250 && p < 750)
                return (int)(soTien / 1000) * 1000 + 500;
            else
                return (int)(soTien / 1000) * 1000 + 1000;
        }

        private void btnGiamSP_Click(object sender, EventArgs e)
        {

            int proidx = dgvChiTietHopDong.CurrentCell.RowIndex;
            string maSP = dgvChiTietHopDong.Rows[proidx].Cells["MaSPHD"].Value.ToString();
            int soLuong = int.Parse(cmSoLuong.Text);
            int currSoLuong = int.Parse(dgvChiTietHopDong.Rows[proidx].Cells["SoLuongHD"].Value.ToString());

            if (currSoLuong - soLuong < 1)
            {
                MessageBox.Show("Không thể giảm " + soLuong + " vì số lượng hiện tại chỉ có " + currSoLuong, "Thông báo");
                return;
            }

            // sửa dữ liệu trong dtcurrHoaDon
            DataRow row = DtCurrCTHopDong.NewRow();
            foreach (DataRow r in DtCurrCTHopDong.Rows)
            {
                if (r["maSP"].ToString() == maSP)
                    row = r;
            }
            row.BeginEdit();

            row["SoLuong"] = currSoLuong - soLuong;

            decimal thanhTien = (currSoLuong - soLuong) * decimal.Parse(dgvChiTietHopDong.Rows[proidx].Cells["GiaMuaHD"].Value.ToString());
            row["ThanhTien"] = thanhTien;

            row.EndEdit();
            DtCurrCTHopDong.AcceptChanges();

            RefreshDgvChiTietHopDong(maSP);

            cmSoLuong.Text = "1";
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mặt hàng đang chọn ra khỏi hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int proidx = dgvChiTietHopDong.CurrentCell.RowIndex;
            string maSP = dgvChiTietHopDong.Rows[proidx].Cells["MaSPHD"].Value.ToString();

            DataRow row = DtCurrCTHopDong.NewRow();
            foreach (DataRow r in DtCurrCTHopDong.Rows)
            {
                if (r["maSP"].ToString() == maSP)
                    row = r;
            }

            DtCurrCTHopDong.Rows.Remove(row);
            DtCurrCTHopDong.AcceptChanges();

            DgvChiTietHopDong_LoadData();
        }

        private void btnTaoDonHangMoi_Click(object sender, EventArgs e)
        {
            TaoDonHangMoi();
        }

        public void TaoDonHangMoi()
        {
            btnXoaSP.Enabled = false;
            btnGiamSP.Enabled = false;
            toolStrip2.Enabled = false;
            btnThanhToan.Enabled = false;

            if (DtCurrCTHopDong.Rows.Count != 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa hết các mặt hàng vừa mới nhập không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                    BuidHopDong();
            }
            else MessageBox.Show("Bạn đang ở trong mục tạo hóa đơn mới", "Thông báo");
            DgvChiTietHopDong_LoadData();
        }

        private void tsBtnThem1_Click(object sender, EventArgs e)
        {
            int proidx = dgvChiTietHopDong.CurrentRow.Index;
            string maSP = dgvChiTietHopDong.Rows[proidx].Cells["MaSPHD"].Value.ToString();

            DataRow row = DtCurrCTHopDong.NewRow();

            foreach (DataRow r in DtCurrCTHopDong.Rows)
            {
                if (r["maSP"].ToString() == maSP)
                    row = r;
            }

            row.BeginEdit();

            int soLuong = int.Parse(dgvChiTietHopDong.Rows[proidx].Cells["SoLuongHD"].Value.ToString()) + 1;

            row["SoLuong"] = soLuong;

            decimal thanhTien = soLuong * decimal.Parse(dgvChiTietHopDong.Rows[proidx].Cells["GiaMuaHD"].Value.ToString());
            row["ThanhTien"] = thanhTien;

            row.EndEdit();

            DtCurrCTHopDong.AcceptChanges();
            RefreshDgvChiTietHopDong(maSP);
        }

        private void tsBtnGiam1_Click(object sender, EventArgs e)
        {
            int proidx = dgvChiTietHopDong.CurrentCell.RowIndex;
            string maSP = dgvChiTietHopDong.Rows[proidx].Cells["MaSPHD"].Value.ToString();
            if (int.Parse(dgvChiTietHopDong.Rows[proidx].Cells["SoLuongHD"].Value.ToString()) == 1)
                return;

            DataRow row = DtCurrCTHopDong.NewRow();

            foreach (DataRow r in DtCurrCTHopDong.Rows)
            {
                if (r["maSP"].ToString() == maSP)
                    row = r;
            }

            row.BeginEdit();

            int soLuong = int.Parse(dgvChiTietHopDong.Rows[proidx].Cells["SoLuongHD"].Value.ToString()) - 1;

            row["SoLuong"] = soLuong;

            decimal thanhTien = soLuong * decimal.Parse(dgvChiTietHopDong.Rows[proidx].Cells["GiaMuaHD"].Value.ToString());
            row["ThanhTien"] = thanhTien;

            row.EndEdit();

            DtCurrCTHopDong.AcceptChanges();
            RefreshDgvChiTietHopDong(maSP);

        }

        private void tsBtnDatSoLuong_Click(object sender, EventArgs e)
        {
            int proidx = dgvChiTietHopDong.CurrentCell.RowIndex;
            string maSP = dgvChiTietHopDong.Rows[proidx].Cells["MaSPHD"].Value.ToString();

            DataRow row = DtCurrCTHopDong.NewRow();

            foreach (DataRow r in DtCurrCTHopDong.Rows)
            {
                if (r["maSP"].ToString() == maSP)
                    row = r;
            }

            (new frmDatSoLuong()).ShowFrmDatSoLuong((int)row["SoLuong"], row, 2, 0);
        }

        private void nudGiamGia_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void nudThue_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            //xác nhận thanh toán
            // Lưu thông tin nhà cc

            if (txtMaNCC.Text.Trim() == "")
            {
                MessageBox.Show("Trường mã nhà cung cấp không được trống");
                return;
            }
            if (txtTenNCC.Text.Trim() == "")
            {
                MessageBox.Show("Trường tên nhà cung cấp không được trống");
                return;
            }

            LuuThongTinNCC();

            // Lưu thông tin hợp đồng
            LuuThongTinHopDong();

            // lưu thông tin chi tiết hợp đồng + tăng số lượng sản phẩm trong kho
            LuuThongTinCTHopDong();

            MessageBox.Show("Thanh toán xong");
            ThanhToan();
        }

        public void ThanhToan()
        {
            cmNhaCC.ResetText();
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            nudGiamGia.Value = 0;

            BuidHopDong();
            DgvChiTietHopDong_LoadData();
            DataLoad();
        }
        private void LuuThongTinHopDong()
        {
            string soHopDong = txtSoPhieu.Text.Trim();
            DateTime ngayKy = dtpNgay.Value;
            DateTime? dt = null;
            dbHopDong.InsertHopDong(soHopDong, txtMaNCC.Text.Trim(), ngayKy, dt);
        }

        private void LuuThongTinNCC()
        {
            //kiểm tra xem đã có ncc này trong db chưa? nếu chưa thì lưu mới
            string maNCC = txtMaNCC.Text.Trim();

            foreach (NhaCungCap ncc in new QuanLyBanHoaEntities().NhaCungCap)
            {
                if (ncc.MaNCC.ToString() == maNCC)
                {
                    return; // nếu có rồi thì thoát
                }
            }

            // ngược lại lưu mới
            string tenNCC = txtTenNCC.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtDienThoai.Text.Trim();

            dbNCC.InsertNhaCC(maNCC, tenNCC, diaChi, sdt);
        }
        private void LuuThongTinCTHopDong()
        {
            DBCTHopDong dbCTHopDong = new DBCTHopDong();

            string soHopDong = txtSoPhieu.Text.Trim();
            string err = "";
            foreach (DataRow row in dtCurrCTHopDong.Rows)
            {
                string maSP = row["MaSP"].ToString();
                int soLuong = int.Parse(row["SoLuong"].ToString());
                decimal donGia = decimal.Parse(row["ThanhTien"].ToString());
                // Lưu thông tin ct hợp đồng
                dbCTHopDong.InsertCTHopDong(ref err, soHopDong, maSP, soLuong, donGia);

                // tăng số lượng sản phẩm với masp ở trên
                dbSanPham.UpdateProductAmount(maSP, soLuong);
            }
        }
    }
}
