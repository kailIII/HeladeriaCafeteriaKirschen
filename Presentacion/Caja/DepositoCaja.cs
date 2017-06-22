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
    public partial class DepositoCaja : Form
    {
        public DepositoCaja()
        {
            InitializeComponent();
        }

		protected virtual void GuardarMovimiento (Entidades.MovimientoDeCaja movimiento)
		{
			Logica.MovimientoDeCaja.NuevoDeposito(movimiento);
			MessageBox.Show(this, "El deposito de caja se registró correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		protected void RegistrarMovimiento(double monto, string razon, Entidades.Usuario usuario)
		{
			var movimiento = new Entidades.MovimientoDeCaja
			{
				FechaHora = DateTime.Now,
				Monto = monto,
				Razon = razon,
				Usuario = usuario
			};

			try
			{
				GuardarMovimiento(movimiento);
			}
			catch (Exception exception)
			{
				MessageBox.Show(
					this,
					"No se pudo realizar el movimiento de caja: " + exception.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (NumMonto.Value <= 0)
            {
                MessageBox.Show(this, "El monto debe ser mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (TxtRazon.Text.Length == 0)
            {
                MessageBox.Show(this, "Escriba la razón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegistrarMovimiento((double)NumMonto.Value, TxtRazon.Text, Logica.Usuario.GetUsuarioActual());
		}

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
