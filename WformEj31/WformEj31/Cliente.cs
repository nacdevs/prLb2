using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WformEj31
{
  class Cliente
  {
    private string nombre;
    private int numero;

    public Cliente(int numero)
    {
      this.numero = numero;
    }

    public Cliente(int numero, string nombre)
    {
      this.numero = numero;
      this.nombre = nombre;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public int Numero { get => numero; set => numero = value; }

    public static bool operator !=(Cliente c1 , Cliente c2)
    {
      bool ret = false;
      if (c1.numero != c2.numero)
      {
        ret = true;
      }
      return ret;
        
    }


    public static bool operator == (Cliente c1, Cliente c2)
    {
      bool ret = false;
      if (c1.numero == c2.numero)
      {
        ret = true;
      }

      return ret;
    }




  }
}
