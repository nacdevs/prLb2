using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDEP
{
    class Peso
    {
        private double unidades;
        private static double cotizacion = 0.023;        
        

        private Peso(double cotizacion)
        {
            cotizacion = cotizacion;
        }

        public Peso(float unidades,float cotizacion):this(cotizacion)
        {
            this.unidades = unidades;
        }


        public static double getCotizacion()
        {
            return cotizacion;
        }

        public double getUnidades()
        {
            return this.unidades;
        }
    }
}
