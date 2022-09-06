using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmkargoekle fr = new Frmkargoekle();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmkargolistele fr = new Frmkargolistele();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmpersonelListesi fr = new FrmpersonelListesi();
            fr.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            kargoSorgula fr = new kargoSorgula();
            fr.Show();
            this.Hide();
        }
    }
}
