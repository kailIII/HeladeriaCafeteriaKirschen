using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Producto
{
    public partial class DecrementarStock : Presentacion.Producto.IncrementarStock
    {
        public DecrementarStock(Entidades.Producto producto) : base(producto)
        {
            InitializeComponent();
        }

        public override void RegistrarCambioDeStock(Entidades.Producto producto, int cantidad)
        {
            try
            {
                Logica.Producto.DecrementarStock(producto.NombreProducto, cantidad);
            }
            catch (Exception e)
            {
                MostrarExcepcion(e);
            }
        }

    }
}
