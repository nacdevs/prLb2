using System;
using System.Threading;
namespace Entities
{
    public class EmisorDeEmails : Emisor
    {
        private string email;

        public string Email
        {
            set => email = value;
            get => email;
        }

        /// <summary>
        /// valida si hay manejadores, en caso de que no haya, lanza un EmisorException 
        /// indicando que no hay manejadores. Caso contrario duerme el Thread 3 segundos y 
        /// luego invoca al evento EventMensaje pasándose a sí mismo (“.Invoke(this)”) como 
        /// parámetro.
        /// </summary>
        public override void EnviarMensaje()
        {
            Thread.Sleep(3000);
            /*if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }*/
            base.EventMensaje(this,this);
        }

        public EmisorDeEmails(string mnsj, EProducto prod, string mail)
            : base(mnsj, prod)
        {
            this.email = mail;
        }
    }
}
