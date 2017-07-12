using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
	public static class Pedido
	{
		public static void Nuevo(Entidades.Pedido pedido)
		{
			Datos.Pedido.Nuevo(pedido);
		}
	}
}
