using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Pedido
	{
		public Pedido () {
			this.Delivery = false;
		}

		[Key]
		public int IDPedido { get; set; }

		[Required]
		public DateTime FechaHora { get; set; }
		
		public bool Delivery { get; set; }

		public virtual ICollection<Producto> Productos { get; set; }
	}
}
