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
	public partial class LogInUsuario : Presentacion.Usuario.Usuario
	{
		public LogInUsuario()
		{
			InitializeComponent();
			this.Text = "Log In";
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			Entidades.Usuario usuario = new Entidades.Usuario(txtNombre.Text, txtContrasenia.Text);
			try
			{
				Logica.Usuario.LogIn(usuario);
				this.Close();
			}
			catch (Exception ex)
			{
				this.MostrarExcepcion(ex);
			}
		}
	}
}
