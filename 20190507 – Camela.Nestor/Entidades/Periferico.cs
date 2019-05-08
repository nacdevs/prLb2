using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Periferico
    {
        private EConector conector;
        private string marca;
        private string modelo;


        public Periferico(string marca,string modelo, EConector conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
        }



        public abstract string ExponerDatos();
        

        public static bool operator !=(Periferico p1, Periferico p2) {
            bool ret = false;
            if (p1.marca != p2.marca || p1.modelo != p2.modelo)
            {
                ret = true;
            }
            return ret;
        }


        public static bool operator ==(Periferico p1, Periferico p2)
        {
            bool ret = false;
            if (p1.marca == p2.marca && p1.modelo == p2.modelo) {
                ret = true;
            }
            return ret;
        }

        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(p.marca);
            sb.Append(p.modelo);            
            return "aaaaa";
        }

        }
}
