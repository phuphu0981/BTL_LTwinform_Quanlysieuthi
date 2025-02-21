using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Nghia
{
	public partial class QLKhachHang : Form
	{
		string role;
		public QLKhachHang()
		{
			InitializeComponent();
		}

		private void btnHang_Click(object sender, EventArgs e)
		{
			KHTT kHTT = new KHTT();
			kHTT.ShowDialog();
			
		}

		private void btnLoaihh_Click(object sender, EventArgs e)
		{
			KHBT kHBT = new KHBT();
			kHBT.ShowDialog();
			
		}

		private void btnNcc_Click(object sender, EventArgs e)
		{
			DSDen dSDen	= new DSDen();
			dSDen.ShowDialog();
		}

		private void QLKhachHang_Load(object sender, EventArgs e)
		{

		}

	
	}
}
