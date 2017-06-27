using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Caja
{
	public partial class ConfigurarLimiteCaja : Form
	{
		private Panel panelAlerta;

		public ConfigurarLimiteCaja(Panel panelAlerta)
		{
			InitializeComponent();
			this.panelAlerta = panelAlerta;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Logica.Caja.SetLimite(Convert.ToDouble(nudLimite.Value));
			panelAlerta.Visible = Logica.Caja.DebeEmitirAlerta();
			this.Close();
		}
	}
}
