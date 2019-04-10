using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDEP
{
    class Euro
    {
        private double unidades;
        private static double cotizacion=0.84;

        private Euro(double cotizacion)
        {
            cotizacion = cotizacion;
        }
        
        public Euro(double unidades, double cotizacion):this(cotizacion)
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
