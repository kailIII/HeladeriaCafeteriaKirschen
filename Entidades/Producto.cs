using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Producto
	{
		public string Nombre { get; set; }

		public double? PrecioVenta { get; set; }

		public int Stock { get; set; }

		public int StockMinimo { get; set; }

		public TipoProducto Tipo { get; set; }
	}
}
