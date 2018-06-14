namespace QuanLyBanHoa.View
{
    partial class frmQLDanhMucHopDong
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
            this.grThongTinHopDong = new System.Windows.Forms.GroupBox();
            this.cmMaNCC = new System.Windows.Forms.ComboBox();
            this.dtpThoiHanHopDong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoHopDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhMucHopDong = new System.Windows.Forms.DataGridView();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.SoHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiHanHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTinHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(534, 437);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 28);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 437);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 28);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(358, 437);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 28);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(270, 437);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 28);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(182, 437);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 28);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(6, 437);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 28);
            this.btnReload.TabIndex = 23;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(94, 437);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 28);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cột tìm kiếm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giá trị tìm kiếm:";
            // 
            // cmCotTimKiem
            // 
            this.cmCotTimKiem.FormattingEnabled = true;
            this.cmCotTimKiem.Location = new System.Drawing.Point(397, 123);
            this.cmCotTimKiem.Name = "cmCotTimKiem";
            this.cmCotTimKiem.Size = new System.Drawing.Size(178, 21);
            this.cmCotTimKiem.TabIndex = 14;
            // 
            // grThongTinHopDong
            // 
            this.grThongTinHopDong.Controls.Add(this.cmMaNCC);
            this.grThongTinHopDong.Controls.Add(this.dtpThoiHanHopDong);
            this.grThongTinHopDong.Controls.Add(this.dtpNgayKy);
            this.grThongTinHopDong.Controls.Add(this.label4);
            this.grThongTinHopDong.Controls.Add(this.label3);
            this.grThongTinHopDong.Controls.Add(this.label2);
            this.grThongTinHopDong.Controls.Add(this.txtSoHopDong);
            this.grThongTinHopDong.Controls.Add(this.label1);
            this.grThongTinHopDong.Location = new System.Drawing.Point(1, 3);
            this.grThongTinHopDong.Name = "grThongTinHopDong";
            this.grThongTinHopDong.Size = new System.Drawing.Size(615, 105);
            this.grThongTinHopDong.TabIndex = 15;
            this.grThongTinHopDong.TabStop = false;
            this.grThongTinHopDong.Text = "Thông tin hợp đồng";
            // 
            // cmMaNCC
            // 
            this.cmMaNCC.FormattingEnabled = true;
            this.cmMaNCC.Location = new System.Drawing.Point(115, 57);
            this.cmMaNCC.Name = "cmMaNCC";
            this.cmMaNCC.Size = new System.Drawing.Size(178, 21);
            this.cmMaNCC.TabIndex = 4;
            // 
            // dtpThoiHanHopDong
            // 
            this.dtpThoiHanHopDong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoiHanHopDong.Location = new System.Drawing.Point(413, 62);
            this.dtpThoiHanHopDong.Name = "dtpThoiHanHopDong";
            this.dtpThoiHanHopDong.Size = new System.Drawing.Size(178, 20);
            this.dtpThoiHanHopDong.TabIndex = 3;
            // 
            // dtpNgayKy
            // 
            this.dtpNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKy.Location = new System.Drawing.Point(413, 25);
            this.dtpNgayKy.Name = "dtpNgayKy";
            this.dtpNgayKy.Size = new System.Drawing.Size(178, 20);
            this.dtpNgayKy.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời hạn hợp đồng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày ký:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.Enabled = false;
            this.txtSoHopDong.Location = new System.Drawing.Point(115, 25);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.Size = new System.Drawing.Size(178, 20);
            this.txtSoHopDong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hợp đồng:";
            // 
            // dgvDanhMucHopDong
            // 
            this.dgvDanhMucHopDong.AllowUserToAddRows = false;
            this.dgvDanhMucHopDong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhMucHopDong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhMucHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHopDong,
            this.MaNCC,
            this.NgayKy,
            this.ThoiHanHopDong});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMucHopDong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMucHopDong.Location = new System.Drawing.Point(6, 161);
            this.dgvDanhMucHopDong.MultiSelect = false;
            this.dgvDanhMucHopDong.Name = "dgvDanhMucHopDong";
            this.dgvDanhMucHopDong.ReadOnly = true;
            this.dgvDanhMucHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucHopDong.Size = new System.Drawing.Size(610, 258);
            this.dgvDanhMucHopDong.TabIndex = 12;
            this.dgvDanhMucHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucHopDong_CellClick);
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(110, 120);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(178, 20);
            this.txtGiaTriTimKiem.TabIndex = 13;
            this.txtGiaTriTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGiaTriTimKiem_KeyUp);
            // 
            // SoHopDong
            // 
            this.SoHopDong.DataPropertyName = "SoHopDong";
            this.SoHopDong.Frozen = true;
            this.SoHopDong.HeaderText = "Số hợp đồng";
            this.SoHopDong.Name = "SoHopDong";
            this.SoHopDong.ReadOnly = true;
            this.SoHopDong.Width = 130;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 150;
            // 
            // NgayKy
            // 
            this.NgayKy.DataPropertyName = "NgayKy";
            this.NgayKy.HeaderText = "Ngày ký";
            this.NgayKy.Name = "NgayKy";
            this.NgayKy.ReadOnly = true;
            this.NgayKy.Width = 130;
            // 
            // ThoiHanHopDong
            // 
            this.ThoiHanHopDong.DataPropertyName = "ThoiHanHopDong";
            this.ThoiHanHopDong.HeaderText = "Thời hạn hợp đồng";
            this.ThoiHanHopDong.Name = "ThoiHanHopDong";
            this.ThoiHanHopDong.ReadOnly = true;
            this.ThoiHanHopDong.Width = 130;
            // 
            // frmQLDanhMucHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 469);
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
            this.Controls.Add(this.grThongTinHopDong);
            this.Controls.Add(this.dgvDanhMucHopDong);
            this.Controls.Add(this.txtGiaTriTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQLDanhMucHopDong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục hợp đồng";
            this.Load += new System.EventHandler(this.frmQLDanhMucHopDong_Load);
            this.grThongTinHopDong.ResumeLayout(false);
            this.grThongTinHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox grThongTinHopDong;
        private System.Windows.Forms.DateTimePicker dtpThoiHanHopDong;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoHopDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhMucHopDong;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
        private System.Windows.Forms.ComboBox cmMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiHanHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHopDong;
    }
}