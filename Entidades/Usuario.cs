using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Usuario
	{
		public Usuario () { }

		public Usuario (string nombre, string contrasenia)
		{
			this.NombreUsuario = nombre;
			this.Contrasenia = contrasenia;
			this.Rol = TipoUsuario.Vendedor;
		}

		[Key]
		public string NombreUsuario { get; set; }

		[Required]
		public string Contrasenia { get; set; }

		public TipoUsuario Rol { get; set; }

		public virtual ICollection<MovimientoDeCaja> Movimientos { get; set; }
	}
}
