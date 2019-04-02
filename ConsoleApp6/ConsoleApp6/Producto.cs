using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
  class Producto
  {
    private string marca;
    private float precio;
    private string codigoDeBarra;

    public Producto() { }

    public string getMarca()
    {
      return this.marca;
    }

    public float getPrecio()
    {
      return this.precio;
    }

    public static string MostrarProducto(Producto p)
    {
      return p.marca;
    }

    public static bool operator !=(Producto p1, string marca)
    {
      bool ret = false;
      if (p1.marca.Equals(marca))
      {
        ret = true;
      }

      return ret;
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
      bool ret = false;
      if ((p1.marca.Equals(p2.marca)) && (p1.codigoDeBarra.Equals(p2.codigoDeBarra)))
      {
        ret = true;
      }
      return ret;
    }

    public static bool operator ==(Producto p1, string marca)
    {
      bool ret = false;
      if (p1.marca.Equals(marca))
      {
        ret = true;
      }

      return ret;
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
      bool ret = false;
      if ((p1.marca.Equals(p2.marca)) && (p1.codigoDeBarra.Equals(p2.codigoDeBarra)))
      {
        ret = true;
      }
      return ret;
    }
  }
  }

