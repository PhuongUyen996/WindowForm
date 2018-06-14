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
	public partial class frmHoaDonBanHang : Form
	{
		private static frmHoaDonBanHang _instance;
		DBSanPham dbSanPham;
		DBNhanVien dbNhanVien;
		DBHoaDon dbHoaDon;

		DataTable dtCurrCTHoaDon;
		public frmHoaDonBanHang()
		{
			InitializeComponent();
		}

		public static frmHoaDonBanHang Instance
		{
			get
			{
				if (_instance == null)
					_instance = new frmHoaDonBanHang();
				return _instance;
			}
		}

		public DataTable DtCurrHoaDon
		{
			get
			{
				return dtCurrCTHoaDon;
			}

			set
			{
				dtCurrCTHoaDon = value;
			}
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			_instance = null;
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			string khachHang = txtKhachHang.Text.Trim();
			string nhanVien = cmNhanVien.SelectedValue.ToString();
			string maHoaDon = txtMaHoaDon.Text.Trim();
			DateTime ngayLap = dtpNgay.Value;
			decimal tongTien = decimal.Parse(txtTongTien.Text);
			decimal tienHang = decimal.Parse(txtTienHang.Text);
			decimal giamGia = decimal.Parse(txtTienGiamGia.Text);
			decimal thue = decimal.Parse(txtTienThue.Text);
			(new frmThanhToan()).ShowFrmThanhToan(dtCurrCTHoaDon, maKH, khachHang, nhanVien, maHoaDon, ngayLap,
				tienHang, giamGia, thue, tongTien);
		}

		private void frmHoaDonBanHang_Load(object sender, EventArgs e)
		{
			DataLoad();
			toolStrip2.Location = new Point(516, 57);
		}

		public void DataLoad()
		{
			BuidHoaDonMoi();
			dbSanPham = new DBSanPham();
			dbHoaDon = new DBHoaDon();
			dbNhanVien = new DBNhanVien();

			dgvDanhMucSanPham.DataSource = dbSanPham.GetAllProduct();
			dgvDanhMucSanPham.Columns["GiaMua"].Visible = false;
			dgvDanhMucSanPham.Columns["ChiTietHoaDon"].Visible = false;
			dgvDanhMucSanPham.Columns["ChiTietHopDong"].Visible = false;
			SetMaHoaDon();

			// Tạo số thứ tự đầu dòng của dgvDanhMucSanPham và tự auto size 
			foreach (DataGridViewRow row in dgvDanhMucSanPham.Rows)
			{
				row.HeaderCell.Value = (row.Index + 1).ToString();
			}
			dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

			var numbers = from n in Enumerable.Range(1, 20)
						  select n;
			cmSoLuong.DataSource = numbers.ToList();

			// Đổ dữ liệu lên cmNhanVien
			cmNhanVien.DataSource = dbNhanVien.GetAllEmployee();
			cmNhanVien.DisplayMember = "HoTenNV";
			cmNhanVien.ValueMember = "MaNV";

			btnGiamSP.Enabled = false;
			btnXoaSP.Enabled = false;
			btnThanhToan.Enabled = false;
			toolStrip2.Enabled = false;

		}

		private void SetMaHoaDon()
		{
			dbHoaDon = new DBHoaDon();
			txtMaHoaDon.Text = dbHoaDon.SetNewPrimaryKey();
		}

		public void BuidHoaDonMoi()
		{
			DtCurrHoaDon = new DataTable("HoaDonMoi");
			DtCurrHoaDon.Columns.Add("MaSP", typeof(string));
			DtCurrHoaDon.Columns.Add("TenSP", typeof(string));
			DtCurrHoaDon.Columns.Add("DonViTinh", typeof(string));
			DtCurrHoaDon.Columns.Add("SoLuong", typeof(int));
			DtCurrHoaDon.Columns.Add("GiaBan", typeof(decimal));
			DtCurrHoaDon.Columns.Add("ChietKhau", typeof(int));
			DtCurrHoaDon.Columns.Add("ThanhTien", typeof(decimal));
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
			string donGia = dgvDanhMucSanPham.Rows[idx].Cells["DonGia"].Value.ToString();
			string giaMua = dgvDanhMucSanPham.Rows[idx].Cells["GiaMua"].Value.ToString();
			string dvt = dgvDanhMucSanPham.Rows[idx].Cells["DonViTinh"].Value.ToString();

			(new frmThem_EditSanPham()).SuaSanPham(maSP, tenSP, soLuong, giaMua, donGia, dvt);
			DataLoad();
		}

		public void RefreshDgvDanhMucSanPham(string maSP)
		{
			dbSanPham = new DBSanPham();
			dgvDanhMucSanPham.DataSource = dbSanPham.GetAllProduct();
			dgvDanhMucSanPham.Columns["GiaMua"].Visible = false;
			dgvDanhMucSanPham.Columns["ChiTietHoaDon"].Visible = false;
			dgvDanhMucSanPham.Columns["ChiTietHopDong"].Visible = false;

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
		public void RefreshDgvChiTietHoaDonHienTai(string maSP)
		{
			DgvChiTietHoaDonHienTai_LoadData();

			foreach (DataGridViewRow row in dgvChiTietHoaDonHienTai.Rows)
			{
				if (row.Cells["MaSPHD"].Value.ToString() == maSP)
				{
					row.Selected = true;
					dgvChiTietHoaDonHienTai.CurrentCell = dgvChiTietHoaDonHienTai.Rows[row.Index].Cells[0];
					break;
				}
			}
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


		private void btnThemSP_Click(object sender, EventArgs e)
		{
			toolStrip2.Enabled = true;
			btnGiamSP.Enabled = true;
			btnXoaSP.Enabled = true;
			btnThanhToan.Enabled = true;

			// Xác định sản phẩm cần thêm
			int idx = dgvDanhMucSanPham.CurrentCell.RowIndex;
			string maSP = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();
			string tenSP = dgvDanhMucSanPham.Rows[idx].Cells["TenSP"].Value.ToString();
			int luongTonSP = int.Parse(dgvDanhMucSanPham.Rows[idx].Cells["SoLuong"].Value.ToString());
			DataRow row = DtCurrHoaDon.NewRow();

			int soLuongAdd = int.Parse(cmSoLuong.Text);

			// Kiểm tra số lượng thêm vào có hợp lệ không?
			if (soLuongAdd > luongTonSP)
			{
				MessageBox.Show($"Mặt hàng \"{maSP} - {tenSP}\" không đủ số lượng, trong kho chỉ còn {luongTonSP}");
				return;
			}

			// Kiểm tra xem đã có sản phẩm này trong hóa đơn chưa?
			bool hasProduct = false;
			int proidx = -1;
			foreach (DataGridViewRow r in dgvChiTietHoaDonHienTai.Rows)
			{
				if (r.Cells["MaSPHD"].Value.ToString() == maSP)
				{
					hasProduct = true;
					proidx = r.Index;
					break;
				}
			}

			if (hasProduct == false) // Nếu chưa có sản phẩm này trong hóa đơn
			{
				row.BeginEdit();

				row["MaSP"] = dgvDanhMucSanPham.Rows[idx].Cells["MaSP"].Value.ToString();
				row["TenSP"] = dgvDanhMucSanPham.Rows[idx].Cells["TenSP"].Value.ToString();
				row["DonViTinh"] = dgvDanhMucSanPham.Rows[idx].Cells["DonViTinh"].Value.ToString();
				row["GiaBan"] = dgvDanhMucSanPham.Rows[idx].Cells["DonGia"].Value.ToString();
				row["ChietKhau"] = 0;
				row["SoLuong"] = soLuongAdd;

				decimal thanhTien = soLuongAdd * decimal.Parse(dgvDanhMucSanPham.Rows[idx].Cells["DonGia"].Value.ToString());
				row["ThanhTien"] = thanhTien;
				row.EndEdit();

				DtCurrHoaDon.Rows.Add(row);
				// Giảm số lượng sản phẩm
				dbSanPham.UpdateProductAmount(maSP, (-1) * soLuongAdd);

			}
			else // nếu đã tồn tại rồi
			{
				foreach (DataRow r in DtCurrHoaDon.Rows)
				{
					if (r["maSP"].ToString() == maSP)
						row = r;
				}
				dbSanPham.UpdateProductAmount(maSP, (-1) * soLuongAdd);
				row.BeginEdit();
				soLuongAdd += int.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["SoLuongHD"].Value.ToString());
				row["SoLuong"] = soLuongAdd;
				decimal thanhTien = soLuongAdd * decimal.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["GiaBan"].Value.ToString());
				row["ThanhTien"] = thanhTien - (decimal)LamTronSoTien((double)(soLuongAdd * (int)row["ChietKhau"] * (decimal)row["GiaBan"] / 100));
				row.EndEdit();
			}


			DtCurrHoaDon.AcceptChanges();
			RefreshDgvDanhMucSanPham(maSP);
			RefreshDgvChiTietHoaDonHienTai(maSP);
			cmSoLuong.Text = "1";
		}

		public void DgvChiTietHoaDonHienTai_LoadData()
		{
			dgvChiTietHoaDonHienTai.DataSource = DtCurrHoaDon;

			// Tạo số thứ tự đầu dòng của dgvDanhMucSanPham và tự auto size 
			foreach (DataGridViewRow row in dgvChiTietHoaDonHienTai.Rows)
			{
				row.HeaderCell.Value = (row.Index + 1).ToString();
			}
			dgvDanhMucSanPham.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

			TinhTien();
			SetMaHoaDon();

			if (dgvChiTietHoaDonHienTai.Rows.Count == 0)
			{
				btnGiamSP.Enabled = false;
				btnXoaSP.Enabled = false;
				toolStrip2.Enabled = false;
				btnThanhToan.Enabled = false;
			}
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

		private void TinhTien()
		{
			double tongTien = 0;
			foreach (DataGridViewRow row in dgvChiTietHoaDonHienTai.Rows)
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

		private void btnTaoHoaDonMoi_Click(object sender, EventArgs e)
		{
			TaoHoaDonMoi();
		}

		public void TaoHoaDonMoi()
		{
			btnXoaSP.Enabled = false;
			btnGiamSP.Enabled = false;
			toolStrip2.Enabled = false;
			btnThanhToan.Enabled = false;

			if (DtCurrHoaDon.Rows.Count != 0)
			{
				if (MessageBox.Show("Bạn có muốn xóa hết các mặt hàng vừa mới nhập không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				// cap nhat lai tat ca so luong sp
				foreach (DataRow row in DtCurrHoaDon.Rows)
				{
					string maSP = row["MaSP"].ToString();
					int sl = int.Parse(row["SoLuong"].ToString());

					dbSanPham.UpdateProductAmount(maSP, sl);
				}

				BuidHoaDonMoi();
				RefreshDgvDanhMucSanPham("");
			}
			else MessageBox.Show("Bạn đang ở trong mục tạo hóa đơn mới", "Thông báo");
			DgvChiTietHoaDonHienTai_LoadData();
            txtKhachHang.ResetText();
		}

		private void btnGiamSP_Click(object sender, EventArgs e)
		{
			int proidx = dgvChiTietHoaDonHienTai.CurrentCell.RowIndex;
			string maSP = dgvChiTietHoaDonHienTai.Rows[proidx].Cells["MaSPHD"].Value.ToString();
			int soLuongSub = int.Parse(cmSoLuong.Text);
			int currSoLuong = int.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["SoLuongHD"].Value.ToString());

			if (currSoLuong - soLuongSub < 1)
			{
				MessageBox.Show("Không thể giảm " + soLuongSub + " vì số lượng hiện tại chỉ có " + currSoLuong, "Thông báo");
				return;
			}

			// sửa dữ liệu trong dtcurrHoaDon
			DataRow row = DtCurrHoaDon.NewRow();
			foreach (DataRow r in DtCurrHoaDon.Rows)
			{
				if (r["maSP"].ToString() == maSP)
					row = r;
			}
			row.BeginEdit();
			row["SoLuong"] = currSoLuong - soLuongSub;
			decimal thanhTien = soLuongSub * decimal.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["GiaBan"].Value.ToString());
			row["ThanhTien"] = thanhTien - soLuongSub * (int)row["ChietKhau"] * (decimal)row["GiaBan"] / 100;
			row.EndEdit();
			DtCurrHoaDon.AcceptChanges();

			// Tang so luong san pham
			dbSanPham.UpdateProductAmount(maSP, soLuongSub);

			RefreshDgvChiTietHoaDonHienTai(maSP);
			RefreshDgvDanhMucSanPham(maSP);
			cmSoLuong.Text = "1";
		}



		private void btnXoaSP_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa mặt hàng đang chọn ra khỏi hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			int proidx = dgvChiTietHoaDonHienTai.CurrentCell.RowIndex;
			string maSP = dgvChiTietHoaDonHienTai.Rows[proidx].Cells["MaSPHD"].Value.ToString();
			int sl = int.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["SoLuongHD"].Value.ToString());

			DataRow row = DtCurrHoaDon.NewRow();
			foreach (DataRow r in DtCurrHoaDon.Rows)
			{
				if (r["maSP"].ToString() == maSP)
					row = r;
			}

			DtCurrHoaDon.Rows.Remove(row);
			DtCurrHoaDon.AcceptChanges();

			// Tang so luong san pham
			dbSanPham.UpdateProductAmount(maSP, +sl);

			RefreshDgvDanhMucSanPham(maSP);
			DgvChiTietHoaDonHienTai_LoadData();
		}

		private void nudGiamGia_ValueChanged(object sender, EventArgs e)
		{
			TinhTien();
		}

		private void tsBtnThem1_Click(object sender, EventArgs e)
		{
			int proidx = dgvChiTietHoaDonHienTai.CurrentRow.Index;
			string maSP = dgvChiTietHoaDonHienTai.Rows[proidx].Cells["MaSPHD"].Value.ToString();
			DataRow row = DtCurrHoaDon.NewRow();
			foreach (DataRow r in DtCurrHoaDon.Rows)
			{
				if (r["maSP"].ToString() == maSP)
					row = r;
			}

			row.BeginEdit();
			int soLuong = int.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["SoLuongHD"].Value.ToString()) + 1;
			row["SoLuong"] = soLuong;
			decimal thanhTien = soLuong * decimal.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["GiaBan"].Value.ToString());
			row["ThanhTien"] = thanhTien - soLuong * (int)row["ChietKhau"] * (decimal)row["GiaBan"] / 100;
			row.EndEdit();
			DtCurrHoaDon.AcceptChanges();
			dbSanPham.UpdateProductAmount(maSP, -1);
			RefreshDgvChiTietHoaDonHienTai(maSP);
			RefreshDgvDanhMucSanPham(maSP);
		}

		private void tsBtnGiam1_Click(object sender, EventArgs e)
		{
			int proidx = dgvChiTietHoaDonHienTai.CurrentCell.RowIndex;
			string maSP = dgvChiTietHoaDonHienTai.Rows[proidx].Cells["MaSPHD"].Value.ToString();
			if (int.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["SoLuongHD"].Value.ToString()) == 1)
				return;
			DataRow row = DtCurrHoaDon.NewRow();
			foreach (DataRow r in DtCurrHoaDon.Rows)
			{
				if (r["maSP"].ToString() == maSP)
					row = r;
			}
			row.BeginEdit();
			int soLuong = int.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["SoLuongHD"].Value.ToString()) - 1;
			row["SoLuong"] = soLuong;
			decimal thanhTien = soLuong * decimal.Parse(dgvChiTietHoaDonHienTai.Rows[proidx].Cells["GiaBan"].Value.ToString());
			row["ThanhTien"] = thanhTien - soLuong * (int)row["ChietKhau"] * (decimal)row["GiaBan"] / 100;
			row.EndEdit();
			DtCurrHoaDon.AcceptChanges();

			dbSanPham.UpdateProductAmount(maSP, 1);
			RefreshDgvChiTietHoaDonHienTai(maSP);
			RefreshDgvDanhMucSanPham(maSP);
		}

		private void tsBtnDatSoLuong_Click(object sender, EventArgs e)
		{
			int proidx = dgvChiTietHoaDonHienTai.CurrentCell.RowIndex;
			string maSP = dgvChiTietHoaDonHienTai.Rows[proidx].Cells["MaSPHD"].Value.ToString();

			DataRow row = DtCurrHoaDon.NewRow();

			foreach (DataRow r in DtCurrHoaDon.Rows)
			{
				if (r["maSP"].ToString() == maSP)
					row = r;
			}

			int lt = 0;
			foreach (DataGridViewRow r in dgvDanhMucSanPham.Rows)
			{
				if (r.Cells["MaSP"].Value.ToString() == maSP)
					lt = int.Parse(r.Cells["SoLuong"].Value.ToString());
			}
			(new frmDatSoLuong()).ShowFrmDatSoLuong((int)row["SoLuong"], row, 1, lt);
		}

		private void tsbtnDoiGiaBan_Click(object sender, EventArgs e)
		{
			int proidx = dgvChiTietHoaDonHienTai.CurrentCell.RowIndex;
			string maSP = dgvChiTietHoaDonHienTai.Rows[proidx].Cells["MaSPHD"].Value.ToString();

			DataRow row = DtCurrHoaDon.NewRow();

			foreach (DataRow r in DtCurrHoaDon.Rows)
			{
				if (r["maSP"].ToString() == maSP)
					row = r;
			}

			(new frmDoiGiaBan()).ShowFrmDoiGiaBan((decimal)row["GiaBan"], row);
		}

		private void tsBtnChieuKhau_Click(object sender, EventArgs e)
		{
			int proidx = dgvChiTietHoaDonHienTai.CurrentCell.RowIndex;
			string maSP = dgvChiTietHoaDonHienTai.Rows[proidx].Cells["MaSPHD"].Value.ToString();

			DataRow row = DtCurrHoaDon.NewRow();

			foreach (DataRow r in DtCurrHoaDon.Rows)
			{
				if (r["maSP"].ToString() == maSP)
					row = r;
			}

			(new frmDatGiamGia()).ShowFrmDatGiamGia((decimal)row["GiaBan"], (int)row["ChietKhau"], row);
		}

		string maKH = "";
		public void ChonKhachHang(string maKH, string tenKH, string ck)
		{
			txtKhachHang.Text = tenKH;
			this.maKH = maKH;
			nudGiamGia.Text = ck;
			TinhTien();
		}
		public void ThanhToan()
		{
			txtKhachHang.ResetText();
			nudGiamGia.Value = 0;

			BuidHoaDonMoi();
			DgvChiTietHoaDonHienTai_LoadData();
			DataLoad();
		}
		private void txtKhachHang_DoubleClick(object sender, EventArgs e)
		{
			frmXemDanhMucKhachHang frm = new frmXemDanhMucKhachHang();
			frm.isChonKH = true;
			frm.Show();
		}

		private void nudThue_ValueChanged(object sender, EventArgs e)
		{
			TinhTien();
		}
	}
}
