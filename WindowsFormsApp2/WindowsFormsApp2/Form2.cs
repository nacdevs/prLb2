using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {   
        public Form2(string nombre, string apellido, string email, string password, string celular, string dob, string sexo)
        {
            InitializeComponent();
            this.nombre.Text = nombre.ToString();
            this.apellido.Text = apellido.ToString();
            this.email.Text = email.ToString();
            this.password.Text = password.ToString();
            this.celular.Text = celular.ToString();
            this.sexo.Text = sexo.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
