using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioInformatico.BL
{
    public class Producto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Caracteristicas { get; set; }
        public int Cantidad { get; set; }
    }
}
