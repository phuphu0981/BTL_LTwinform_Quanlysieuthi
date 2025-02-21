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
    public partial class KHBT : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True");
        DataSet ds;
        string test = "Reset";
        public KHBT()
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
            string query = "select*from tblKH_BinhThuong ";
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
            string query = "update tblKH_BinhThuong set  MaHoaDon = N'" + txtMaHoaDon.Text + "' , GioiTinh = '" + gt + "' , DoTuoi = N'" + cboDoTuoi.Text + "' , NhuCau = N'" + cboNhuCau.Text + "' , NgayMua = '" + dtpNgayMua.Text + "' where MaHoaDon = N'" + txtMaHoaDon.Text + "'  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sua Thanh Cong");
            connclose();
            getdata();

        }
        private void xoa()
        {
            connopen();
            string query = "delete  from tblKH_BinhThuong where MaHoaDon='" + txtMaHoaDon.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoa Thanh Cong");
            connclose();
            getdata();
        }
        private void timkiem()
        {
            connopen();
            string query = "select*from tblKH_BinhThuong where DoTuoi='"+txtTimKiem.Text+"' ";
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

            string query = "insert into tblKH_BinhThuong values  ( N'" + txtMaHoaDon.Text + "' , '" + gt + "' , N'" + cboDoTuoi.Text + "' , N'" + cboNhuCau.Text + "'  , '" + dtpNgayMua.Text + "'  ) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Them Thanh Cong");

            connclose();
            getdata();
            

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

                    txtMaHoaDon.Enabled = false;
                    cboDoTuoi.Enabled = false;
                    cboNhuCau.Enabled = false;
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                    dtpNgayMua.Enabled = false;
                    dtpNgayMua.Text = DateTime.Now.ToString();
                    txtTimKiem.Enabled = false;


                    txtMaHoaDon.Text = "";                
                    txtTimKiem.Text = "";

                    txtMaHoaDon.Focus();

                    break;

                case "Add":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = false;

                    txtMaHoaDon.Enabled= true;
                    cboDoTuoi.Enabled = true;
                    cboNhuCau.Enabled = true;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayMua.Enabled = true;
                    dtpNgayMua.Text = DateTime.Now.ToString();
                    txtTimKiem.Enabled = false;

                    txtMaHoaDon.Text = "";                 
                    txtTimKiem.Text = "";

                    txtMaHoaDon.Focus();

                    break;

                case "Edit":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = false;

                    txtMaHoaDon.Enabled = true;
                    cboDoTuoi.Enabled = true;
                    cboNhuCau.Enabled = true;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayMua.Enabled = true;
                    dtpNgayMua.Text = DateTime.Now.ToString();
                    txtTimKiem.Enabled = false;

                    txtMaHoaDon.Text = "";                  
                    txtTimKiem.Text = "";

                    txtMaHoaDon.Focus();

                    break;

                case "Delete":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = false;

                    txtMaHoaDon.Enabled = true;
                    cboDoTuoi.Enabled = true;
                    cboNhuCau.Enabled = true;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayMua.Enabled = true;
                    dtpNgayMua.Text = DateTime.Now.ToString();
                    txtTimKiem.Enabled = false;

                    txtMaHoaDon.Text = "";                 
                    txtTimKiem.Text = "";

                    txtMaHoaDon.Focus();

                    break;

                case "Rearch":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTim.Enabled = false;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = true;
                    btnOK.Enabled = true;

                    txtMaHoaDon.Enabled = false;
                    cboDoTuoi.Enabled = false;
                    cboNhuCau.Enabled = false;
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                    dtpNgayMua.Enabled = false;
                    dtpNgayMua.Text = DateTime.Now.ToString();
                    txtTimKiem.Enabled = true;

                    txtMaHoaDon.Text = "";                  
                    txtTimKiem.Text = "";

                    txtMaHoaDon.Focus();

                    break;          
            }
        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {
            hien("Add");
            test = "Add";
            txtMaHoaDon.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hien("Edit");
            test = "Edit";
            txtMaHoaDon.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hien("Delete");
            test = "Delete";
            txtMaHoaDon.Focus();
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
            txtMaHoaDon.Text = dgvMain.Rows[i].Cells["MaHoaDon"].Value.ToString();
            cboDoTuoi.Text = dgvMain.Rows[i].Cells["DoTuoi"].Value.ToString();
            cboNhuCau.Text = dgvMain.Rows[i].Cells["NhuCau"].Value.ToString();
            dtpNgayMua.Text = dgvMain.Rows[i].Cells["NgayMua"].Value.ToString();
            
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
            string rowFilter = string.Format("{0} like '{1}'", "DoTuoi", "*" + txtTimKiem.Text + "*");
            (dgvMain.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }

    }

