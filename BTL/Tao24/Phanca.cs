using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;



namespace BTL
{
    public partial class Phanca : Form
    {
        public Phanca()
        {
            InitializeComponent(); 
            cbonam.SelectedIndex = 0;
            getdatama(); 
            getdataten(); 
            getdatamaca();               
            getdatagiovaten();           
            getdata();
            hienthi(hien);   
           

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

            e_excel.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH PHÂN CA";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã NV";
            cl1.ColumnWidth = 15.0;

            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên NV";
            cl2.ColumnWidth = 20.0;

            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Mã Ca Làm";
            cl3.ColumnWidth = 20.0;

            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tên Ca";
            cl4.ColumnWidth = 25.0;

            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Khung Giờ";
            cl5.ColumnWidth = 15.0;


            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Tháng";
            cl6.ColumnWidth = 15.0;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "J3");
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
    private void button1_Click(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();

            DataColumn col1 = new DataColumn("Mã NV");
            DataColumn col2 = new DataColumn("Tên NV");
            DataColumn col3 = new DataColumn("Mã Ca Làm");
            DataColumn col4 = new DataColumn("Tên Ca");
            DataColumn col5 = new DataColumn("Khung Giờ");
            DataColumn col6 = new DataColumn("Tháng");



            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);


            foreach (DataGridViewRow dtgvRow in dgvxuat.Rows)
            {
                DataRow dtrow = dt.NewRow();
                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;

                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;


                dt.Rows.Add(dtrow);
            }
            ExportExcel(dt, "DSL");
        


    }

    string hien = "reset";
        private void hienthi(string hien)
        {
            switch (hien)
            {
                case "reset":
                    {
                       
                        dgvxuat.Enabled = true;
                        
                        btnthem.Visible = true;
                        btnsua.Visible = true;
                        btnxoa.Visible = true;

                        btntimkiem.Enabled = true;
                        txttimkiem.Enabled = true;
                        txttimkiem.Text = "";

                        btnghi.Visible = false;
                        btnhuy.Visible = false;
                           
                        cbothang.Enabled = true;
                        cbonam.Enabled = true;
                        txtkhungh.Enabled = false;
                        txtten.Enabled = false;
                        txttenca.Enabled = false;
                        cboma.Enabled = false;
                        cbomaca.Enabled = false;
                        
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;

                        btnghi.Enabled = false;
                        btnhuy.Enabled = false;
                        break;
                    }
                case "insert":
                    {
                        dgvxuat.Enabled = false;
                        btntimkiem.Enabled = false;
                        txttimkiem.Enabled = false;
                        txttimkiem.Text = "";
                      
                        btnthem.Visible = false;
                        btnsua.Visible = false;
                        btnxoa.Visible = false;

                        btnghi.Visible = true;
                        btnhuy.Visible = true;
                      
                        cbomaca.Enabled = true;
                        cboma.Enabled=true;

                        btnthem.Enabled = false;
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;

                        btnghi.Enabled = true;
                        btnhuy.Enabled = true;
                        break;
                    }
                case "update":
                    {
                        btntimkiem.Enabled = false;
                        txttimkiem.Enabled = false;
                        txttimkiem.Text = "";

                     
                        btnthem.Visible = false;
                        btnsua.Visible = false;
                        btnxoa.Visible = false;

                        btnghi.Visible = true;
                        btnhuy.Visible = true;

                        cbomaca.Enabled = true;
                        cboma.Enabled =false;

                        btnthem.Enabled = false;
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;

                        btnghi.Enabled = true;
                        btnhuy.Enabled = true;
                        break;
                    }

            }
        }
        SqlConnection conn = new SqlConnection(" Data Source=LAPTOP-P7MVM1FD;Initial Catalog=BaiTapLon;Integrated Security=True ");
        DataSet ds;
        private void connopen()
        {
            if (conn.State != ConnectionState.Open)
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
            string tg = "";
            tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
            connopen();
            string query = "select tblPhanca.Manv,tblThongtin.Tennv ,tblPhanca.Maca,tblCalamviec.Calam,tblCalamviec.khunggio ,tblPhanca.Thang from tblThongtin, tblPhanca,tblCalamviec where tblCalamviec.Maca=tblPhanca.Maca and tblThongtin.Manv=tblPhanca.Manv and tblPhanca.Thang='"+tg+"' ;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds);           
            dgvxuat.DataSource = ds.Tables[0];
             connclose();               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           

        }
        private void getdatama()
        {
            try
            {   
                connopen();
                string query = "Select Manv From tblThongtin";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds);
                connclose();
                if (ds.Tables[0].Rows.Count > 0)
                {
                cboma.DataSource = ds.Tables[0];
                cboma.DisplayMember = "Manv";
                cboma.ValueMember = "Manv";
                cboma.SelectedIndex = 0;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }


        }

        private void getdataten()
        {
            try
            {

                if (cboma.SelectedIndex != -1)
                {
                    connopen();
                    string query = "Select TenNV From tblThongtin where Manv='" + cboma.SelectedValue.ToString().Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    ad.Fill(ds);
                    connclose();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtten.Text = ds.Tables[0].Rows[0][0].ToString();
                    }

                }

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void cboma_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdataten();
        }

