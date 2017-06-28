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

namespace Presentacion.Usuario
{
	public partial class CambiarRolUsuarios : CoreClasses.Formulario
	{
		private List<Entidades.Usuario> usuarios;

		public CambiarRolUsuarios(List<Entidades.Usuario> usuarios)
		{
			InitializeComponent();
			this.usuarios = usuarios;
			if(usuarios.Count() > 0)
			{
				txtUsuarios.Text = usuarios.Aggregate("", (acum, u) => acum + u.NombreUsuario + ", ");
				txtUsuarios.Text = txtUsuarios.Text.Substring(0, txtUsuarios.Text.Length - 2);
			}
			cboRol.DataSource = Enum.GetValues(typeof(Entidades.TipoUsuario));
			cboRol.SelectedIndex = -1;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				Entidades.TipoUsuario tipoUsuario = ((Entidades.TipoUsuario)cboRol.SelectedItem);
				usuarios.ForEach(u => Logica.Usuario.CambiarRol(u, tipoUsuario));
				MessageBox.Show(this, usuarios.Count() + " usuarios cambiados a " + tipoUsuario.ToString());
				this.Close();
			}
			catch(Exception ex)
			{
				this.MostrarExcepcion(ex);
			}
		}
	}
}
