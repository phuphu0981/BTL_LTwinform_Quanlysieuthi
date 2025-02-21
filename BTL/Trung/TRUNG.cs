using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;



namespace BTL
{
    public partial class TRUNG : Form
    {
        string state;
        public TRUNG()
        {

            InitializeComponent();

            getdata();
            state = "RESET";
            swich(state);
            txtchietkhau.Text = "0";
            txtthanhtien.Text = "0";

        }
        #region f1 load
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        string connection = "Data Source= LAPTOP-P7MVM1FD;Initial Catalog = BaiTapLon; Integrated Security = True";

		public void getdata()
        {
            SqlConnection conn = new SqlConnection(connection);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select MaSP,TenSP,DonVi,SoLuong,GiaXuat from tblHangHoa";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgv1.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void dgv1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i;
                i = dgv1.CurrentRow.Index;
                txtmasp.Text = dgv1.Rows[i].Cells[0].Value.ToString();
                txtdvtinh.Text = dgv1.Rows[i].Cells[2].Value.ToString();
                txttensp.Text = dgv1.Rows[i].Cells[1].Value.ToString();
                txtslsp.Text = dgv1.Rows[i].Cells[3].Value.ToString();
                txtgianhap.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        public void swich(string state)
        {
            switch (state)
            {
                case "RESET":
                    txtmasp.Enabled = false;
                    txtgianhap.Enabled = false;
                    txttensp.Enabled = false;
                    txtdvtinh.Enabled = false;
                    txtchietkhau.Enabled = true;
                    txtslsp.Enabled = false;
                    txtthanhtien.Enabled = false;

                    btthem.Enabled = true;
                    btsua.Enabled = true;
                    btxoa.Enabled = true;
                    btok.Enabled = false;
                    btcancel.Enabled = false;
                    break;

                case "ADD":
                    txtmasp.Enabled = false;
                    txtgianhap.Enabled = false;
                    txttensp.Enabled = false;
                    txtdvtinh.Enabled = false;
                    txtchietkhau.Enabled = true;
                    txtslsp.Enabled = false;
                    txtthanhtien.Enabled = false;
                    txtslnhap.Enabled = true;


                    btthem.Enabled = false;
                    btsua.Enabled = false;
                    btxoa.Enabled = false;
                    btreset.Enabled = true;
                    btok.Enabled = true;
                    btcancel.Enabled = true;

                    break;
                case "UPDATE":
                    txtmasp.Enabled = false;
                    txtgianhap.Enabled = true;
                    txttensp.Enabled = true;
                    txtdvtinh.Enabled = true;
                    txtchietkhau.Enabled = false;
                    txtslsp.Enabled = true;
                    txtslnhap.Enabled = false;
                    txtthanhtien.Enabled = false;

                    btthem.Enabled = false;
                    btsua.Enabled = false;
                    btxoa.Enabled = false;
                    btreset.Enabled = true;
                    btok.Enabled = true;
                    btcancel.Enabled = true;
                    txtmasp.Focus();
                    break;
                case "DELETE":
                    txtmasp.Enabled = false;
                    txtgianhap.Enabled = false;
                    txttensp.Enabled = false;
                    txtdvtinh.Enabled = false;
                    txtchietkhau.Enabled = false;
                    txtslsp.Enabled = false;
                    txtslnhap.Enabled = false;
                    txtthanhtien.Enabled = false;


                    btthem.Enabled = false;
                    btsua.Enabled = false;
                    btxoa.Enabled = false;
                    btreset.Enabled = true;
                    btok.Enabled = true;
                    btcancel.Enabled = true;
                    txtmasp.Focus();
                    break;

                case "CLEAR":
                    txtmasp.ResetText();
                    txtgianhap.ResetText();
                    txttensp.ResetText();
                    txtthanhtien.ResetText();
                    txtdvtinh.ResetText();
                    txtslnhap.ResetText();
                    txtslsp.ResetText();
                    break;
            }
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            state = "ADD";
            swich(state);
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            state = "UPDATE";
            swich(state);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            state = "DELETE";
            swich(state);
        }
        private void btcancel_Click(object sender, EventArgs e)
        {
            state = "RESET";
            swich(state);
        }
        private void btreset_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                txtmasp.ResetText();
                txttensp.ResetText();
                txtdvtinh.ResetText();
                txtslsp.ResetText();
                txtgianhap.ResetText();
                txtthanhtien.ResetText();
                txtslnhap.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btthoat_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgv2.Rows.Count != 0)
                {
                    MessageBox.Show("Bạn chưa thanh toán ! ", "Thông báo", MessageBoxButtons.OK);
                }
                else if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TIMKIEM_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string rowFilter = string.Format("{0} like '{1}'", "TENSP", "*" + TIMKIEM.Text + "*");
                (dgv1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btok_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "ADD")
                {
                    insert();
                }
                else if (state == "UPDATE")
                {
                    update();
                }
                else if (state == "DELETE")
                {
                    delete();
                }
                txtmasp.ResetText();
                txttensp.ResetText();
                txtdvtinh.ResetText();
                txtslsp.ResetText();
                txtgianhap.ResetText();
                txtslnhap.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            List<dynamic> ordList = new List<dynamic>();
        public void insert()
        {
            try
            {
                if (txtmasp.Text == "" || txttensp.Text == "" || txtslsp.Text == "" || txtgianhap.Text == "" || txtdvtinh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (txtslnhap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập so luong ! ", "Thông báo", MessageBoxButtons.OK);

                }
                else if (txtchietkhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập chiết khấu !", "Thông báo ", MessageBoxButtons.OK);
                }
                else
                {
                    int a = int.Parse(txtslnhap.Text);
                    int b = int.Parse(txtgianhap.Text);
                    int d = int.Parse(txtslsp.Text);
                    if (a > d || a == 0)
                    {
                        MessageBox.Show("Vượt quá số lượng sản phẩm trong kho !", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        bool duplicate = false;
                        foreach (var item in ordList)
                        {
                            if (item.MASP == txtmasp.Text)
                            {
                                duplicate = true;
                                break;
                            }
                        }
                        if (duplicate)
                        {
                            MessageBox.Show("Sản phẩm đã có trong giỏ hàng !", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dynamic obj = new ExpandoObject();
                            obj.STT = ordList.Count + 1;
                            obj.MASP = txtmasp.Text;
                            obj.TENSP = txttensp.Text;
                            obj.DONVI = txtdvtinh.Text;
                            obj.SOLUONG = txtslnhap.Text;
                            string dongia = txtchietkhau.Text != "0" ? (decimal.Parse(txtgianhap.Text) - ((decimal.Parse(txtgianhap.Text) * decimal.Parse(txtchietkhau.Text) / 100))).ToString() : double.Parse(txtgianhap.Text).ToString();
                            obj.DONGIA = dongia;
                            ordList.Add(obj);
                            if (dgv2.Columns.Count == 0)
                            {
                                dgv2.Columns.Add("MASP", "Mã sản phẩm");
                                dgv2.Columns.Add("TENSP", "Tên sản phẩm");
                                dgv2.Columns.Add("DONVI", "Đơn vị");
                                dgv2.Columns.Add("SOLUONG", "Số lượng");
                                dgv2.Columns.Add("DONGIA", "Đơn giá");
                            }
                            dgv2.Rows.Add(new object[] { obj.MASP, obj.TENSP, obj.DONVI, obj.SOLUONG, obj.DONGIA });
                            decimal total = 0;
                            ordList.ForEach(x =>
                            {
                                total += decimal.Parse(x.DONGIA.ToString()) * decimal.Parse(x.SOLUONG.ToString());
                                txtthanhtien.Text = total.ToString();
                            });
                            SqlConnection conn = new SqlConnection(connection);
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            int l = d - a;
                            txtslsp.Text = l.ToString();
                            string updatesoluong = "Update tblHangHoa set SoLuong ='" + l.ToString() + "' where MaSP = '" + txtmasp.Text + "' ";
                            SqlCommand cmd1 = new SqlCommand(updatesoluong, conn);
                            cmd1.ExecuteNonQuery();
                            getdata();
                        }
                        #region an
                        //string query = "insert into banhang3 values('" + txtmasp.Text + "','" + txttensp.Text + "','" + txtdvtinh.Text + "','" + txtslnhap.Text + "','" + txtgianhap.Text + "','')";
                        //     SqlCommand cmd = new SqlCommand(query, conn);
                        //     cmd.ExecuteNonQuery();




                        //     int s = a * b;
                        //     int g = int.Parse(txtchietkhau.Text.ToString());
                        //     int m = s + s * g / 100;

                        //     string thanhtien1 = "Update banhang3 set THANHTIEN ='" + m.ToString() + "' where MASP = '" + txtmasp.Text + "' ";
                        //     SqlCommand cmd2 = new SqlCommand(thanhtien1, conn);
                        //     cmd2.ExecuteNonQuery();

                        //     double tongtien = 0;

                        //     int sodong = dgv2.Rows.Count;
                        //     int thanhien = a*b+a*b*g/100;
                        //     for (int i = 0; i < sodong-1 ; i++)
                        //     {

                        //         thanhien = thanhien + int.Parse(dgv2.Rows[i].Cells["THANHTIEN"].Value.ToString());
                        //     }

                        //     txtthanhtien.Text = thanhien.ToString();

                        //     state = "ADD";

                        //     swich(state);


                        //getdata1();
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete()
        {
            try
            {

                #region an
                //SqlConnection conn = new SqlConnection(connection);
                //if (conn.State == ConnectionState.Closed)
                //{
                //    conn.Open();
                //}
                //string query = "delete from banhang3 where MASP='" + txtmasp.Text + "'";
                //SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.ExecuteNonQuery();
                //conn.Close();
                //getdata1();
                #endregion
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ordList.Remove(ordList.Where(x => x.MASP == txtmasp.Text).FirstOrDefault());
                    dgv2.Rows.RemoveAt(dgv2.CurrentRow.Index);
                   
                }
                int a = int.Parse(txtslnhap.Text);
                int b = int.Parse(txtgianhap.Text);
                int d = int.Parse(txtslsp.Text);
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int l = d + a;
              
                string updatesoluong = "Update tblHangHoa set SOLUONG ='" + l.ToString() + "' where MASP = '" + txtmasp.Text + "' ";
                SqlCommand cmd1 = new SqlCommand(updatesoluong, conn);
                cmd1.ExecuteNonQuery();
                getdata();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void update()
        {
            try
            {
                
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update  tblHangHoa set MaSP ='" + txtmasp.Text + "',TenSP='" + txttensp.Text + "',DonVi='" + txtdvtinh.Text + "',SoLuong='" + txtslsp.Text + "',GiaXuat='" + txtgianhap.Text + "' WHERE MaSP='" + txtmasp.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                state = "RESET";
                swich(state);
                conn.Close();
                getdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            try {
                if (dgv2.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có sản phẩm trong giỏ hàng ", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    #region an
                    //string insertQuery = $"DELETE FROM banhang3 INSERT INTO banhang3 VALUES ";
                    //ordList.ForEach(x => {
                    //    string tensp = x.TENSP;
                    //    string masp = x.MASP;
                    //    string donvi = x.DONVI;
                    //    decimal soluong = decimal.Parse(x.SOLUONG);
                    //    decimal dongia = decimal.Parse(x.DONGIA);

                    //    insertQuery += $"(N'{masp}',N'{tensp}',N'{donvi}', {soluong}, {dongia}, {dongia * soluong}),";
                    //});
                    //insertQuery = insertQuery.Remove(insertQuery.Length - 1);
                    //SqlConnection conn = new SqlConnection(connection);
                    //if (conn.State == ConnectionState.Closed)
                    //{
                    //    conn.Open();
                    //}

                    //SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    //int kq = cmd.ExecuteNonQuery();
                    //if (kq > 0)
                    //{
                    //    Form2 f = new Form2();

                    //    f.ShowDialog();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Can not insert data to database");
                    //} 
                    #endregion
                    SqlConnection conn = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand("Cre_HD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MAHD", SqlDbType.VarChar, 255);
                    cmd.Parameters["@MAHD"].Direction = ParameterDirection.Output;
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    string mahd = cmd.Parameters["@MAHD"].Value.ToString();

                    ordList.ForEach(x =>
                    {
                        string tensp = x.TENSP;
                        string masp = x.MASP;
                        string donvi = x.DONVI;
                        decimal soluong = decimal.Parse(x.SOLUONG);
                        decimal dongia = decimal.Parse(x.DONGIA);

                        cmd = new SqlCommand("Cre_chitiet_hoadon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MAHD", mahd);
                        cmd.Parameters.AddWithValue("@TENSP", tensp);
                        cmd.Parameters.AddWithValue("@MASP", masp);
                        cmd.Parameters.AddWithValue("@DONVI", donvi);
                        cmd.Parameters.AddWithValue("@GIABAN", dongia);
                        cmd.Parameters.AddWithValue("@SOLUONG", soluong);
                        cmd.Parameters.AddWithValue("@THANHTIEN", soluong * dongia);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        cmd.ExecuteNonQuery();
                       
                       
                    });
                    ordList.Clear();
                    dgv2.Rows.Clear();
                    dgv2.Columns.Clear();
                    txtthanhtien.Text = "0";

                    if (txtsdt.Text != "")
                    {
                        int g = int.Parse(txttichdiem1.Text);
                        int h = int.Parse(txtdiemhienco.Text);
                        int j = h + g;
                        string query = "update  tblKH_ThanThiet set  TichDiem ='"+ j.ToString()+ "' WHERE SoDienThoai='" + txtsdt.Text + "'";
                         cmd = new SqlCommand(query, conn);
                        
                        cmd.ExecuteNonQuery();
                        getdatakh();
                    }
                    MessageBox.Show("Thanh toán thành công ! ", "Thông báo", MessageBoxButtons.OK);
                    
                    Form2 f2 = new Form2(mahd);    
                    f2.ShowDialog();
                    f2.Visible = false;
               
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getdatakh()
        {
            SqlConnection conn = new SqlConnection(connection);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from tblKH_ThanThiet";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã sản phẩm";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên sản phẩm";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Đơn vị";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Số lượng";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Đơn giá";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

           
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

            rowHead.Font.Bold = true;
           

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            

            rowHead.Interior.ColorIndex = 4;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

           

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
         

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }
           

            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

           
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

           
            range.Value2 = arr;

           

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

           
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
              
            DataTable dt = new DataTable(); 
            for(int i = 0; i < dgv1.ColumnCount ; i++)
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
            export(dt, "32234", "Bán hàng");
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            int quatang;
            quatang = int.Parse(txtthanhtien.Text);
            if (quatang > 1000000)
            {
                MessageBox.Show("Đủ điều kiện nhận quà");
                Form6 form6 = new Form6();
                form6.ShowDialog();
            }
            else MessageBox.Show("Không đủ điều kiện nhận quà");
        }

        private void dgv2_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgv2.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Hàng mới không có thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {


                int i;
                i = dgv2.CurrentRow.Index;

                txtmasp.Text = dgv2.Rows[i].Cells["MASP"].Value.ToString();
                txtdvtinh.Text = dgv2.Rows[i].Cells["DONVI"].Value.ToString();
                txttensp.Text = dgv2.Rows[i].Cells["TENSP"].Value.ToString();
                txtslnhap.Text = dgv2.Rows[i].Cells["SOLUONG"].Value.ToString();
                txtgianhap.Text = dgv2.Rows[i].Cells["DONGIA"].Value.ToString();
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectQuery = "SELECT SoLuong FROM tblHangHoa WHERE MaSP='" + txtmasp.Text + "'";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                object result = selectCmd.ExecuteScalar();

               
                if (result != null)
                {
                    txtslsp.Text = result.ToString();
                }

                conn.Close();
                getdata();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rowFilter = string.Format("{0} like '{1}'", "TENSP", "*" + TIMKIEM.Text + "*");
                (dgv1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string sdt = "";

        // Khai báo biến số điểm
        int diem = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);    
          
            string sdt = txtsdt.Text;

           
            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

           
            string sql = "SELECT TichDiem FROM tblKH_ThanThiet WHERE SoDienThoai ='"+txtsdt.Text+"' ";

           
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue(txtsdt.Text, sdt);

         
            conn.Open();

           
            object result = cmd.ExecuteScalar();

          
            conn.Close();

           
            if (result == null)
            {
                
                MessageBox.Show("Không có số điện thoại này trong cơ sở dữ liệu!");
            }
            else
            {
               
                int sodiem = (int)result;

               
                txtdiemhienco.Text = sodiem.ToString();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (txtsudungdiem.Text != "")
            {
                int p = int.Parse(txtsudungdiem.Text);
                int q = int.Parse(txtchietkhau.Text);
                for (int i = 100; i <= p; i += 100)
                {
                    q += 5;
                }
                txtchietkhau.Text = q.ToString();
                SqlConnection conn = new SqlConnection(connection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand();
                if (txtsdt.Text != "" && txtsudungdiem.Text != "")
                {
                    int g = int.Parse(txtsudungdiem.Text);
                    int h = int.Parse(txtdiemhienco.Text);
                    int j = h - g;
                    if (h < g)
                    {
                        MessageBox.Show("Không đủ điểm ! ", "Thông báo", MessageBoxButtons.OK);
                        txtchietkhau.Text = "0";
                    }
                    else { txtdiemhienco.Text = j.ToString();
                    string query = "update  tblKH_ThanThiet set  TichDiem ='" + j.ToString()
                        + "' WHERE SoDienThoai='" + txtsdt.Text + "'";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    getdatakh();
          MessageBox.Show("Sử dụng điểm thành công ! ", "Thông báo", MessageBoxButtons.OK);
                        txtsudungdiem.ResetText();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Không có giá trị ! ", "Thông báo", MessageBoxButtons.OK);
            }
        }

		private void label15_Click(object sender, EventArgs e)
		{

		}
	}
           

      }
    
