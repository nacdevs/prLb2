using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica2ElectricBoogaloo
{
    public class Local:Llamada
    {
        protected float costo;        
        
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

    public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino,costo)
        {
            this.costo = costo;
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {   
            
            return base.Duracion*this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion:" + base.Duracion);
            sb.AppendLine("Nro Destino:" + base.NroDestino);
            sb.AppendLine("Nro Origen:" + base.NroOrigen);
            sb.AppendFormat("Costo llamada:{0}", CostoLlamada);
            return sb.ToString();
        }

        public bool Equals(object obj)
        {   
            if(obj is Local)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
