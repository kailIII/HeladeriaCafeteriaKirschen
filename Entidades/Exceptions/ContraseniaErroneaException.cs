using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
	public class ContraseniaErroneaException : Exception
	{
		public ContraseniaErroneaException()
			: base("La contraseña ingresada es errónea. Intente nuevamente con otra contraseña.")
		{
			this.Source = "Datos";
		}
	}
}
