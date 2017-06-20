using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MovimientoDeCaja
    {
		private static DBHeladeria dbHeladeria = new DBHeladeria();

        public static void NuevoMovimiento(Entidades.MovimientoDeCaja movimiento)
        {
			/*TODO: Eliminar linea*/movimiento.Usuario = (dbHeladeria.Usuario.Find("Santiago") != null) ? dbHeladeria.Usuario.Find("Santiago") : new Entidades.Usuario { NombreUsuario = "Santiago", Contrasenia = "Contr", Rol = Entidades.TipoUsuario.Supervisor };
			dbHeladeria.MovimientoDeCaja.Add(movimiento);
			dbHeladeria.SaveChanges();
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
            var query =
                from item in dbHeladeria.MovimientoDeCaja
                where desde <= item.FechaHora && item.FechaHora <= hasta
                select item;
            return query.ToList();
        }
    }
}
