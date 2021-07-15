using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;       // Librerias

namespace Panaderia
{
    class Base_Datos
    {
        public static MySqlConnection Conexion()
        {
            // Conexion a la base de datos creada en MySQL
            MySqlConnection conexion = new MySqlConnection("server = localhost; port = 3306; database = panaderia; Uid = root;Pwd = 271509Familia;");
            // Se abre la conexion
            conexion.Open();
            return conexion;       
        }
    }
}
