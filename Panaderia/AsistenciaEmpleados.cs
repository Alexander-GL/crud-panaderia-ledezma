using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia
{
    public class AsistenciaEmpleados
    {
        // Sirven para ejecutar las consultas de la base de datos.
        public int Clave_Empleado { get; set; }
        public string Llegada { get; set; }
        public string Salida { get; set; }

        public AsistenciaEmpleados() { }
        public AsistenciaEmpleados(int pClave_Empleado, string pLlegada, string pSalida)
        {
            // Recibe su nombre cada parametro para ser mandados a llamar en otra parte del código
            this.Clave_Empleado = pClave_Empleado;
            this.Llegada = pLlegada;
            this.Salida = pSalida;
        }
    }
}
