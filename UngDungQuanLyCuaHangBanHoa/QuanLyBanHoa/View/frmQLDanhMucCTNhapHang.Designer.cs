namespace QuanLyBanHoa.View
{
    partial class frmQLDanhMucCTNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmCotTimKiem = new System.Windows.Forms.ComboBox();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhMucCTNhapHang = new System.Windows.Forms.DataGridView();
            this.grThongTinChiTietNhapHang = new System.Windows.Forms.GroupBox();
            this.cmSoHopDong = new System.Windows.Forms.ComboBox();
            this.cmMaSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNhapHang = new System.Windows.Forms.TextBox();
            this.dtpNgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.MaNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucCTNhapHang)).BeginInit();
            this.grThongTinChiTietNhapHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cột tìm kiếm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giá trị tìm kiếm:";
            // 
            // cmCotTimKiem
            // 
            this.cmCotTimKiem.FormattingEnabled = true;
            this.cmCotTimKiem.Location = new System.Drawing.Point(417, 139);
            this.cmCotTimKiem.Name = "cmCotTimKiem";
            this.cmCotTimKiem.Size = new System.Drawing.Size(185, 21);
            this.cmCotTimKiem.TabIndex = 27;
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(100, 142);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(186, 20);
            this.txtGiaTriTimKiem.TabIndex = 26;
            this.txtGiaTriTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGiaTriTimKiem_KeyUp);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(534, 423);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 28);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 423);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 28);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(358, 423);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 28);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(270, 423);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 28);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(182, 423);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 28);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(5, 423);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 28);
            this.btnReload.TabIndex = 24;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(94, 423);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 28);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhMucCTNhapHang
            // 
            this.dgvDanhMucCTNhapHang.AllowUserToAddRows = false;
            this.dgvDanhMucCTNhapHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhMucCTNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhMucCTNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucCTNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhapHang,
            this.SoHopDong,
            this.MaSP,
            this.SoLuong,
            this.NgayNhapHang});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMucCTNhapHang.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDanhMucCTNhapHang.Location = new System.Drawing.Point(5, 182);
            this.dgvDanhMucCTNhapHang.MultiSelect = false;
            this.dgvDanhMucCTNhapHang.Name = "dgvDanhMucCTNhapHang";
            this.dgvDanhMucCTNhapHang.ReadOnly = true;
            this.dgvDanhMucCTNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucCTNhapHang.Size = new System.Drawing.Size(611, 227);
            this.dgvDanhMucCTNhapHang.TabIndex = 18;
            // 
            // grThongTinChiTietNhapHang
            // 
            this.grThongTinChiTietNhapHang.Controls.Add(this.dtpNgayNhapHang);
            this.grThongTinChiTietNhapHang.Controls.Add(this.cmSoHopDong);
            this.grThongTinChiTietNhapHang.Controls.Add(this.cmMaSP);
            this.grThongTinChiTietNhapHang.Controls.Add(this.label3);
            this.grThongTinChiTietNhapHang.Controls.Add(this.label5);
            this.grThongTinChiTietNhapHang.Controls.Add(this.txtMaNhapHang);
            this.grThongTinChiTietNhapHang.Controls.Add(this.label4);
            this.grThongTinChiTietNhapHang.Controls.Add(this.txtSoLuong);
            this.grThongTinChiTietNhapHang.Controls.Add(this.label2);
            this.grThongTinChiTietNhapHang.Controls.Add(this.label1);
            this.grThongTinChiTietNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTinChiTietNhapHang.Location = new System.Drawing.Point(7, 1);
            this.grThongTinChiTietNhapHang.Name = "grThongTinChiTietNhapHang";
            this.grThongTinChiTietNhapHang.Size = new System.Drawing.Size(609, 124);
            this.grThongTinChiTietNhapHang.TabIndex = 17;
            this.grThongTinChiTietNhapHang.TabStop = false;
            this.grThongTinChiTietNhapHang.Text = "Thông tin chi tiết nhập hàng";
            // 
            // cmSoHopDong
            // 
            this.cmSoHopDong.FormattingEnabled = true;
            this.cmSoHopDong.Location = new System.Drawing.Point(104, 55);
            this.cmSoHopDong.Name = "cmSoHopDong";
            this.cmSoHopDong.Size = new System.Drawing.Size(185, 23);
            this.cmSoHopDong.TabIndex = 2;
            // 
            // cmMaSP
            // 
            this.cmMaSP.FormattingEnabled = true;
            this.cmMaSP.Location = new System.Drawing.Point(104, 86);
            this.cmMaSP.Name = "cmMaSP";
            this.cmMaSP.Size = new System.Drawing.Size(185, 23);
            this.cmMaSP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày nhập hàng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(410, 25);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(185, 21);
            this.txtSoLuong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hợp đồng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhập hàng:";
            // 
            // txtMaNhapHang
            // 
            this.txtMaNhapHang.Enabled = false;
            this.txtMaNhapHang.Location = new System.Drawing.Point(104, 26);
            this.txtMaNhapHang.Name = "txtMaNhapHang";
            this.txtMaNhapHang.Size = new System.Drawing.Size(185, 21);
            this.txtMaNhapHang.TabIndex = 1;
            // 
            // dtpNgayNhapHang
            // 
            this.dtpNgayNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhapHang.Location = new System.Drawing.Point(410, 54);
            this.dtpNgayNhapHang.Name = "dtpNgayNhapHang";
            this.dtpNgayNhapHang.Size = new System.Drawing.Size(185, 21);
            this.dtpNgayNhapHang.TabIndex = 3;
            // 
            // MaNhapHang
            // 
            this.MaNhapHang.DataPropertyName = "MaNhapHang";
            this.MaNhapHang.HeaderText = "Mã nhập hàng";
            this.MaNhapHang.Name = "MaNhapHang";
            this.MaNhapHang.ReadOnly = true;
            this.MaNhapHang.Width = 120;
            // 
            // SoHopDong
            // 
            this.SoHopDong.DataPropertyName = "SoHopDong";
            this.SoHopDong.HeaderText = "Số hợp đồng";
            this.SoHopDong.Name = "SoHopDong";
            this.SoHopDong.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.DataPropertyName = "NgayNhapHang";
            this.NgayNhapHang.HeaderText = "Ngày nhập hàng";
            this.NgayNhapHang.Name = "NgayNhapHang";
            this.NgayNhapHang.ReadOnly = true;
            this.NgayNhapHang.Width = 140;
            // 
            // frmQLDanhMucCTNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmCotTimKiem);
            this.Controls.Add(this.txtGiaTriTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhMucCTNhapHang);
            this.Controls.Add(this.grThongTinChiTietNhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLDanhMucCTNhapHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục chi tiết nhập hàng";
            this.Load += new System.EventHandler(this.frmQLDanhMucCTNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucCTNhapHang)).EndInit();
            this.grThongTinChiTietNhapHang.ResumeLayout(false);
            this.grThongTinChiTietNhapHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmCotTimKiem;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhMucCTNhapHang;
        private System.Windows.Forms.GroupBox grThongTinChiTietNhapHang;
        private System.Windows.Forms.ComboBox cmSoHopDong;
        private System.Windows.Forms.ComboBox cmMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhapHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHopDong;
    }
}