using System;
using System.Text;

namespace Entities
{
    public static class EmisorExtension {

        public static string Mostrar(this EmisorDeEmails emisor) {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Mensaje: ", emisor.Mensaje);
            sb.AppendFormat("Email: ", emisor.Email);
            return sb.ToString() ;
        }

        public static string Mostrar(this EmisorDeWhatsapp emisor) {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Mensaje: ", emisor.Mensaje);
            sb.AppendFormat("Email: ", emisor.NumeroTelefono);
            return sb.ToString();
        }


    }
}
