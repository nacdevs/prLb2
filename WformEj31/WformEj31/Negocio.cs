using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WformEj31
{
  class Negocio
  {
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;

    private Negocio() { }

    public Negocio(string nombre)
    {
      this.nombre = nombre;
    }

    public static bool operator !=(Negocio n, Cliente c) {
      bool ret = true;
      foreach(Cliente cliente in n.clientes)
      {
        if(cliente == c)
        {
          ret = false;
          break;
        }
      }

      return ret;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      bool ret = false;
      foreach (Cliente cliente in n.clientes)
      {
        if (cliente == c)
        {
          ret = true;
          break;
        }
      }
      return ret;
    }

  }
}
