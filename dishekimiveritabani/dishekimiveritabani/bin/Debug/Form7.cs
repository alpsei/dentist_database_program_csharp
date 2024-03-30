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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dishekimiveri.accdb");
        OleDbCommand komut;
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into personel (padisoyadi,pcins,pdogtar,pbastar,pdiplomano,udiplomano,bolumu,gorevi,tcno)values(@padisoyadi,@pcins,@pdogtar,@pbastar,@pdiplomano,@udiplomano,@bolumu,@gorevi,@tcno)";
            komut.Parameters.AddWithValue("@padisoyadi",textBox1.Text);
            komut.Parameters.AddWithValue("@pcins",comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@pdogtarih",dateperdogtar.Value.ToString());
            komut.Parameters.AddWithValue("@pbastarih",dateperbastar.Value.ToString());
            komut.Parameters.AddWithValue("@pdiplomano",textBox5.Text);
            komut.Parameters.AddWithValue("@udiplomano",textBox6.Text);
            komut.Parameters.AddWithValue("@bolumu",textBox7.Text);
            komut.Parameters.AddWithValue("@gorevi",textBox8.Text);
            komut.Parameters.AddWithValue("@tcno",textBox9.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Tamamlandı.");
            textBox1.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "";
            this.personelTableAdapter.Fill(this.dishekimiveriDataSet.personel);
            }

        private void button3_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update personel set padisoyadi=@padisoyadi,pcins=@pcins,pdogtar=@pdogtarih,pbastar=@pbastarih,pdiplomano=@pdiplomano,udiplomano=@udiplomano,bolumu=@bolumu,gorevi=@gorevi,tcno=@tcno where pid=@pid");
            komut.Parameters.AddWithValue("@padisoyadi", textBox1.Text);
            komut.Parameters.AddWithValue("@pcins", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@pdogtar", dateperdogtar.Value.ToString());
            komut.Parameters.AddWithValue("@pbastar", dateperbastar.Value.ToString());
            komut.Parameters.AddWithValue("@pdiplomano", textBox5.Text);
            komut.Parameters.AddWithValue("@udiplomano", textBox6.Text);
            komut.Parameters.AddWithValue("@bolumu", textBox7.Text);
            komut.Parameters.AddWithValue("@gorevi", textBox8.Text);
            komut.Parameters.AddWithValue("@tcno", textBox9.Text);
            komut.Parameters.AddWithValue("@pid", textBox2.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.personelTableAdapter.Fill(this.dishekimiveriDataSet.personel);
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
                komut.CommandText = "Delete from personel where pid=" + textBox2.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                ds.Clear();
                this.personelTableAdapter.Fill(this.dishekimiveriDataSet.personel);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dishekimiveriDataSet.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.dishekimiveriDataSet.personel);
            
            // TODO: This line of code loads data into the 'dishekimiveriDataSet3.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.dishekimiveriDataSet.personel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            
            
         
        }

     

        private void button5_Click(object sender, EventArgs e)
        {
            
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = false;
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from personel where pid=@pid", baglan);
            komut.Parameters.AddWithValue("@pid", textBox2.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["padisoyadi"].ToString();
                textBox5.Text = dr["pdiplomano"].ToString();
                textBox6.Text = dr["udiplomano"].ToString();
                comboBox1.Text = dr["pcins"].ToString();
                textBox7.Text = dr["bolumu"].ToString();
                textBox8.Text = dr["gorevi"].ToString();
                textBox9.Text = dr["tcno"].ToString();
            }
            else
                MessageBox.Show("Personel Bulunamadı");
            baglan.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            if (textBox2.Text == "")
            {
                button5.Enabled = false;

            }
            if (textBox2.Text == "")
            {
                button3.Enabled = false;

            }
            if (textBox2.Text == "")
            {
                button2.Enabled = false;

            }
            if (textBox2.Text == "")
            {
                button1.Enabled = true;

            }
        }
    }
}
