using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dishekimiveritabani
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dishekimiveritabani.Form7 f2 = new dishekimiveritabani.Form7();
            f2.Show();

            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                Form1 f2 = new Form1();
                f2.Show();
                this.Hide();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }
    }
}
