using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeWhatsApp:Emisor
    {
        private bool numeroCargado=false;
        private int numeroTelefono;

        
        public int NumeroTelefono { get { return numeroTelefono; }
            set { if (value > 1500000000 && value <= 1599999999) {
                    numeroTelefono = value;
                    numeroCargado = true;
                }
            }
        }

        public EmisorDeWhatsApp(string mensaje, Emisor.EProducto producto):base(mensaje,producto)
        {

        }


        public override string EnviarMensaje()
        {
            string text;
            if (this.numeroCargado)
            {
                text = "Enviando Mensaje";
            }
            else
            {
                text = "No se pudo enviar el mensaje";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendFormat("\n{0}", text);            
            return sb.ToString();
        }

        public static explicit operator string(EmisorDeWhatsApp emisor) {
            string txt;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(emisor.ToString());
            if (emisor.numeroCargado)
            {
                txt = emisor.numeroTelefono.ToString();
            }
            else
            {
                txt = ".No cargado";
            }
            sb.AppendLine(txt);
            return sb.ToString();
        }
    }
}
