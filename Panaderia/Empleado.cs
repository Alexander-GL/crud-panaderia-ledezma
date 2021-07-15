using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       // Librerias

namespace Panaderia
{
    public class Empleado
    {
        // Sirven para ejecutar las consultas de la base de datos.
        public int Clave { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; } 
        public string Puesto { get; set; }
        public string Llegada { get; set; }
        public string Salida { get; set; }

        public Empleado() { }
        // Se mandan a llamar los parametros
        public Empleado(int pClave, string pDireccion, string pTelefono, string pNombre, string pApellido1, string pApellido2, string pPuesto, string pLlegada, string pSalida)

        {
            // Recibe su nombre cada parametro para ser mandados a llamar en otra parte del código
            this.Clave = pClave;
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
            this.Nombre = pNombre;
            this.Apellido1 = pApellido1;
            this.Apellido2 = pApellido2;
            this.Puesto = pPuesto;
            this.Llegada = pLlegada;
            this.Salida = pSalida;
        }
    }
}
