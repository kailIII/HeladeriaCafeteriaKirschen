using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class ProductoPedido
	{
		[Key, Column(Order = 0)]
		public int IDPedido { get; set; }

		[Key, Column(Order = 1)]
		public string NombreProducto { get; set; }

		[Required]
		public int Cantidad { get; set; }

		[ForeignKey("IDPedido")]
		public virtual Pedido Pedido { get; set; }

		[ForeignKey("NombreProducto")]
		public virtual Producto Producto { get; set; }
	}
}
