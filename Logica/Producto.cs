using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
	public static class Producto
	{
		public static void Nuevo(Entidades.Producto producto)
		{
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
			Datos.Producto.Nuevo(producto);
		}

		public static void Editar(Entidades.Producto producto)
		{
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
			Datos.Producto.Editar(producto);
		}

		public static Entidades.Producto Buscar(string nombreProducto)
		{
			return Datos.Producto.Buscar(nombreProducto);
		}

		public static void Borrar(string nombreProducto)
		{
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
			Datos.Producto.Borrar(nombreProducto);
		}

		public static void IncrementarStock(string nombreProducto, int cantidad)
		{
			LogicaHeladeria.ControlarCantidadNoNegativa(cantidad);
			Datos.Producto.IncrementarStock(nombreProducto, cantidad);
		}

		public static void DecrementarStock(string nombreProducto, int cantidad)
		{
			LogicaHeladeria.ControlarCantidadNoNegativa(cantidad);
			var producto = Buscar(nombreProducto);
			LogicaHeladeria.ControlarCantidadNoSuperaStock(producto, cantidad);
			Datos.Producto.DecrementarStock(nombreProducto, cantidad);
		}

		public static List<Entidades.Producto> ToList()
		{
			return Datos.Producto.ToList();
		}

		public static List<Entidades.Producto> ListarALaVenta()
		{
			return Datos.Producto.ListarALaVenta();
		}
	}
}
