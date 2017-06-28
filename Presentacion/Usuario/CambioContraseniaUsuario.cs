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
	public partial class CambioContraseniaUsuario : Usuario
	{
		private Entidades.Usuario usuario;

		public CambioContraseniaUsuario(Entidades.Usuario usuarioAEditar)
		{
			InitializeComponent();
			this.Text = "Cambiar Contraseña";
			lblNombre.Text = "Contraseña anterior";
			lblContrasenia.Text = "Contraseña nueva";
			txtNombre.PasswordChar = '*';
			usuario = usuarioAEditar;
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				Logica.Usuario.CambiarContrasenia(usuario, txtNombre.Text, txtContrasenia.Text);
				MessageBox.Show(this, "Contraseña cambiada.");
				this.Close();
			}
			catch(Exception ex)
			{
				this.MostrarExcepcion(ex);
			}
		}
	}
}
