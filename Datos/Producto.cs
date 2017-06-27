using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public static class Producto
	{
		private static DBHeladeria dbHeladeria = DBHeladeria.Instance;

		public static void Nuevo(Entidades.Producto producto)
		{
			dbHeladeria.Producto.Add(producto);
			dbHeladeria.SaveChanges();
		}

		public static void Editar(Entidades.Producto producto)
		{
			dbHeladeria.Entry(producto).State = System.Data.Entity.EntityState.Modified;
			dbHeladeria.SaveChanges();
		}

		public static Entidades.Producto Buscar(string nombreProducto)
		{
			return dbHeladeria.Producto.Find(nombreProducto);
		}
	}
}
