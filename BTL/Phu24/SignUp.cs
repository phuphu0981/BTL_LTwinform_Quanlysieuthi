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
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.ComponentModel.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
	public partial class SignUp : Form
	{
		SqlConnection conn;
		
		
		public SignUp()
		{
			
			InitializeComponent();
			conn = new SqlConnection("Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True");
			conn.Open();
		}
		public void Reset()
		{
			txtEmail.Texts = "";
			txtMatKhau.Texts = "";
			txtMatKhau2.Texts = "";
			txtName.Texts = "";
			txtSdt.Texts = "";
			txtTenTK.Texts = "";
		}
		static bool IsValidEmail(string email)
		{			
			string TestEmail = @"^[a-zA-Z0-9]+@gmail.com$";
			return Regex.IsMatch(email, TestEmail);
		}
		static bool IsValiDSDT(string sdt)
		{			
			string Testsdt = @"^0\d{9}$";
			return Regex.IsMatch(sdt, Testsdt);
		}
		public bool IsNameValid(string name)
		{
			// Kiểm tra xem tên có chứa ký tự không
			if (string.IsNullOrWhiteSpace(name))
			{
				return false;
			}

			// Kiểm tra xem tên có chứa ký số hoặc ký tự đặc biệt không
			foreach (char c in name)
			{
				if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
				{
					return false;
				}
			}

			// Kiểm tra xem tên có chứa khoảng trắng liên tục không
			if (name.Trim().Split(' ').Length < 2) // ít nhất hai từ
			{
				return false;
			}

			return true;
		}
		private void txtName_Leave(object sender, EventArgs e)
		{
			if (IsNameValid(txtName.Texts) == false)
			{
				MessageBox.Show("Tên Không Hợp Lệ !!!", "Thông Báo");
				txtName.Focus();
				return;
			}
		}
		private void txtEmail_Leave(object sender, EventArgs e)
		{
			if (IsValidEmail(txtEmail.Texts) == false)
			{
				MessageBox.Show("Email Không Hợp Lệ !!!", "Thông Báo");
				txtEmail.Focus();
				return;
			}
		}

		private void txtSdt_Leave(object sender, EventArgs e)
		{
			if (IsValiDSDT(txtSdt.Texts) == false)
			{
				MessageBox.Show("Số Điện Thoại Không Hợp Lệ !!!", "Thông Báo");
				txtSdt.Focus();
				return;
			}
		}

		private void SignUp_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			this.MaximizeBox = false; // Ẩn nút phóng to
			this.MinimizeBox = false; // Ẩn nút thu nhỏ
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Aqua, 5, ButtonBorderStyle.Solid, Color.Aqua, 5, ButtonBorderStyle.Solid, Color.Aqua, 5, ButtonBorderStyle.Solid, Color.Aqua, 5, ButtonBorderStyle.Solid);
		}

		private void lblDangnhap_Click(object sender, EventArgs e)
		{
			Login form1 = new Login();
			form1.Show();
			this.Close();
		}

	
		private void label9_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Close();
		}

		private void btnDangki_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtName.Texts.Trim() == "")
				{
					MessageBox.Show("Chưa nhập Tên", "Thông Báo");
					txtName.Focus();
					return;
				}
				if (txtEmail.Texts.Trim() == "")
				{
					MessageBox.Show("Bạn chưa nhập Email", "Thông Báo");
					txtEmail.Focus();
					return;
				}


				if (txtSdt.Texts.Trim() == "")
				{
					MessageBox.Show("Bạn chưa nhập Số Điện Thoại", "Thông Báo");
					txtSdt.Focus();
					return;
				}

				if (txtTenTK.Texts.Trim() == "")
				{
					MessageBox.Show("Bạn chưa nhập Tên Tài Khoản", "Thông Báo");
					txtTenTK.Focus();
					return;
				}
				if (txtMatKhau.Texts.Trim() == "")
				{
					MessageBox.Show("Bạn chưa nhập Mật Khẩu", "Thông Báo");
					txtMatKhau.Focus();
					return;
				}
				if (txtMatKhau2.Texts.Trim() == "")
				{
					MessageBox.Show("Bạn chưa nhập lại Mật Khẩu", "Thông Báo");
					return;
				}
				if (txtMatKhau.Texts != txtMatKhau2.Texts)
				{
					MessageBox.Show("Mật Khẩu Nhập Lại chưa đúng", "Thông Báo");
					txtMatKhau2.Focus();
					return;
				}
				string loai = null;
				if (rdoAdmin.Checked == true) { loai = "1"; }
				else if (rdoNhanvien.Checked == true) { loai = "0"; }
				else { loai = "2"; }

				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}

				DataSet ds = new DataSet();
				string query = "Select Ten_tk from Tai_Khoan";
				SqlCommand cmd1 = new SqlCommand(query, conn);
				SqlDataAdapter adt = new SqlDataAdapter(cmd1);
				adt.Fill(ds);
				if (ds.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow dr1 in ds.Tables[0].Rows)
					{
						if (dr1["Ten_tk"].ToString() == txtTenTK.Texts)
						{
							MessageBox.Show("Tên Tài Khoản Đã Tồn Tại");
							txtTenTK.Texts = "";
							txtTenTK.Focus();
							return;
						}

					}

					string them = "Insert into XacNhanTK (Hoten,email,sdt,Ten_TK,MatKhau,LoaiTK) values (N'" + txtName.Texts.Trim() + "','" + txtEmail.Texts.Trim() + "','" + txtSdt.Texts.Trim() + "','" + txtTenTK.Texts.Trim() + "','" + txtMatKhau.Texts.Trim() + "','" + loai + "')";
					SqlCommand cmd = new SqlCommand(them, conn);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Tài Khoản của bạn đang chờ được duyệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
					Reset();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void txtEmail__TextChanged(object sender, EventArgs e)
		{

		}

		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		

		private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
			}
		}

		
	}
}
