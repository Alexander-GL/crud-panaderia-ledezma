using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia
{
    public class InventarioProductos
    {
        // Sirven para ejecutar las consultas de la base de datos.
        public int Id { get; set; }
        public int Existencia { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public int Stock { get; set; }
        public string Precio { get; set; }

        public InventarioProductos() { }
            public InventarioProductos(int pId, int pExistencia, string pNombre, string pTipo, int pEntradas, int pSalidas, int pStock, string pPrecio)
            {
                // Recibe su nombre cada parametro para ser mandados a llamar en otra parte del código
                this.Id = pId;
                this.Existencia = pExistencia;
                this.Nombre = pNombre;
                this.Tipo = pTipo;
                this.Entradas = pEntradas;
                this.Salidas = pSalidas;
                this.Stock = pStock;
                this.Precio = pPrecio;
            }
    }
}
