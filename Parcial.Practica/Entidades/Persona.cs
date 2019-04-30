using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Persona
    {
        private string nombre, apellido;
        private int dni, edad;

        public Persona(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }

        public virtual string Mostrar()
        {   StringBuilder a= new StringBuilder();
            a.Append("Nombre:" + this.nombre.ToString() + "Apellido:" + this.apellido.ToString());
            a.Append("DNI:"+this.dni.ToString() + " Edad:" + this.edad.ToString());
            return a.ToString();
        }

        public virtual bool ValidarAptitud()
        {
            bool ret= false;
            return ret;

        }
    }
}
