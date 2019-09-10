using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
  public   class CategoriasBL
    {
        public List<Categoria> ListadeCategorias { get; set; }

        public CategoriasBL()
        {
            ListadeCategorias = new List<Categoria>();
            CrearDatosdePrueba(); 
        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            ListadeCategorias.Add(categoria1);
            ListadeCategorias.Add(categoria2);
    }
}
}
