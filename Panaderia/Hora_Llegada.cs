using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       // Librerias

namespace Panaderia
{
    public class Hora_Llegada
    {
        // Sirven para ejecutar las consultas de la base de datos.
        public string Llegada { get; set; }
        public string Salida { get; set; }
        public int Clave_Empleado { get; set; }

        public Hora_Llegada() { }
        // Se mandan a llamar los parametros
        public Hora_Llegada(string pLlegada, string pSalida, int pClave_Empleado)

        {
            // Recibe su nombre cada parametro para ser mandados a llamar en otra parte del código
            this.Llegada = pLlegada;
            this.Salida = pSalida;
            this.Clave_Empleado = pClave_Empleado;

        }
    }
}
