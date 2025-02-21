using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmKhoHang : Form
    {
      
		public frmKhoHang()
        {
            InitializeComponent();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            frmHangHoa fhh = new frmHangHoa();
            fhh.ShowDialog();
        }

        private void btnNcc_Click(object sender, EventArgs e)
        {
            frmNcc fncc = new frmNcc();
            fncc.ShowDialog();
        }

        private void btnLoaihh_Click(object sender, EventArgs e)
        {
            frmLoaihh frmLoaihh = new frmLoaihh();
            frmLoaihh.ShowDialog();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            NhapXuat nhapXuat = new NhapXuat();
            nhapXuat.ShowDialog();
           
        }

		private void frmKhoHang_Load(object sender, EventArgs e)
		{

		}

		
	}
}
