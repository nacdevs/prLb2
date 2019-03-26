using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Alumno
  {
    private byte nota1, nota2;
    private float notaFinal;
    private string firstName, lastName, colegio;    
    private int age,legajo;

    public Alumno(string firstName, string lastName, int legajo, string colegio)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.legajo = legajo;
      this.colegio = colegio;

    }


    public void estudiar (byte notaUno, byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
    }

    public void calcularFinal()
    {
      if(nota1>=4 && nota2>=4)
      {
        Random rnd = new Random();
        notaFinal=rnd.Next();
      }
      else
      {
        notaFinal = -1;
      }
    }


    public void mostrar()
    {
      string des;
      if (notaFinal != -1)
      {
        des = notaFinal.ToString();
      }
      else
      {
        des = "Alumno desaprobado";
      }
      Console.WriteLine("Nombre: " + this.firstName + "\nApellido: " + this.lastName + "\nLegajo: "+this.legajo+"\nNota 1: "+this.nota1+ "\nNota 2: " + this.nota2 + "\nFinal: " + des+"\n\n");
      System.Threading.Thread.Sleep(2000);
    }

    public void printAlumno()
    {
      Console.WriteLine("Nombre: "+this.firstName+"\nApellido: "+this.lastName+"\nEdad: "+this.age);
      System.Threading.Thread.Sleep(2000);
    }



  }
}
