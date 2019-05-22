using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica2ElectricBoogaloo
{
    public class Centralita
    {
        private List<Llamada> ListaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get
            {
                float ret = 0;
                foreach (Llamada valor in ListaDeLlamadas)
                {
                    if (valor is Local)
                    {
                        ret += ((Local)valor).CostoLlamada;
                    }
                }
                return ret; }
        }
        public float GananciasPorProvincial { get
            {
                float ret = 0;
                foreach (Llamada valor in ListaDeLlamadas)
                {
                    if (valor is Provincial)
                    {
                        ret += ((Provincial)valor).CostoLlamada;
                    }
                }
                return ret;
            }
        }
        public float GananciasPorTotal { get
            {
                float ret = 0;
                foreach (Llamada valor in ListaDeLlamadas)
                {
                    if (valor is Local)
                    {
                        ret += ((Local)valor).CostoLlamada;
                    }

                    if (valor is Provincial)
                    {
                        ret += ((Provincial)valor).CostoLlamada;
                    }

                }
                return ret;
            }
        }

        public List<Llamada> Llamadas { get => ListaDeLlamadas; }

        public Centralita() {
            ListaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ret = 0;
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    ret = GananciasPorLocal;
                    break;

                case Llamada.TipoLlamada.Provincial:
                    ret = GananciasPorProvincial;
                    break;

                case Llamada.TipoLlamada.Todas:
                    ret = GananciasPorTotal;
                    break;
            }

            return 2;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            ListaDeLlamadas.Add(nuevaLlamada);
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social" + razonSocial);
            sb.AppendLine("Ganancia Total" + GananciasPorTotal);
            sb.AppendLine("Ganancia Local" + GananciasPorLocal);
            sb.AppendLine("Ganancia Provincial" + GananciasPorProvincial);
            for (int i = 0; i < ListaDeLlamadas.Count(); i++)
            {
                sb.AppendLine("---------------------");
                sb.AppendLine("Llamada:" + i.ToString());
                sb.AppendLine("Duracion:" + ListaDeLlamadas[i].Duracion.ToString());
                sb.AppendLine("Nro Destino:" + ListaDeLlamadas[i].NroDestino.ToString());
                sb.AppendLine("Nro Origen:" + ListaDeLlamadas[i].NroOrigen.ToString());

            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {

        }

        public override string ToString()
        {
            return Mostrar();
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach (Llamada llamada in c.ListaDeLlamadas)
            {
                if (llamada == l) {
                    return true;
                }
            }
            return false;
        }


        public static bool operator !=(Centralita c, Llamada l)
        {
            foreach (Llamada llamada in c.ListaDeLlamadas)
            {
                if (llamada == l)
                {
                    return false;
                }
            }
            return true;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
            {
            c.AgregarLlamada(nuevaLlamada);
                return c;
            }
    }
}
