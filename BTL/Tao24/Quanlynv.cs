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
using System.Runtime.InteropServices;

namespace BTL
{
    
    public partial class Quanlynv : Form
    {
      

		public Quanlynv()
        {
            InitializeComponent();

        }

        private Form fcon;

        private void oppenfcon(Form con)
        {
            if (fcon != null)
            {
                fcon.Close();
            }
            fcon = con;
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            con.Dock = DockStyle.Fill;
            panelthan.Controls.Add(con);
            panelthan.Tag = con;
            con.BringToFront();
            con.Show();
        }

        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            oppenfcon(new Thongtinnv());
            lblmain.Text = btnthongtinnv.Text;
        }

        private void btntinhluong_Click(object sender, EventArgs e)
        {
            oppenfcon(new Tinhluongnv());
            lblmain.Text = btntinhluong.Text;
        }

        private void btnbangluong_Click(object sender, EventArgs e)
        {
            oppenfcon(new Phanca());
            lblmain.Text = btnbangluong.Text;
        }

        private void lblmain_Click(object sender, EventArgs e)
        {
            if (fcon != null)
            {
                fcon.Close();
                lblmain.Text = "Home";
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button4.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button4.Visible = false;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
    }

}
