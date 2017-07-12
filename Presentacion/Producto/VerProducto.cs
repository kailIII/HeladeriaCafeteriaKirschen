using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Pedido;

namespace Presentacion.Producto
{
	public partial class VerProducto : EdicionProducto
	{
		private Button btnEditar = new Button() { Text = "Editar Producto", Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left))) };
		private Button btnAgregarAPedido = new Button() { Text = "Agregar al Pedido", Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left))) };
		private Button btnIncrementarStock = new Button() { Text = "Incr. Stock", Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left))) };
		private Button btnDecrementarStock = new Button() { Text = "Decr. Stock", Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left))) };
		private AltaPedido frmAltaPedido;

		public VerProducto(Entidades.Producto producto) : base(producto)
		{
			InitializeComponent();
			nudPrecioVenta.Enabled = false;
			nudStock.Enabled = false;
			nudStockMinimo.Enabled = false;
			cboTipoProducto.Enabled = false;
			if (Logica.Usuario.UsuarioActualEstaEnRol(Entidades.TipoUsuario.Supervisor))
			{
				tableLayoutPanel1.Controls.Add(btnEditar, 0, 11);
				tableLayoutPanel1.Controls.Add(btnIncrementarStock, 0, 12);
				tableLayoutPanel1.Controls.Add(btnDecrementarStock, 1, 12);
				btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
				btnIncrementarStock.Click += new System.EventHandler(this.btnIncrementarStock_Click);
				btnDecrementarStock.Click += new System.EventHandler(this.btnDecrementarStock_Click);
				tableLayoutPanel1.SetColumnSpan(btnEditar, 2);
			}
		}

		private void btnIncrementarStock_Click(object sender, EventArgs e)
		{
			ShowNewForm(new IncrementarStock(this.producto));
			GetProducto();
		}

		private void btnDecrementarStock_Click(object sender, EventArgs e)
		{
			ShowNewForm(new DecrementarStock(this.producto));
			GetProducto();
		}

		public VerProducto(Entidades.Producto producto, Presentacion.Pedido.AltaPedido frmAltaPedido) : this(producto)
		{
			this.frmAltaPedido = frmAltaPedido;
			tableLayoutPanel1.Controls.Add(btnAgregarAPedido, 0, 10);
			tableLayoutPanel1.SetColumnSpan(btnAgregarAPedido, 2);
			btnAgregarAPedido.Click += new System.EventHandler(this.btnAgregarAlPedido_Click);
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected void btnEditar_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Producto.EdicionProducto(this.producto));
		}

		protected void btnAgregarAlPedido_Click(object sender, EventArgs e)
		{
			if (this.frmAltaPedido != null)
			{
				frmAltaPedido.AgregarAPedido(this.producto);
				this.btnAceptar_Click(null, null);
			}
		}
	}
}
