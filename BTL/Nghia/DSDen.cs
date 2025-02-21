using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class DSDen : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True");
        DataSet ds;
        string test = "Reset";
        public DSDen()
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
            string query = "select*from tblDS_Den ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds);
            dgvMain.DataSource = ds.Tables[0];/* ds.Tables[0];*/

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

            //Anh
            //Byte[] a = (byte[])dgvMain["AnhDoiTuong", 0].Value;
            //MemoryStream stmBLOBData = new MemoryStream(a);
            //ptbAnhDoiTuong.Image = System.Drawing.Image.FromStream(stmBLOBData);


            //Byte[] l = (byte[])dgvMain[5, 0].Value;
            //MemoryStream stmBLOBData = new MemoryStream(l);
            //ptbAnhDoiTuong.Image = System.Drawing.Image.FromStream(stmBLOBData);
            connclose();


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
            //anh
            var Anh = new ImageConverter().ConvertTo(ptbAnhDoiTuong.Image, typeof(Byte[]));

            string query = "update tblDS_Den set  DoTuoi = N'" + cboDoTuoi.Text + "' , GioiTinh = N'" + gt + "' ,  DacDiem = N'" + txtDacDiem.Text + "' , NgayDienRa = '" + dtpNgayDienRa.Text + "', AnhDoiTuong = '" + (byte[])Anh + "' where DacDiem = N'" + txtDacDiem.Text + "'  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sua Thanh Cong");
            connclose();
            getdata();

        }
        private void xoa()
        {
            connopen();
            string query = "delete  from tblDS_Den where DacDiem='" + txtDacDiem.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoa Thanh Cong");
            connclose();
            getdata();
        }
        private void timkiem()
        {
            connopen();
            string query = "select*from tblDS_Den where DacDiem='" + txtDacDiem.Text + "' ";
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
            //anh
            //var Anh = new ImageConverter().ConvertTo(ptbAnhDoiTuong.Image, typeof(Byte[]));

            byte[] A = PathtobyArray(this.Text);
            string query = "insert into tblDS_Den values  ( N'" + cboDoTuoi.Text + "' , N'" + gt + "'  , N'" + txtDacDiem.Text + "'  , '" + dtpNgayDienRa.Text + "' , '" + A + "' ) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Them Thanh Cong");

            connclose();


        }

        byte[] PathtobyArray(string path)
        {
            MemoryStream m = new MemoryStream();
            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        public void hien(string test)
        {
            switch (test)
            {
                case "Reset":

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnAnh.Enabled = false;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;

                    cboDoTuoi.Enabled = false;
                    txtDacDiem.Enabled = false;
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                    dtpNgayDienRa.Enabled = false;
                    dtpNgayDienRa.Text = DateTime.Now.ToString();
                    ptbAnhDoiTuong.Enabled = false;

                    ptbAnhDoiTuong.Image = null;


                    txtDacDiem.Focus();

                    break;

                case "Add":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnAnh.Enabled = true;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;


                    cboDoTuoi.Enabled = true;
                    txtDacDiem.Enabled = true;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayDienRa.Enabled = true;
                    dtpNgayDienRa.Text = DateTime.Now.ToString();
                    ptbAnhDoiTuong.Enabled = true;

                    txtDacDiem.Focus();

                    break;

                case "Edit":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnAnh.Enabled = true;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;


                    cboDoTuoi.Enabled = true;
                    txtDacDiem.Enabled = false;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayDienRa.Enabled = true;
                    dtpNgayDienRa.Text = DateTime.Now.ToString();
                    ptbAnhDoiTuong.Enabled = true;


                    txtDacDiem.Focus();

                    break;

                case "Delete":

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnAnh.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    cboDoTuoi.Enabled = true;
                    txtDacDiem.Enabled = true;
                    rdoNam.Checked = true;
                    rdoNu.Checked = true;
                    dtpNgayDienRa.Enabled = true;
                    dtpNgayDienRa.Text = DateTime.Now.ToString();
                    ptbAnhDoiTuong.Enabled = true;


                    txtDacDiem.Focus();

                    break;


            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            hien("Add");
            test = "Add";
            cboDoTuoi.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hien("Edit");
            test = "Edit";
            cboDoTuoi.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hien("Delete");
            test = "Delete";
            cboDoTuoi.Focus();
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
            getdata();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hien("Reset");
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvMain.CurrentRow.Index;
            cboDoTuoi.Text = dgvMain.Rows[i].Cells["DoTuoi"].Value.ToString();
            txtDacDiem.Text = dgvMain.Rows[i].Cells["DacDiem"].Value.ToString();
            dtpNgayDienRa.Text = dgvMain.Rows[i].Cells["NgayDienRa"].Value.ToString();
            //byte[] imageBytes = (byte[])dgvMain.Rows[i].Cells["AnhDoiTuong"].Value;
            //ptbAnhDoiTuong.Image = ByteArrayToImage(imageBytes);

            //Hiển ảnh
            // System.Drawing.Image ByteArrayToImage(byte[] byteArray)
            //{
            //    using (MemoryStream memoryStream = new MemoryStream(byteArray))
            //    {
            //        return System.Drawing.Image.FromStream(memoryStream);
            //    }
            //}



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





        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbAnhDoiTuong.Image = System.Drawing.Image.FromFile(open.FileName);
                this.Text = open.FileName;

            }


        }

		private void DSDen_Load(object sender, EventArgs e)
		{

		}

		private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
