using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo:Periferico
    {
        private int ramMB;
        
        
        public PlacaVideo(string marca, string modelo,int ramMB) : base(marca, modelo, EConector.PCIExpress)
        {
            this.ramMB = ramMB;

      }




        public override string ExponerDatos()
        {
            return "aaa";
        }

     
    }
}
