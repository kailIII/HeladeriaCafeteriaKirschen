﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Pedido
	{
		private static int ultimoID = 0;

		public Pedido () {
			ultimoID++;
			this.IDPedido = ultimoID;
			this.FechaHora = DateTime.Now;
			this.Delivery = false;
			this.ProductosPedido = new List<ProductoPedido>();
		}

		[Key]
		public int IDPedido { get; set; }

		[Required]
		public DateTime FechaHora { get; set; }
		
		public bool Delivery { get; set; }

		public bool Efectivo { get; set; }

		public virtual ICollection<ProductoPedido> ProductosPedido { get; set; }

		public virtual double Monto {
			get
			{
				return ProductosPedido.Aggregate(0.0d, (acum, p) =>
					acum + Convert.ToDouble(p.Cantidad) * Convert.ToDouble(p.Producto.PrecioVenta));
			}
		}
	}
}
