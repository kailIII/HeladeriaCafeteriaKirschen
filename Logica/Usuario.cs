using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
	public static class Usuario
	{
		public static void Nuevo(Entidades.Usuario usuario)
		{
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
			Datos.Usuario.Nuevo(usuario);
		}

		public static void LogIn(Entidades.Usuario usuario)
		{
			Datos.Usuario.LogIn(usuario);
		}

		public static void LogOut()
		{
			Datos.Usuario.LogOut();
		}

		public static Entidades.Usuario GetUsuarioActual()
		{
			return Datos.Usuario.GetUsuarioActual();
		}

		public static bool UsuarioActualEstaEnRol(Entidades.TipoUsuario rol)
		{
			return Datos.Usuario.UsuarioActualEstaEnRol(rol);
		}

		public static bool UsuarioActualEstaLogueado()
		{
			return Datos.Usuario.UsuarioActualEstaLogueado();
		}

		public static void CambiarRol(Entidades.Usuario usuario, Entidades.TipoUsuario rol)
		{
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
			Datos.Usuario.CambiarRol(usuario, rol);
		}

		public static void CambiarContrasenia(Entidades.Usuario usuario, string contraseniaAnterior, string nuevaContrasenia)
		{
			LogicaHeladeria.FiltrarPorUsuarioLogueado();
			if (usuario.Contrasenia != contraseniaAnterior)
				throw new Exception("Contraseña anterior no válida.");
			usuario.Contrasenia = nuevaContrasenia;
			Datos.Usuario.Editar(usuario);
		}

		public static void Editar(Entidades.Usuario usuario)
		{
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
			Datos.Usuario.Editar(usuario);
		}

		public static void Borrar(string nombreUsuario)
		{
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
			Datos.Usuario.Borrar(nombreUsuario);
		}

		public static bool Existe(string nombreUsuario)
		{
			return Datos.Usuario.Existe(nombreUsuario);
		}

		public static bool Existe(Entidades.Usuario usuario)
		{
			return Datos.Usuario.Existe(usuario);
		}

		public static Entidades.Usuario Buscar(string nombreUsuario)
		{
			return Datos.Usuario.Buscar(nombreUsuario);
		}

		public static List<Entidades.Usuario> ToList()
		{
			return Datos.Usuario.ToList();
		}
	}
}
