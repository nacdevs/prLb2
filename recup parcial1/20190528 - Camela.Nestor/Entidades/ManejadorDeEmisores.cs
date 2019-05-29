using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDeEmisores
    {
        private List<Emisor> emisores;
        private string region;

        public string EnviarMensajes() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Region:{0}", region);
            if (emisores != null) {
                foreach (Emisor emisor in emisores)
                {
                    sb.AppendLine(emisor.EnviarMensaje());
                }
            }
           
            return sb.ToString();
        }

        private ManejadorDeEmisores() {
            emisores = new List<Emisor>();
        }

        public ManejadorDeEmisores(string region):this() {
            this.region = region;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Region:{0}",region);
            foreach (Emisor emisor in emisores) {
                sb.AppendLine(emisor.ToString());
            }
            return sb.ToString();
        }


        

        public static bool operator ==(ManejadorDeEmisores manejador, Emisor emisorDos)
        {
            if (manejador.emisores != null)
            {
                foreach (Emisor emisor in manejador.emisores)
                {
                    if (emisorDos == emisor)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(ManejadorDeEmisores manejador, Emisor emisorDos)
        {
            if (manejador.emisores != null) {
                foreach (Emisor emisor in manejador.emisores)
                {
                    if (emisorDos == emisor)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator +(ManejadorDeEmisores manejador, Emisor emisor) {

            if (manejador.emisores != null && manejador != emisor)
            {            
                    manejador.emisores.Add(emisor);
                    return true;
              
            }else {
             
                return false;
            }
            
        }

        public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
        {
            if (manejador != null && (manejador == emisor)) {
                
                    manejador.emisores.Remove(emisor);
                    return true;
                
            }         
            else
            {
                return false;
            }
        }


    }
}
