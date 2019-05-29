using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeEmails:Emisor
    {
        private string email;
        private bool enviado;

        public EmisorDeEmails(string mensaje, Emisor.EProducto producto, string email) : base(mensaje,producto){
            this.email = email;
            this.enviado = false;
        }

        public override string EnviarMensaje()
        {
            string text;
            if (enviado)
            {
                text = "El mensaje ya fue enviado";
            }
            else {
                text = "Se envia el mensaje";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendFormat("\n{0}", text);
            enviado = true;
            return sb.ToString();
        }

        public static explicit operator string(EmisorDeEmails emisor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(emisor.ToString());
            sb.AppendLine(emisor.email);
            return sb.ToString();
        }
    }
}
