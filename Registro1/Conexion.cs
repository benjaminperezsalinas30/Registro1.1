using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Registro1
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=GAMERSTORECBBA;DATABASE=REGISTRO1;integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
