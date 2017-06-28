using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Usuario
{
	public partial class AltaUsuario : Presentacion.Usuario.Usuario
	{
		public AltaUsuario()
		{
			InitializeComponent();
			this.Text = "Nuevo Usuario";
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			Entidades.Usuario nuevoUsuario = new Entidades.Usuario(txtNombre.Text, txtContrasenia.Text);
			try
			{
				Logica.Usuario.Nuevo(nuevoUsuario);
				MessageBox.Show("Usuario " + nuevoUsuario.NombreUsuario + " creado con éxito.");
				this.Close();
			}
			catch(Exception ex)
			{
				this.MostrarExcepcion(ex);
			}
		}
	}
}
