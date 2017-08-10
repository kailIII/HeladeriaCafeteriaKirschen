using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
	public static class Usuario
	{
		private static Entidades.Usuario usuarioActual;

		private static DBHeladeria dbHeladeria = DBHeladeria.Instance;

		public static void Nuevo(Entidades.Usuario usuario)
		{
			usuario.Contrasenia = MD5Hash.Get(usuario.Contrasenia);
			dbHeladeria.Usuario.Add(usuario);
			dbHeladeria.SaveChanges();
		}

		public static void LogIn(Entidades.Usuario usuario)
		{
			usuarioActual = Usuario.Buscar(usuario.NombreUsuario, usuario.Contrasenia);
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
			return UsuarioActualEstaLogueado() && usuarioActual.Rol == rol;
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
			dbHeladeria.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
			dbHeladeria.SaveChanges();
		}

		public static void CambiarContrasenia(Entidades.Usuario usuario, string contraseniaAnterior, string nuevaContrasenia)
		{
			if (!MD5Hash.Compare(contraseniaAnterior, usuario.Contrasenia))
				throw new Entidades.Exceptions.ContraseniaErroneaException();
			usuario.Contrasenia = MD5Hash.Get(nuevaContrasenia);
			Editar(usuario);
		}

		public static void Borrar(string nombreUsuario)
		{
			dbHeladeria.Usuario.Remove(Usuario.Buscar(nombreUsuario));
			dbHeladeria.SaveChanges();
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
			Entidades.Usuario usuario = dbHeladeria.Usuario.Find(nombreUsuario);
			if (usuario == null)
				throw new Entidades.Exceptions.UsuarioNoEncontradoException();
			return usuario;
		}

		public static Entidades.Usuario Buscar(string nombreUsuario, string contrasenia)
		{
			Entidades.Usuario usuario = Buscar(nombreUsuario);
			if (!MD5Hash.Compare(contrasenia, usuario.Contrasenia))
				throw new Entidades.Exceptions.ContraseniaErroneaException();
			return usuario;
		}

		public static List<Entidades.Usuario> ToList()
		{
			return dbHeladeria.Usuario.ToList();
		}
	}
}
