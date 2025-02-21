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
using System.Reflection;
using System.DirectoryServices.ActiveDirectory;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using OfficeOpenXml;

namespace BTL
{
	public partial class QLTK : Form
	{
		SqlConnection conn;
		string role;
		public QLTK()
		{
			InitializeComponent();
			conn= new SqlConnection("Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True");
		}

		private void QLTK_Load(object sender, EventArgs e)
		{
			lblEmai.Text = "";
			lblLoaiTK.Text = "";
			lblLoaiTKNV.Text = "";
			lblMK.Text = "";
			lblMKNV.Text = "";
			lblName.Text = "";
			lblnameNv.Text = "";
			lblSdt.Text = "";
			lblTenTK.Text = "";
			lblTenTKNV.Text = "";
			dgvDuyet.Visible = true;
			dgvTK.Visible = false;
			grbTK.Visible = false;
			grbDuyet.Visible = true;
			getdataDuyet();
			getdataDuyet();
		}
		public void getdata()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			DataSet ds = new DataSet();
			string query = "Select * from Tai_Khoan";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dgvTK.DataSource = ds.Tables[0];
			conn.Close();
		}
		public void getdataDuyet()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			DataSet ds = new DataSet();
			string query = "Select * from XacNhanTK";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dgvDuyet.DataSource = ds.Tables[0];
			conn.Close();
		}
		public void Deletedata()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query = "delete from XacNhanTK where Hoten = N'"+lblName.Text+"' and Ten_TK = N'"+lblTenTK.Text+"' ";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.ExecuteNonQuery();
			getdataDuyet();
		}
		public void DeletedataNV()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query = "delete from Tai_Khoan where Ten_tk = N'" + lblTenTKNV.Text + "' ";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.ExecuteNonQuery();
			getdata();
		}
		public void Duyetdata()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query = "Insert into XacNhanTK where Hoten = N'" + lblName.Text + "' ";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.ExecuteNonQuery();
			getdataDuyet();
		}
		private void QLTK_FormClosed(object sender, FormClosedEventArgs e)
		{
			Trangchu trangchu = new Trangchu();
			trangchu.Show();
			this.Hide();
		}

		public void ExportExcel(string path)
		{
			Excel.Application application = new Excel.Application();
			application.Application.Workbooks.Add(Type.Missing);

			for (int i = 0; i < dgvTK.Columns.Count; i++)
			{
				application.Cells[1, i + 1] = dgvTK.Columns[i].HeaderText;
			}

			for (int i = 0; i < dgvTK.Rows.Count; i++)
			{
				for (int j = 0; j < dgvTK.Columns.Count; j++)
				{
					application.Cells[i + 2, j + 1] = dgvTK.Rows[i].Cells[j].Value;

				}
			}

			application.Columns.AutoFit();
			application.ActiveWorkbook.SaveCopyAs(path);
			application.ActiveWorkbook.Saved = true;

		}
		public void ExportExceltk(string path)
		{
			Excel.Application application = new Excel.Application();
			application.Application.Workbooks.Add(Type.Missing);

			for (int i = 0; i < dgvDuyet.Columns.Count; i++)
			{
				application.Cells[1, i + 1] = dgvDuyet.Columns[i].HeaderText;
			}

			for (int i = 0; i < dgvDuyet.Rows.Count; i++)
			{
				for (int j = 0; j < dgvDuyet.Columns.Count; j++)
				{
					application.Cells[i + 2, j + 1] = dgvDuyet.Rows[i].Cells[j].Value;

				}
			}

			application.Columns.AutoFit();
			application.ActiveWorkbook.SaveCopyAs(path);
			application.ActiveWorkbook.Saved = true;

		}
		private void btnXuatTK_Click_1(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Export Excel";
			saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					ExportExcel(saveFileDialog.FileName);
					MessageBox.Show("Xuất file thành công");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Xuất không thành công\n" + ex.Message);
				}
			}
		}
		private void vbButton1_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Export Excel";
			saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					ExportExceltk(saveFileDialog.FileName);
					MessageBox.Show("Xuất file thành công");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Xuất không thành công\n" + ex.Message);
				}
			}
		}

		

		private void btnDuyet_Click_1(object sender, EventArgs e)
		{			
				dgvDuyet.Visible = true;
				dgvTK.Visible = false;
				grbDuyet.Visible = true;
				grbTK.Visible = false;
				getdata();	
		}
		private void btnShowTK_Click_1(object sender, EventArgs e)
		{
			dgvDuyet.Visible = false;
			dgvTK.Visible = true;
			grbDuyet.Visible = false;
			grbTK.Visible = true;
			getdataDuyet();
			getdata();
		}
		private void btnThoat_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDuyetTk_Click(object sender, EventArgs e)
		{
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				string loai = null;
				if (lblLoaiTK.Text == "Nhân Viên")
				{
					loai = "0";
				}
				else if (lblLoaiTK.Text == "ADMIN")
				{
					loai = "1";
				}
				else if (lblLoaiTK.Text == "Quản Lý")
				{
					loai = "2";
				}
				else
				{
					MessageBox.Show("Bạn chưa chọn tài khoản để phê duyệt. Vui lòng chọn Tài Khoản !!!");
					dgvDuyet.Focus();
				}
				string Duyet = "insert into Tai_Khoan (Ten_tk,Mat_Khau,Loai_TK,Hoten) values (N'" + lblTenTK.Text + "','" + lblMK.Text + "','" + loai + "',N'" + lblName.Text + "')";
				SqlCommand cmd = new SqlCommand(Duyet, conn);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Tài Khoản đã được phê duyệt", "Thông báo", MessageBoxButtons.OK);
				Deletedata();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dgvTK_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
				int index;
				index = dgvTK.CurrentCell.RowIndex;
				lblTenTKNV.Text = dgvTK.Rows[index].Cells[0].Value.ToString();
				lblMKNV.Text = dgvTK.Rows[index].Cells[1].Value.ToString();
				if (dgvTK.Rows[index].Cells[2].Value.ToString() == "0")
				{
					lblLoaiTKNV.Text = "Nhân Viên";
				}
				else if (dgvTK.Rows[index].Cells[2].Value.ToString() == "1")
				{
					lblLoaiTKNV.Text = "ADMIN";
				}
				else
				{
					lblLoaiTKNV.Text = "Quản Lý";
				}
				lblnameNv.Text = dgvTK.Rows[index].Cells[3].Value.ToString();
		}

		private void dgvDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
		{	
				int index;
				index = dgvDuyet.CurrentCell.RowIndex;
				lblName.Text = dgvDuyet.Rows[index].Cells[0].Value.ToString();
				lblEmai.Text = dgvDuyet.Rows[index].Cells[1].Value.ToString();
				lblSdt.Text = dgvDuyet.Rows[index].Cells[2].Value.ToString();
				lblTenTK.Text = dgvDuyet.Rows[index].Cells[3].Value.ToString();
				lblMK.Text = dgvDuyet.Rows[index].Cells[4].Value.ToString();
				if (dgvDuyet.Rows[index].Cells[5].Value.ToString() == "0")
				{
					lblLoaiTK.Text = "Nhân Viên";
				}
				else if (dgvDuyet.Rows[index].Cells[5].Value.ToString() == "1")
				{
					lblLoaiTK.Text = "ADMIN";
				}
				else
				{
					lblLoaiTK.Text = "Quản Lý";
				}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
		
				
			if(lblTenTK.Text != "")
			{
				DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa không??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (result == DialogResult.OK)
				{
					Deletedata();
				}
				else
				{
					return;
				}
			}
			else
			{
				MessageBox.Show("Bạn chưa chọn tài khoản cần xóa!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
			}
			
		}

		private void btnXoaTKNV_Click(object sender, EventArgs e)
		{
			if(lblTenTKNV.Text != "")
			{
				DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa Tài Khoản này không Và Bạn Không Thể Khôi Phục??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (result == DialogResult.OK)
				{
					DeletedataNV();
				}
				else
				{
					return;
				}
			}
			else
			{
				MessageBox.Show("Bạn chưa chọn tài khoản cần xóa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}
		private void vbButton2_Click_1(object sender, EventArgs e)
		{

			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string search = "select * from XacNhanTK where Hoten like N'%" + txtSearch.Texts.Trim() + "%'";
			SqlCommand cmd = new SqlCommand(search, conn);
			cmd.ExecuteNonQuery();
			DataSet ds = new DataSet();
			SqlDataAdapter adt = new SqlDataAdapter(cmd);
			adt.Fill(ds);
			dgvDuyet.DataSource = ds.Tables[0];

			conn.Close();
		}
		private void btnTimNV_Click_1(object sender, EventArgs e)
		{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				string search = "select * from Tai_Khoan where Hoten like N'%" + txtTimNV.Texts.Trim() + "%'";
				SqlCommand cmd = new SqlCommand(search, conn);
				cmd.ExecuteNonQuery();
				DataSet ds = new DataSet();
				SqlDataAdapter adt = new SqlDataAdapter(cmd);
				adt.Fill(ds);
				dgvTK.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void QLTK_FormClosing(object sender, FormClosingEventArgs e)
		{
		
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
