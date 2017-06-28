using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public static List<Entidades.Producto> ToList()
		{
			return Datos.Producto.ToList();
		}
	}
}
