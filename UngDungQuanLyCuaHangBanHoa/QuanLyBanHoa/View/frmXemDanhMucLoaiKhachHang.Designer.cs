namespace QuanLyBanHoa.View
{
    partial class frmXemDanhMucLoaiKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhMucLoaiKH = new System.Windows.Forms.DataGridView();
            this.MaLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmCotTimKiem = new System.Windows.Forms.ComboBox();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiKH)).BeginInit();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMucLoaiKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhMucLoaiKH.Location = new System.Drawing.Point(4, 39);
            this.dgvDanhMucLoaiKH.MultiSelect = false;
            this.dgvDanhMucLoaiKH.Name = "dgvDanhMucLoaiKH";
            this.dgvDanhMucLoaiKH.ReadOnly = true;
            this.dgvDanhMucLoaiKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucLoaiKH.Size = new System.Drawing.Size(610, 266);
            this.dgvDanhMucLoaiKH.TabIndex = 56;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Cột tìm kiếm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Giá trị tìm kiếm:";
            // 
            // cmCotTimKiem
            // 
            this.cmCotTimKiem.FormattingEnabled = true;
            this.cmCotTimKiem.Location = new System.Drawing.Point(390, 6);
            this.cmCotTimKiem.Name = "cmCotTimKiem";
            this.cmCotTimKiem.Size = new System.Drawing.Size(188, 21);
            this.cmCotTimKiem.TabIndex = 53;
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(122, 7);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(188, 20);
            this.txtGiaTriTimKiem.TabIndex = 52;
            this.txtGiaTriTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGiaTriTimKiem_KeyUp);
            // 
            // frmXemDanhMucLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 309);
            this.Controls.Add(this.dgvDanhMucLoaiKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmCotTimKiem);
            this.Controls.Add(this.txtGiaTriTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmXemDanhMucLoaiKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem danh mục loại khách hàng";
            this.Load += new System.EventHandler(this.frmXemDanhMucLoaiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMucLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChietKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmCotTimKiem;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
    }
}