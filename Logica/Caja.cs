using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Caja
    {
        public static double Estado()
        {
            return Datos.Caja.Estado();
        }

        public static void SetLimite(double monto)
        {
			LogicaHeladeria.FiltrarUsuarioActualPorRol(Entidades.TipoUsuario.Supervisor);
            Datos.Caja.SetLimite(monto);
        }

		public static double GetLimite()
		{
			return Datos.Caja.GetLimite();
		}


		public static bool DebeEmitirAlerta()
        {
            return Datos.Caja.DebeEmitirAlerta();
        }
    }
}
