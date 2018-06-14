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
    public partial class frmThanhToan : Form
    {
        DataTable dtCTHD;
        string tenKH;
        string maKH;
        string nhanVien;
        string maHoaDon;
        DateTime ngayLap;
        decimal tienHang;
        decimal giamGia;
        decimal thue;
        decimal tongTien;

        public frmThanhToan()
        {
            InitializeComponent();
        }
        public void ShowFrmThanhToan(DataTable dtCTHD, string maKH, string khachHang, string nhanVien,
            string maHoaDon, DateTime ngayLap, decimal tienHang, decimal giamGia, decimal thue, decimal tongTien)
        {
            this.dtCTHD = dtCTHD;
            this.maKH = maKH;
            this.tenKH = khachHang;
            this.nhanVien = nhanVien;
            this.maHoaDon = maHoaDon;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
            this.tienHang = tienHang;
            this.giamGia = giamGia;
            this.thue = thue;

            txtKhachDua.Focus();
            txtTongTien.Text = tongTien.ToString();
            txtKhachDua.Text = tongTien.ToString();
            txtTraLai.Text = "0.00";
            this.Show();
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            decimal tienTraLai = decimal.Parse(txtKhachDua.Text.Trim()) - tongTien;

            if (tienTraLai < 0)
            {
                txtTraLai.Text = "0.00";
                btnThanhToan.Enabled = false;
            }
            else
            {
                btnThanhToan.Enabled = true;
                txtTraLai.Text = tienTraLai.ToString();
            }
        }

        private void LuuThongTinKhachHang()
        {
            DBKhachHang dbKH = new DBKhachHang();
            DateTime? dt = null;

            maKH = dbKH.SetNewPrimaryKey();
            dbKH.InsertCustomer(maKH, tenKH, dt, "", "", "", "3");
        }

        private void LuuThongTinHoaDon(string maKH)
        {
            DBHoaDon dbHoaDon = new DBHoaDon();
            dbHoaDon.InsertHoaDon(dbHoaDon.SetNewPrimaryKey(), maKH, ngayLap, tienHang, giamGia, thue, tongTien, nhanVien);
        }
        private void LuuThongTinChiTietHoaDon()
        {
            foreach (DataRow row in dtCTHD.Rows)
            {
                string err = "";
                string maSP = row["MaSP"].ToString();
                int soLuong = int.Parse(row["SoLuong"].ToString());
                decimal donGia = decimal.Parse(row["ThanhTien"].ToString());
                int chietKhau = int.Parse(row["ChietKhau"].ToString());
                DBChiTietHoaDon dbCTHoaDon = new DBChiTietHoaDon();
                dbCTHoaDon.InsertCTHoaDon(ref err, maHoaDon, maSP, soLuong, donGia, chietKhau);
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            // Kiểm tra số lượng từng mặt hàng có đủ số lượng ko?
            //        foreach (DataRow r in dtCTHD.Rows)
            //        {
            //            string maSP = r["MaSP"].ToString();
            //            string tenSP = r["TenSP"].ToString();

            //            int soLuong = int.Parse(r["SoLuong"].ToString());

            //            // lấy ra số lượng của sản phẩm có cùng maSP ở trên
            //            SanPham sp = dbs.SanPhams.SingleOrDefault(s => s.MaSP.Equals(maSP));
            //            if (soLuong > sp.SoLuong)
            //            {
            //                MessageBox.Show($"Mặt hàng {maSP} - {tenSP} không đủ số lượng, trong kho chỉ còn {sp.SoLuong} ",
            //                    "Cảnh báo không đủ số lượng");
            //                return;
            //            }
            //            else // cập nhật lại số lượng
            //            {
            //                int lt = (int)sp.SoLuong - soLuong;
            //                sp.SoLuong = lt;
            //                dbs.SaveChanges();
            //            }
            //        }

            // Lưu thông tin khách Hàng
            if (tenKH == "")
                tenKH = "Unknown";
            LuuThongTinKhachHang();

            // Lưu thông tin hóa đơn
            LuuThongTinHoaDon(maKH);


            // Luu chi tiet hoa don
            LuuThongTinChiTietHoaDon();

            MessageBox.Show("Thanh toán xong", "Thông báo");
            this.Close();

            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;
            frm.ThanhToan();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
