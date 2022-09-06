using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KargoTakipProgramı
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {


            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-972PD8E\\SQLEXPRESS;Initial Catalog=KargoTakipProgramı;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
