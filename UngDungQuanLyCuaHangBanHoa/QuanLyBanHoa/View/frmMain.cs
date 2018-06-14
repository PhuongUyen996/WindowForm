using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHoa.View
{
    public partial class frmMain : Form
    {
        string user;
        string pass;
        public frmMain()
        {
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        public void ShowFrmMain(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
            this.Show();
        }

        private void ShowTabages(string tabpageName, Form frm)
        {
           
          
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;

            // kiểm tra xem có tồn tại tabpage hóa đơn bán hàng chưa
            int count = tabControl.TabPages.Count;
            bool hasTab = false;
            for (int i = 0; i < count; i++)
            {
                if (tabControl.TabPages[i].Text == tabpageName)
                    hasTab = true;
            }

            // nếu chưa thì add thêm
            if (hasTab == false)
            {
                TabPage tpHoaDonBanHang = new TabPage(tabpageName);
                tabControl.TabPages.Add(tpHoaDonBanHang);
                tpHoaDonBanHang.Controls.Add(frm);
            }
        }
        private void tsBtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;
            ShowTabages("Hóa đơn bán hàng", frm);
        }

        private void tsBtnHoaDonBanHang_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;

            ShowTabages("Hóa đơn bán hàng", frm);
            SetSelectedTab("Hóa đơn bán hàng");
        }

        private void hoaDonBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang frm = frmHoaDonBanHang.Instance;

            ShowTabages("Hóa đơn bán hàng", frm);
            SetSelectedTab("Hóa đơn bán hàng");
        }

        private void tabControl_DoubleClick(object sender, EventArgs e)
        {
            TabPage tp = tabControl.SelectedTab;
            if (tp != null)
            {
                tabControl.TabPages.Remove(tp);
            }
        }

        private void SetSelectedTab(string tabpageName)
        {
            foreach (TabPage tp in tabControl.TabPages)
            {
                if(tp.Text == tabpageName)
                {
                    tabControl.SelectedTab = tp;
                    break;
                }
            }
        }
        private void danhMucHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucHoaDon().Show();
        }

        private void danhMucChiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucCTHoaDon().Show();
        }

        private void qlDanhMucKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucKhachHang().Show();
        }

        private void qlDanhMucSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucSanPham().Show();
        }

        private void qlDanhMucNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucNhaCungCap().Show();
        }

        private void xenDanhMucSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucSanPham().Show();
        }

        private void xemDanhMucKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucKhachHang().Show();
        }

        private void xemDanhMucNhaCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucNCC().Show();
        }

        private void danhMucLoaiKHtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucLoaiKhachHang().Show();
        }

        private void xemDanhMucLoaiKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucLoaiKhachHang().Show();
        }

        private void xemDanhMucCTHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucChiTietHoaDon().Show();
        }

        private void qlDanhMucNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucNhanVien().Show();
        }

        private void xemDanhMucNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucNhanVien().Show();
        }

        private void qlDanhMucHopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucHopDong().Show();
        }

        private void xemDanhMucHopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucHopDong().Show();
        }

        private void xemDanhMucSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucSanPham().Show();
        }

        private void xemDanhMucHopDongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmXemDanhMucHopDong().Show();
        }

        private void qlDanhMucCTHopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucCTHopDong().Show();
        }

        private void xemDanhMuCTHopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucCTHopDong().Show();
        }

        private void xemDanhMucHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmXemDanhMucHoaDon().Show();
        }

        private void tsbtnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frm = frmThongKeDoanhThu.Instance;

            ShowTabages("Thống kê doanh thu", frm);
            SetSelectedTab("Thống kê doanh thu");
        }

        private void thongKeDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frm = frmThongKeDoanhThu.Instance;

            ShowTabages("Thống kê doanh thu", frm);
            SetSelectedTab("Thống kê doanh thu");
        }

        private void tsBtnDanhMucMatHang_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucSanPham().Show();
        }

        private void DanhMucMatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQLDanhMucSanPham().Show();
        }

        private void thoatKhoiHeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mess = "Nhóm thực hiện:\n Lầu Hôn Thìn - 14110190\n Nguyễn Thị Phương Uyên - 14110231\n"+
                "Mai Xuân Kỳ - 14110096";
            MessageBox.Show(mess);
        }

        private void tsBtnDatHangNCCStripButton1_Click(object sender, EventArgs e)
        {
            frmDatHangNCC frm = frmDatHangNCC.Instance;

            ShowTabages("Đặt hàng nhà cung cấp", frm);
            SetSelectedTab("Đặt hàng nhà cung cấp");
        }

        private void datHangNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatHangNCC frm = frmDatHangNCC.Instance;

            ShowTabages("Đặt hàng nhà cung cấp", frm);
            SetSelectedTab("Đặt hàng nhà cung cấp");
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhauDangNhap frm = new frmDoiMatKhauDangNhap();
            frm.DoiMatKhau(user, pass);
        }
    }
}
