using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
  public  class ProductosBL
    {
        public List<Producto> ListadeProductos { get; set; }
        public List<Producto> ListadeProductosVendidos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new List<Producto>();
            ListadeProductosVendidos = new List<Producto>();

            CrearDatosdePrueba();
        }

        public void AgregarProductosVendidos(Producto producto)
        {
            var encontrado = false;

            foreach (var productoVendido in ListadeProductosVendidos)
            {
                if (producto.Id == productoVendido.Id)
                {
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                ListadeProductosVendidos.Add(producto);
            }
        }

        public void RemoverProducto(Producto producto)
        {
            ListadeProductosVendidos.Remove(producto);
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop Dell", 150000, categoria1);
            var producto2 = new Producto(2, "Laptop HP", 20000, categoria1);
            var producto3 = new Producto(3, "Mouse", 200, categoria2);

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
        }
    }
}
