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
	public partial class MenuPrincipal : Form
	{
		public MenuPrincipal()
		{
			InitializeComponent();
			CheckLogIn();
		}

		private void MenuPrincipal_Load(object sender, EventArgs e)
		{
            PctAlertaCaja.Image = SystemIcons.Warning.ToBitmap();
        }

        private void ShowNewForm(Form newForm)
        {
            newForm.ShowDialog(this);
        }

        private void BtnMovimientosDeCaja_Click(object sender, EventArgs e)
        {
            var frmListaMovimientosRango = new Caja.ListaMovimientosRango();
            ShowNewForm(frmListaMovimientosRango);
        }

        private void BtnDepositoCaja_Click(object sender, EventArgs e)
        {
            var frmDepositoCaja = new Caja.DepositoCaja();
            ShowNewForm(frmDepositoCaja);
        }

        private void BtnExtraccion_Click(object sender, EventArgs e)
        {
            var frmExtraccionCaja = new Caja.ExtraccionCaja();
            ShowNewForm(frmExtraccionCaja);
        }

        private void MenuPrincipal_Activated(object sender, EventArgs e)
        {
            var estado = Logica.Caja.Estado();
            TxtEstadoDeCaja.Text = string.Format("{0:C}", estado);
            PnlAlerta.Visible = Logica.Caja.DebeEmitirAlerta();
        }

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			Usuario.LogInUsuario logInForm = new Usuario.LogInUsuario();
			ShowNewForm(logInForm);
			CheckLogIn();
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			Logica.Usuario.LogOut();
			CheckLogIn();
		}

		private void CheckLogIn()
		{
			if (Logica.Usuario.UsuarioActualEstaLogueado())
			{
				btnLogIn.Enabled = false;
				btnLogOut.Enabled = true;
				lblNombreUsuario.Visible = true;
				lblNombreUsuario.Text = Logica.Usuario.GetUsuarioActual().NombreUsuario;
			}
			else
			{
				btnLogIn.Enabled = true;
				btnLogOut.Enabled = false;
				lblNombreUsuario.Visible = false;
			}
			if (Logica.Usuario.UsuarioActualEstaEnRol(Entidades.TipoUsuario.Supervisor))
			{
				btnNuevoUsuario.Visible = true;
				btnUsuarios.Visible = true;
				btnUsuarios.Visible = true;
			}
			else
			{
				btnNuevoUsuario.Visible = false;
				btnNuevoUsuario.Visible = false;
				btnUsuarios.Visible = false;
			}
		}

		private void btnNuevoUsuario_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Usuario.AltaUsuario());
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			ShowNewForm(new Usuario.ListaUsuarios());
		}
	}
}
