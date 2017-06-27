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
			if (!Datos.Usuario.UsuarioActualEstaEnRol(Entidades.TipoUsuario.Supervisor))
				throw new Entidades.Exceptions.ProhibidoException();
			Datos.Producto.Nuevo(producto);
		}

		public static void Editar(Entidades.Producto producto)
		{
			if (!Datos.Usuario.UsuarioActualEstaEnRol(Entidades.TipoUsuario.Supervisor))
				throw new Entidades.Exceptions.ProhibidoException();
			Datos.Producto.Editar(producto);
		}

		public static Entidades.Producto Buscar(string nombreProducto)
		{
			return Datos.Producto.Buscar(nombreProducto);
		}
	}
}
