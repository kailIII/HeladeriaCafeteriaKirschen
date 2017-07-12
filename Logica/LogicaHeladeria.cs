using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
	public static class LogicaHeladeria
	{
		public static void FiltrarUsuarioActualPorRol(Entidades.TipoUsuario rol)
		{
			if (!Usuario.UsuarioActualEstaEnRol(rol))
				throw new Entidades.Exceptions.ProhibidoException();
		}

		public static void FiltrarPorUsuarioLogueado()
		{
			if (!Usuario.UsuarioActualEstaLogueado())
				throw new Entidades.Exceptions.ProhibidoException();
		}

		public static void ControlarCantidadNoNegativa(int cantidad)
		{
			if (cantidad < 1)
				throw new Entidades.Exceptions.CantidadNegativaException();
		}

		public static void ControlarCantidadNoSuperaStock(Entidades.Producto producto, int cantidad)
		{
			if (cantidad > producto.Stock)
				throw new Entidades.Exceptions.StockNuloException(producto.NombreProducto);
		}
	}
}
