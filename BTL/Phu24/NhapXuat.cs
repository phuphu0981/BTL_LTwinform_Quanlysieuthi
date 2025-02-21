using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DirectoryServices.ActiveDirectory;

namespace BTL
{

	public partial class NhapXuat : Form
	{
		SqlConnection conn;
		string state = "Reset";
		DataSet ds;
		public NhapXuat()
		{
			
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			conn = new SqlConnection("Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True");
			getdataCob();
			getdataKho();
			getdata();
			managementITF("Reset");
		}
		private void NhapXuat_Load(object sender, EventArgs e)
		{
			lblMaGD.Text = "";
			this.FormBorderStyle = FormBorderStyle.None;
			this.MaximizeBox = false; // Ẩn nút phóng to
			this.MinimizeBox = false; // Ẩn nút thu nhỏ
			dataGridView2.Visible = false;
			
		}
		public void getdataCob()
		{
			getcobLoaiSP();
			getcobTenSP();
			getcobNhaCC();
		}
		public void getcobTenSP()
		{
			
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query1 = "select TenSP,MaSP from tblHangHoa";
			SqlCommand cmd = new SqlCommand(query1, conn);
			ds = new DataSet();
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];


			if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
			{
				cobTenSP.DisplayMember = "TenSP";
				cobTenSP.ValueMember = "MaSP";
				cobTenSP.DataSource = ds.Tables[0];
				cobTenSP.SelectedIndex = 0;
			}
			else
			{
				cobTenSP.DataSource = null;
			}
			conn.Close();
		}
		public void getcobLoaiSP()
		{

			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query1 = "select LoaiSP from tblHangHoa";
			SqlCommand cmd = new SqlCommand(query1, conn);
			ds = new DataSet();
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];


