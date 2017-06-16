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

        protected override void RegistrarMovimiento(double monto, string razon)
        {
            var extraccion = new Entidades.MovimientoDeCaja
            {
                FechaHora = DateTime.Now,
                Monto = -monto,
                Razon = razon,
                empleado = null, // TODO Eric: MovimientoDeCaja.empleado = null
            };

            try
            {
                Logica.MovimientoDeCaja.NuevaExtraccion(extraccion);
                MessageBox.Show(this, "La extracción de caja se registró correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    this,
                    "No se pudo realizar la extracción de caja: " + exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
