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
    public partial class Form2 : Form
    {
        string thanhTien = "";
            string mahd = "";
        public Form2(string mahd)
        {           
            InitializeComponent();
            this.mahd = mahd;
            inhoadon();
            
        }
        public void inhoadon()
        {
            ppdhoadon.Document = pdhoadon;
            ppdhoadon.ShowDialog();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
		string connection = "Data Source=LAPTOP-P7MVM1FD;Initial Catalog = BaiTapLon; Integrated Security = True";
		private void pdhoadon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // join tb chitiet_hoadon + tb hoadon = MAHD
            SqlConnection conn = new SqlConnection(connection);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * " +
                       "from hoadon a inner join chitiet_hoadon c " +
                       "on a.MAHD  = c.MAHD " +
                       $"Where c.MAHD = '{mahd}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            // tính cột THANHTIEN 
            query = "select sum(THANHTIEN) from chitiet_hoadon  " +
                             $"Where MAHD = '{mahd}'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            thanhTien = dt.Rows[0].ItemArray.ElementAt(0).ToString();
            // vẽ hóa đơn
            var w = pdhoadon.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawString(string.Format("{0}", "HÓA ĐƠN THANH TOÁN"),
                new Font("Courier New", 30, FontStyle.Bold),
                Brushes.Black,
                new Point(170, 10)
                );
            e.Graphics.DrawString(string.Format("{0}", "Địa chỉ:Trường Đại Học Công Nghệ GTVT"),
               new Font("Courier New", 12, FontStyle.Bold),
               Brushes.Black,
               new Point(20, 105)
               );
            e.Graphics.DrawString(string.Format("{0}", "Nhân viên thanh toán:Bùi Hữu Trung "),
             new Font("Courier New", 12, FontStyle.Bold),
             Brushes.Black,
             new Point(20, 140)
             );
            e.Graphics.DrawString(string.Format("{0}", "Số hóa đơn: " + mahd),
             new Font("Courier New", 12, FontStyle.Bold),
             Brushes.Black,
             new Point(20, 175)
             );
            e.Graphics.DrawString(string.Format("{0}", "Ngày lập :" + DateTime.Now.ToString("dd/MM/yyyy  HH:mm ")),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(400, 75)
                );
            var y = 250;
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
            Pen pen = new Pen(Color.Black, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawLine(pen, p1, p2);
            e.Graphics.DrawString("STT", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(20, 255));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(150, 255));
            e.Graphics.DrawString("Đơn vị", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("Số lượng", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Đơn giá ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(640, 255));
            e.Graphics.DrawString("Thành tiền ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(730, 255));

            int khoangcach = 280;
            int indx = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                e.Graphics.DrawString((++indx).ToString().PadLeft(1, '1'), new Font("Arial", 12), Brushes.Black, new Point(20, khoangcach));
                e.Graphics.DrawString(row["TENSP"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(150, khoangcach));
                e.Graphics.DrawString(row["DONVI"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(380, khoangcach));
                e.Graphics.DrawString(row["SOLUONG"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(510, khoangcach));
                e.Graphics.DrawString(row["GIABAN"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(640, khoangcach));
                e.Graphics.DrawString(row["THANHTIEN"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(770, khoangcach));
                khoangcach += 35;
            }

            var h = 560;
            Point p3 = new Point(10, h);
            Point p4 = new Point(w - 10, h);
            Pen pen1 = new Pen(Color.Black, 1);
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawLine(pen1, p3, p4);
            e.Graphics.DrawString("Tổng cộng:" + thanhTien + " " + "VND", new Font("Courier New", 17, FontStyle.Bold), Brushes.Black, new Point(300, 600));
			e.Graphics.DrawString("Tiền khách trả " + thanhTien + " " + "VND", new Font("Courier New", 17, FontStyle.Bold), Brushes.Black, new Point(350, 600));

			// Gọi hàm SoThanhChu để chuyển đổi số thành chữ

		}
         
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "không";

            if (number < 0)
                return "âm " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "lẻ ";

                var unitsMap = new[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
                var tensMap = new[] { "không", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words.Trim();
        }
    }
}
    

