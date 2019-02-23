using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioInformatico.BL
{
    public class ProductosBL
    {
       public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Marca = "Computadora Portatil Sony";
            producto1.Caracteristicas = "4GB RAM, 500GB Disco Duro";

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Marca = "Computadora Portatil HP";
            producto2.Caracteristicas = "6GB RAM, 500GB Disco Duro";

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Marca = "Computadora Portatil Dell";
            producto3.Caracteristicas = "8GB RAM, 1TB Disco Duro";


            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            return listadeProductos;
        }
    }
}
