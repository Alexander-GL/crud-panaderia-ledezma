using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;        // Librerias


namespace Panaderia
{
    class AsistenciaDAL
    {
        public static List<InventarioProductos> Buscar(int pId) // Esta clase sirve para buscar un empleado en la BD
        {
            List<InventarioProductos> _lista = new List<InventarioProductos>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id, Existencia, Nombre, Tipo, Entradas, Salidas, Stock, Precio" +
           " FROM producto where Id ='{0}'", pId), Base_Datos.Conexion());
            // Se ejecuta la consulta
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read()) // Mientras haya lectura de datos va a hacer la captura de datos.
            {
                InventarioProductos pInventario = new InventarioProductos();
                pInventario.Id = _reader.GetInt32(0);
                pInventario.Existencia = _reader.GetInt32(1);
                pInventario.Nombre = _reader.GetString(2);
                pInventario.Tipo = _reader.GetString(3);
                pInventario.Entradas = _reader.GetInt32(4);
                pInventario.Salidas = _reader.GetInt32(5);
                pInventario.Stock = _reader.GetInt32(6);
                pInventario.Precio = _reader.GetString(7);

                _lista.Add(pInventario); // Lo agrega el empleado encontrado con ese ID.
            }

            return _lista;
        }
    }
}
