using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace QuanLyBanHoa.View
{
    public partial class frmThongKeDoanhThu : Form
    {
        QuanLyBanHoaEntities context = new QuanLyBanHoaEntities();
        static frmThongKeDoanhThu _instance;
        public static frmThongKeDoanhThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmThongKeDoanhThu();
                return _instance;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _instance = null;
        }
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var tkdt = context.HoaDon.Join(context.NhanVien, hd => hd.NhanVien, nv => nv.MaNV, (hd, nv) => new
            {
                hd.NgayLap, hd.MaHoaDon, hd.TienHang, hd.GiamGia,hd.Thue, hd.TongTien, hd.KhachHang.TenKH, nv.HoTenNV
            });

            dgvThonKeDoanhThu.DataSource = tkdt.ToList();
            SetHeaderIndex();
            TinhTien();
        }

        private void SetHeaderIndex()
        {
            foreach (DataGridViewRow row in dgvThonKeDoanhThu.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvThonKeDoanhThu.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void TinhTien()
        {
            decimal tienHang = 0;
            decimal giamGia = 0;
            decimal thue = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvThonKeDoanhThu.Rows)
            {
                tienHang += decimal.Parse(row.Cells["TienHang"].Value.ToString());
                giamGia += decimal.Parse(row.Cells["GiamGia"].Value.ToString());
                thue += decimal.Parse(row.Cells["Thue"].Value.ToString());
                tongTien += decimal.Parse(row.Cells["TongTien"].Value.ToString());
            }

            lblTienHang.Text = tienHang.ToString();
            lblGiamGia.Text = giamGia.ToString();
            lblThue.Text = thue.ToString();
            lblTongTien.Text = tongTien.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay = dtpDen.Value;

            var tkdt = context.HoaDon.Where(hd => hd.NgayLap >= tuNgay && hd.NgayLap <= denNgay)
                .Join(context.NhanVien, hd => hd.NhanVien, nv => nv.MaNV, (hd, nv) => new
            {
                hd.NgayLap,
                hd.MaHoaDon,
                hd.TienHang,
                hd.GiamGia,
                hd.Thue,
                hd.TongTien,
                hd.KhachHang.TenKH,
                nv.HoTenNV
            });

            dgvThonKeDoanhThu.DataSource = tkdt.ToList();
            SetHeaderIndex();
            TinhTien();
        } 

    }
}
