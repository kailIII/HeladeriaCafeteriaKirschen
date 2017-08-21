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
	public partial class ListaUsuarios : CoreClasses.ListaEntidades
	{
		List<Entidades.Usuario> usuarios;

		public ListaUsuarios()
		{
			InitializeComponent();
			btnNuevo.Text = "Nuevo Usuario";
			this.Text = "Listado de Usuarios";
			btnAccion3.Text = "Cambiar Rol Seleccionados";
			btnAccion3.Click += new System.EventHandler(this.btnCambiarRol_Click);
			CargarEntidades(null, null);
		}

		protected override void CargarEntidades(object sender, EventArgs e)
		{
			usuarios = Logica.Usuario.ToList();
			txtBuscar.Text = "";
			dgvEntidades.DataSource = usuarios;
			dgvEntidades.Columns[1].Visible = false;
			dgvEntidades.Columns[3].Visible = false;
		}

		protected override void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			if (txtBuscar.Text != null && txtBuscar.Text != "")
				dgvEntidades.DataSource = usuarios.Where(u => u.NombreUsuario.ToLower().Contains(txtBuscar.Text.ToLower())).ToList();
			else
				dgvEntidades.DataSource = usuarios;
		}

		protected override void btnBorrar_Click(object sender, EventArgs e)
		{
			if (this.MostrarSiNoMensaje("Eliminar", "¿Está seguro?"))
			{
				try
				{
					List<Entidades.Usuario> usuariosSeleccionados = GetUsuariosSeleccionados();
					usuariosSeleccionados.ForEach(u => Logica.Usuario.Borrar(u.NombreUsuario));
					MessageBox.Show(this, usuariosSeleccionados.Count() + " usuarios eliminados.");
					CargarEntidades(null, null);
				}
				catch (Exception ex)
				{
					this.MostrarExcepcion(ex);
				}
			}
		}

		protected override void btnNuevo_Click(object sender, EventArgs e)
		{
			ShowNewForm(new AltaUsuario());
		}

		private void btnCambiarRol_Click(object sender, EventArgs e)
		{
			ShowNewForm(new CambiarRolUsuarios(GetUsuariosSeleccionados()));
		}

		private List<Entidades.Usuario> GetUsuariosSeleccionados()
		{
			List<Entidades.Usuario> usuariosSeleccionados = new List<Entidades.Usuario>();
			var rowsEnumerator = dgvEntidades.SelectedRows.GetEnumerator();
			while (rowsEnumerator.MoveNext())
			{
				string nombreUsuario = ((DataGridViewRow)rowsEnumerator.Current).Cells[0].Value.ToString();
				if (Logica.Usuario.UsuarioActualEstaLogueado() && nombreUsuario != Logica.Usuario.GetUsuarioActual().NombreUsuario)
					usuariosSeleccionados.Add(usuarios.Find(u => u.NombreUsuario == nombreUsuario));
			}
			return usuariosSeleccionados;
		}
	}
}
