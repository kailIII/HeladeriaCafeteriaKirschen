using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Caja
{
    public partial class ListaMovimientosRango : Form
    {
        public ListaMovimientosRango()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var lista = Logica.MovimientoDeCaja.Consultar(DateTimeDesde.Value, DateTimeHasta.Value);

            if (lista.Count == 0)
            {
                MessageBox.Show(this, "No se encontraron movimientos en el rango de fechas", "Lista de movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var sw = new StringWriter();
                foreach (var item in lista)
                {
                    sw.WriteLine("Fecha: {0:dd/MM/yyyy HH:mm:ss}\tMonto: {1:C}\tRazón: {2}", item.FechaHora, item.Monto, item.Razon);
                }
                MessageBox.Show(this, sw.ToString(), "Lista de movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaMovimientosRango_Load(object sender, EventArgs e)
        {
            var hoy = DateTime.Now.Date;
            DateTimeDesde.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day, 0, 0, 0);
            DateTimeHasta.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day, 23, 59, 59);
        }
    }
}
