using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class MovimientoDeCaja
	{
		[Key]
		public DateTime FechaHora { get; set; }

		[Required]
		public string Razon { get; set; }

		[Required]
		public double Monto { get; set; }

		[ForeignKey("Usuario")]
		public string NombreUsuario { get; set; }

		[Required]
		public Usuario Usuario { get; set; }
	}
}
