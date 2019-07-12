using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeropuerto<T> where T:IAvion
    {
        private List<T> vuelos;

        public Aeropuerto() {
        }

        public void FinalizarVuelos() {
            
        }

        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);
            return a.vuelos.Count * 50;
        }

        public static explicit operator String(Aeropuerto<T> a) {
            int suma=0;
            List<T> list = a.vuelos;
            foreach (T vuelo in list) {
                if (vuelo.Estado == Avion.EstadoVuelo.Volando) {
                    suma++;
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El aeropuerto cuenta con {0} vuelos en estado Volando", suma);
            return sb.ToString();
        }

        


    }
}
