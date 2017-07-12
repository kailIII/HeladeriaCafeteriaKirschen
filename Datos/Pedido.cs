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
	}
}
