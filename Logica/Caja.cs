using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Caja
    {
        public static double Estado()
        {
            return Datos.Caja.Estado();
        }

        public static void SetLimite(double monto)
        {
            Datos.Caja.SetLimite(monto);
        }

        public static bool DebeEmitirAlerta()
        {
            return Datos.Caja.DebeEmitirAlerta();
        }
    }
}
