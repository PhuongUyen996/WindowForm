namespace QuanLyBanHoa.View
{
    partial class frmHoaDonBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBanHang));
            this.dgvDanhMucSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemSanPham = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSuaSanPham = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoaSanPham = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefreshSanPham = new System.Windows.Forms.ToolStripButton();
            this.lblHoaDonBanHang = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDonHienTai = new System.Windows.Forms.DataGridView();
            this.MaSPHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSPHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinhHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBtnThem1 = new System.Windows.Forms.ToolStripButton();
            this.tsBtnGiam1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnDatSoLuong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDoiGiaBan = new System.Windows.Forms.ToolStripButton();
            this.tsBtnChieuKhau = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmSoLuong = new System.Windows.Forms.ComboBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnGiamSP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.nudThue = new System.Windows.Forms.NumericUpDown();
            this.txtTienGiamGia = new System.Windows.Forms.TextBox();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTienHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btnTaoHoaDonMoi = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSanPham)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonHienTai)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhMucSanPham
            // 
            this.dgvDanhMucSanPham.AllowUserToAddRows = false;
            this.dgvDanhMucSanPham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhMucSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.DonViTinh});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMucSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMucSanPham.Location = new System.Drawing.Point(8, 40);
            this.dgvDanhMucSanPham.MultiSelect = false;
            this.dgvDanhMucSanPham.Name = "dgvDanhMucSanPham";
            this.dgvDanhMucSanPham.ReadOnly = true;
            this.dgvDanhMucSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucSanPham.Size = new System.Drawing.Size(440, 402);
            this.dgvDanhMucSanPham.TabIndex = 0;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 70;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 85;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 75;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "GiaBan";
            this.DonGia.HeaderText = "Giá bán";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 80;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "DVT";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 65;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFilter.Location = new System.Drawing.Point(154, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(135, 23);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm theo tên sản phẩm:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemSanPham,
            this.toolStripSeparator2,
            this.btnSuaSanPham,
            this.toolStripSeparator1,
            this.btnXoaSanPham,
            this.toolStripSeparator3,
            this.btnRefreshSanPham,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(8, 446);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(441, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Image = global::QuanLyBanHoa.Properties.Resources.plus;
            this.btnThemSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(64, 22);
            this.btnThemSanPham.Text = "  Thêm";
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSuaSanPham
            // 
            this.btnSuaSanPham.Image = global::QuanLyBanHoa.Properties.Resources.edit;
            this.btnSuaSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaSanPham.Name = "btnSuaSanPham";
            this.btnSuaSanPham.Size = new System.Drawing.Size(52, 22);
            this.btnSuaSanPham.Text = "  Sửa";
            this.btnSuaSanPham.Click += new System.EventHandler(this.btnSuaSanPham_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Image = global::QuanLyBanHoa.Properties.Resources.x;
            this.btnXoaSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(53, 22);
            this.btnXoaSanPham.Text = "  Xóa";
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefreshSanPham
            // 
            this.btnRefreshSanPham.Image = global::QuanLyBanHoa.Properties.Resources.Refresh;
            this.btnRefreshSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshSanPham.Name = "btnRefreshSanPham";
            this.btnRefreshSanPham.Size = new System.Drawing.Size(77, 22);
            this.btnRefreshSanPham.Text = " Làm mới";
            this.btnRefreshSanPham.Click += new System.EventHandler(this.btnRefreshSanPham_Click);
            // 
            // lblHoaDonBanHang
            // 
            this.lblHoaDonBanHang.AutoSize = true;
            this.lblHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoaDonBanHang.Location = new System.Drawing.Point(733, 6);
            this.lblHoaDonBanHang.Name = "lblHoaDonBanHang";
            this.lblHoaDonBanHang.Size = new System.Drawing.Size(219, 24);
            this.lblHoaDonBanHang.TabIndex = 4;
            this.lblHoaDonBanHang.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // dgvChiTietHoaDonHienTai
            // 
            this.dgvChiTietHoaDonHienTai.AllowUserToAddRows = false;
            this.dgvChiTietHoaDonHienTai.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChiTietHoaDonHienTai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTietHoaDonHienTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDonHienTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSPHD,
            this.TenSPHD,
            this.DonViTinhHD,
            this.SoLuongHD,
            this.GiaBan,
            this.CK,
            this.ThanhTien});
            this.dgvChiTietHoaDonHienTai.Location = new System.Drawing.Point(520, 130);
            this.dgvChiTietHoaDonHienTai.MultiSelect = false;
            this.dgvChiTietHoaDonHienTai.Name = "dgvChiTietHoaDonHienTai";
            this.dgvChiTietHoaDonHienTai.ReadOnly = true;
            this.dgvChiTietHoaDonHienTai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDonHienTai.Size = new System.Drawing.Size(589, 233);
            this.dgvChiTietHoaDonHienTai.TabIndex = 10;
            // 
            // MaSPHD
            // 
            this.MaSPHD.DataPropertyName = "MaSP";
            this.MaSPHD.HeaderText = "Mã SP";
            this.MaSPHD.Name = "MaSPHD";
            this.MaSPHD.ReadOnly = true;
            this.MaSPHD.Width = 70;
            // 
            // TenSPHD
            // 
            this.TenSPHD.DataPropertyName = "TenSP";
            this.TenSPHD.HeaderText = "Tên SP";
            this.TenSPHD.Name = "TenSPHD";
            this.TenSPHD.ReadOnly = true;
            this.TenSPHD.Width = 110;
            // 
            // DonViTinhHD
            // 
            this.DonViTinhHD.DataPropertyName = "DonViTinh";
            this.DonViTinhHD.HeaderText = "ĐVT";
            this.DonViTinhHD.Name = "DonViTinhHD";
            this.DonViTinhHD.ReadOnly = true;
            this.DonViTinhHD.Width = 60;
            // 
            // SoLuongHD
            // 
            this.SoLuongHD.DataPropertyName = "SoLuong";
            this.SoLuongHD.HeaderText = "S.lượng";
            this.SoLuongHD.Name = "SoLuongHD";
            this.SoLuongHD.ReadOnly = true;
            this.SoLuongHD.Width = 50;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 80;
            // 
            // CK
            // 
            this.CK.DataPropertyName = "ChietKhau";
            this.CK.HeaderText = "% CK";
            this.CK.Name = "CK";
            this.CK.ReadOnly = true;
            this.CK.Width = 60;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Enabled = false;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnThem1,
            this.tsBtnGiam1,
            this.toolStripSeparator4,
            this.tsBtnDatSoLuong,
            this.tsbtnDoiGiaBan,
            this.tsBtnChieuKhau});
            this.toolStrip2.Location = new System.Drawing.Point(520, 107);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(591, 25);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsBtnThem1
            // 
            this.tsBtnThem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnThem1.Image = global::QuanLyBanHoa.Properties.Resources.plus;
            this.tsBtnThem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnThem1.Name = "tsBtnThem1";
            this.tsBtnThem1.Size = new System.Drawing.Size(23, 22);
            this.tsBtnThem1.Text = "Tăng số lượng 1";
            this.tsBtnThem1.Click += new System.EventHandler(this.tsBtnThem1_Click);
            // 
            // tsBtnGiam1
            // 
            this.tsBtnGiam1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnGiam1.Image = global::QuanLyBanHoa.Properties.Resources.subtract;
            this.tsBtnGiam1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGiam1.Name = "tsBtnGiam1";
            this.tsBtnGiam1.Size = new System.Drawing.Size(23, 22);
            this.tsBtnGiam1.Text = "Giảm số lượng 1";
            this.tsBtnGiam1.Click += new System.EventHandler(this.tsBtnGiam1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnDatSoLuong
            // 
            this.tsBtnDatSoLuong.Image = global::QuanLyBanHoa.Properties.Resources.dat_soluong;
            this.tsBtnDatSoLuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDatSoLuong.Name = "tsBtnDatSoLuong";
            this.tsBtnDatSoLuong.Size = new System.Drawing.Size(94, 22);
            this.tsBtnDatSoLuong.Text = "Đặt số lượng";
            this.tsBtnDatSoLuong.Click += new System.EventHandler(this.tsBtnDatSoLuong_Click);
            // 
            // tsbtnDoiGiaBan
            // 
            this.tsbtnDoiGiaBan.Image = global::QuanLyBanHoa.Properties.Resources.doigiaban;
            this.tsbtnDoiGiaBan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDoiGiaBan.Name = "tsbtnDoiGiaBan";
            this.tsbtnDoiGiaBan.Size = new System.Drawing.Size(87, 22);
            this.tsbtnDoiGiaBan.Text = "Đổi giá bán";
            this.tsbtnDoiGiaBan.Click += new System.EventHandler(this.tsbtnDoiGiaBan_Click);
            // 
            // tsBtnChieuKhau
            // 
            this.tsBtnChieuKhau.Image = global::QuanLyBanHoa.Properties.Resources.percent;
            this.tsBtnChieuKhau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnChieuKhau.Name = "tsBtnChieuKhau";
            this.tsBtnChieuKhau.Size = new System.Drawing.Size(84, 22);
            this.tsBtnChieuKhau.Text = "Chiết khấu";
            this.tsBtnChieuKhau.Click += new System.EventHandler(this.tsBtnChieuKhau_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng";
            // 
            // cmSoLuong
            // 
            this.cmSoLuong.FormattingEnabled = true;
            this.cmSoLuong.Location = new System.Drawing.Point(463, 139);
            this.cmSoLuong.Name = "cmSoLuong";
            this.cmSoLuong.Size = new System.Drawing.Size(57, 21);
            this.cmSoLuong.TabIndex = 13;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(448, 176);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(72, 28);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Text = "Thêm >>";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnGiamSP
            // 
            this.btnGiamSP.Location = new System.Drawing.Point(448, 210);
            this.btnGiamSP.Name = "btnGiamSP";
            this.btnGiamSP.Size = new System.Drawing.Size(72, 28);
            this.btnGiamSP.TabIndex = 14;
            this.btnGiamSP.Text = "<< Giảm";
            this.btnGiamSP.UseVisualStyleBackColor = true;
            this.btnGiamSP.Click += new System.EventHandler(this.btnGiamSP_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.txtTienThue);
            this.panel1.Controls.Add(this.nudThue);
            this.panel1.Controls.Add(this.txtTienGiamGia);
            this.panel1.Controls.Add(this.nudGiamGia);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtTienHang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(519, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 115);
            this.panel1.TabIndex = 20;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Image = global::QuanLyBanHoa.Properties.Resources.thanhtoan;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(390, 29);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(134, 45);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTienThue
            // 
            this.txtTienThue.Location = new System.Drawing.Point(169, 61);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.Size = new System.Drawing.Size(142, 20);
            this.txtTienThue.TabIndex = 26;
            this.txtTienThue.Text = "0.00";
            this.txtTienThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudThue
            // 
            this.nudThue.Location = new System.Drawing.Point(109, 61);
            this.nudThue.Name = "nudThue";
            this.nudThue.Size = new System.Drawing.Size(54, 20);
            this.nudThue.TabIndex = 25;
            this.nudThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudThue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudThue.ValueChanged += new System.EventHandler(this.nudThue_ValueChanged);
            // 
            // txtTienGiamGia
            // 
            this.txtTienGiamGia.Location = new System.Drawing.Point(169, 35);
            this.txtTienGiamGia.Name = "txtTienGiamGia";
            this.txtTienGiamGia.Size = new System.Drawing.Size(142, 20);
            this.txtTienGiamGia.TabIndex = 26;
            this.txtTienGiamGia.Text = "0.00";
            this.txtTienGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(109, 35);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(54, 20);
            this.nudGiamGia.TabIndex = 25;
            this.nudGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiamGia.ValueChanged += new System.EventHandler(this.nudGiamGia_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(15, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Thuế(%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(15, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tổng tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Giảm giá (%):";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(109, 88);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(202, 20);
            this.txtTongTien.TabIndex = 21;
            this.txtTongTien.Text = "0.00";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienHang
            // 
            this.txtTienHang.Location = new System.Drawing.Point(109, 7);
            this.txtTienHang.Name = "txtTienHang";
            this.txtTienHang.Size = new System.Drawing.Size(202, 20);
            this.txtTienHang.TabIndex = 22;
            this.txtTienHang.Text = "0.00";
            this.txtTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(12, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tiền hàng:";
            // 
            // cmNhanVien
            // 
            this.cmNhanVien.FormattingEnabled = true;
            this.cmNhanVien.Location = new System.Drawing.Point(910, 47);
            this.cmNhanVien.Name = "cmNhanVien";
            this.cmNhanVien.Size = new System.Drawing.Size(185, 21);
            this.cmNhanVien.TabIndex = 27;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(607, 74);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(180, 20);
            this.dtpNgay.TabIndex = 26;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKhachHang.Location = new System.Drawing.Point(607, 45);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(180, 20);
            this.txtKhachHang.TabIndex = 25;
            this.txtKhachHang.DoubleClick += new System.EventHandler(this.txtKhachHang_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(823, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(910, 74);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(185, 20);
            this.txtMaHoaDon.TabIndex = 28;
            // 
            // btnTaoHoaDonMoi
            // 
            this.btnTaoHoaDonMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHoaDonMoi.Image")));
            this.btnTaoHoaDonMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaoHoaDonMoi.Location = new System.Drawing.Point(448, 295);
            this.btnTaoHoaDonMoi.Name = "btnTaoHoaDonMoi";
            this.btnTaoHoaDonMoi.Size = new System.Drawing.Size(72, 66);
            this.btnTaoHoaDonMoi.TabIndex = 14;
            this.btnTaoHoaDonMoi.Text = "Tạo hóa đơn mới";
            this.btnTaoHoaDonMoi.UseVisualStyleBackColor = true;
            this.btnTaoHoaDonMoi.Click += new System.EventHandler(this.btnTaoHoaDonMoi_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Image = global::QuanLyBanHoa.Properties.Resources.xoasp2;
            this.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSP.Location = new System.Drawing.Point(451, 244);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(69, 28);
            this.btnXoaSP.TabIndex = 14;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 494);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.cmNhanVien);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTaoHoaDonMoi);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnGiamSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.cmSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvChiTietHoaDonHienTai);
            this.Controls.Add(this.lblHoaDonBanHang);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvDanhMucSanPham);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmHoaDonBanHang";
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSanPham)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonHienTai)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMucSanPham;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemSanPham;
        private System.Windows.Forms.ToolStripButton btnRefreshSanPham;
        private System.Windows.Forms.ToolStripButton btnSuaSanPham;
        private System.Windows.Forms.ToolStripButton btnXoaSanPham;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lblHoaDonBanHang;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDonHienTai;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBtnGiam1;
        private System.Windows.Forms.ToolStripButton tsBtnThem1;
        private System.Windows.Forms.ToolStripButton tsBtnDatSoLuong;
        private System.Windows.Forms.ToolStripButton tsbtnDoiGiaBan;
        private System.Windows.Forms.ToolStripButton tsBtnChieuKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmSoLuong;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnGiamSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnTaoHoaDonMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTienGiamGia;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cmNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinhHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSPHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPHD;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.NumericUpDown nudThue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}