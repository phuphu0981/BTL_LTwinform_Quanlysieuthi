using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL
{
    public partial class frmLoaihh : Form
    {
        string ConnectionString = @"Data Source = LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon ; Integrated Security = true ";

		DataSet ds = new DataSet();
        string State;
        string Type;
       
        public frmLoaihh()
        {
            InitializeComponent();
            State = "Reset";
            ManagerInterface(State);
            GetLoaiSP();
            GetData();


        }

        private void frmLoaihh_Load(object sender, EventArgs e)
        {
            txtType.Text = ds.Tables[0].Rows[0]["LoaiSP"].ToString();
            txtCondi.Text = ds.Tables[0].Rows[0]["BaoQuan"].ToString();
            txtStore.Text = ds.Tables[0].Rows[0]["ViTriBaoQuan"].ToString();
            txtDisplay.Text = ds.Tables[0].Rows[0]["ViTriTrungBay"].ToString();
        }

        public void ManagerInterface(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnOut.Enabled = true;

                    txtType.Enabled = false;
                    txtCondi.Enabled = false;
                    txtStore.Enabled = false;
                    txtDisplay.Enabled = false;

                    txtType.Text = "";
                    txtCondi.Text = "";
                    txtStore.Text = "";
                    txtDisplay.Text = "";
                    txtType.Focus();

                    break;

                case "Add":
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnOut.Enabled = true;

                    txtType.Enabled = true;
                    txtCondi.Enabled = true;
                    txtStore.Enabled = true;
                    txtDisplay.Enabled = true;

                    txtType.Text = "";
                    txtCondi.Text = "";
                    txtStore.Text = "";
                    txtDisplay.Text = "";
                    txtType.Focus();

                    break;

                case "Edit":
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnOut.Enabled = true;

                    txtType.Enabled = false;
                    txtCondi.Enabled = true;
                    txtStore.Enabled = true;
                    txtDisplay.Enabled = true;

                    txtType.Text = "";
                    txtCondi.Text = "";
                    txtStore.Text = "";
                    txtDisplay.Text = "";
                    txtType.Focus();

                    break;

                case "Delete":
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnOut.Enabled = true;

                    txtType.Enabled = true;
                    txtCondi.Enabled = false;
                    txtStore.Enabled = false;
                    txtDisplay.Enabled = false;

                    txtType.Text = "";
                    txtCondi.Text = "";
                    txtStore.Text = "";
                    txtDisplay.Text = "";
                    txtType.Focus();

                    break;
            }
        }

        public void GetData()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string query = "SELECT * FROM tblLoaiSP";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            dgvMain.DataSource = ds.Tables[0];
            con.Close();

            lblTotal.Text = "Cửa hàng đang kinh doanh " + ds.Tables[0].Rows.Count + " loại sản phẩm";
        }

        public void GetDataByType(string Type)
        {
            

            SqlConnection con = new SqlConnection(ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string query = "SELECT * FROM tblHangHoa where LoaiSP = N'"+Type+"' ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            dgv2.DataSource = ds.Tables[0];
            con.Close();

            lblTotal.Text = "Cửa hàng đang kinh doanh " + ds.Tables[0].Rows.Count + " mặt hàng " + cboLoai.SelectedValue;
        }

        public void GetLoaiSP()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string query = "select * from tblLoaiSP";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();

            cboLoai.DisplayMember = "LoaiSP";
            cboLoai.ValueMember = "LoaiSP";
            cboLoai.DataSource = ds.Tables[0];
            cboLoai.SelectedIndex = -1;
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvMain.CurrentRow.Index;

            txtType.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
            txtCondi.Text = dgvMain.Rows[i].Cells[2].Value.ToString();
            txtStore.Text = dgvMain.Rows[i].Cells[3].Value.ToString();
            txtDisplay.Text = dgvMain.Rows[i].Cells[4].Value.ToString();
        }

        public void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add();

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
					if (dr["LoaiSP"].ToString() == txtType.Text)
					{
						MessageBox.Show("Loại sản phẩm đã tồn tại");
						return;
						break;
					}
				}
				string query = "insert into tblLoaiSP values ( N'" + txtType.Text+"' , N'"+txtCondi.Text+"' , N'"+txtStore.Text+"' , N'"+txtDisplay.Text+"'  )   ";

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

                string query = "update tblLoaiSP set  BaoQuan = N'" + txtCondi.Text+ "' , ViTriBaoQuan = N'" + txtStore.Text+ "' , ViTriTrungBay = N'" + txtDisplay.Text+"' where LoaiSP = N'"+txtType.Text+"' ";

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

                string query = " delete from tblLoaiSP where LoaiSP = N'" + txtType.Text + "' ";
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
        private void btnUndo_Click_1(object sender, EventArgs e)
        {
            cboLoai.SelectedIndex = -1;
            dgv2.Visible = false;
            GetData();
            lblTotal.Text = "Cửa hàng đang kinh doanh " + ds.Tables[0].Rows.Count + " loại sản phẩm";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(State == "Add")
            {
                if(txtType.Text == "" || txtCondi.Text == "" || txtStore.Text == "" || txtDisplay.Text == "")
                {
                    MessageBox.Show("Thiếu dữ liệu");
                    return;
                }
                InsertData();
            }
            else if(State == "Edit")
            {
                if (txtType.Text == "" || txtCondi.Text == "" || txtStore.Text == "" || txtDisplay.Text == "")
                {
                    MessageBox.Show("Thiếu dữ liệu");
                    return;
                }
               EditData();
            }
            else
            {
                DeleteData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            State = "Reset";
            ManagerInterface(State);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoai.SelectedIndex != -1)
            {
                Type = cboLoai.SelectedValue.ToString();
                GetDataByType(Type);
                dgv2.Visible = true;
            }
            else
            {
                dgv2.Visible =false; 
            }
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

        
    }
}
