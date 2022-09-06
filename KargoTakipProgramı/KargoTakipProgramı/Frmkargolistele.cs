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
    public partial class Frmkargolistele : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public Frmkargolistele()
        {
            InitializeComponent();
        }

        private void Frmkargolistele_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KargoEkle", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
