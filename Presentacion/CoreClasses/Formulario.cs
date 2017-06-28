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
	public partial class Formulario : Form
	{
		protected Formulario()
		{
			InitializeComponent();
		}

		protected void MostrarExcepcion(Exception ex)
		{
			MessageBox.Show(this, "Error de " + ex.Source + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		protected bool MostrarSiNoMensaje(string titulo, string mensaje)
		{
			return MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
		}

		protected virtual void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected virtual void ShowNewForm(Form newForm)
		{
			newForm.ShowDialog(this);
		}
	}
}
