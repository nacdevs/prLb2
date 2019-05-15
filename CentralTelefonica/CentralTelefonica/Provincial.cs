using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;
        public float CostoLlamada {
            get{
                return CalcularCosto();
            }
        }
        public Provincial(string nroOrigen,Franja miFranja, float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
        }

        public Provincial(Franja miFranja, Llamada llamada): this(llamada.NroOrigen,miFranja,llamada.Duracion, llamada.NroDestino)
        {

        }

        private float CalcularCosto()
        {
            float ret=0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    ret = Duracion * (float)0.99;
                    break;

                case Franja.Franja_2:
                    ret = Duracion * (float)1.25;
                    break;

                case Franja.Franja_3:
                    ret = Duracion * (float)0.66;
                    break;
                    
            }

      return ret;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion:" + base.Duracion);
            sb.AppendLine("Nro Destino:" + base.NroDestino);
            sb.AppendLine("Nro Origen:" + base.NroOrigen);
              sb.AppendLine("Costo Llamada: " + CostoLlamada.ToString());
            return sb.ToString();
        }

        public enum Franja
        {
            Franja_1,Franja_2,Franja_3
        }
    }
} 

