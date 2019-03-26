using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumno = new Alumno("Juan","Perez",40,"UTC");
      alumno.estudiar(2, 6);
      alumno.calcularFinal();
      alumno.mostrar();


      Alumno alumno2 = new Alumno("John", "Doe", 120,"UBA");
      alumno.estudiar(5, 6);
      alumno.calcularFinal();
      alumno.mostrar();



      Alumno alumno3 = new Alumno("Michael", "Kane", 9999, "UTN");
      alumno.estudiar(10, 1);
      alumno.calcularFinal();
      alumno.mostrar();




    }
  }
}
