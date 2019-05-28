using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado : Periferico
    {
        private EDistribucion distribucion;
        public Teclado(string marca, string modelo, EConector conector) : base(marca, modelo, conector)
        {
          this.distribucion = EDistribucion.Dvorak;
        }

        public Teclado(string marca, string modelo, EConector conector, EDistribucion distribucion) : base(marca, modelo, conector)
        {
            this.distribucion = distribucion;
        }



        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendFormat("Distribucion:{0}", this.distribucion);
            return sb.ToString();
        }

        public enum EDistribucion {
            Dvorak,QWERTY,QWERTZ,AZERTY
        }
    }
}
