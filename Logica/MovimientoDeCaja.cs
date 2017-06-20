using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MovimientoDeCaja
    {
        public static void NuevoDeposito(Entidades.MovimientoDeCaja deposito)
        {
            if (deposito.Monto <= 0)
            {
                throw new Exception("El monto del deposito debe ser mayor a 0");
            }
            Datos.MovimientoDeCaja.NuevoDeposito(deposito);
        }

        public static void NuevaExtraccion(Entidades.MovimientoDeCaja extraccion)
        {
            if (extraccion.Monto <= 0)
            {
                throw new Exception("El monto de la extracción debe ser mayor a 0");
            }
            if (Caja.Estado() - extraccion.Monto < 0)
            {
                throw new Exception(string.Format("El monto de la extracción supera el monto en la caja ({0:C})", Caja.Estado()));
            }
			extraccion.Monto = -extraccion.Monto;
			Datos.MovimientoDeCaja.NuevaExtraccion(extraccion);
        }

        public static List<Entidades.MovimientoDeCaja> Consultar(DateTime desde, DateTime hasta)
        {
            return Datos.MovimientoDeCaja.Consultar(desde, hasta);
        }
    }
}