			if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
			{
				cobLoaiSP.DisplayMember = "LoaiSP";
				cobLoaiSP.ValueMember = "LoaiSP";
				cobLoaiSP.DataSource = ds.Tables[0];
				cobLoaiSP.SelectedIndex = 0;
			}
			else
			{
				cobLoaiSP.DataSource = null;
			}
			conn.Close();
		}
		public void getcobNhaCC()
		{

			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query1 = "select MaNcc,TenNcc from tblNCC";
			SqlCommand cmd = new SqlCommand(query1, conn);
			ds = new DataSet();
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];


			if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
			{
				cobNhaCC.DisplayMember = "TenNcc";
				cobNhaCC.ValueMember = "MaNcc";
				cobNhaCC.DataSource = ds.Tables[0];
				cobNhaCC.SelectedIndex = 0;
			}
			else
			{
				cobNhaCC.DataSource = null;
			}
			conn.Close();
		}
		private void cobTenSP_TextChanged(object sender, EventArgs e)
		{
			textXuatXu();
			textDonvi();
			textCobLoaiSP();
		}
		public void textXuatXu()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query1 = "select MaSP,XuatXu from tblHangHoa";
			SqlCommand cmd1 = new SqlCommand(query1, conn);
			ds = new DataSet();
			SqlDataAdapter adt = new SqlDataAdapter(cmd1);
			adt.Fill(ds);
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr["MaSP"].ToString() == cobTenSP.SelectedValue.ToString())
				{
					txtXuatXu.Texts = dr["XuatXu"].ToString();
				}

			}
			conn.Close();
		}
		public void textDonvi()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query1 = "select MaSP,Donvi from tblHangHoa";
			SqlCommand cmd1 = new SqlCommand(query1, conn);
			ds = new DataSet();
			SqlDataAdapter adt = new SqlDataAdapter(cmd1);
			adt.Fill(ds);
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr["MaSP"].ToString() == cobTenSP.SelectedValue.ToString())
				{
					txtDonvi.Texts = dr["Donvi"].ToString();
				}

			}
			conn.Close();
		}
		public void textCobLoaiSP()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query1 = "select MaSP,LoaiSP from tblHangHoa";
			SqlCommand cmd1 = new SqlCommand(query1, conn);
			ds = new DataSet();
			SqlDataAdapter adt = new SqlDataAdapter(cmd1);
			adt.Fill(ds);
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr["MaSP"].ToString() == cobTenSP.SelectedValue.ToString())
				{
					cobLoaiSP.Text = dr["LoaiSP"].ToString();
				}

			}
			conn.Close();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Maroon, 5, ButtonBorderStyle.Solid, Color.Maroon, 10, ButtonBorderStyle.Solid, Color.Maroon, 5, ButtonBorderStyle.Solid, Color.Maroon, 10, ButtonBorderStyle.Solid);
		}
		public void getdata()
		{
			if(conn.State == ConnectionState.Closed) { conn.Open(); }
			DataSet ds = new DataSet();	
			string query = "Select * from NhapHangHoa";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}
		public void getdataKho()
		{
			
			if (conn.State == ConnectionState.Closed) { conn.Open(); }
			DataSet ds = new DataSet();
			string query = "Select * from Kho";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];


		}
		public void UpdatedataKho()
		{
			try
			{
				if (conn.State == ConnectionState.Closed) { conn.Open(); }

				int a = Convert.ToInt32(txtSoLuong.Texts);
				int b = 0, Tong = 0;
				string them = "";
				DataSet ds = new DataSet();
				string query = "Select * from Kho";
				SqlCommand cmd2 = new SqlCommand(query, conn);
				SqlDataAdapter adt = new SqlDataAdapter(cmd2);
				adt.Fill(ds);
				dataGridView2.DataSource = ds.Tables[0];

				if (ds.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow dr1 in ds.Tables[0].Rows)
					{
						if (dr1["MaSP"].ToString() == cobTenSP.SelectedValue.ToString() )
						{
							b = Convert.ToInt32(dr1["SoLuong"].ToString());
							Tong = a + b;
							them = "update Kho set SoLuong = '" + Tong + "' where MaSP = '" + cobTenSP.SelectedValue + "' ";
							break;
						}
						else
						{
							them = "insert into Kho (MaSP,TenSP,LoaiSP,MaNcc,TenNcc,SoLuong) values ('" + cobTenSP.SelectedValue + "',N'" + cobTenSP.Text + "',N'" + cobLoaiSP.Text + "','" + cobNhaCC.SelectedValue + "',N'" + cobNhaCC.Text + "','" + txtSoLuong.Texts.Trim() + "')";

						}
					}
					if (conn.State == ConnectionState.Closed) { conn.Open(); }

					SqlCommand cmd = new SqlCommand(them, conn);
					cmd.ExecuteNonQuery();
					getdataKho();
					if (conn.State == ConnectionState.Open) { conn.Close(); }
					managementITF("Reset");
					txtGiaNhap.Texts = "";
					txtSoLuong.Texts = "";
					txtTim.Texts = "";
					
				}
				else
				{
					MessageBox.Show("Không có dữ liệu!!!");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Bạn Chưa Nhập Đủ Dữ Liệu");
				return;
			}
		}
		public void managementITF(string state)
		{
			switch (state)
			{
				case "Reset":
					btnHuy.Enabled = false;
					btnLuu.Enabled = false;
					btnSua.Enabled = true;
					btnThem.Enabled = true;
					btnXoa.Enabled = true;

					txtDonvi.Enabled = false;
					txtGiaNhap.Enabled = false;
					txtSoLuong.Enabled = false;
					txtXuatXu.Enabled = false;

					cobLoaiSP.Enabled = false;
					cobNhaCC.Enabled = false;
					cobTenSP.Enabled = false;
					
					dobNgayNhap.Enabled = false;
					break;
				case "Insert":
					btnHuy.Enabled = true;
					btnLuu.Enabled = true;
					btnSua.Enabled = false;
					btnThem.Enabled = false;
					btnXoa.Enabled = false;

					txtDonvi.Enabled = false;
					txtGiaNhap.Enabled = true;
					txtSoLuong.Enabled = true;
					txtXuatXu.Enabled = true;

					cobLoaiSP.Enabled = false;
					cobNhaCC.Enabled = true;
					cobTenSP.Enabled = true;

					dobNgayNhap.Enabled = true;
					break;
				case "Edit":
					btnHuy.Enabled = true;
					btnLuu.Enabled = true;
					btnSua.Enabled = false;
					btnThem.Enabled = false;
					btnXoa.Enabled = false;

					txtDonvi.Enabled = true;
					txtGiaNhap.Enabled = true;
					txtSoLuong.Enabled = false;
					txtXuatXu.Enabled = false;

					cobLoaiSP.Enabled = false;
					cobNhaCC.Enabled = true;
					cobTenSP.Enabled = true;

					dobNgayNhap.Enabled = true;
					break;
				case "Delete":
					btnHuy.Enabled = true;
					btnLuu.Enabled = true;
					btnSua.Enabled = false;
					btnThem.Enabled = false;
					btnXoa.Enabled = false;

					txtDonvi.Enabled = false;
					txtGiaNhap.Enabled = false;
					txtSoLuong.Enabled = false;
					txtXuatXu.Enabled = false;

					cobLoaiSP.Enabled = false;
					cobNhaCC.Enabled = false;
					cobTenSP.Enabled = false;

					dobNgayNhap.Enabled = false;
					break;

			}

		}

		public void Insertdata()
		{
			try
			{
				if (conn.State == ConnectionState.Closed) { conn.Open(); }
				string them = "insert into NhapHangHoa (TenSP,LoaiSP,MaNcc,XuatXu,GiaNhap,SoLuong,Donvi,NgayNhap,MaSP,TenNcc) values (N'" + cobTenSP.Text + "',N'" + cobLoaiSP.Text + "',N'" + cobNhaCC.SelectedValue.ToString() + "',N'" + txtXuatXu.Texts + "','" + txtGiaNhap.Texts + "','" + txtSoLuong.Texts + "',N'" + txtDonvi.Texts + "','" + dobNgayNhap.Value.ToString("MM/dd/yyyy") + "',N'" + cobTenSP.SelectedValue.ToString() + "',N'" + cobNhaCC.Text + "')";
				SqlCommand cmd = new SqlCommand(them, conn);
				cmd.ExecuteNonQuery();
				if (conn.State == ConnectionState.Open) { conn.Close(); }
				getdata();
				MessageBox.Show("Thêm Thành Công !!", "Thông Báo");
				managementITF("Reset");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bạn nhập chưa đúng kiểu dữ liệu vui lòng nhập lại");
				txtGiaNhap.Focus();
			}
		}

		public void Editdata()
		{

			try
			{
				if (conn.State == ConnectionState.Closed) { conn.Open(); }
				string sua = "update NhapHangHoa set MaSP='" + cobTenSP.ValueMember + "',TenSP='" + cobTenSP.DisplayMember + "',LoaiSP='" + cobLoaiSP + "',MaNcc='" + cobNhaCC.SelectedValue.ToString() + "',XuatXu='" + txtXuatXu.Texts + "',GiaNhap='" + txtGiaNhap.Texts + "',SoLuong ='" + txtSoLuong.Texts + "',Donvi='" + txtDonvi.Texts + "',NgayNhap='" + dobNgayNhap.Value.ToString("MM/dd/yyyy") + "' where MaGD = '" + lblMaGD.Text + "'";
				SqlCommand cmd = new SqlCommand(sua, conn);
				cmd.ExecuteNonQuery();
				if (conn.State == ConnectionState.Open) { conn.Close(); }
				getdata();
				MessageBox.Show("Cập Nhật Thành Công !!", "Thông Báo");
				managementITF("Reset");

			}
			catch (Exception)
			{
				MessageBox.Show("Bạn Hãy Chọn Dữ Liệu Muốn Sửa!!!", "Thông Báo", MessageBoxButtons.OK);
				dataGridView1.Focus();
			}
		}
		public void Deletedata()
		{
			try
			{
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
				if (result == DialogResult.No)
				{
					return;
				}

				if (conn.State == ConnectionState.Closed) { conn.Open(); }
				string xoa = "delete  NhapHangHoa where MaGD = '" + lblMaGD.Text.ToString() + "'";
				SqlCommand cmd = new SqlCommand(xoa, conn);
				cmd.ExecuteNonQuery();
				if (conn.State == ConnectionState.Open) { conn.Close(); }
				getdata();
				MessageBox.Show("Xóa Dữ Liệu Thành Công !!", "Thông Báo");
				managementITF("Reset");
			}
			catch (Exception)
			{
				MessageBox.Show("Bạn Hãy Chọn Dữ Liệu Muốn Xóa !!!", "Thông Báo", MessageBoxButtons.OK);
				dataGridView1.Focus();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			state = "Insert";
			managementITF(state);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			state = "Edit";
			managementITF(state);
		}
		private void vbButton6_Click(object sender, EventArgs e)
		{
			if(lblMaGD.Text == "")
			{
				MessageBox.Show("Bạn Hãy Chọn Dữ Liệu Muốn Xóa Ở Bảng!!!", "Thông Báo", MessageBoxButtons.OK);
				dataGridView1.Focus();
				return;
			}
			else
			{
				managementITF("Delete");
			}
			
		}
		private void btnHuy_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn Trở Lại ??", "Confirm", MessageBoxButtons.OK);
			if (result == DialogResult.OK)
			{
				managementITF("Reset");
			}
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			if(state == "Insert")
			{
				UpdatedataKho();
				Insertdata();
				
			}
			else if(state == "Edit")
			{
				Editdata();
			}
			else
			{
				Deletedata();
			}
		}
		

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index;
			index = dataGridView1.CurrentRow.Index;
			cobTenSP.Text = dataGridView1.Rows[index].Cells[1].Value.ToString(); //teensp
			cobLoaiSP.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();//loaisp
			cobNhaCC.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();//tenNcc
			txtXuatXu.Texts = dataGridView1.Rows[index].Cells[5].Value.ToString();//xuatxu
			txtGiaNhap.Texts = dataGridView1.Rows[index].Cells[6].Value.ToString();//gianhap
			txtSoLuong.Texts = dataGridView1.Rows[index].Cells[7].Value.ToString();//soluong
			txtDonvi.Texts = dataGridView1.Rows[index].Cells[8].Value.ToString();
			dobNgayNhap.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
			lblMaGD.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			dataGridView2.Visible = false;
			if (conn.State == ConnectionState.Closed) { conn.Open(); }
			DataSet ds = new DataSet();
			string query = "Select * from NhapHangHoa where TenSP like N'%"+txtTim.Texts.Trim()+"%' or NgayNhap = '"+dobNgayNhap.Value.ToString("MM/dd/yyyy")+"'";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void label12_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void vbButton1_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = true;
			dataGridView2.Visible = false;
			if (conn.State == ConnectionState.Closed) { conn.Open(); }
			DataSet ds = new DataSet();
			string query = "Select * from NhapHangHoa where SoLuong > 22";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void btnTonKho_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = false;
			dataGridView2.Visible = true;
		}

		private void vbButton1_Click_1(object sender, EventArgs e)
		{
			dataGridView1.Visible = true;
			dataGridView2.Visible = false;
			getdata();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtXuatXu__TextChanged(object sender, EventArgs e)
		{

			
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		
	}
}
