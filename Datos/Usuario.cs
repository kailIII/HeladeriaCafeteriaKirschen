using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public static class Usuario
	{
		private static Entidades.Usuario usuarioActual;

		private static DBHeladeria baseDeDatos = DBHeladeria.Get;

		public static void Nuevo(Entidades.Usuario usuario)
		{
			baseDeDatos.Usuario.Add(usuario);
			baseDeDatos.SaveChanges();
		}

		public static void LogIn(Entidades.Usuario usuario)
		{
			Entidades.Usuario usuarioBuscado = Usuario.Buscar(usuario.NombreUsuario, usuario.Contrasenia);
			if (usuarioBuscado != null)
				usuarioActual = usuarioBuscado;
			else
				throw new Entidades.Exceptions.UsuarioNotFoundException();
		}

		public static void LogOut()
		{
			usuarioActual = null;
		}

		public static Entidades.Usuario GetUsuarioActual()
		{
			return usuarioActual;
		}

		public static bool UsuarioActualEstaEnRol(Entidades.TipoUsuario rol)
		{
			if (usuarioActual == null)
				return false;
			return usuarioActual.Rol == rol;
		}

		public static bool UsuarioActualEstaLogueado()
		{
			return usuarioActual != null;
		}

		public static void CambiarRol(Entidades.Usuario usuario, Entidades.TipoUsuario rol)
		{
			usuario.Rol = rol;
			Usuario.Editar(usuario);
		}

		public static void Editar(Entidades.Usuario usuario)
		{
			baseDeDatos.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
			baseDeDatos.SaveChanges();
		}

		public static void Borrar(string nombreUsuario)
		{
			baseDeDatos.Usuario.Remove(Usuario.Buscar(nombreUsuario));
			baseDeDatos.SaveChanges();
		}

		public static bool Existe(string nombreUsuario)
		{
			return Usuario.Buscar(nombreUsuario) != null;
		}

		public static bool Existe(Entidades.Usuario usuario)
		{
			return Usuario.Buscar(usuario.NombreUsuario, usuario.Contrasenia) != null;
		}

		public static Entidades.Usuario Buscar(string nombreUsuario)
		{
			return baseDeDatos.Usuario.Find(nombreUsuario);
		}

		public static Entidades.Usuario Buscar(string nombreUsuario, string contrasenia)
		{
			try
			{
				var query =
					from usuarioBuscado in baseDeDatos.Usuario
					where nombreUsuario == usuarioBuscado.NombreUsuario
						&& contrasenia == usuarioBuscado.Contrasenia
					select usuarioBuscado;
				return query.Single();
			}
			catch (InvalidOperationException)
			{
				return null;
			}
		}

		public static List<Entidades.Usuario> ToList()
		{
			return baseDeDatos.Usuario.ToList();
		}
	}
}
