using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class Caja
    {
        public static Entidades.Caja EntidadesCaja = new Entidades.Caja { Monto = 0.0d, Limite = 10.0d };

        public static double Estado()
        {
            return EntidadesCaja.Monto;
        }

        public static void SetLimite(double monto)
        {
			ConfigurationManager.AppSettings["limiteCaja"] = monto.ToString();
        }

		public static double GetLimite()
		{
			return Convert.ToDouble(ConfigurationManager.AppSettings["limiteCaja"]);
		}

        public static bool DebeEmitirAlerta()
        {
            return EntidadesCaja.Monto >= GetLimite();
        }
    }
}
