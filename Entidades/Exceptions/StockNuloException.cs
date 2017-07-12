using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
	public class StockNuloException : Exception
	{
		public StockNuloException(string nombreProducto) : base("No hay suficiente Stock del producto " + nombreProducto + ". Reponga stock para continuar la venta.")
		{
			this.Source = "Logica";
		}
	}
}
