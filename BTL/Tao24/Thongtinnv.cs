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
using e_excel = Microsoft.Office.Interop.Excel;

namespace BTL
{
    public partial class Thongtinnv : Form
    {
        public Thongtinnv()
        {
            InitializeComponent();
            hienthi(hien);          
            getdata();
            dulieudau();
        }


        private void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn

            e_excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH THÔNG TIN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã NV";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên NV";
            cl2.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày Sinh";
            cl3.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl3_1 = oSheet.get_Range("C4", "C1000");
            cl3_1.Columns.NumberFormat = "dd/MM/yyyy";
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Quê Quán";
            cl4.ColumnWidth = 25.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "SDT";
            cl5.ColumnWidth = 25.0;
           

            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Chức Vụ";
            cl6.ColumnWidth = 25.0;

            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Giới Tính";
            cl7.ColumnWidth = 25.0;
            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    if (c == 2)
                        arr[r, c] = "'" + dr[c].ToString();
                    else
                        arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            e_excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Căn giữa cột STT
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }  

        string hien = "reset";
        SqlConnection conn = new SqlConnection(" Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True ");
        DataSet ds;
        private void connopen()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        private void connclose()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        private void getdata()
        {
            try
            { 
             connopen();
            string query = "Select * From tblThongtin";
            SqlCommand cmd=new SqlCommand(query, conn);    
            SqlDataAdapter ad=new SqlDataAdapter(cmd);
            ds=new DataSet();
            ad.Fill(ds);
            connclose();
           dgvxuat.DataSource = ds.Tables[0];
            DataColumn column = new DataColumn("Giới Tính");
            ds.Tables[0].Columns.Add(column);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr[2].ToString() == "1")
                {
                    dr[7] = "Nam";
                }
                else
                {
                    dr[7] = "Nữ";
                }
            }

            }
            catch
            {
               
            }
           

        }
        private bool ktraloi()
        {
            errorProviderThongtin.Clear();
            if (txtma.Text == "")   
            {
                errorProviderThongtin.SetError(txtma, "Chưa nhập mã");
                txtma.Focus();
                return false;
            }
            else if (txtten.Text == "")
            {
                errorProviderThongtin.SetError(txtten, "Chưa nhập tên");
                txtten.Focus();
                return false;
            }
            else if (txtque.Text == "")
            {
                errorProviderThongtin.SetError(txtque, "Chưa nhập quê quán");
                txtque.Focus();
                return false;
            }
            else if (txtsdt.Text == "")
            {
                errorProviderThongtin.SetError(txtsdt, "Chưa nhập số điện thoại");
                txtsdt.Focus();
                return false;
            }

            else if (cbochucvu.SelectedIndex==-1)
            {
                errorProviderThongtin.SetError(cbochucvu, "Chưa chọn chức vụ");
               
                return false;
            }
            else if (dtpns.Text == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                errorProviderThongtin.SetError(dtpns, "Ngày sinh không hợp lệ");
                dtpns.Focus();
                return false;
            }
             else if (radnam.Checked==false && radnu.Checked ==false)
            {
                errorProviderThongtin.SetError(groupBox2, "Chưa chọn giới tính");
                return false;
            }
           
            else
            { 
                return true;
            }
        }
        private void them()
        {
            try
            {
             string gt = "";
            if (radnam.Checked == true)
            {
                gt = "1";
            }
            else if (radnu.Checked == true)
            {
                gt = "0";
            }
            connopen();
            string query = "Insert into tblThongtin values( '" + txtma.Text.Trim() + "' , N'" + txtten.Text.Trim() + "' , '" + gt + "' , '"+dtpns.Value.ToString("MM/dd/yyyy")+"' , N'"+txtque.Text+"' , '"+txtsdt.Text+"' , N'"+cbochucvu.SelectedItem.ToString()+ "' )";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            connclose();
            MessageBox.Show("Thêm thành công");
            getdata();            
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }           
        }
        private void sua()
        {
            try
            {   
                string gt = "";
                if (radnam.Checked == true)
                {
                    gt = "1";
                }
                else if (radnu.Checked == true)
                {
                    gt = "0";
                }
                connopen();
                string query = "Update tblThongtin Set  Tennv= N'" + txtten.Text.Trim() + "' , Gioitinh='" + gt + "' , Ngaysinh='" + dtpns.Value.ToString("MM/dd/yyyy") + "' ,Quequan= N'" + txtque.Text + "' ,SDT= '" + txtsdt.Text + "' ,Chucvu= N'" + cbochucvu.SelectedItem.ToString() + "'  Where Manv='" + txtma.Text.Trim() + "'  ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                connclose();
                MessageBox.Show("Sửa thành công");
                getdata();

            }
            catch
            {
                MessageBox.Show("Sửa không thành công");
            }

        }
        private void xoa()
        {
            try
            {
                if (txtma.Text != "")
                {
                connopen();
                string query = "Delete From tblThongtin Where Manv='" + txtma.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                 query = "Delete From tblTinhluong Where Manv='" + txtma.Text.Trim() + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                query = "Delete From tblPhanca Where Manv='" + txtma.Text.Trim() + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                connclose();
                MessageBox.Show("Xóa thành công");
                getdata();
                   
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xóa");

                }


            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void hienthi(string hien)
        {
            try
            {
                switch (hien)
                {
                    case "reset":
                        {

                            errorProviderThongtin.Clear();
                            dgvxuat.Enabled = true;
                          
                            btnthem.Visible = true;
                            btnsua.Visible = true;
                            btnxoa.Visible = true;
                            

                            btnthem.Enabled = true;
                            btnsua.Enabled = true;
                            btnxoa.Enabled = true;
                            

                            btntimkiem.Enabled = true;
                            txttimkiem.Enabled=true;
                            txttimkiem.Text = "";

                            btnghi.Enabled = false;
                            btnhuy.Enabled = false;

                            btnghi.Visible = false;
                            btnhuy.Visible = false;

                            txtma.Text = "";
                            txtque.Text = "";
                            txtsdt.Text = "";
                            txtten.Text = "";                            
                            radnam.Checked = false;
                            radnu.Checked = false;
                            cbochucvu.SelectedIndex = -1;
                            dtpns.Text = DateTime.Now.ToString();

                            txtma.Enabled=false;
                            txtten.Enabled=false;
                            txtque.Enabled=false;
                            txtsdt.Enabled=false;
                            groupBox2.Enabled=false;
                            cbochucvu.Enabled=false;
                            dtpns.Enabled=false;
                            dulieudau();
                        break;
                    }
                    case "insert":
                        {
                            btnthem.Visible = false;
                            btnsua.Visible = false;
                            btnxoa.Visible = false;

                            dgvxuat.Enabled = false;
                            btnthem.Enabled = false;
                            btnsua.Enabled = false;
                            btnxoa.Enabled = false;

                            btntimkiem.Enabled = false;
                            txttimkiem.Enabled = false;
                            txttimkiem.Text = "";

                            btnghi.Enabled = true;
                            btnhuy.Enabled = true;
                            btnghi.Visible = true;
                            btnhuy.Visible = true;

                            txtma.Text = "";
                            txtque.Text = "";
                            txtsdt.Text = "";
                            txtten.Text = "";
                            radnam.Checked = false;
                            radnu.Checked = false;
                            cbochucvu.SelectedIndex = -1;
                            dtpns.Text = DateTime.Now.ToString();

                            txtma.Enabled = true;
                            txtten.Enabled = true;
                            txtque.Enabled = true;
                            txtsdt.Enabled = true;
                            groupBox2.Enabled = true;
                            cbochucvu.Enabled = true;
                            dtpns.Enabled = true;
                            break;
                        }
                    case "update":
                        {                            
                            btnthem.Visible = false;
                            btnsua.Visible=false;
                            btnxoa.Visible=false;   

                            btnthem.Enabled = false;
                            btnsua.Enabled = false;
                            btnxoa.Enabled = false;
                           
                            btntimkiem.Enabled = false;
                            txttimkiem.Enabled = false;
                            txttimkiem.Text = "";

                            btnghi.Enabled = true;
                            btnhuy.Enabled = true;
                            btnghi.Visible = true;
                            btnhuy.Visible = true;

                            txtma.Enabled = false;
                            txtten.Enabled = true;
                            txtque.Enabled = true;
                            txtsdt.Enabled = true;
                            groupBox2.Enabled = true;
                            cbochucvu.Enabled = true;
                            dtpns.Enabled = true;
                            break;
                        }


                }

            }
            catch
            {
               
            }
            
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            hien = "insert";
            hienthi(hien);
        }
       private void btnsua_Click(object sender, EventArgs e)
        {
            hien = "update";
            hienthi(hien);
        }
        private void btnghi_Click(object sender, EventArgs e)
        {
            if (hien == "insert")
            {
                
                if (ktraloi() == true)
                { 
                    them();
                     hienthi("reset");
                }
               
            }
            else if(hien == "update")
            {
                if (ktraloi() == true)
                {
                    sua();
                    hienthi("reset");
                }
               
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa không?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    xoa();
                    hienthi("reset");
            }
            }
            catch
            {
                MessageBox.Show("Xoá không thành công");
            }
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
            connopen();
            string query = " Select * From tblThongtin Where Manv='"+txttimkiem.Text+"' or Tennv=N'"+txttimkiem.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0 ) {
                    MessageBox.Show("Không có dữ liệu cần tìm ");
                    return;
                }
            dgvxuat.DataSource = ds.Tables[0];
            DataColumn column = new DataColumn("Giới Tính");
            ds.Tables[0].Columns.Add(column);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr[2].ToString() == "1")
                {
                    dr[7] = "Nam";
                }
                else
                {
                    dr[7] = "Nữ";
                }
            }
                MessageBox.Show("Tìm thành công");

                dulieudau();
                connclose();

            }
            catch
            {
                MessageBox.Show("Tìm không thành công");
            }

        }

        private void dgvxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvxuat.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgvxuat.CurrentRow.Cells[1].Value.ToString();
            if (dgvxuat.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                radnam.Checked = true;
                radnu.Checked = false;
            }
            else if (dgvxuat.CurrentRow.Cells[2].Value.ToString() == "0")
            {
                radnam.Checked = false;
                radnu.Checked = true;
            }
            else
            {
                radnam.Checked = false;
                radnu.Checked = false;
            }
            dtpns.Text = dgvxuat.CurrentRow.Cells[3].Value.ToString();
            txtque.Text = dgvxuat.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = dgvxuat.CurrentRow.Cells[5].Value.ToString();
            cbochucvu.Text = dgvxuat.CurrentRow.Cells[6].Value.ToString();
        }
        private void dulieudau()
        {
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtma.Text = ds.Tables[0].Rows[0][0].ToString();
                txtten.Text = ds.Tables[0].Rows[0][1].ToString();
                if (ds.Tables[0].Rows[0][2].ToString() == "1")
                {
                    radnam.Checked = true;
                    radnu.Checked = false;
                }
                else
                {
                    radnam.Checked = false;
                    radnu.Checked = true;
                }
                dtpns.Text = ds.Tables[0].Rows[0][3].ToString();
                txtque.Text = ds.Tables[0].Rows[0][4].ToString();
                txtsdt.Text = ds.Tables[0].Rows[0][5].ToString();
                cbochucvu.Text = ds.Tables[0].Rows[0][6].ToString();

            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            hien = "reset";
            hienthi(hien);
        }

        private void btbreset_Click(object sender, EventArgs e)
        {
            hien = "reset";
            hienthi(hien);
            getdata();
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (Keys)e.KeyChar != Keys.Space)
            {

                e.Handled = true;
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            DataColumn col1 = new DataColumn("Mã NV");
            DataColumn col2 = new DataColumn("Tên NV");
            DataColumn col3 = new DataColumn("Ngày Sinh");
            DataColumn col4 = new DataColumn("Quê Quán");
            DataColumn col5 = new DataColumn("SDT");
            DataColumn col6 = new DataColumn("Chức Vụ");
            DataColumn col7 = new DataColumn("Giới Tính");



            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);
            dt.Columns.Add(col7);


            foreach (DataGridViewRow dtgvRow in dgvxuat.Rows)
            {
                DataRow dtrow = dt.NewRow();
                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
               
                dtrow[2] = dtgvRow.Cells[3].Value;
                dtrow[3] = dtgvRow.Cells[4].Value;
                dtrow[4] = dtgvRow.Cells[5].Value;
                dtrow[5] = dtgvRow.Cells[6].Value;
                dtrow[6] = dtgvRow.Cells[7].Value;


                dt.Rows.Add(dtrow);
            }
            ExportExcel(dt, "DSL");
        }

       
    }
}
