using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
	public class UsuarioNotFoundException : Exception
	{
		public UsuarioNotFoundException()
			: base("No existe el usuario ingresado. Intente nuevamente con otro nombre de usuario y/o contraseña")
		{
			this.Source = "Datos";
		}
	}
}
