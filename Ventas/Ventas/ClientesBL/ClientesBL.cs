using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.ModelosP;

namespace Ventas.ClientesBL
{
   public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {

             var ciudad1 = new Ciudad(1, "San Pedro Sula");
        var ciudad2 = new Ciudad(2, "Tegucigalpa");

        var cliente1 = new Cliente(1, "Carlos", 99887766, ciudad1);
        var cliente2 = new Cliente(2, "Maria", 94332211, ciudad2);
        var cliente3 = new Cliente(3, "Jose", 95664489, ciudad1);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);

}
}
}
