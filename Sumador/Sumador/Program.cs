using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador
{
  class Program
  {
    static void Main(string[] args)
    {
      Sumador sm = new Sumador();
      sm.sumar();

      Sumador sm2 = new Sumador();
      sm2.sumar();

      long j =sm + sm2;

      Console.WriteLine(j);

      System.Threading.Thread.Sleep(5000);
    }
  }
}
