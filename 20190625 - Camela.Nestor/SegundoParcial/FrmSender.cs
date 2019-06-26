using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Entities;
using Persistencia;

namespace SegundoParcial
{
    public partial class FrmSender : Form
    {
        private readonly List<Thread> hilos;

        public FrmSender()
        {
            InitializeComponent();
            hilos = new List<Thread>();
        }

        /// <summary>
        /// El botón Enviar Email debe crear un EmisorDeEmails, agregar al eventMensaje el 
        /// manejador “EmailDB.Guardar” y “MostrarMensaje” y ejecutar el método EnviarMensaje 
        /// (del objeto EmisorDeEmails) en un hilo nuevo. (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            EmisorDeEmails emisorEmails = new EmisorDeEmails(richMensaje.Text.ToString(),EProducto.SQLDatabase,txtEmail.Text.ToString());

            EmailDB edb = new EmailDB();

            emisorEmails.EventMensaje += edb.Guardar;
            emisorEmails.EventMensaje += MostrarMensaje;
            Thread thread = new Thread(emisorEmails.EnviarMensaje);
            hilos.Add(thread);
        }

        /// <summary>
        /// Email info utilizarán las clase EmailDb para traer la 
        /// información de la base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMailInfo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// El botón Enviar Whatsapp hace lo mismo con el objeto EmisorDeWhatsapp per 
        /// agrega al event eventMensaje el manejador “WhatsappTexto.Guardar” y “MostrarMensaje” 
        /// y ejecutar el método EnviarMensaje (del objeto EmisorDeEmails) en un hilo nuevo. 
        /// (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendWhat_Click(object sender, EventArgs e)
        {
            EmisorDeWhatsapp emisorEmails = new EmisorDeWhatsapp();
            WhatsappTexto wtxt = new WhatsappTexto();
            emisorEmails.EventMensaje+= wtxt.Guardar;
            emisorEmails.EventMensaje+=MostrarMensaje;
            Thread thread = new Thread(emisorEmails.EnviarMensaje);
            hilos.Add(thread);

        }

        /// <summary>
        /// Whatsapp info utilizarán las clase WhatsappTexto para traer la información de la 
        /// base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWhatInfo_Click(object sender, EventArgs e)
        {
            EmailDB edb = new EmailDB();
         
          
        }

        /// <summary>
        /// recibe un objeto del tipo Emisor y muestra en un MessageBox el siguiente mensaje: 
        /// $"{mensaje.GetType().Name} - Se envió mensaje del producto: {mensaje.Producto}”
        /// </summary>
        /// <param name="emisor"></param>
        private void MostrarMensaje(Emisor emisor)
        {
            StringBuilder sb = new StringBuilder();
            MessageBox.Show("a");
        }

        /// <summary>
        /// Cuando se cierra la aplicación abortar todos los hilos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSender_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
