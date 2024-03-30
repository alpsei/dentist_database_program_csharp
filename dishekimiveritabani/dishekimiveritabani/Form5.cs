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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dishekimiveri.accdb");
        OleDbCommand komut;
        DataSet ds = new DataSet();
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.ucret' table. You can move, or remove it, as needed.
            this.ucretTableAdapter.Fill(this.dishekimiveriDataSet.ucret);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.dishekimiveriDataSet.personel);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.muayene' table. You can move, or remove it, as needed.
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.dishekimiveriDataSet.personel);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.muayene' table. You can move, or remove it, as needed.
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.muayene' table. You can move, or remove it, as needed.
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.dishekimiveriDataSet.hasta);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.muayene' table. You can move, or remove it, as needed.
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.muayene' table. You can move, or remove it, as needed.
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update muayene set hastaid=@hastaid,muayenetar=@muayenetar,muayenesaat=@muayenesaat,sikayet=@sikayet,sonuc=@sonuc,durum=@durum where mid=@mid");
            komut.Parameters.AddWithValue("@hastaid", textBox2.Text);
            komut.Parameters.AddWithValue("@muayenetar", dateTimePicker1.Value.ToString());
            komut.Parameters.AddWithValue("@muayenesaat", textBox7.Text);
            komut.Parameters.AddWithValue("@sikayet", richTextBox1.Text);
            komut.Parameters.AddWithValue("@sonuc", textBox6.Text);
            komut.Parameters.AddWithValue("@durum", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@pid", textBox13.Text);
            komut.Parameters.AddWithValue("@islemno", textBox16.Text);
            komut.Parameters.AddWithValue("@mid", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
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
                komut.CommandText = "Delete from muayene where mid=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                ds.Clear();
                this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Insert into muayene (hastaid,muayenetar,muayenesaat,sikayet,sonuc,durum,pid,islemno)values(@hastaid,@muayenetar,@muayenesaat,@sikayet,@sonuc,@durum,@pid,@islemno)";
                komut.Parameters.AddWithValue("@hastaid", textBox2.Text);
                komut.Parameters.AddWithValue("@muayenetar", dateTimePicker1.Value.ToString());
                komut.Parameters.AddWithValue("@muayenesaat", textBox7.Text);
                komut.Parameters.AddWithValue("@sikayet", richTextBox1.Text);
                komut.Parameters.AddWithValue("@sonuc", textBox6.Text);
                komut.Parameters.AddWithValue("@durum", comboBox1.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@pid", textBox13.Text);
                komut.Parameters.AddWithValue("@islemno", textBox16.Text);
                komut.Parameters.AddWithValue("@mid", textBox1.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Tamamlandı.");
                this.muayeneTableAdapter.Fill(this.dishekimiveriDataSet.muayene);
                textBox3.Clear();
                richTextBox1.Clear();
                textBox6.Clear();
                textBox7.Clear();
                comboBox1.Text = "";
                textBox7.Enabled = true;
                richTextBox1.Enabled = true;
                textBox6.Enabled = true;
                comboBox1.Enabled = true;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Hasta Numarası Girilmedi.");
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from muayene where mid=@mid", baglan);
            komut.Parameters.AddWithValue("@mid", textBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["hastaid"].ToString();
                richTextBox1.Text = dr["sikayet"].ToString();
                textBox6.Text = dr["sonuc"].ToString();
                textBox7.Text = dr["muayenesaat"].ToString();
            }
            else
                MessageBox.Show("Muayene Bilgisi Bulunamadı");
            baglan.Close();
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            textBox7.Enabled = true;
            richTextBox1.Enabled = true;
            textBox6.Enabled = true;
            comboBox1.Enabled = true;
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
                button3.Enabled = false;
            }
            if (textBox1.Text == "")
            {
                button2.Enabled = false;
            }
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox7.Enabled = true;
                richTextBox1.Enabled = true;
                textBox6.Enabled = true;
                comboBox1.Enabled = true;
            }
            else if (textBox3.Text == "")
            {
                textBox7.Enabled = false;
                richTextBox1.Enabled = false;
                textBox6.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from hasta where hastaid=@hastaid", baglan);
            komut.Parameters.AddWithValue("@hastaid", textBox3.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hasta Bulundu", "Hasta bilgisi");
                textBox2.Text = textBox3.Text;
                textBox4.Text = dr["hastadi"].ToString();
                textBox5.Text = dr["cins"].ToString();
                textBox8.Text = dr["dogtar"].ToString();
                textBox9.Text = dr["adres"].ToString();
                textBox10.Text = dr["alerji"].ToString();
                textBox11.Text = dr["aciklama"].ToString();
                textBox12.Text = dr["mdurum"].ToString();
            }
            else
                MessageBox.Show("Hasta Bulunamadı", "Hasta bilgisi");
            baglan.Close();
            textBox3.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from personel where pid=@pid", baglan);
            komut.Parameters.AddWithValue("@pid", textBox14.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Personel Bulundu", "Personel bilgisi");
                textBox13.Text = textBox14.Text;
            }
            else
                MessageBox.Show("Personel Bulunamadı", "Hasta bilgisi");
            baglan.Close();
            textBox14.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from ucret where islemno=@islemno", baglan);
            komut.Parameters.AddWithValue("@islemno", textBox15.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("İşlem Bulundu", "İşlem Bilgisi");
                textBox16.Text = textBox15.Text;
            }
            else
                MessageBox.Show("İşlem Bulunamadı", "İşlem bilgisi");
            baglan.Close();
            textBox15.Clear();
        }
    }
}
