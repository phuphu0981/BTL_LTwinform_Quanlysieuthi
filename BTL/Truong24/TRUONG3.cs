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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL
{
    public partial class frmNcc : Form
    {
        string ConnectionString = @"Data Source = LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon ; Integrated Security = true ";

		DataSet ds = new DataSet();
        string State;
        string Find = "";

        public frmNcc()
        {
            InitializeComponent();
            State = "Reset";
            ManagerInterface(State);
            GetData();
        }

        public void ManagerInterface(string State)
        {
            switch (State)
            {
                case "Reset":
                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    txtPN.Enabled = false;
                    txtAdd.Enabled = false;

                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;

                    txtID.Text = "";
                    txtName.Text = "";
                    txtPN.Text = "";
                    txtAdd.Text = "";
                    txtID.Focus();

                    break;

                case "Add":
                    txtID.Enabled = true;
                    txtName.Enabled = true;
                    txtPN.Enabled = true;
                    txtAdd.Enabled = true;

                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    txtID.Text = "";
                    txtName.Text = "";
                    txtPN.Text = "";
                    txtAdd.Text = "";
                    txtID.Focus();

                    break;

                case "Edit":
                    txtID.Enabled = false;
                    txtName.Enabled = true;
                    txtPN.Enabled = true;
                    txtAdd.Enabled = true;

                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    txtID.Text = "";
                    txtName.Text = "";
                    txtPN.Text = "";
                    txtAdd.Text = "";
                    txtName.Focus();

                    break;

                case "Delete":

                    txtID.Enabled = true;
                    txtName.Enabled = false;
                    txtPN.Enabled = false;
                    txtAdd.Enabled = false;

                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    txtID.Text = "";
                    txtName.Text = "";
                    txtPN.Text = "";
                    txtAdd.Text = "";
                    txtID.Focus();

                    break;

            }
        }
        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvMain.CurrentRow.Index;

            txtID.Text = dgvMain.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
            txtPN.Text = dgvMain.Rows[i].Cells[2].Value.ToString();
            txtAdd.Text = dgvMain.Rows[i].Cells[3].Value.ToString();
        }

        private void frmNcc_Load(object sender, EventArgs e)
        {
            txtID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPN.Text = ds.Tables[0].Rows[0][2].ToString();
            txtAdd.Text = ds.Tables[0].Rows[0][3].ToString();

        }

        public void GetData()
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string query = "SELECT * FROM tblNcc";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            dgvMain.DataSource = ds.Tables[0];
            con.Close();
            lblTotal.Text = "Tổng số " + ds.Tables[0].Rows.Count + " nhà cung cấp";
        }

        public void TimKiem(string Find)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT * FROM tblNcc where TenNcc = N'" + txtFind.Text + "' ";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dgvMain.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertData()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					if (dr["MaNcc"].ToString() == txtID.Text)
					{
						MessageBox.Show("Mã nhà cung cấp đã tồn tại");
						return;
						break;
					}
				}

				string query = "insert into tblNcc values ( '" + txtID.Text + "' , N'" + txtName.Text + "' , '" + txtPN.Text + "' , N'" + txtAdd.Text + "' )  ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm dữ liệu thành công.");
                GetData();

                State = "Reset";
                ManagerInterface(State);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void EditData()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "update tblNcc set TenNcc = N'" + txtName.Text + "' , Sdt = '" + txtPN.Text + "' , DiaChi = N'" + txtAdd.Text + "'  where MaNcc = '" + txtID.Text + "'   ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa dữ liệu thành công.");
                GetData();

                State = "Reset";
                ManagerInterface(State);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void DeleteData()
        {
            try
            {
                DialogResult result = MessageBox.Show("Dữ liệu đã xóa không thể khôi phục", "Xác nhận xóa?", MessageBoxButtons.YesNo);


                if (result == DialogResult.No)
                {
                    return;
                }
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "delete  from tblNcc  where MaNcc = '" + txtID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Xóa dữ liệu thành công.");
                GetData();

                State = "Reset";
                ManagerInterface(State);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dgvMain.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvMain.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvMain.Rows.Count; i++)
            {
                for (int j = 0; j < dgvMain.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvMain.Rows[i].Cells[j].Value;

                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            State = "Add";
            ManagerInterface(State);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            State = "Edit";
            ManagerInterface(State);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            State = "Delete";
            ManagerInterface(State);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(State == "Add")
            {

                if( txtID.Text == "" || txtName.Text == "" || txtPN.Text == "" || txtAdd.Text =="" )
                {
                    MessageBox.Show("Thiếu dữ liệu");
                    return;
                }
                InsertData();
            }
            else if(State == "Edit")
            {

                if (txtID.Text == "" || txtName.Text == "" || txtPN.Text == "" || txtAdd.Text == "")
                {
                    MessageBox.Show("Thiếu dữ liệu");
                    return;
                }
                EditData();
            }
            else
            {
                if (txtID.Text == "" )
                {
                    MessageBox.Show("Thiếu dữ liệu");
                    return;
                }

                DeleteData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            State = "Reset";
            ManagerInterface(State);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find = txtFind.Text;
            TimKiem(Find);
        }

        private void btnExport_Click(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            GetData();
        }

        
    }
}
