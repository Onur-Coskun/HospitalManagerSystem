using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    class sqlbağlantisi
        
    {
        public SqlConnection bağlanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C183FF8\\SQLEXPRESS;Initial Catalog=HasteneProje;Integrated Security=True");
            baglan.Open();
            return baglan;


        } 


    }
}
