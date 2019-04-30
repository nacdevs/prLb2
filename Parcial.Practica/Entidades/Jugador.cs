using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Jugador :Persona
    {
        private const double Y = 2.00;
        private float altura , peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int dni, int edad,float peso,float altura,Posicion posicion) : base(nombre, apellido, dni, edad)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public float Altura { get => altura; set => altura = value; }
        public float Peso { get => peso; set => peso = value; }
        public Posicion Posicion { get => posicion; set => posicion = value; }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Altura:"+this.altura.ToString());
            sb.Append("Peso:" + this.peso.ToString());
            sb.Append("Posicion:" + this.posicion.ToString());

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool ret=base.ValidarAptitud();

            if (Edad < 40 && ValidarEstadoFisico())
            {
                ret = true;
            }
            return ret;
        }

        public bool ValidarEstadoFisico()
        {
            bool ret = false;
            double alt;
            Double.TryParse(altura.ToString(), out alt);
            float imc = peso / (float)(Math.Pow(alt, 2.00));

            if(imc>18.5 && imc <= 25)
            {
                ret = true;
            }

            return ret;
        }

        
    }
}
