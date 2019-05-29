using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Emisor
    {
        private string mensaje;
        private EProducto producto;

        protected Emisor(string mensaje, EProducto producto) {
            this.mensaje = mensaje;
            this.producto = producto;
        }
        public abstract string EnviarMensaje();

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n.{0}\n.{1}", this.mensaje, this.producto);
            return sb.ToString();
        }

        public enum EProducto
        {
            SQLDatabase, MonitoringApp, AppHosting
        }



        public static bool operator ==(Emisor emisor, Emisor emisorDos)
        {
            if (!(emisor is null) && !(emisorDos is null))
            {
                if (((emisor.producto) == (emisorDos.producto)) && (emisor.mensaje.Equals(emisorDos.mensaje)))
                {
                    return true;
                }
            }
            
            return false;
        }

        public static bool operator !=(Emisor emisor, Emisor emisorDos) {

            if (!(emisor is null) && !(emisorDos is null))
            {
                if (emisor.producto != emisorDos.producto)
                {
                    return true;
                }
                else {
                    return false;
                }

               
            }
            else {
                return false;
            }

            
            
        }

     

        

    }
}
