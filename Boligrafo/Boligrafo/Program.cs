using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
  class Program
  {
    
    static void Main(string[] args)      
    {
      string dibujo;
      Boligrafo bol1 = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo bol2 = new Boligrafo(50, ConsoleColor.Red);
      bol1.recargar();
      bol1.pintar(-70, out dibujo);
      Console.ForegroundColor = (bol1.getColor());
      Console.WriteLine(dibujo);
      System.Threading.Thread.Sleep(5000);
    }
  }
}
