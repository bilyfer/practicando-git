using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;
using Ventas.Modelos;

namespace Ventas
{
    public partial class Form3 : Form
    {
        ProductosBL _productosBL;

        public Form3()
        {
            InitializeComponent();

            _productosBL = new ProductosBL();

            listadeProductosBindingSource.DataSource =
                _productosBL.ListadeProductos;

            listadeProductosVendidosBindingSource.DataSource =
                _productosBL.ListadeProductosVendidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = 
                (Producto)listadeProductosBindingSource.Current;

            _productosBL.AgregarProductosVendidos(producto);

            listadeProductosVendidosBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var producto =
                (Producto)listadeProductosVendidosBindingSource.Current;

            _productosBL.RemoverProducto(producto);

            listadeProductosVendidosBindingSource.ResetBindings(false);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
