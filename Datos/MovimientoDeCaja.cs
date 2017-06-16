using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MovimientoDeCaja
    {
        static List<Entidades.MovimientoDeCaja> List = new List<Entidades.MovimientoDeCaja>();

        public static void NuevoMovimiento(Entidades.MovimientoDeCaja movimiento)
        {
            List.Add(movimiento);
            Caja.EntidadesCaja.Monto += movimiento.Monto;
        }

        public static void NuevoDeposito(Entidades.MovimientoDeCaja deposito)
        {
            NuevoMovimiento(deposito);
        }

        public static void NuevaExtraccion(Entidades.MovimientoDeCaja extraccion)
        {
            NuevoMovimiento(extraccion);
        }

        public static List<Entidades.MovimientoDeCaja> Consultar(DateTime desde, DateTime hasta)
        {
            var list = new List<Entidades.MovimientoDeCaja>();
            foreach (var item in List)
            {
                if (desde <= item.FechaHora && item.FechaHora <= hasta)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
