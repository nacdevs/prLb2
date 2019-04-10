using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDEP
{
    class Dolar
    {

        public static double operator +(Euro e, Peso p)
        {
            double pesos = p.getUnidades() * Peso.getCotizacion();
            double euro = e.getUnidades() * Euro.getCotizacion();
            return pesos + euro;
        }

        public static double operator +(Peso p, Euro e)
        {
            double ret = 00.00;
            double cotEuro = Euro.getCotizacion();
            double cotPeso = Peso.getCotizacion();
            
            return ret;
        }

    }
}
