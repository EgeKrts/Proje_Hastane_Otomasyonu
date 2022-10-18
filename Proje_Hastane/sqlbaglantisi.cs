using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    internal class sqlbaglantisi
    {

        public SqlConnection connection()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0QUH85L;Initial Catalog=HastaneProje;Integrated Security=True");
            baglanti.Open();

            return baglanti;
            
        }

    }
}
