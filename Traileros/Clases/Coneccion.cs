using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Traileros
{
    class Coneccion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conectado = new SqlConnection(@"Data Source=DARTHVADER\SQLEXPRESS;Initial Catalog=trailers;Integrated Security=True");
            conectado.Open();
            return conectado;
        }
        public static SqlConnection desconectar()
        {
            SqlConnection conectado = new SqlConnection(@"Data Source=DARTHVADER\SQLEXPRESS;Initial Catalog=trailers;Integrated Security=True");
            conectado.Close();
            return conectado;
        }
    }
}
