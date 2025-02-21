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
    public partial class frmHangHoa : Form
    {
        string ConnectionString = @"Data Source = LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon ; Integrated Security = true ";
        DataSet ds = new DataSet();
        string State;
        string tk;


        public frmHangHoa()
        {
            InitializeComponent();
            State = "Reset";
            ManagerInterface(State);
            GetNhaCungCap();
            GetLoaiSP();
            GetData();
            
        }

       
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            //txtMaSP.Text = ds.Tables[0].Rows[0][0].ToString();
            //txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            //cboLoai.Text = ds.Tables[0].Rows[0][2].ToString();
            //cboNcc.SelectedValue = ds.Tables[0].Rows[0][3].ToString();
            //txtXuatXu.Text = ds.Tables[0].Rows[0][4].ToString();
            //txtIn.Text = ds.Tables[0].Rows[0][5].ToString();
            //txtOut.Text = ds.Tables[0].Rows[0][6].ToString();
            //txtSL.Text = ds.Tables[0].Rows[0][7].ToString();
            //dtpHsd.Text = ds.Tables[0].Rows[0][8].ToString();
            //txtDv.Text = ds.Tables[0].Rows[0][9].ToString();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
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

                    txtMaSP.Enabled = false;
                    txtName.Enabled = false;
                    cboLoai.Enabled = false;
                    cboNcc.Enabled = false;
                    txtXuatXu.Enabled = false;
                    txtIn.Enabled = false;
                    txtOut.Enabled = false;
                    txtSL.Enabled = false;
                    txtDv.Enabled = false;
                    dtpHsd.Enabled = false;

                    txtMaSP.Text = "";
                    txtName.Text = "";
                    cboLoai.Text = "";
                    cboNcc.Text = "";
                    txtXuatXu.Text = "";
                    txtIn.Text = "";
                    txtOut.Text = "";
                    txtSL.Text = "";
                    txtDv.Text = "";
                    dtpHsd.Text = DateTime.Now.ToString();
                    txtMaSP.Focus();

                    break;

                case "Add":
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnOut.Enabled = true;

                    txtMaSP.Enabled = true;
                    txtName.Enabled = true;
                    cboLoai.Enabled = true;
                    cboNcc.Enabled = true;
                    txtXuatXu.Enabled = true;
                    txtIn.Enabled = true;
                    txtOut.Enabled = true;
                    txtSL.Enabled = true;
                    txtDv.Enabled = true;
                    dtpHsd.Enabled = true;

                    txtMaSP.Text = "";
                    txtName.Text = "";
                    cboLoai.Text = "";
                    cboNcc.Text = "";
                    txtXuatXu.Text = "";
                    txtIn.Text = "";
                    txtOut.Text = "";
                    txtSL.Text = "";
                    txtDv.Text = "";
                    dtpHsd.Text = DateTime.Now.ToString();
                    txtMaSP.Focus();

                    break;

                case "Edit":
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnOut.Enabled = true;

                    txtMaSP.Enabled = false;
                    txtName.Enabled = true;
                    cboLoai.Enabled = true;
                    cboNcc.Enabled = true;
                    txtXuatXu.Enabled = true;
                    txtIn.Enabled = true;
                    txtOut.Enabled = true;
                    txtSL.Enabled = true;
                    txtDv.Enabled = true;
                    dtpHsd.Enabled = true;

                    txtMaSP.Text = "";
                    txtName.Text = "";
                    cboLoai.Text = "";
                    cboNcc.Text = "";
                    txtXuatXu.Text = "";
                    txtIn.Text = "";
                    txtOut.Text = "";
                    txtSL.Text = "";
                    txtDv.Text = "";
                    dtpHsd.Text = DateTime.Now.ToString();
                    txtName.Focus();

                    break;

                case "Delete":
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnOut.Enabled = true;

                    txtMaSP.Enabled = true;
                    txtName.Enabled = false;
                    cboLoai.Enabled = false;
                    cboNcc.Enabled = false;
                    txtXuatXu.Enabled = false;
                    txtIn.Enabled = false;
                    txtOut.Enabled = false;
                    txtSL.Enabled = false;
                    txtDv.Enabled = false;
                    dtpHsd.Enabled = false;

                    txtMaSP.Text = "";
                    txtName.Text = "";
                    cboLoai.Text = "";
                    cboNcc.Text = "";
                    txtXuatXu.Text = "";
                    txtIn.Text = "";
                    txtOut.Text = "";
                    txtSL.Text = "";
                    txtDv.Text = "";
                    dtpHsd.Text = DateTime.Now.ToString();
                    txtName.Focus();

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

            string query = "SELECT * FROM tblHangHoa";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            dgvMain.DataSource = ds.Tables[0];
            con.Close();

            lblTotal.Text = "Tổng số " + ds.Tables[0].Rows.Count + " sản phẩm" ;
        }

        public void TimKiemSP(string tk)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT * FROM tblHangHoa where TenSP = N'" + tk + "' ";

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
        }

        public void GetNhaCungCap()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string query = "select * from tblNcc";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();

            cboNcc.DisplayMember = "TenNcc";
            cboNcc.ValueMember = "MaNcc";
            cboNcc.DataSource = ds.Tables[0];
            
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
					if (dr["MaSP"].ToString() == txtMaSP.Text)
					{
                        MessageBox.Show("Mã sản phẩm đã tồn tại");
                        return;
                        break;
					}
				}

				string query = "insert into tblHangHoa (MaSP,TenSP,LoaiSP,MaNcc,XuatXu,GiaNhap,GiaXuat,SoLuong,HanSuDung,Donvi) values ( '" + txtMaSP.Text + "'  , N'" + txtName.Text + "' , N'" + cboLoai.SelectedValue + "' , N'" + cboNcc.SelectedValue + "' , N'" + txtXuatXu.Text + "' " +
                    " , '" + txtIn.Text + "' , '" + txtOut.Text + "' , '" + txtSL.Text + "' , '" + dtpHsd.Value.ToString("MM/dd/yyyy") + "' , N'" + txtDv.Text + "'   )   ";

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
                int sl_them = Convert.ToInt32(txtSL.Text);
                
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Lấy tất cả dữ liệu ở bảng hàng hóa (trên kệ hiện có)
                string query = "SELECT * FROM tblHangHoa";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dgvMain.DataSource = ds.Tables[0];

				int sl_hientai1 = 0;
				foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["MaSP"].ToString() == txtMaSP.Text)
                    {
                        sl_hientai1 = Convert.ToInt32(dr["SoLuong"].ToString()) ;
                        break;
                    }
                }

                //lấy số lượng hàng hóa trong kho
				int sl_hientai2 = 0;
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				string query3 = "SELECT * FROM Kho";

				SqlCommand cmd3 = new SqlCommand(query3, con);
				da = new SqlDataAdapter(cmd3);
				ds = new DataSet();
				da.Fill(ds);
				dgvMain.DataSource = ds.Tables[0];
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					if (dr["MaSP"].ToString() == txtMaSP.Text)
					{
						sl_hientai2 = Convert.ToInt32(dr["SoLuong"].ToString());
						break;
					}
				}
				if (sl_hientai2 < sl_them)
				{
					GetData();
					MessageBox.Show("Số lượng trong kho không đủ");
					return;
				}


				//update số lượng trên kệ = số lượng trên kệ hiện có + số lượng lấy trong kho
				int sl_trenke = sl_them + sl_hientai1;

                string query2 = "update tblHangHoa set TenSP = N'" + txtName.Text + "' , LoaiSP = N'" + cboLoai.SelectedValue + "' , MaNcc = N'" + cboNcc.SelectedValue + "' " +
                    " , XuatXu = N'" + txtXuatXu.Text + "' , GiaNhap = '" + txtIn.Text + "' , GiaXuat = '" + txtOut.Text + "' , SoLuong = '"+sl_trenke.ToString()+"' , HanSuDung = '" + dtpHsd.Value.ToString("MM/dd/yyyy") + "' " +
                    " , DonVi = N'" + txtDv.Text + "' where MaSP = '" + txtMaSP.Text + "'  ";

                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Lấy hàng thành công.");
                GetData();

                // update số lượng trong kho = số lượng có - số lượng vừa lấy
                int sl_kho = sl_hientai2 - sl_them;

                string query4 = "update Kho set SoLuong = '"+sl_kho.ToString()+ "' where MaSP = '" + txtMaSP.Text + "'  ";
				SqlCommand cmd4 = new SqlCommand(query4, con);
				cmd4.ExecuteNonQuery();
				con.Close();
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

                string query = " delete from tblHangHoa where MaSP = '" + txtMaSP.Text + "' ";
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

            for(int i=0;i<dgvMain.Columns.Count;i++)
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
		private void btnExcel_Click(object sender, EventArgs e)
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
                if (txtMaSP.Text == "" || txtName.Text == "" || txtSL.Text == "" || txtXuatXu.Text == "" ||
                txtIn.Text == "" || txtOut.Text == "" || txtDv.Text == "" || dtpHsd.Text == ""
                || cboLoai.SelectedValue == "" || cboNcc.SelectedValue == "")
                {
                    MessageBox.Show("Thiếu dữ liệu");
                    return;
                }
                int id;
                if (Int32.TryParse(txtMaSP.Text, out id) == false)
                {
                    MessageBox.Show("Sai định dạng mã sản phẩm");
                    return;
                }
                InsertData();
            }
            else if(State == "Edit")
            {
                if (txtMaSP.Text == "" || txtName.Text == "" || txtSL.Text == "" || txtXuatXu.Text == "" ||
                txtIn.Text == "" || txtOut.Text == "" || txtDv.Text == "" || dtpHsd.Text == ""
                || cboLoai.SelectedValue == "" || cboNcc.SelectedValue == "")
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
        private void btnUndo_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            tk = txtTk.Text;
            TimKiemSP(tk);
        }

       

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaSP.Text = dgvMain.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvMain.CurrentRow.Cells[1].Value.ToString();
            cboLoai.Text = dgvMain.CurrentRow.Cells[2].Value.ToString();
            cboNcc.SelectedValue = dgvMain.CurrentRow.Cells[3].Value.ToString();
            txtXuatXu.Text = dgvMain.CurrentRow.Cells[4].Value.ToString();
            txtIn.Text = dgvMain.CurrentRow.Cells[5].Value.ToString();
            txtOut.Text = dgvMain.CurrentRow.Cells[6].Value.ToString();
            txtSL.Text = dgvMain.CurrentRow.Cells[7].Value.ToString();
            dtpHsd.Text = dgvMain.CurrentRow.Cells[8].Value.ToString();
            txtDv.Text = dgvMain.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
