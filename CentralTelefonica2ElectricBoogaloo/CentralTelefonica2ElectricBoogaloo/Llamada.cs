using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica2ElectricBoogaloo
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino; }
        public string NroOrigen { get => nroOrigen; }
        //public abstract float CostoLlamada;

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion:"+this.duracion);
            sb.AppendLine("Nro Destino:" + this.nroDestino);
            sb.AppendLine("Nro Origen:" + this.nroOrigen);
            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int ret =0;
            if (llamada1.duracion > llamada2.duracion)
            {
                ret = 1;
            }
            else
            {
                ret = -1;
            }
            return ret;
        }
        public enum TipoLlamada
        {
            Local,Provincial,Todas
        }

        public static bool operator ==(Llamada l1, Llamada l2) {
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return false;
        }
    }
}
