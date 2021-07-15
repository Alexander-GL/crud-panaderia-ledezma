using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;        // Librerias

namespace Panaderia
{
    class EmpleadosDAL // Esta clase tendra el acceso en capas a la base de datos.
    {
        public static int Agregar(Empleado pEmpleado) // Esta clase sirve para agregar un empleado a la BD
        {
            // Se inicializa la variable de retorno en 0
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into  empleado (Clave, Dirección, Telefono," +
                " Nombre, Apellido1, Apellido2, Puesto) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                pEmpleado.Clave, pEmpleado.Direccion, pEmpleado.Telefono, pEmpleado.Nombre, pEmpleado.Apellido1,
                pEmpleado.Apellido2, pEmpleado.Puesto), Base_Datos.Conexion());
            // Nos devuelve un 1 o 0 en caso de ser buena o mala la consulta
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        // Se crea un metodo estatico de tipo lista que recibe como parametro pID
        public static List<Empleado> Buscar(int pClave) // Esta clase sirve para buscar un empleado en la BD
        {
            List<Empleado> _lista = new List<Empleado>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Clave, Dirección, Telefono, Nombre, Apellido1, Apellido2, Puesto" +
           " FROM empleado where Clave ='{0}'", pClave), Base_Datos.Conexion());
            // Se ejecuta la consulta
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read()) // Mientras haya lectura de datos va a hacer la captura de datos.
            {
                Empleado pEmpleado = new Empleado();
                pEmpleado.Clave = _reader.GetInt32(0);
                pEmpleado.Direccion = _reader.GetString(1);
                pEmpleado.Telefono = _reader.GetString(2);
                pEmpleado.Nombre = _reader.GetString(3);
                pEmpleado.Apellido1 = _reader.GetString(4);
                pEmpleado.Apellido2 = _reader.GetString(5);
                pEmpleado.Puesto = _reader.GetString(6);

                _lista.Add(pEmpleado); // Lo agrega el empleado encontrado con ese ID.
            }

            return _lista;
        }

        public static List<Empleado> BuscarEliminar(int pID) // Esta clase sirve para buscar y eliminar a un empleado en la BD
        {
            List<Empleado> _lista = new List<Empleado>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM empleado where noCtrl = @noCtrl"), Base_Datos.Conexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read()) // Mientra haya lectura de datos va a hacer la captura de datos.
            {
                Empleado pEmpleado = new Empleado();
                pEmpleado.Clave = _reader.GetInt32(1);
                pEmpleado.Direccion = _reader.GetString(2);
                pEmpleado.Telefono = _reader.GetString(3);
                pEmpleado.Nombre = _reader.GetString(4);
                pEmpleado.Apellido1 = _reader.GetString(5);
                pEmpleado.Apellido2 = _reader.GetString(6);
                pEmpleado.Puesto = _reader.GetString(7); ;

                _lista.Add(pEmpleado); // Lo agrega el empleado encontrado con ese ID.
            }

            return _lista;
        }
        // Este metodo nos retorna solamente un cliente
        public static Empleado ObtenerEmpleado(int pID) // Esta clase sirve para jalar un empleado de la BD
        {
            Empleado pEmpleado = new Empleado();
            // Creamos la conexion a la BD
            MySqlConnection conexion = Base_Datos.Conexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Clave, Dirección, Telefono, Nombre, Apellido1, Apellido2, Puesto" +
           " FROM empleado where Clave = {0}", pID), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                // Lee los datos de la BD de forma ordenada
                pEmpleado.Clave = _reader.GetInt32(0);
                pEmpleado.Direccion = _reader.GetString(1);
                pEmpleado.Telefono = _reader.GetString(2);
                pEmpleado.Nombre = _reader.GetString(3);
                pEmpleado.Apellido1 = _reader.GetString(4);
                pEmpleado.Apellido2 = _reader.GetString(5);
                pEmpleado.Puesto = _reader.GetString(6);

            }
            // Se cierra la conexion a la BD
            conexion.Close();
            return pEmpleado;
        }
        public static int Actualizar(Empleado pEmpleado) // Esta clase sirve para actualzar los datos de un empleado en la BD
        {
            int retorno = 0;
            MySqlConnection conexion = Base_Datos.Conexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update empleado set Dirección = '{0}', Telefono = '{1}', Nombre = '{2}', Apellido1 = '{3}', " + "Apellido2 = '{4}', Puesto = '{5}' where Clave = {6}",
                 pEmpleado.Direccion, pEmpleado.Telefono, pEmpleado.Nombre, pEmpleado.Apellido1, pEmpleado.Apellido2, pEmpleado.Puesto, pEmpleado.Clave), conexion);

            retorno = comando.ExecuteNonQuery();
            // Se cierra la conexion a la BD
            conexion.Close();

            return retorno;

        }
        public static int Eliminar(int pClave) // Esta clase sirve para eliminar a un empleado de la BD
        {
            int retorno = 0;
            MySqlConnection conexion = Base_Datos.Conexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From empleado where Clave = {0}", pClave), conexion);

            retorno = comando.ExecuteNonQuery();
            // Se cierra la conexion a la BD
            conexion.Close();

            return retorno;

        }
            public static int H_Llegada(Hora_Llegada pLlegada)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Asistencia_Empleados (Clave_Empleado, Llegada) values ('{0}', NOW())", pLlegada.Clave_Empleado, pLlegada.Llegada), Base_Datos.Conexion());
           
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int H_Salida(Hora_Llegada pSalida)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Asistencia_Empleados (Clave_Empleado, Salida) values ('{0}', NOW())", pSalida.Clave_Empleado, pSalida.Salida), Base_Datos.Conexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
