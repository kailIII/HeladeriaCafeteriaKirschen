using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion.Producto
{
	public partial class ListaProductos : CoreClasses.ListaEntidades
	{
		private List<Entidades.Producto> productos;

		public ListaProductos()
		{
			InitializeComponent();
			btnNuevo.Text = "Nuevo Producto";
			this.Text = "Listado de Productos";
			btnAccion3.Text = "Ver Producto";
			btnAccion3.Click += new System.EventHandler(this.btnVerProducto_Click);
		}

		private void btnVerProducto_Click(object sender, EventArgs e)
		{
			GetProductosSeleccionados().ForEach(p => ShowNewForm(new VerProducto(p)));
		}

		protected override void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			if (txtBuscar.Text != null && txtBuscar.Text != "")
				dgvEntidades.DataSource = productos.Where(p => p.NombreProducto.ToLower().Contains(txtBuscar.Text.ToLower())).ToList();
			else
				dgvEntidades.DataSource = productos;
		}

		protected override void CargarEntidades(object sender, EventArgs e)
		{
			productos = Logica.Producto.ToList();
			this.txtBuscar.Text = "";
			this.dgvEntidades.DataSource = productos;
			this.dgvEntidades.Columns[5].Visible = false;
		}

		protected override void btnNuevo_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Producto.AltaProducto());
		}

		protected override void btnBorrar_Click(object sender, EventArgs e)
		{
			if (this.MostrarSiNoMensaje("Eliminar", "¿Está seguro?"))
			{
				try
				{
					List<Entidades.Producto> productosSeleccionados = GetProductosSeleccionados();
					productosSeleccionados.ForEach(p => Logica.Producto.Borrar(p.NombreProducto));
					MessageBox.Show(this, productosSeleccionados.Count() + " productos eliminados.");
					CargarEntidades(null, null);
				}
				catch (Exception ex)
				{
					this.MostrarExcepcion(ex);
				}
			}
		}

		private List<Entidades.Producto> GetProductosSeleccionados()
		{
			List<Entidades.Producto> productosSeleccionados = new List<Entidades.Producto>();
			var rowsEnumerator = dgvEntidades.SelectedRows.GetEnumerator();
			while (rowsEnumerator.MoveNext())
			{
				string nombreProducto = ((DataGridViewRow)rowsEnumerator.Current).Cells[0].Value.ToString();
				productosSeleccionados.Add(productos.Find(p => p.NombreProducto == nombreProducto));
			}
			return productosSeleccionados;
		}
	}
}
