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
	public partial class VerProducto : EdicionProducto
	{
		public VerProducto(Entidades.Producto producto) : base(producto)
		{
			InitializeComponent();
			nudPrecioVenta.Enabled = false;
			nudStock.Enabled = false;
			nudStockMinimo.Enabled = false;
			cboTipoProducto.Enabled = false;
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
