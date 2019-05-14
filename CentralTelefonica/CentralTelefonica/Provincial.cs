using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Provincial : Llamada
    {
        protected Franja franjaHoraria;
        public float CostoLlamada {
            get{
                return 1;
            }
        }
        public Provincial(float duracion, string nroDestino, string nroOrigen) : base(duracion, nroDestino, nroOrigen)
        {
        }

        public Provincial(Franja miFranja, Llamada llamada): this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {

        }

        private float CalcularCosto()
        {
            float ret;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    ret = float.TryParse(Duracion * 0.99);
                    break;

                case Franja.Franja_2:
                    ret = Duracion * 1.25;
                    break;

                case Franja.Franja_3:
                    ret = Duracion * 0.66;
                    break;
                    
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion:" + base.Duracion);
            sb.AppendLine("Nro Destino:" + base.NroDestino);
            sb.AppendLine("Nro Origen:" + base.NroOrigen);
            sb.AppendLine("Costo Llamada: "+this.cos)
            return sb.ToString();
        }

        public enum Franja
        {
            Franja_1,Franja_2,Franja_3
        }
    }
} 

