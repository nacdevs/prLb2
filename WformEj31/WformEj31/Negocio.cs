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
    private Cliente cliente;
    private string nombre;

    internal Cliente Cliente
    {
      get
      {
        return clientes.Dequeue();
      }
      set
      {

      }
    }

    private Negocio() { }

    public Negocio(string nombre)
    {
      this.nombre = nombre;
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
      bool ret = true;
      foreach (Cliente cliente in n.clientes)
      {
        if (cliente == c)
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



    public static bool operator +(Negocio n, Cliente c)
    {
      bool ret = false;
      if (n != c) {
        n.clientes.Enqueue(c);
        ret = true;
      }

      return ret;
    }

    public static bool operator ~(Negocio n) {
      bool ret = false;
      Cliente c =n.clientes.Dequeue();
      PuestoAtencion pa = new PuestoAtencion();
      if (pa.Atender(c)) {
        ret = true;
      }
      
      return ret;
    }
  }
}
