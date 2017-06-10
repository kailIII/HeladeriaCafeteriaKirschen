using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Pedido
	{
		public int ID { get; set; }

		public List<Producto> Productos { get; set; }

		public DateTime FechaHora { get; set; }

		public bool Delivery { get; set; }
	}
}
