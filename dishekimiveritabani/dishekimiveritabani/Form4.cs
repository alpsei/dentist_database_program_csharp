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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dishekimiveri.accdb");
        OleDbCommand komut;
        DataSet ds = new DataSet();
        string alerji;
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into hasta (hastadi,cins,dogtar,adres,alerji,aciklama,mdurum)values(@hastadi,@cins,@dogtar,@adres,@alerji,@aciklama,@mdurum)";
            komut.Parameters.AddWithValue("@hastadi", textBox2.Text);
            komut.Parameters.AddWithValue("@cins", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@dogtar", dateTimePicker1.Value.ToString());
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.Parameters.AddWithValue("@alerji", alerji);
            komut.Parameters.AddWithValue("@aciklama", textBox3.Text);
            komut.Parameters.AddWithValue("@mdurum", comboBox2.SelectedItem.ToString());
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Tamamlandı.");
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update hasta set hastadi=@hastadi,cins=@cins,dogtar=@dogtar,adres=@adres,alerji=@alerji,aciklama=@aciklama,mdurum=@mdurum where hastaid=@hastaid");
            komut.Parameters.AddWithValue("@hastadi", textBox2.Text);
            komut.Parameters.AddWithValue("@cins", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@dogtar", dateTimePicker1.Value.ToString());
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.Parameters.AddWithValue("@alerji", alerji);
            komut.Parameters.AddWithValue("@aciklama", textBox3.Text);
            komut.Parameters.AddWithValue("@mdurum", comboBox2.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@hastaid", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Delete from hasta where hastaid=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                ds.Clear();
                this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * from hasta where hastaid=@hastaid", baglan);
            komut.Parameters.AddWithValue("@hastaid", textBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);

            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["hastadi"].ToString();
                comboBox1.Text = dr["cins"].ToString();
                dateTimePicker1.Text = dr["dogtar"].ToString();
                textBox4.Text = dr["adres"].ToString();
                textBox3.Text = dr["aciklama"].ToString();
                comboBox2.Text = dr["mdurum"].ToString();
            }
            else

                MessageBox.Show("Hasta Bulunamadı");
            baglan.Close();
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = false;
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button5.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
                button5.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            alerji = "Var";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            alerji = "Yok";
        }
    }
}
