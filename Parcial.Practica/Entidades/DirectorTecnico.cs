using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int dni, int edad,int añosExperiencia) : base(nombre, apellido, dni, edad)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia { get => añosExperiencia; set => añosExperiencia = value; }

        public override bool ValidarAptitud()
        {
            bool ret = base.ValidarAptitud();
            if(base.Edad<65 && this.añosExperiencia > 2)
            {
                ret = true;
            }
            return ret;
        }
    }
}
