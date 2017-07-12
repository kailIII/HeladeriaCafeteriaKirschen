using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.ProductoPedido
{
	public partial class AltaProductoPedido : Presentacion.CoreClasses.Formulario
	{
		private Entidades.ProductoPedido productoPedido;
		private Pedido.AltaPedido frmAltaPedido;

		public AltaProductoPedido()
		{
			InitializeComponent();
		}

		public AltaProductoPedido(Entidades.Producto producto, Entidades.Pedido pedido, Pedido.AltaPedido frmAltaPedido)
		{
			InitializeComponent();
			productoPedido = new Entidades.ProductoPedido();
			productoPedido.NombreProducto = producto.NombreProducto;
			productoPedido.IDPedido = pedido.IDPedido;
			productoPedido.Producto = producto;
			productoPedido.Pedido = pedido;
			this.frmAltaPedido = frmAltaPedido;
		}
		
		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if(nudCantidad.Value > 0)
			{
				productoPedido.Cantidad = Convert.ToInt32(nudCantidad.Value);
				frmAltaPedido.AgregarAPedido(productoPedido);
				this.Close();
			}
		}
	}
}
