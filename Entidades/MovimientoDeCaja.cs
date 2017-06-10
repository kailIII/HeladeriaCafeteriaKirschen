using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class MovimientoDeCaja
	{
		public DateTime FechaHora { get; set; }

		public string Razon { get; set; }

		public double Monto { get; set; }

		public Usuario empleado { get; set; }
	}
}
