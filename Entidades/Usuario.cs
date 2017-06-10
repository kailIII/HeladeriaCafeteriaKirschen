using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Usuario
	{
		public Usuario () { }

		public Usuario (string nombre, string contrasenia, TipoUsuario rol)
		{
			this.Nombre = nombre;
			this.Contrasenia = contrasenia;
			this.Rol = rol;
		}

		public string Nombre { get; set; }

		public string Contrasenia { get; set; }

		public TipoUsuario Rol { get; set; }
	}
}
