namespace Datos
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.ModelConfiguration.Conventions;
	using System.Linq;

	public class DBHeladeria : DbContext
	{
		private DBHeladeria()
			: base("name=DBHeladeria")
		{
		}

		public DbSet<Entidades.MovimientoDeCaja> MovimientoDeCaja { get; set; }

		public DbSet<Entidades.Pedido> Pedido { get; set; }

		public DbSet<Entidades.Producto> Producto { get; set; }

		public DbSet<Entidades.Usuario> Usuario { get; set; }

		public DbSet<Entidades.ProductoPedido> ProductoPedido { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			Database.SetInitializer<DBHeladeria>(new DBHeladeriaInitializer());
		}

		private static DBHeladeria instance;

		public static DBHeladeria Instance
		{
			get
			{
				if (instance == null) instance = new DBHeladeria();
				return instance;
			}
		}
	}
}