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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dishekimiveri.accdb");
        OleDbCommand komut;
        DataSet ds = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);


        }

            

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Delete from ucret where islemno=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                ds.Clear();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update ucret set islemadi=@islemadi,ucrett=@ucrett,islemtar=@islemtar where islemno=@islemno");
            komut.Parameters.AddWithValue("@islemadi", textBox2.Text);
            komut.Parameters.AddWithValue("@ucrett", textBox3.Text);
            komut.Parameters.AddWithValue("@islemtar", dateTimePicker1.Value.ToString());
            komut.Parameters.AddWithValue("@islemno", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from ucret where islemno=@islemno", baglan);
            komut.Parameters.AddWithValue("@islemno", textBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["islemadi"].ToString();
                textBox3.Text = dr["ucrett"].ToString();
            }
            else

                MessageBox.Show("Girilen İşlem Bulunamadı");
            baglan.Close();

                button3.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            if (textBox1.Text == "")
            {
                button5.Enabled = false;

            }
            if (textBox1.Text == "")
            {
                button1.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into ucret (islemadi,ucrett,islemtar)values(@islemadi,@ucrett,@islemtar)";
            komut.Parameters.AddWithValue("@islemadi", textBox2.Text);
            komut.Parameters.AddWithValue("@ucrett", textBox3.Text);
            komut.Parameters.AddWithValue("@islemtar", dateTimePicker1.Value.ToString());
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Tamamlandı.");
            textBox2.Clear();
            textBox3.Clear();
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
        }
    }
}
