using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Sender
{
    public partial class Form1 : Form
    {   
        private string region="West Europe";
        private ManejadorDeEmisores manejador;
        
        public Form1()
        {
            InitializeComponent();
            manejador = new ManejadorDeEmisores(region);
            this.comboBoxProductos.DataSource = Enum.GetNames(typeof(Emisor.EProducto));
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string msj=richMensaje.Text.ToString();
            string prod = comboBoxProductos.Text;
            int numero;
            int.TryParse(textEmail.Text, out numero);
            Emisor.EProducto producto;
            Enum.TryParse(this.comboBoxProductos.SelectedItem.ToString(), out producto);
            EmisorDeWhatsApp emi = new EmisorDeWhatsApp(msj,producto);
            emi.NumeroTelefono = numero;

            if (manejador + emi)
            {
                MessageBox.Show("Agregado");
            }
            else {
                MessageBox.Show("No se pudo agregar");
            }

            richMensaje.Clear();
            textEmail.Clear();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.richConsola.Text=manejador.EnviarMensajes();
       
            
        }

        private void richMensaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
