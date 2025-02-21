using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
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
using static System.Windows.Forms.AxHost;
using DataTable = System.Data.DataTable;




namespace BTL 
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            getdata1();
            getdata2();
            
        }
        string connection = "Data Source=LAPTOP-P7MVM1FD;Initial Catalog = BaiTapLon; Integrated Security = True";
        
        public void getdata1()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from hoadon";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
                dgv1.Columns["CREATED_DATE"].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getdata2()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from chitiet_hoadon";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv2.DataSource = ds.Tables[0];
                dgv2.Columns["MAHD"].Visible = false;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable getListSpByCode(string mahd)
        {
            SqlConnection conn = new SqlConnection(connection);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand($"select * from chitiet_hoadon where MAHD = '{mahd}'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txttongtien.Text = dt.Compute("Sum(THANHTIEN)", "").ToString();
            return dt;
        }
       
        
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            (dgv1.DataSource as DataTable).DefaultView.RowFilter = $"MAHD LIKE '%{txttimkiem.Text}%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mahd = txttimkiem.Text == "" ? dgv1.CurrentRow.Cells[0].Value.ToString() : txttimkiem.Text.Contains("HDB") ? txttimkiem.Text : $"HDB{txttimkiem.Text}";
            dgv2.DataSource = getListSpByCode(mahd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            for (int i = 0; i < dgv1.ColumnCount; i++)
            {
                string colName = dgv1.Columns[i].Name;
                // Tạo một DataColumn với tên cột
                DataColumn col = new DataColumn(colName);
                // Thêm DataColumn vào DataTable
                dt.Columns.Add(col);
            }
            foreach (DataGridViewRow dgvrow in dgv1.Rows)
            {
                DataRow dtrow = dt.NewRow();
                // Sử dụng vòng lặp for để gán giá trị cho các cột
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dtrow[i] = dgvrow.Cells[i].Value;
                }
                dt.Rows.Add(dtrow);
            }
            for (int i = 0; i < dgv2.ColumnCount; i++)
            {
                string colName = dgv2.Columns[i].Name;
                // Tạo một DataColumn với tên cột
                DataColumn col = new DataColumn(colName);
                // Thêm DataColumn vào DataTable
                dt2.Columns.Add(col);
            }
            foreach (DataGridViewRow dgvrow in dgv2.Rows)
            {
                DataRow dtrow = dt2.NewRow();
                // Sử dụng vòng lặp for để gán giá trị cho các cột
                for (int i = 0; i < dt2.Columns.Count; i++)
                {
                    dtrow[i] = dgvrow.Cells[i].Value;
                }
                dt2.Rows.Add(dtrow);
            }

            exportEXCEL1(dt, "1", "Lịch sử hóa đơn");
            exportEXCEL2(dt2, "1", "Thông tin hóa đơn");
            
        }
        public void exportEXCEL1(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;
            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "B1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã hóa đơn";

            cl1.ColumnWidth = 17;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Ngày xuất";

            cl2.ColumnWidth = 25.0;

            

            

            // Tạo màu theo hang 
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "B3");

            rowHead.Font.Bold = true;
            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 4;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }
            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        public void exportEXCEL2(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;
            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã hóa đơn";

            cl1.ColumnWidth = 17;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã sản phẩm";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Tên sản phẩm";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Đơn vị";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Số lượng";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Giá bán";

            cl6.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Thành tiền";

            cl7.ColumnWidth = 20.5;

           
            // Tạo màu theo hang 
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;
            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 7;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }
            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void dgv1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv1.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Không có thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {


                int i;
                i = dgv1.CurrentRow.Index;
                dtpdate.Value = Convert.ToDateTime(dgv1.Rows[i].Cells["CREATED_DATE"].Value);
                dgv2.DataSource = getListSpByCode(dgv1.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void dgv3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            dtpdate.Value = Convert.ToDateTime(dgv1.Rows[i].Cells["CREATED_DATE"].Value);
            dgv2.DataSource = getListSpByCode(dgv1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
