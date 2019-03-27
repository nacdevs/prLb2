using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador
{
  class Sumador
  {

    private int cantidadSumas;
    public Sumador(int s)
    {
      this.cantidadSumas = s;
    }

    public Sumador() : this(0) { }

    public void sumar()
    {
      cantidadSumas++;
    }

    public long sumar(long a, long b)
    {
      long ret = a + b;
      return ret;
    }

    public string sumar(string a, string b)
    {
      string ret = String.Concat(a, b);
      return ret;
    }

    public static explicit operator int(Sumador s)
    {
      int ret = s.cantidadSumas;
      return ret;

    }

    public static long operator +(Sumador s1, Sumador s2)
    {
      long ret = s1.cantidadSumas + s1.cantidadSumas;
      return ret;
    }

    public static bool operator |(Sumador s1, Sumador s2)
    {
      bool ret=false;
      if (s1.cantidadSumas == s2.cantidadSumas)
      {
        ret = true;
      }
      return ret;
    }
  }
}
