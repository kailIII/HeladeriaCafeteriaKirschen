using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Producto
	{
		[Key]
		public string NombreProducto { get; set; }

		public double? PrecioVenta { get; set; }

		[Required]
		public int Stock { get; set; }

		[Required]
		public int StockMinimo { get; set; }

		public TipoProducto Tipo { get; set; }

		public virtual ICollection<Pedido> Pedidos { get; set; }
	}
}
