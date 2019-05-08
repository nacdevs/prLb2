using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Teclado : Periferico
    {
        private EDistribucion distribucion;
        public Teclado(string marca, string modelo, EConector conector) : base(marca, modelo, conector)
        {
        }

        public Teclado(string marca, string modelo, EConector conector, EDistribucion distribucion) : base(marca, modelo, conector)
        {
            this.distribucion = distribucion;
        }



        public override string ExponerDatos()
        {
            throw new NotImplementedException();
        }

        public enum EDistribucion {
            Dvorak,QWERTY,QWERTZ,AZERTY
        }
    }
}
