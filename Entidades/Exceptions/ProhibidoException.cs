using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
	public class ProhibidoException : Exception
	{
		public ProhibidoException()
			: base("No tiene los permisos necesarios para realizar esta acción")
		{
			this.Source = "Lógica";
		}
	}
}
