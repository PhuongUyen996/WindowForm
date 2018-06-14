namespace QuanLyBanHoa.View
{
    partial class frmXemTon
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
            this.dgvXemTon = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTongTon = new System.Windows.Forms.Label();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemTon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXemTon
            // 
            this.dgvXemTon.AllowUserToAddRows = false;
            this.dgvXemTon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvXemTon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvXemTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXemTon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXemTon.Location = new System.Drawing.Point(1, 1);
            this.dgvXemTon.MultiSelect = false;
            this.dgvXemTon.Name = "dgvXemTon";
            this.dgvXemTon.ReadOnly = true;
            this.dgvXemTon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXemTon.Size = new System.Drawing.Size(440, 162);
            this.dgvXemTon.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResult.Location = new System.Drawing.Point(137, 174);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(124, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Số lượng hàng tồn: ";
            // 
            // lblTongTon
            // 
            this.lblTongTon.AutoSize = true;
            this.lblTongTon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTon.Location = new System.Drawing.Point(257, 174);
            this.lblTongTon.Name = "lblTongTon";
            this.lblTongTon.Size = new System.Drawing.Size(15, 17);
            this.lblTongTon.TabIndex = 2;
            this.lblTongTon.Text = "0";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 80;
            // 
            // frmXemTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 205);
            this.Controls.Add(this.lblTongTon);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvXemTon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXemTon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem hàng tồn";
            this.Load += new System.EventHandler(this.frmXemTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXemTon;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
    }
}