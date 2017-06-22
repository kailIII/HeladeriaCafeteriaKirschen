﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Caja
    {
        public static Entidades.Caja EntidadesCaja = new Entidades.Caja { Monto = 0.0d };

        public static double MontoLimite = 10.0d;

        public static double Estado()
        {
            return EntidadesCaja.Monto;
        }

        public static void SetLimite(double monto)
        {
            MontoLimite = monto;
        }

        public static bool DebeEmitirAlerta()
        {
            return EntidadesCaja.Monto >= MontoLimite;
        }
    }
}