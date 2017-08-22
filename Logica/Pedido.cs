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
			if (pedido.Efectivo)
			{
				Entidades.MovimientoDeCaja deposito = new Entidades.MovimientoDeCaja();
				deposito.FechaHora = pedido.FechaHora;
				deposito.NombreUsuario = Logica.Usuario.GetUsuarioActual().NombreUsuario;
				deposito.Monto = pedido.Monto;
				deposito.Razon = "Venta " + pedido.IDPedido;
				Datos.MovimientoDeCaja.NuevoDeposito(deposito);
			}
			Datos.Pedido.Nuevo(pedido);
		}

		public static int GetNewID()
		{
			return Datos.Pedido.GetNewID();
		}

		public static List<Entidades.Pedido> ToList(DateTime from, DateTime to)
		{
			return Datos.Pedido.ToList(from, to);
		}

		public static string GuardarAExcel(List<Entidades.Pedido> pedidos, string path)
		{
			return Datos.Pedido.GuardarAExcel(pedidos, path);
		}
	}
}
