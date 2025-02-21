using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Form4 : Form
    {
        string role;
        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           TRUNG form = new TRUNG();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        Form3 form = new Form3();
            form.ShowDialog();
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        { 
           

		}
	}
}
