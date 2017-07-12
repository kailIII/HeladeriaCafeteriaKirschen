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
	public partial class AltaProducto : CoreClasses.Formulario
	{
		public AltaProducto()
		{
			InitializeComponent();
			cboTipoProducto.DataSource = Enum.GetValues(typeof(Entidades.TipoProducto));
		}

		protected void SetProducto(Entidades.Producto producto)
		{
			producto.NombreProducto = txtNombreProducto.Text;
			producto.PrecioVenta = Convert.ToDouble(nudPrecioVenta.Value);
			producto.Stock = Convert.ToInt32(nudStock.Value);
			producto.StockMinimo = Convert.ToInt32(nudStockMinimo.Value);
			producto.Tipo = (Entidades.TipoProducto)cboTipoProducto.SelectedItem;
		}

		protected virtual void btnAceptar_Click(object sender, EventArgs e)
		{
			Entidades.Producto nuevoProducto = new Entidades.Producto();
			SetProducto(nuevoProducto);
			try
			{
				Logica.Producto.Nuevo(nuevoProducto);
				MessageBox.Show(this, "Producto creado con éxito.");
				this.Close();
			}
			catch(Exception ex)
			{
				this.MostrarExcepcion(ex);
			}
		}

		protected override void btnCancelar_Click(object sender, EventArgs e)
		{
			base.btnCancelar_Click(sender, e);
		}

		private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((Entidades.TipoProducto)cboTipoProducto.SelectedItem == Entidades.TipoProducto.Balde)
			{
				nudPrecioVenta.Enabled = false;
				nudPrecioVenta.Value = 0;
			}
			else
				nudPrecioVenta.Enabled = true;
		}
	}
}
