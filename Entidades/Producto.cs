using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Producto
	{
		[Key][DisplayName("Nombre de Producto")]
		public string NombreProducto { get; set; }

		[DisplayName("Precio de Venta")]
		public double? PrecioVenta { get; set; }

		[Required]
		public int Stock { get; set; }

		[Required][DisplayName("Stock Minimo")]
		public int StockMinimo { get; set; }

		public TipoProducto Tipo { get; set; }

		public virtual ICollection<ProductoPedido> PedidosProducto { get; set; }
	}
}
