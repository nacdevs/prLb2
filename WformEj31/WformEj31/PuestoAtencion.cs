using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WformEj31
{
  class PuestoAtencion
  {
    private static int numeroActual;
    private Puesto puesto;
    public enum Puesto { Caja1,Caja2 };

    public PuestoAtencion() {
      numeroActual = 0;
    }

    public PuestoAtencion(Puesto puesto) {
      numeroActual = 0;
      this.puesto = puesto;
    }

    public static int NumeroActual {
      get
      {
        numeroActual++;
        return numeroActual;
      }
    }

    public bool Atender(Cliente cli)
    {
      bool ret=false;
      System.Threading.Thread.Sleep(10000);
      return ret;
    }


  }
}
