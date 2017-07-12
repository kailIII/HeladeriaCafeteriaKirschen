using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
	public class CantidadNegativaException : Exception
	{
		public CantidadNegativaException() : base("La cantidad debe ser mayor o igual a 0.")
		{
			this.Source = "Logica";
		}
	}
}
