using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
	public static class Pedido
	{
		private static DBHeladeria dbHeladeria = DBHeladeria.Instance;

		public static void Nuevo(Entidades.Pedido pedido)
		{
			dbHeladeria.Pedido.Add(pedido);
			dbHeladeria.SaveChanges();
		}

		public static int GetNewID()
		{
            try
            {
                int? maxNum = dbHeladeria.Pedido.Max(p => p.IDPedido);
                return (maxNum == null) ? 1 : (Convert.ToInt32(maxNum) + 1);
            }
            catch (InvalidOperationException)
            {
                return 1;
            }
		}

		public static List<Entidades.Pedido> ToList(DateTime fechaDesde, DateTime fechaHasta)
		{
			return (from p in dbHeladeria.Pedido
					where p.FechaHora >= fechaDesde && p.FechaHora <= fechaHasta
					select p).ToList();
		}
	}
}