        private void getdatamaca()
        {
            try
            {   
                connopen();
                string query = "Select Maca From tblCalamviec";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds);
                
                if (ds.Tables[0].Rows.Count>0)
                {   

                cbomaca.DataSource = ds.Tables[0];
                cbomaca.DisplayMember = "Maca";
                cbomaca.ValueMember = "Maca";
                cbomaca.SelectedIndex = 0;

                }
             

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void getdatagiovaten()
        {
            try
            {

                if (cbomaca.SelectedIndex != -1)
                {
                    connopen();
                    string query = "Select Calam,Khunggio From tblCalamviec where Maca='" + cbomaca.SelectedValue.ToString().Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    ad.Fill(ds);
                    connclose();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txttenca.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtkhungh.Text = ds.Tables[0].Rows[0][1].ToString();

                    }

                }
              

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void cbomaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdatagiovaten();
        }

        private void suaphanca()
        {
            try
            {
                if(cboma.SelectedIndex != -1 && cbomaca.SelectedIndex!=-1)
                { 
                string tg = "";
                tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                connopen();
                string query = "Update tblPhanca set Maca= '" + cbomaca.SelectedValue.ToString().Trim() + "' where Manv= '" + cboma.SelectedValue.ToString().Trim() + "' and Thang='"+tg.Trim() +"' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                connclose();
                MessageBox.Show("Sửa thành công");
                getdata();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void themphanca()
        {
            try
            {
                if (cboma.SelectedIndex != -1)
                { 
                    string tg = "";
                tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                connopen();
                string query1 = "select Manv,Thang from tblPhanca where Manv='" + cboma.SelectedValue.ToString().Trim() + "' and Thang = '" + tg.Trim() + "'  ";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                ds = new DataSet();
                ad.Fill(ds);
                connclose();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Nhân viên đã được phân ca trong tháng này rồi");
                    return;
                }
                if(cboma.SelectedIndex != -1 && cbomaca.SelectedIndex != -1)
                    {
                 connopen();
                string query = "Insert into tblPhanca values( '" + cboma.SelectedValue.ToString().Trim() + "' , '" + cbomaca.SelectedValue.ToString().Trim() + "'  , '" + tg.Trim() + "'  )";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                connclose();
                MessageBox.Show("Phân ca thành công");
                getdata();

                    }
                    else
                    {
                        MessageBox.Show("Phân ca không thành công");

                    }

                }
               
            }
            catch
            {
                MessageBox.Show("Phân ca không thành công");
            }
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            hien = "insert";
            hienthi(hien);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if(cboma.SelectedIndex !=-1 && cboma.Text!="") 
                    {
                    string tg = "";
                    tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                    connopen();
                    string query = " delete from tblPhanca where Manv='" + cboma.SelectedValue + "' and Thang='" + tg + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    query = "Delete from tblTinhluong Where Manv='" + cboma.SelectedValue + "' and Thang='" + tg + "' ";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    connclose();
                    MessageBox.Show("Xóa thành công");  
                    getdata();
                    }                  
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
           
        }

        private void cbothang_SelectedIndexChanged(object sender, EventArgs e)
        {            
            getdata();
        }       

        private void cbonam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbothang.SelectedIndex = 0;
            getdata();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            hienthi("reset");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {           
                      
            cbonam.SelectedIndex = 0;
            cbothang.SelectedIndex = 0;
            hienthi("reset");
            getdatama();
            getdataten();
            getdatamaca();
            getdatagiovaten();
            getdata();

        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (hien == "insert")
            {
                themphanca();
                hienthi("reset");
            }
            else if (hien == "update")
            {
                suaphanca();
                hienthi("reset");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            hien = "update";
            hienthi(hien);

        }        
        private void dgvxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboma.Text = dgvxuat.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgvxuat.CurrentRow.Cells[1].Value.ToString();
            cbomaca.Text = dgvxuat.CurrentRow.Cells[2].Value.ToString();
            txttenca.Text = dgvxuat.CurrentRow.Cells[3].Value.ToString();
            txtkhungh.Text = dgvxuat.CurrentRow.Cells[4].Value.ToString();        
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tg = "";
                tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                connopen();
                string query = "select tblPhanca.Manv,tblThongtin.Tennv ,tblPhanca.Maca,tblCalamviec.Calam,tblCalamviec.khunggio ,tblPhanca.Thang from tblThongtin, tblPhanca,tblCalamviec where tblCalamviec.Maca=tblPhanca.Maca and tblThongtin.Manv=tblPhanca.Manv and (tblPhanca.Manv='" + txttimkiem.Text.Trim() + "'or tblThongtin.Tennv=N'" + txttimkiem.Text.Trim() + "' )and tblPhanca.Thang='" + tg.Trim() + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm");
                    return;
                }
                dgvxuat.DataSource = ds.Tables[0];
                MessageBox.Show("Tìm thành công");

                conn.Close();

            }
            catch
            {
                MessageBox.Show("Tìm không thành công");
            }
        }

       
    }
}
