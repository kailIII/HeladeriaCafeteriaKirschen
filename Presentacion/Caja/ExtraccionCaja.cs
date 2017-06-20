using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Caja
{
    public partial class ExtraccionCaja : Presentacion.Caja.DepositoCaja
    {
        public ExtraccionCaja()
        {
            InitializeComponent();
        }

		protected override void GuardarMovimiento(Entidades.MovimientoDeCaja movimiento)
		{
			Logica.MovimientoDeCaja.NuevaExtraccion(movimiento);
			MessageBox.Show(this, "La extraccion de caja se registró correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

	}
}
