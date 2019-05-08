using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        
        private string nombre;
        private string systemInfo;
        private List<Periferico> perifericos;

        public int CantidadMaxPerifericos {
            
            set {
                    if (value > 1 && value < 4) {
                        CantidadMaxPerifericos = value;
                    }
                    else
                    {
                        CantidadMaxPerifericos = 1;
                    }
                 }
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string SystemInfo { get {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.nombre);
                sb.Append(this.perifericos);
                sb.Append(this.cantidadMaxPerifericos.ToString());
                for (int i = 0; i < perifericos.Count(); i++)
                {
                    sb.Append(perifericos[i].ExponerDatos());
                }
                return sb.ToString();
            }  }

        public Maquina() {
            perifericos = new List<Periferico>();
            this.cantidadMaxPerifericos = 3;
        }

        

        public Maquina(string nombre):this() {
            this.nombre = nombre;
        }


        public static bool operator !=(Maquina m, Periferico p)
        {
            bool ret = false;
            for (int i = 0; i < m.perifericos.Count(); i++)
            {
                if (m.perifericos[i] != p)
                {
                    ret = true;
                }
            }
            return ret;
        }


        public static bool operator ==(Maquina m, Periferico p)
        {
            bool ret = false;
            for (int i = 0; i < m.perifericos.Count(); i++)
            {
                if (m.perifericos[i] == p) {
                    ret = true;                    
                }
            }
            return ret;
        }


        public static string operator +(Maquina m, Periferico p) {
            string ret="No se puede conectar el dispositivo";
            if (m.perifericos.Count() < 4 && m.perifericos.Count() > 1) {
                if (!m.perifericos.Contains(p)) {
                    m.perifericos.Add(p);
                    ret = "Periferico Conectado!";
                }
            }

            return ret;
        }


        public static string operator -(Maquina m, Periferico p) {
            string ret = "No se puede desconectar el dispositivo";

            if (m.perifericos.Count() < 4 && m.perifericos.Count() > 1)
            {
                if (m.perifericos.Contains(p))
                {
                    m.perifericos.Remove(p);
                    ret = "Periferico desconectado!";
                }
            }

            return ret;

        }





    }
}
