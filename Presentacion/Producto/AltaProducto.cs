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
	public partial class AltaProducto : Form
	{
		public AltaProducto()
		{
			InitializeComponent();
			cboTipoProducto.DataSource = Enum.GetValues(typeof(Entidades.TipoProducto));
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
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
				MessageBox.Show(this, ex.Message);
			}
		}
	}
}
