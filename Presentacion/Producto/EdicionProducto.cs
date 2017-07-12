using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Producto
{
	public partial class EdicionProducto : AltaProducto
	{
		protected Entidades.Producto producto;

		public EdicionProducto() : base() { }

		public EdicionProducto(Entidades.Producto producto) : this()
		{
			this.producto = producto;
			InitializeComponent();
			GetProducto();
		}

		protected void GetProducto()
		{
			txtNombreProducto.Text = producto.NombreProducto;
			txtNombreProducto.Enabled = false;
			nudPrecioVenta.Value = Convert.ToDecimal(producto.PrecioVenta);
			nudStock.Value = Convert.ToDecimal(producto.Stock);
			nudStockMinimo.Value = Convert.ToDecimal(producto.StockMinimo);
			cboTipoProducto.SelectedIndex = Convert.ToInt32(producto.Tipo);
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			SetProducto(producto);
			try
			{
				Logica.Producto.Editar(producto);
				MessageBox.Show(this, "Producto modificado con éxito.");
				this.Close();
			}
			catch (Exception ex)
			{
				this.MostrarExcepcion(ex);
			}
		}
	}
}
