using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Producto
{
    public partial class IncrementarStock : Presentacion.CoreClasses.Formulario
    {
        private Entidades.Producto Producto;

		public IncrementarStock()
		{
			InitializeComponent();
			nudDiferencia.Maximum = int.MaxValue;
		}

        public IncrementarStock(Entidades.Producto producto)
        {
            InitializeComponent();
            Producto = producto;
            txtProducto.Text = producto.NombreProducto;
            txtStockActual.Text = producto.Stock.ToString();
        }

        private void IncrementarStock_Load(object sender, EventArgs e)
        {

        }

        public virtual void RegistrarCambioDeStock(Entidades.Producto producto, int cantidad)
        {
            try
            {
                Logica.Producto.IncrementarStock(producto.NombreProducto, cantidad);
            }
            catch (Exception e)
            {
                MostrarExcepcion(e);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RegistrarCambioDeStock(Producto, (int)nudDiferencia.Value);
			if (Producto.Stock < Producto.StockMinimo) MessageBox.Show(this, "Alerta de stock: El stock del producto " + Producto.NombreProducto + " es bajo.");
            this.Close();
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
			base.btnCancelar_Click(sender, e);
        }
    }
}
