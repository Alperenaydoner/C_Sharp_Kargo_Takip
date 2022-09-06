using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KargoTakipProgramı
{
    public partial class YöneticiGiris : Form
    {

        sqlbaglantisi bgl = new sqlbaglantisi();
        public YöneticiGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From PersonelBilgileri where PersonelKullaniciAdi=@p1 and PersonelSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1(); 
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelKayıt fr = new PersonelKayıt();
            fr.Show();
        }
    }
}
