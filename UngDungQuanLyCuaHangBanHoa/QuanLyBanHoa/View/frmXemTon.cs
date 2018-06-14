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
    public partial class frmXemTon : Form
    {
        DBSanPham db;
        string tenSP;
        public frmXemTon()
        {
            InitializeComponent();
        }

        private void frmXemTon_Load(object sender, EventArgs e)
        {
            db = new DBSanPham();
            DataTable dt = new DataTable();
            dt = db.XemTon(tenSP).Tables[0];

            dgvXemTon.DataSource = dt;
            dgvXemTon.Columns["GiaMua"].Visible = false;
            dgvXemTon.Columns["GiaBan"].Visible = false;

            foreach (DataGridViewRow row in dgvXemTon.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgvXemTon.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            int tongTon = 0;
            for (int i = 0; i < dgvXemTon.Rows.Count; i++)
            {
                tongTon += int.Parse(dgvXemTon.Rows[i].Cells["SoLuong"].Value.ToString());
            }

            lblTongTon.Text = tongTon.ToString();
        }

        public void ShowHangTon(string tenSP)
        {
            this.Text += " Sản phẩm " + tenSP;
            this.tenSP = tenSP;
            this.Show();
        }

    }
}
