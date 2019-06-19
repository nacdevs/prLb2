using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Patente
    {
        private string codPatente;
        private string tipoCodigo;

        public void Patente();

        public void Patente(String codPatente,Tipo tipo)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public enum Tipo{

        }
    }
}
