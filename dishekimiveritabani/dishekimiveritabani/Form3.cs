using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace dishekimiveritabani
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dishekimiveri.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbDataAdapter a = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "SELECT * from muayene where hastaid=@hastaid";
            komut.Parameters.AddWithValue("@hastaid", hastaid.Text);
            adtr = new OleDbDataAdapter(komut);
            ds = new DataSet();
            adtr.Fill(ds, "muayene");
            dataGridView1.DataSource = ds.Tables["muayene"];
            MessageBox.Show("İşlem Tamamlandı");
            baglan.Close();
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.muayene' table. You can move, or remove it, as needed.
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "SELECT * from muayene where pid=@pid";
            komut.Parameters.AddWithValue("@pid", personelid.Text);
            adtr = new OleDbDataAdapter(komut);
            ds = new DataSet();
            adtr.Fill(ds, "muayene");
            dataGridView1.DataSource = ds.Tables["muayene"];
            MessageBox.Show("İşlem Tamamlandı");
            baglan.Close();
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
          
        }

    }
}
