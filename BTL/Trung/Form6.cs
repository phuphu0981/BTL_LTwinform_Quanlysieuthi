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

namespace BTL
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            getquatang();
            txtso.Enabled = true;
            
            
        }
        string connection = "Data Source=LAPTOP-P7MVM1FD;initial Catalog = BaiTapLon; Integrated Security = True";

		public void getquatang()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from quatang";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void randum()
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            txtso.Text = dgv1.Rows[i].Cells["so"].Value.ToString();
            txttenquatang.Text = dgv1.Rows[i].Cells["tenquatang"].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            int numfift = 5;
            int gift = 0;
          
                 gift = rand.Next(1, numfift + 1);
            string quatang = dgv1.Rows[gift-1].Cells["tenquatang"].Value.ToString();
            MessageBox.Show("Ban nhan duoc qua tang : " +quatang);
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "insert into quatang values ( '" + txtso.Text + "','" + txttenquatang.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                getquatang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update quatang set  so= '" + txtso.Text + "',tenquatang='" + txttenquatang.Text + "'where so ='" + txtso.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                getquatang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "delete from quatang where so = '" + txtso.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
              
                conn.Close();
                getquatang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void export(DataTable dataTable, string sheetName, string title)
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

            cl1.Value2 = "Số";

            cl1.ColumnWidth = 17;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên quà tặng";

            cl2.ColumnWidth = 25.0;





            // Tạo màu theo hang 
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "B3");

            rowHead.Font.Bold = true;
            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 8;

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
        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            txtso.Text = dgv1.Rows[i].Cells["so"].Value.ToString();
            txttenquatang.Text = dgv1.Rows[i].Cells["tenquatang"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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
            export(dt, "32234", "Quà tặng đặc biệt");
        }
    }
    }

