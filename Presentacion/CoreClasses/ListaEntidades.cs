using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.CoreClasses
{
	public partial class ListaEntidades : Formulario
	{
		public ListaEntidades()
		{
			InitializeComponent();
			CargarEntidades(null, null);
		}

		protected virtual void txtBuscar_TextChanged(object sender, EventArgs e) { }

		protected virtual void CargarEntidades(object sender, EventArgs e) { }

		protected virtual void btnNuevo_Click(object sender, EventArgs e) { }

		protected virtual void btnBorrar_Click(object sender, EventArgs e) { }

		protected override void ShowNewForm(Form newForm)
		{
			base.ShowNewForm(newForm);
			CargarEntidades(null, null);
		}
	}
}
