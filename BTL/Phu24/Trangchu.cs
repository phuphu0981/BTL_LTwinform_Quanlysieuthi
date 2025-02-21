using BTL.Nghia;
using OfficeOpenXml.ConditionalFormatting.Contracts;
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
	public partial class Trangchu : Form
	{
		Login Login = new Login();
		public Trangchu()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedSingle; // Ngăn chặn thay đổi kích thước
			this.MaximizeBox = false; // Ẩn nút phóng to
			this.MinimizeBox = false; // Ẩn nút thu nhỏ
		}


		private void vbButton4_Click(object sender, EventArgs e)
		{
			Login.Show();
			this.Close();
		}

		private void vbButton5_Click(object sender, EventArgs e)
		{
			QLTK qLTK = new QLTK();
			qLTK.ShowDialog();			
		}
		private void vbButton6_Click(object sender, EventArgs e)
		{
			frmKhoHang frmKhoHang = new frmKhoHang();
			frmKhoHang.ShowDialog();
		}
		public void vbButton3_Click(object sender, EventArgs e)
		{
			Quanlynv quanlynv = new Quanlynv();
			quanlynv.ShowDialog();	
		}
		private void btnKhachHang_Click(object sender, EventArgs e)
		{
			QLKhachHang qLKhachHang = new QLKhachHang();
			qLKhachHang.ShowDialog();

		}

		private void btnBanHang_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			form4.ShowDialog();

		}
		public void PhanQuyenNV()
		{
			btnBanHang.Enabled = true;
			btnHangHoaKho.Enabled = false;
			btnKhachHang.Enabled = false;
			btnNhanVien.Enabled = false;
			btnQuanLyTK.Enabled = false;
			btnThoat.Enabled = true;
			
		}
		public void PhanQuyenQuanLy()
		{
			btnBanHang.Enabled = false;
			btnHangHoaKho.Enabled = true;
			btnKhachHang.Enabled = true;
			btnNhanVien.Enabled = true;
			btnQuanLyTK.Enabled = false;
			btnThoat.Enabled = true;
		}
		public void PhanQuyenAdmin()
		{
			btnBanHang.Enabled = true;
			btnHangHoaKho.Enabled = true;
			btnKhachHang.Enabled = true;
			btnNhanVien.Enabled = true;
			btnQuanLyTK.Enabled = true;
			btnThoat.Enabled = true;
		}
		private void Trangchu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Trangchu_Load(object sender, EventArgs e)
		{

		}

		
	}
}

