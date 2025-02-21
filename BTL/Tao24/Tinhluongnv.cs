using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using e_excel = Microsoft.Office.Interop.Excel;


namespace BTL
{
    public partial class Tinhluongnv : Form
    {
        public Tinhluongnv()
        {   
            InitializeComponent();
            getdatama();
            cbonam.SelectedIndex = 0;
            cbothang.SelectedIndex = 0;
            getdataten();                                
            hienthi(hien);
             getdata();
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
            head.Value2 = "DANH SÁCH LƯƠNG";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Lương";
            cl1.ColumnWidth = 15.0;

            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã NV";
            cl2.ColumnWidth = 20.0;

            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tên NV";
            cl3.ColumnWidth = 30.0;

            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Chức Vụ";
            cl4.ColumnWidth = 25.0;

             Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Ngày Sinh";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl5_1 = oSheet.get_Range("E4", "E1000");
            cl5_1.Columns.NumberFormat = "dd/MM/yyyy";

            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Tháng";
            cl6.ColumnWidth = 15.0;

            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Số Công";
            cl7.ColumnWidth = 15.0;

            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Ca Làm";
            cl8.ColumnWidth = 15.0;

            e_excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Loại Thưởng";
            cl9.ColumnWidth = 15.0;

            e_excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Lương";
            cl10.ColumnWidth = 25.0;
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

        private void dulieudau()
        {
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtmaluong.Text = ds.Tables[0].Rows[0][0].ToString();
                cboma.Text = ds.Tables[0].Rows[0][1].ToString();
                txtsocong.Text = ds.Tables[0].Rows[0][6].ToString();
            }

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DataColumn col1 = new DataColumn("Mã Lương");
            DataColumn col2 = new DataColumn("Mã NV");
            DataColumn col3 = new DataColumn("Tên NV");
            DataColumn col4 = new DataColumn("Chức Vụ");
            DataColumn col5 = new DataColumn("Ngày Sinh");
            DataColumn col6 = new DataColumn("Tháng");
            DataColumn col7 = new DataColumn("Số Công");
            DataColumn col8 = new DataColumn("Ca Làm");
            DataColumn col9 = new DataColumn("Loại Thưởng");
            DataColumn col10 = new DataColumn("Lương");

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);
            dt.Columns.Add(col7);
            dt.Columns.Add(col8);
            dt.Columns.Add(col9);
            dt.Columns.Add(col10);



            foreach (DataGridViewRow dtgvRow in dgvxuat.Rows)
            {
                DataRow dtrow = dt.NewRow();
                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;

                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;
                dtrow[7] = dtgvRow.Cells[7].Value;
                dtrow[8] = dtgvRow.Cells[8].Value;
                dtrow[9] = dtgvRow.Cells[9].Value;


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
                      

                        btntinhluong.Visible = true;
                        btnsua.Visible = true;
                        btnxoa.Visible = true;

                        btntimkiem.Enabled = true;
                        txttimkiem.Enabled = true;
                        txttimkiem.Text = "";

                        btnghi.Visible = false;
                        btnhuy.Visible = false;

                        cbonam.Enabled = true;
                        txtmaluong.Enabled = false;
                        txtten.Enabled = false;
                        txtsocong.Enabled = false;
                        cboma.Enabled = false;
                        cbothang.Enabled = true;

                        btntinhluong.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;

                        btnghi.Enabled = false;
                        btnhuy.Enabled = false;

                        txtmaluong.Text = "";
                        txtsocong.Text = "";

                        break;
                    }
                case "insert":
                    {
                        dgvxuat.Enabled = false;
                        btntimkiem.Enabled = false;
                        txttimkiem.Enabled = false;
                        txttimkiem.Text = "";


                        btntinhluong.Visible = false;
                        btnsua.Visible = false;
                        btnxoa.Visible = false;

                        btnghi.Visible = true;
                        btnhuy.Visible = true;

                        txtten.Enabled = false;                        
                        txtmaluong.Enabled = false;                     
                        txtsocong.Enabled = true;
                        cboma.Enabled = true;
                        cbothang.Enabled = true;
                        cbonam.Enabled=true;

                        btntinhluong.Enabled = false;
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;

                        btnghi.Enabled = true;
                        btnhuy.Enabled = true;
                        txtsocong.Text = "";
                        break;
                    }
                case "update":
                    {
                        btntimkiem.Enabled = false;
                        txttimkiem.Enabled = false;
                        txttimkiem.Text = "";

                      

                        btntinhluong.Visible = false;
                        btnsua.Visible = false;
                        btnxoa.Visible = false;

                        btnghi.Visible = true;
                        btnhuy.Visible = true;

                        txtmaluong.Enabled = false;
                        txtten.Enabled = false;
                        txtsocong.Enabled = true;
                        cboma.Enabled = false;
                        cbothang.Enabled = false;
                        cbonam.Enabled = false;


                        btntinhluong.Enabled = false;
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

                if (cboma.SelectedIndex !=-1)
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
        private void getdata()
        {
            try
            {                  
                string tg = "";                
                tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                connopen();
                string query = " select  tblTinhluong.Maluong ,tblThongtin.Manv ,tblThongtin.Tennv, tblThongtin.Chucvu  ,tblThongtin.Ngaysinh,tblTinhluong.Thang,tblTinhluong.Socong ,tblCalamviec.Calam,tblTinhluong.Loai ,tblTinhluong.Luong from tblThongtin inner join tblChucvu on tblThongtin.Chucvu=tblChucvu.Chucvu inner join tblPhanca on tblPhanca.Manv=tblThongtin.Manv inner join tblCalamviec on tblCalamviec.Maca=tblPhanca.Maca inner join tblTinhluong on tblTinhluong.Manv=tblThongtin.Manv inner join tblTienthuong on tblTienthuong.Loai=tblTinhluong.Loai where tblPhanca.Thang= '" + tg.Trim() + "' and tblTinhluong.Thang= '" + tg.Trim() + "' ;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                dgvxuat.DataSource = ds.Tables[0];
                conn.Close();
                dulieudau();

            }
            catch
            {

            }

        }
        private void tinhluong()
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
                 
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Chưa phân ca không thể tính lương");
                    return;
                }


