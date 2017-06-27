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
	public partial class ListaUsuarios : Form
	{
		List<Entidades.Usuario> usuarios;

		public ListaUsuarios()
		{
			InitializeComponent();
			CargarUsuarios(null, null);
		}

		private void CargarUsuarios(object sender, EventArgs e)
		{
			usuarios = Logica.Usuario.ToList();
			txtBuscar.Text = "";
			dgvUsuarios.DataSource = usuarios;
			dgvUsuarios.Columns[1].Visible = false;
			dgvUsuarios.Columns[3].Visible = false;
		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			if (txtBuscar.Text != null && txtBuscar.Text != "")
				dgvUsuarios.DataSource = usuarios.Where(u => u.NombreUsuario.ToLower().Contains(txtBuscar.Text.ToLower())).ToList();
			else
				dgvUsuarios.DataSource = usuarios;
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				try
				{
					List<Entidades.Usuario> usuariosSeleccionados = GetUsuariosSeleccionados();
					usuariosSeleccionados.ForEach(u => Logica.Usuario.Borrar(u.NombreUsuario));
					MessageBox.Show(this, usuariosSeleccionados.Count() + " usuarios eliminados.");
					CargarUsuarios(null, null);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error de" + ex.Source + ": " + ex.Message);
				}
			}
		}

		private void btnNuevoUsuario_Click(object sender, EventArgs e)
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
			var rowsEnumerator = dgvUsuarios.SelectedRows.GetEnumerator();
			while (rowsEnumerator.MoveNext())
			{
				string nombreUsuario = ((DataGridViewRow)rowsEnumerator.Current).Cells[0].Value.ToString();
				if (nombreUsuario != Logica.Usuario.GetUsuarioActual().NombreUsuario)
					usuariosSeleccionados.Add(usuarios.Find(u => u.NombreUsuario == nombreUsuario));
			}
			return usuariosSeleccionados;
		}

		private void ShowNewForm(Form newForm)
		{
			newForm.ShowDialog(this);
			CargarUsuarios(null, null);
		}
	}
}
