using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Presentacion.Pedido
{
	public partial class ListaPedidos : CoreClasses.ListaEntidades
	{
		private List<Entidades.Pedido> pedidos;

		public ListaPedidos() : base()
		{
			InitializeComponent();
			btnBorrar.Enabled = false;
			btnNuevo.Text = "Nuevo Pedido";
			btnAccion3.Text = "Guardar a Excel";
			btnAccion3.Click += new System.EventHandler(this.BtnGuardarExcel_Click);
			lblBuscar.Visible = false;
			txtBuscar.Visible = false;
			btnLimpiar.Visible = false;
			DateTime today = DateTime.Now;
			dtpDesde.Value = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0, 0);
			dtpHasta.Value = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59, 999);
			CargarEntidades(null, null);
		}

		private void BtnGuardarExcel_Click(object sender, EventArgs e)
		{
			try
			{
				string nombre = Logica.Pedido.GuardarAExcel(pedidos, System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
				MessageBox.Show("El archivo de nombre " + nombre + " se guardo exitosamente en Documentos.");
			}
			catch(Exception ex)
			{
				this.MostrarExcepcion(ex);
			}
		}

		protected override void CargarEntidades(object sender, EventArgs e)
		{
			pedidos = (dtpDesde.Value <= dtpHasta.Value) ? Logica.Pedido.ToList(dtpDesde.Value, dtpHasta.Value) : new List<Entidades.Pedido>();
			this.dgvEntidades.DataSource = pedidos;
			this.dgvEntidades.Columns[4].Visible = false;
		}

		protected override void btnNuevo_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Pedido.AltaPedido());
		}
	}
}
