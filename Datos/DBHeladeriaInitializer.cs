using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public class DBHeladeriaInitializer : CreateDatabaseIfNotExists<DBHeladeria>
	{
		protected override void Seed(DBHeladeria context)
		{
			base.Seed(context);
			Entidades.Usuario admin = new Entidades.Usuario("admin", "admin");
			admin.Rol = Entidades.TipoUsuario.Supervisor;
			Datos.Usuario.Nuevo(admin);
		}
	}
}
