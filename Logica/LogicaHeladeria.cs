using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
	public static class LogicaHeladeria
	{
		public static void FiltrarUsuarioActualPorRol(Entidades.TipoUsuario rol)
		{
			if (!Usuario.UsuarioActualEstaEnRol(rol))
				throw new Entidades.Exceptions.ProhibidoException();
		}

		public static void FiltrarPorUsuarioLogueado()
		{
			if (!Usuario.UsuarioActualEstaLogueado())
				throw new Entidades.Exceptions.ProhibidoException();
		}
	}
}
