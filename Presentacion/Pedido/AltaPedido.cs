using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Presentacion.Pedido
{
	public partial class AltaPedido : Presentacion.CoreClasses.Formulario
	{
		protected Entidades.Pedido pedido;

		public AltaPedido()
		{
			InitializeComponent();
			pedido = new Entidades.Pedido();
			SetControls();
			CargarEntidades();
		}

		protected void SetControls()
		{
			this.nudIDPedido.Value = pedido.IDPedido;
			this.dtpFecha.Value = pedido.FechaHora;
			this.cbxDelivery.Checked = pedido.Delivery;
		}

		public void AgregarAPedido(Entidades.Producto producto)
		{
			ShowNewForm(new ProductoPedido.AltaProductoPedido(producto, pedido, this));
		}

		public void AgregarAPedido(Entidades.ProductoPedido productoPedido)
		{
			List<Entidades.ProductoPedido> productoPedidoExistente = pedido.ProductosPedido.Where(pp => pp.NombreProducto == productoPedido.NombreProducto).ToList();
			if (productoPedidoExistente.Count == 0)
				pedido.ProductosPedido.Add(productoPedido);
			else
				productoPedidoExistente.ForEach(pp => pp.Cantidad += productoPedido.Cantidad);
			CargarEntidades();
		}

		public void CargarEntidades()
		{
			dgvProductos.DataSource = null;
			dgvProductos.DataSource = pedido.ProductosPedido;
			dgvProductos.Columns[0].Visible = false;
			dgvProductos.Columns[3].Visible = false;
			dgvProductos.Columns[4].Visible = false;
		}

		private void btnAgregarProductos_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Producto.ListaProductos(this));
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				GetControls();
				DecrementarStocks();
				if (pedido.ProductosPedido.Count > 0)
				{
					Logica.Pedido.Nuevo(pedido);
					MessageBox.Show(this, "Pedido creado exitosamente. Total: $" + pedido.Monto);
					this.Close();
				}
				else MessageBox.Show(this, "Debe agregar productos al pedido para continuar.");
			}
			catch(Exception ex)
			{
				MostrarExcepcion(ex);
			}
		}

		private void DecrementarStocks()
		{
			foreach (Entidades.ProductoPedido productoPedido in this.pedido.ProductosPedido)
			{
				Logica.Producto.DecrementarStock(productoPedido.NombreProducto, productoPedido.Cantidad);
				if (productoPedido.Producto.Stock < productoPedido.Producto.StockMinimo)
					MessageBox.Show(this, "Alerta de stock: El stock del producto " + productoPedido.NombreProducto + " es bajo.");
			}
		}

		private void GetControls()
		{
			pedido.IDPedido = Convert.ToInt32(nudIDPedido.Value);
			pedido.FechaHora = dtpFecha.Value;
			pedido.Delivery = cbxDelivery.Checked;
			pedido.Efectivo = cbxEfectivo.Checked;
		}

		protected override void btnCancelar_Click(object sender, EventArgs e)
		{
			base.btnCancelar_Click(sender, e);
		}
	}
}
