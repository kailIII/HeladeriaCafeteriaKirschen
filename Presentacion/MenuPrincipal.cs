using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
	public partial class MenuPrincipal : CoreClasses.Formulario
	{
		private List<ToolStripMenuItem> botonesSupervisor;

		public MenuPrincipal() : base()
		{
			InitializeComponent();
			botonesSupervisor = new List<ToolStripMenuItem> {
				btnNuevoUsuario,
				btnUsuarios,
				tsmiCaja,
				btnNuevoProducto
			};
			CheckLogIn();
		}

		protected override void ShowNewForm(Form formulario)
		{
			formulario.MdiParent = this;
			formulario.StartPosition = FormStartPosition.CenterScreen;
			formulario.Show();
		}

		public void CheckLogIn()
		{
			if (Logica.Usuario.UsuarioActualEstaLogueado())
			{
				btnLogIn.Visible = false;
				btnLogOut.Visible = true;
				btnCambiarContrasenia.Visible = true;
				tsmiUsuario.Text = Logica.Usuario.GetUsuarioActual().NombreUsuario;
			}
			else
			{
				btnLogIn.Visible = true;
				btnLogOut.Visible = false;
				btnCambiarContrasenia.Visible = false;
				tsmiUsuario.Text = "Usuario";
			}
			if (Logica.Usuario.UsuarioActualEstaEnRol(Entidades.TipoUsuario.Supervisor))
			{
				botonesSupervisor.ForEach(btn => btn.Visible = true);
			}
			else
			{
				botonesSupervisor.ForEach(btn => btn.Visible = false);
			}
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.MostrarSiNoMensaje("Salir", "¿Está seguro?"))
			{
				e.Cancel = true;
			}
		}

		private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Caja.DepositoCaja());
		}

		private void extraccionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Caja.ExtraccionCaja());
		}

		private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Caja.ListaMovimientosRango());
		}

		private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Usuario.AltaUsuario());
		}

		private void btnListaUsuarios_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Usuario.ListaUsuarios());
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(this.MostrarSiNoMensaje("Cerrar Sesión", "¿Está seguro que desea cerrar sesión? Se cerrarán las ventanas abiertas."))
			{
				Logica.Usuario.LogOut();
				CloseAllToolStripMenuItem_Click(null, null);
				CheckLogIn();
			}
		}

		private void logInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Usuario.LogInUsuario());
		}

		private void cambiarContraseniaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Usuario.CambioContraseniaUsuario(Logica.Usuario.GetUsuarioActual()));
		}

		private void MenuPrincipal_Load(object sender, EventArgs e)
		{
			PctAlertaCaja.Image = SystemIcons.Warning.ToBitmap();
		}

		private void MenuPrincipal_Activated(object sender, EventArgs e)
		{
			var estado = Logica.Caja.Estado();
			TxtEstadoDeCaja.Text = string.Format("{0:C}", estado);
			PnlAlerta.Visible = Logica.Caja.DebeEmitirAlerta();
		}

		private void limiteDeAlertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Caja.ConfigurarLimiteCaja(PnlAlerta));
		}

		private void btnNuevoProducto_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Producto.AltaProducto());
		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Producto.ListaProductos());
		}
	}
}
