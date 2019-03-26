using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
  class Calculador
  {
    private static int acumulador;
    

    public  Calculador()
    {
      acumulador = 0;
    }

    public static string Acumulador(String binario)
    {
      Convert.ToInt32(binario, acumulador);

    }

    public static string getResultadoBinario() {
      string ret=Convert.ToString(acumulador, 2);
      return ret;
    }

    public static int getResultadoEntero()
    {
      return acumulador;
    }

  }
}