                string loai = "";
                if (int.Parse(txtsocong.Text.ToString()) >= 28)
                {
                    loai = "Xuất sắc";
                }
                else if (int.Parse(txtsocong.Text.ToString()) >= 26)
                {
                    loai = "Tốt";
                }
                else if (int.Parse(txtsocong.Text.ToString()) >= 24)
                {
                    loai = "Khá";
                }
                else if (int.Parse(txtsocong.Text.ToString()) >= 0)
                {
                    loai = "Khuyến khích";
                }              
                connopen();
                string query = "Insert into tblTinhluong(Manv,Thang,Socong,Loai) values( '" + cboma.SelectedValue.ToString().Trim() + "' , '" + tg.Trim() + "' , " + txtsocong.Text.Trim() + "  , N'" + loai + "' )";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                query = " Update tblTinhluong set Luong=(HSL*Socong*Sotienca+Sotien) from tblThongtin inner join tblChucvu on tblThongtin.Chucvu=tblChucvu.Chucvu inner join tblPhanca on tblPhanca.Manv=tblThongtin.Manv inner join tblCalamviec on tblCalamviec.Maca=tblPhanca.Maca inner join tblTinhluong on tblTinhluong.Manv=tblThongtin.Manv inner join tblTienthuong on tblTienthuong.Loai=tblTinhluong.Loai where tblPhanca.Thang= '" + tg.Trim() + "' and tblTinhluong.Thang= '" + tg.Trim() + "'and tblThongtin.Manv='" + cboma.SelectedValue.ToString().Trim() + "' ;";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    connclose();
                MessageBox.Show("Tính lương thành công");
                getdata();

                }


            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

        }
        
        
        private void sua()
        {
            try
            {   if(cboma.SelectedIndex != -1)
                {
                    string loai = "";
                if (int.Parse(txtsocong.Text.ToString()) >= 28)
                {
                    loai = "Xuất sắc";
                }
                else if (int.Parse(txtsocong.Text.ToString()) >= 26)
                {
                    loai = "Tốt";
                }
                else if (int.Parse(txtsocong.Text.ToString()) >= 24)
                {
                    loai = "Khá";
                }
                else
                {
                    loai = "Khuyến khích";
                }

               
                connopen();
                string tg = "";
                tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                string query = "Update tblTinhluong set Socong= " + txtsocong.Text.Trim() + "  ,Loai= N'" + loai + "' where Maluong=" + txtmaluong.Text + " ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();              
                query = " Update tblTinhluong set Luong=(HSL*Socong*Sotienca+Sotien) from tblThongtin inner join tblChucvu on tblThongtin.Chucvu=tblChucvu.Chucvu inner join tblPhanca on tblPhanca.Manv=tblThongtin.Manv inner join tblCalamviec on tblCalamviec.Maca=tblPhanca.Maca inner join tblTinhluong on tblTinhluong.Manv=tblThongtin.Manv inner join tblTienthuong on tblTienthuong.Loai=tblTinhluong.Loai where tblPhanca.Thang= '" + tg.Trim() + "' and tblTinhluong.Thang= '" + tg.Trim() + "'and tblThongtin.Manv='" + cboma.SelectedValue.ToString().Trim() + "' ;";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                connclose();
                MessageBox.Show("Sửa thành công");
                getdata();
                }
 

            }
            catch
            {
                MessageBox.Show("Sửa không thành công");

            }

        }
      
        private void cbonam_TextChanged(object sender, EventArgs e)
        {
            
            cbothang.SelectedIndex = 0;
            getdata();
        }
        private void cbothang_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdata();
        }
     
        private void Tinhluongnv_Load(object sender, EventArgs e)
        {
            cbonam.SelectedIndex = 0;
            cbothang.SelectedIndex = 0;
        }

        private void txtsocong_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
               
                e.Handled = true;
            }
            
            
        }

        private bool ktra()
        {
            if (cboma.Text == "")
            {
                MessageBox.Show("Chưa chọn mã");              
                return false;
            }
            else if ( txtsocong.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập số công");
                txtsocong.Focus();
                return false;
           
            }           
            else if ((int.Parse(txtsocong.Text) >31   )&& (txtsocong.Text.Length > 0) && (cbothang.SelectedItem.ToString() == "1" || cbothang.SelectedItem.ToString() == "3" || cbothang.SelectedItem.ToString() == "5" || cbothang.SelectedItem.ToString() == "7" || cbothang.SelectedItem.ToString() == "8" || cbothang.SelectedItem.ToString() == "10" || cbothang.SelectedItem.ToString() == "12"))
            {
                MessageBox.Show("Số ngày nhỏ hơn hoặc bằng 31");
                    return false;
            }
            else if ((int.Parse(txtsocong.Text) > 30) && (txtsocong.Text.Length > 0) && (cbothang.SelectedItem.ToString() == "4" || cbothang.SelectedItem.ToString() == "6" || cbothang.SelectedItem.ToString() == "9" || cbothang.SelectedItem.ToString() == "11"))
            {
                MessageBox.Show("Số ngày nhỏ hơn hoặc bằng 30");

                return false;
            }
            else if( (int.Parse(cbonam.SelectedItem.ToString()) %4 ==0  ) && (int.Parse(cbonam.SelectedItem.ToString())%100!=0 ) &&(int.Parse(txtsocong.Text) > 29) && (txtsocong.Text.Length > 0) && (cbothang.SelectedItem.ToString() == "2"))
            {
                MessageBox.Show("Số ngày nhỏ hơn hoặc bằng 29");


                return false;
            }
            else if ((int.Parse(cbonam.SelectedItem.ToString()) % 4 != 0)  && (int.Parse(txtsocong.Text) > 28) && (txtsocong.Text.Length > 0) && (cbothang.SelectedItem.ToString() == "2"))
            {
                MessageBox.Show("Số ngày nhỏ hơn hoặc bằng 28");

                return false;
            }
            else
            {               
                return true;
            }
           
        }

        private void btntinhluong_Click(object sender, EventArgs e)
        {
            hien = "insert";
            hienthi(hien);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            hien = "update";
            hienthi(hien);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connopen();
                    string query = "Delete from tblTinhluong Where Maluong=" + txtmaluong.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    connclose();
                    getdata();
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (hien == "update")
            {
                if (ktra() == false)
                {
                    return;
                }
                 sua();
                hienthi("reset");
                getdata();
            }
            else if (hien == "insert")
            {
                try
                {
                    string tg = "";
                    tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                    connopen();
                    string query = "select Manv from tblTinhluong where Thang = '" + tg.Trim() + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);

                    ds = new DataSet();
                    ad.Fill(ds);
                    connclose();
                    bool test = true;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        if (dr[0].ToString().Trim() == cboma.SelectedValue.ToString().Trim())
                        {
                            test = false;
                            break;
                        }

                    }
                    if (test == true)
                    {
                        if (ktra() == false)
                        {
                            return;
                        }
                        tinhluong();
                        hienthi("reset");
                        getdata();
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên đã được tính lương rồi");
                    }

                }
                catch
                {
                    MessageBox.Show("Lỗi");

                }

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            hienthi("reset");
        }
      
        private void btnreset_Click(object sender, EventArgs e)
        {
            cbonam.SelectedIndex = 0;
            cbothang.SelectedIndex = 0;
           
            getdatama();
            getdataten();
            hien = "reset";
            hienthi(hien);  
            getdata();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {

                string tg = "";
                tg = cbothang.SelectedItem.ToString() + "/" + cbonam.SelectedItem.ToString();
                connopen();
                string query = " select  tblTinhluong.Maluong ,tblThongtin.Manv ,tblThongtin.Tennv, tblThongtin.Chucvu  ,tblThongtin.Ngaysinh,tblTinhluong.Thang,tblTinhluong.Socong ,tblCalamviec.Calam,tblTinhluong.Loai ,(HSL*Sotienca*Socong + Sotien)as\"Lương\" from tblThongtin inner join tblChucvu on tblThongtin.Chucvu=tblChucvu.Chucvu inner join tblPhanca on tblPhanca.Manv=tblThongtin.Manv inner join tblCalamviec on tblCalamviec.Maca=tblPhanca.Maca inner join tblTinhluong on tblTinhluong.Manv=tblThongtin.Manv inner join tblTienthuong on tblTienthuong.Loai=tblTinhluong.Loai where tblPhanca.Thang= '" + tg.Trim() + "' and tblTinhluong.Thang= '" + tg.Trim() + "' and (tblThongtin.Manv='" + txttimkiem.Text.Trim() + "' or tblThongtin.Tennv=N'" + txttimkiem.Text.Trim() + "')  ;";
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
               
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Tìm không thành công");
            }
        }

        private void dgvxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaluong.Text = dgvxuat.CurrentRow.Cells[0].Value.ToString();
            cboma.Text = dgvxuat.CurrentRow.Cells[1].Value.ToString();
            txtten.Text = dgvxuat.CurrentRow.Cells[2].Value.ToString();
            txtsocong.Text = dgvxuat.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
    
