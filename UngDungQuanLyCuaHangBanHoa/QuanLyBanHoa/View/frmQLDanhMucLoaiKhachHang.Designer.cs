namespace QuanLyBanHoa.View
{
    partial class frmQLDanhMucLoaiKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhMucLoaiKH = new System.Windows.Forms.DataGridView();
            this.MaLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmCotTimKiem = new System.Windows.Forms.ComboBox();
            this.grThongTinLoaiKH = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiKH = new System.Windows.Forms.TextBox();
            this.txtMaLoaiKH = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiKH)).BeginInit();
            this.grThongTinLoaiKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhMucLoaiKH
            // 
            this.dgvDanhMucLoaiKH.AllowUserToAddRows = false;
            this.dgvDanhMucLoaiKH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhMucLoaiKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhMucLoaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucLoaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiKH,
            this.TenLoaiKH,
            this.ChietKhau});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMucLoaiKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhMucLoaiKH.Location = new System.Drawing.Point(6, 139);
            this.dgvDanhMucLoaiKH.MultiSelect = false;
            this.dgvDanhMucLoaiKH.Name = "dgvDanhMucLoaiKH";
            this.dgvDanhMucLoaiKH.ReadOnly = true;
            this.dgvDanhMucLoaiKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucLoaiKH.Size = new System.Drawing.Size(610, 266);
            this.dgvDanhMucLoaiKH.TabIndex = 51;
            this.dgvDanhMucLoaiKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucLoaiKH_CellClick);
            // 
            // MaLoaiKH
            // 
            this.MaLoaiKH.DataPropertyName = "MaLoaiKH";
            this.MaLoaiKH.Frozen = true;
            this.MaLoaiKH.HeaderText = "Mã loại khách hàng";
            this.MaLoaiKH.Name = "MaLoaiKH";
            this.MaLoaiKH.ReadOnly = true;
            this.MaLoaiKH.Width = 160;
            // 
            // TenLoaiKH
            // 
            this.TenLoaiKH.DataPropertyName = "TenLoaiKH";
            this.TenLoaiKH.HeaderText = "Tên loại khách hàng";
            this.TenLoaiKH.Name = "TenLoaiKH";
            this.TenLoaiKH.ReadOnly = true;
            this.TenLoaiKH.Width = 180;
            // 
            // ChietKhau
            // 
            this.ChietKhau.DataPropertyName = "ChietKhau";
            this.ChietKhau.HeaderText = "Giảm giá";
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.ReadOnly = true;
            this.ChietKhau.Width = 160;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(534, 411);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 28);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 411);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 28);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(358, 411);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 28);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(270, 411);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 28);
            this.btnLuu.TabIndex = 47;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(182, 411);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 28);
            this.btnSua.TabIndex = 48;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(6, 411);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 28);
            this.btnReload.TabIndex = 49;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(94, 411);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 28);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cột tìm kiếm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Giá trị tìm kiếm:";
            // 
            // cmCotTimKiem
            // 
            this.cmCotTimKiem.FormattingEnabled = true;
            this.cmCotTimKiem.Location = new System.Drawing.Point(392, 106);
            this.cmCotTimKiem.Name = "cmCotTimKiem";
            this.cmCotTimKiem.Size = new System.Drawing.Size(188, 21);
            this.cmCotTimKiem.TabIndex = 40;
            // 
            // grThongTinLoaiKH
            // 
            this.grThongTinLoaiKH.Controls.Add(this.txtTenLoaiKH);
            this.grThongTinLoaiKH.Controls.Add(this.txtMaLoaiKH);
            this.grThongTinLoaiKH.Controls.Add(this.txtChietKhau);
            this.grThongTinLoaiKH.Controls.Add(this.label3);
            this.grThongTinLoaiKH.Controls.Add(this.label2);
            this.grThongTinLoaiKH.Controls.Add(this.label1);
            this.grThongTinLoaiKH.Location = new System.Drawing.Point(1, 5);
            this.grThongTinLoaiKH.Name = "grThongTinLoaiKH";
            this.grThongTinLoaiKH.Size = new System.Drawing.Size(615, 94);
            this.grThongTinLoaiKH.TabIndex = 41;
            this.grThongTinLoaiKH.TabStop = false;
            this.grThongTinLoaiKH.Text = "Thông tin loại khách hàng";
            // 
            // txtTenLoaiKH
            // 
            this.txtTenLoaiKH.Location = new System.Drawing.Point(123, 57);
            this.txtTenLoaiKH.Name = "txtTenLoaiKH";
            this.txtTenLoaiKH.Size = new System.Drawing.Size(188, 20);
            this.txtTenLoaiKH.TabIndex = 4;
            // 
            // txtMaLoaiKH
            // 
            this.txtMaLoaiKH.Enabled = false;
            this.txtMaLoaiKH.Location = new System.Drawing.Point(123, 28);
            this.txtMaLoaiKH.Name = "txtMaLoaiKH";
            this.txtMaLoaiKH.Size = new System.Drawing.Size(188, 20);
            this.txtMaLoaiKH.TabIndex = 3;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(391, 28);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(188, 20);
            this.txtChietKhau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chiết khấu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại khách hàng:";
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(124, 107);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(188, 20);
            this.txtGiaTriTimKiem.TabIndex = 39;
            this.txtGiaTriTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGiaTriTimKiem_KeyUp);
            // 
            // frmQLDanhMucLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.dgvDanhMucLoaiKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmCotTimKiem);
            this.Controls.Add(this.grThongTinLoaiKH);
            this.Controls.Add(this.txtGiaTriTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQLDanhMucLoaiKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục loại khách hàng";
            this.Load += new System.EventHandler(this.frmQLDanhMucLoaiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiKH)).EndInit();
            this.grThongTinLoaiKH.ResumeLayout(false);
            this.grThongTinLoaiKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMucLoaiKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmCotTimKiem;
        private System.Windows.Forms.GroupBox grThongTinLoaiKH;
        private System.Windows.Forms.TextBox txtTenLoaiKH;
        private System.Windows.Forms.TextBox txtMaLoaiKH;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiKH;
    }
}