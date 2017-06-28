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
	public abstract partial class ListaEntidades : Formulario
	{
		public ListaEntidades()
		{
			InitializeComponent();
			CargarEntidades(null, null);
		}

		protected abstract void txtBuscar_TextChanged(object sender, EventArgs e);

		protected abstract void CargarEntidades(object sender, EventArgs e);

		protected abstract void btnNuevo_Click(object sender, EventArgs e);

		protected abstract void btnBorrar_Click(object sender, EventArgs e);

		protected override void ShowNewForm(Form newForm)
		{
			base.ShowNewForm(newForm);
			CargarEntidades(null, null);
		}
	}
}
