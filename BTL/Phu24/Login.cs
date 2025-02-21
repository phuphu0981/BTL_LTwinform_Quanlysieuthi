using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
	public partial class Login : Form
	{
		
		//Khai báo
		string connectionString = "Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn
		SqlConnection conn;
		
		public Login()
		{
			InitializeComponent();
			lblError.Text = "";
		}
		private void Login_Load(object sender, EventArgs e)
		{
			txtTenTKhoan.Focus();
			this.FormBorderStyle = FormBorderStyle.None;
			this.FormBorderStyle = FormBorderStyle.FixedSingle; // Ngăn chặn thay đổi kích thước
			this.MaximizeBox = false; // Ẩn nút phóng to
			this.MinimizeBox = false; // Ẩn nút thu nhỏ
		}
		public string TestQuyen(string username, string password)
		{
			//hàm phân quyền loại tài khoản
			conn = new SqlConnection(connectionString);
			conn.Open();
			string query = "select Loai_TK From Tai_Khoan where Ten_tk = '" + username + "' and Mat_Khau = '" + password + "'";
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader reader = command.ExecuteReader();

			if (reader.Read())
			{
				string role = reader["Loai_TK"].ToString();
				return role;
			}
			return null;

		}
		
		public void vbButton1_Click(object sender, EventArgs e)
		{
			//kiểm tra xem textbox tài khoản và textbox mật khẩu đã nhận chưa
			if (txtTenTKhoan.Texts != null && txtTenTKhoan.Texts.Trim() != "") { }
			else
			{
				MessageBox.Show("Chưa nhập thông tin tài khoản", "Thông báo");
				txtTenTKhoan.Focus();
				return;
			}

			if (txtMatKhau.Texts != null && txtMatKhau.Texts.Trim() != "") { }
			else
			{
				MessageBox.Show("Chưa nhập thông tin mật khẩu", "Thông báo");
				txtMatKhau.Focus();
				return;
			}
			//Kiểm tra thông tin tài khoản so sánh với bảng tbltaiKhoan (trong du lieu)
			conn = new SqlConnection(connectionString);
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			string query = " SELECT * FROM Tai_Khoan WHERE Ten_tk = '" + txtTenTKhoan.Texts.Trim() + "' AND Mat_Khau = '" + txtMatKhau.Texts.Trim() + "'";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			da.Fill(ds);
			//kiếm tra quyền đăng nhập (admin/user) + có thể thêm quyền quản lý sau
			if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
			{
				conn.Close();
				string role = TestQuyen(txtTenTKhoan.Texts, txtMatKhau.Texts); //gọi hàm xét quyền
				if (role == "1")
				{
					//Quyen admin
					Trangchu trangchu = new Trangchu();
					trangchu.Show();
					trangchu.PhanQuyenAdmin();
					this.Hide();

				}
				else if (role == "0")
				{
					//quyen NV
					Trangchu trangchu = new Trangchu();
					trangchu.Show();
					trangchu.PhanQuyenNV();
					this.Hide();
				}
				else
				{
					//quyền quản lý
					Trangchu trangchu = new Trangchu();
					trangchu.PhanQuyenQuanLy();
					trangchu.Show();
					this.Hide();
				}
				this.Hide();
			}
			else
			{
				//khong tim thay
				lblError.Text = "Thông tin tài khoản hoặc mật khẩu chưa chính xác.";

			}



		}

		private void label4_Click_1(object sender, EventArgs e)
		{
			SignUp signUp = new SignUp();
			signUp.Show();
			this.Hide();
		}

		private void Login_FormClosed(object sender, FormClosedEventArgs e)
		{
			

		}

		

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
