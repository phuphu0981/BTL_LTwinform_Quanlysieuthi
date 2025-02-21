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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BTL
{
    public partial class KHTT : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True");
        DataSet ds;
        string test = "Reset";
        
        public KHTT()
        {
            InitializeComponent();
            getdata();
            hien(test);

        }
       
        public void connopen()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }
        }
        public void connclose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();

            }
        }
        public void getdata()
        {
            connopen(); 
            string query = "select*from tblKH_ThanThiet ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds);
            dgvMain.DataSource = ds.Tables[0];
            connclose();
       
            DataColumn col = new DataColumn();
            col.ColumnName = "SEX";
            ds.Tables[0].Columns.Add(col);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr["GioiTinh"].ToString().Trim() == "1")
                {
                    dr["SEX"] = "Nam";
                }
                else
                {
                    dr["SEX"] = "Nu";
                }
            }
        }
        private void sua()
        {
            connopen();
            string gt;
            connopen();
            if (rdoNam.Checked)
            {
                gt = "1";
            }
            else
            {
                gt = "0";
            }
            string query = "update tblKH_ThanThiet set  HoTen = N'" + txtHoTen.Text + "' , GioiTinh = '" + gt + "' , NgaySinh = '" + dtpNgaySinh.Text + "' , NgayDangKi = '" + dtpNgayDangKi.Text + "' , MaKhachHang = '" + txtMaKhachHang.Text + "', TichDiem = '" + txtTichDiem.Text + "', SoDienThoai = '"+ txtSDT.Text +"' where MaKhachHang = N'" + txtMaKhachHang.Text + "'  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sua Thanh Cong");
            connclose();
            getdata();

        }
        private void xoa()
        {
            connopen();
            string query = "delete  from tblKH_ThanThiet where MaKhachHang='" + txtMaKhachHang.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoa Thanh Cong");
            connclose();
            getdata();
        }
        private void timkiem()
        {
            connopen();
            string query = "select*from tblKH_ThanThiet where HoTen='"+txtHoTen.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds);
            dgvMain.DataSource = ds.Tables[0];
            connclose();
            DataColumn col = new DataColumn();
            col.ColumnName = "SEX";
            ds.Tables[0].Columns.Add(col);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr["GioiTinh"].ToString().Trim() == "1")
                {
                    dr["SEX"] = "Nam";
                }
                else
                {
                    dr["SEX"] = "Nu";
                }
            }
            getdata();
        }
        private void them()
        {
            string gt;
            connopen();
            if (rdoNam.Checked == true)
            {
                gt = "1";
            }
            else
            {
                gt = "0";
            }

            string query = "insert into tblKH_ThanThiet values  ( N'" + txtHoTen.Text + "' , '" + gt + "' , '" + dtpNgaySinh.Value.ToString("MM/dd/yyyy") + "' , '" + dtpNgayDangKi.Value.ToString("MM/dd/yyyy") + "'  , '" + txtMaKhachHang.Text + "'  , N'" + txtTichDiem.Text + "' , '" + txtSDT.Text + "'   ) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            connclose();
            MessageBox.Show("Them Thanh Cong");
            getdata();
           
            

        }

        public void TruyXuat()
        {
            int i;
            i = dgvMain.CurrentRow.Index;
            txtHoTen.Text = dgvMain.Rows[i].Cells["HoTen"].Value.ToString();
            dtpNgaySinh.Text = dgvMain.Rows[i].Cells["NgaySinh"].Value.ToString();
            dtpNgayDangKi.Text = dgvMain.Rows[i].Cells["NgayDangKi"].Value.ToString();
            txtMaKhachHang.Text = dgvMain.Rows[i].Cells["MaKhachHang"].Value.ToString();
            txtTichDiem.Text = dgvMain.Rows[i].Cells["TichDiem"].Value.ToString();
            txtSDT.Text = dgvMain.Rows[i].Cells["SoDienThoai"].Value.ToString();

            if (dgvMain.Rows[i].Cells["GioiTinh"].Value.ToString() == "1")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }
        }

        public void hien(string test)
            {
                switch (test)
                {
                case "Reset":

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnTim.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    btnOK.Enabled = false;

                    txtHoTen.Enabled = false;
                    txtMaKhachHang.Enabled = false;
                    txtTichDiem.Enabled = false;
                 
                    txtSDT.Enabled = false;
                    txtTimKiem.Enabled = false;
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                    dtpNgayDangKi.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    dtpNgayDangKi.Text = DateTime.Now.ToString();
                    dtpNgaySinh.Text = DateTime.Now.ToString();

                    txtHoTen.Text = "";
                    txtMaKhachHang.Text = "";
                    txtTichDiem.Text = "";
         
                    txtTimKiem.Text = "";

                    txtHoTen.Focus();

                    break;

                case "Add":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = false;

                    txtHoTen.Enabled = true;
                    txtMaKhachHang.Enabled = true;
                    txtTichDiem.Enabled = true;
             
                    txtTimKiem.Enabled = false;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayDangKi.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    dtpNgayDangKi.Text = DateTime.Now.ToString();
                    dtpNgaySinh.Text = DateTime.Now.ToString();
                    txtSDT.Enabled = true;

                    txtHoTen.Text = "";
                    txtMaKhachHang.Text = "";
                    txtTichDiem.Text = "";
               
                    txtTimKiem.Text = "";

                    txtHoTen.Focus();

                    break;

                case "Edit":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = false;

                    txtHoTen.Enabled = true;
                    txtMaKhachHang.Enabled = true;
                    txtTichDiem.Enabled = true;

                    txtSDT.Enabled = true;
                    txtTimKiem.Enabled = false;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayDangKi.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    dtpNgayDangKi.Text = DateTime.Now.ToString();
                    dtpNgaySinh.Text = DateTime.Now.ToString();

                    txtHoTen.Text = "";
                    txtMaKhachHang.Text = "";
                    txtTichDiem.Text = "";
    
                    txtTimKiem.Text = "";

                    txtHoTen.Focus();

                    break;

                case "Delete":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = false;

                    txtHoTen.Enabled = true;
                    txtMaKhachHang.Enabled = true;
                    txtTichDiem.Enabled = true;
   
                    txtSDT.Enabled = true;
                    txtTimKiem.Enabled = false;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayDangKi.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    dtpNgayDangKi.Text = DateTime.Now.ToString();
                    dtpNgaySinh.Text = DateTime.Now.ToString();

                    txtHoTen.Text = "";
                    txtMaKhachHang.Text = "";
                    txtTichDiem.Text = "";

                    txtTimKiem.Text = "";

                    txtHoTen.Focus();

                    break;

                case "Rearch":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = true;

                    txtHoTen.Enabled = false;
                    txtMaKhachHang.Enabled = false;
                    txtTichDiem.Enabled = false;
  
                    txtTimKiem.Enabled = true;
                    txtSDT.Enabled = false;
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                    dtpNgayDangKi.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    dtpNgayDangKi.Text = DateTime.Now.ToString();
                    dtpNgaySinh.Text = DateTime.Now.ToString();

                    txtHoTen.Text = "";
                    txtMaKhachHang.Text = "";
                    txtTichDiem.Text = "";

                    txtTimKiem.Text = "";

                    txtHoTen.Focus();

                    break;          
            }
        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {
            hien("Add");
            test = "Add";
            txtHoTen.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hien("Edit");
            test = "Edit";
            txtMaKhachHang.Focus();
            TruyXuat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hien("Delete");
            test = "Delete";
            txtHoTen.Focus();
            TruyXuat();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            hien("Rearch");
            test = "Rearch";
            txtTimKiem.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (test == "Add")
            {
                them(); 
                hien("Reset");
            }
            else if (test == "Edit")
            {
                sua();
                hien("Reset");
            }
            else if (test == "Delete")
            {
                if (MessageBox.Show("Ban co muon xoa khong?", "Noi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    xoa();
                hien("Reset");
            }
            else if (test == "Rearch")
            {
                timkiem();
                hien("Reset");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hien("Reset");
            getdata();
        }



        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvMain.CurrentRow.Index;
            txtHoTen.Text = dgvMain.Rows[i].Cells["HoTen"].Value.ToString();
            dtpNgaySinh.Text = dgvMain.Rows[i].Cells["NgaySinh"].Value.ToString();
            dtpNgayDangKi.Text = dgvMain.Rows[i].Cells["NgayDangKi"].Value.ToString();
            txtMaKhachHang.Text = dgvMain.Rows[i].Cells["MaKhachHang"].Value.ToString();
            txtTichDiem.Text = dgvMain.Rows[i].Cells["TichDiem"].Value.ToString();
            txtSDT.Text = dgvMain.Rows[i].Cells["SoDienThoai"].Value.ToString();

            if (dgvMain.Rows[i].Cells["GioiTinh"].Value.ToString() == "1")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }
        } 

        private void btnOK_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "SoDienThoai", "*" + txtTimKiem.Text + "*");
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        
    }

    }

