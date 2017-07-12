using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

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

		public static void Borrar(string nombreProducto)
		{
			dbHeladeria.Producto.Remove(Buscar(nombreProducto));
			dbHeladeria.SaveChanges();
		}

		public static List<Entidades.Producto> ToList()
		{
			return dbHeladeria.Producto.ToList();
		}

		public static List<Entidades.Producto> ListarALaVenta()
		{
			return (from producto in dbHeladeria.Producto
					where producto.PrecioVenta != null && producto.PrecioVenta != 0
					select producto).ToList();
		}

		public static void IncrementarStock(string nombreProducto, int cantidad)
		{
			var producto = dbHeladeria.Producto.Find(nombreProducto);
			producto.Stock += cantidad;
			Editar(producto);
		}

		public static void DecrementarStock(string nombreProducto, int cantidad)
		{
			var producto = dbHeladeria.Producto.Find(nombreProducto);
			producto.Stock -= cantidad;
			Editar(producto);
		}
	}
}
