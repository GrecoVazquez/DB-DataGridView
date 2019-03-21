using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaDB
{
    class Connection
    {
        public SqlConnection NewConection()
        {
            SqlConnection conexion = new SqlConnection("server=HGDLAPVAZQUEZPA\\SQLEXPRESS; database=Hitss_TM ; integrated security = true");
            conexion.Open();
            Console.WriteLine("Conexion establecida");
            return conexion;
        }
    }
}
