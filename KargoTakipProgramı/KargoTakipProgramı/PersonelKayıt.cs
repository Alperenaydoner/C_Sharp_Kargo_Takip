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
    public partial class PersonelKayıt : Form
    {
        public PersonelKayıt()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into PersonelBilgileri (PersonelAd, PersonelSoyad, PersonelTelefon, PersonelEPosta, PersonelSehir, PersonelKullaniciAdi, PersonelSifre)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", TxtEposta.Text);
            komut.Parameters.AddWithValue("@p5", TxtSehir.Text);
            komut.Parameters.AddWithValue("@p6", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p7", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir. Şifreniz : " + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
