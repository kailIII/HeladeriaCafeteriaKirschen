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
    }
}
