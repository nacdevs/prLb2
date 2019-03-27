using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
  class Boligrafo
  {
    private int cantidadTintaMaxima;
    private ConsoleColor color;
    private short tinta;


    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }

    public ConsoleColor getColor()
    {
      return this.color;
    }

    public short getTinta()
    {
      return this.tinta;      
    }

    public void setTinta(short tinta)
    {
      if ((this.tinta + tinta < 100) && (this.tinta - tinta > 0))
      {
        this.tinta+=tinta; 
      }        
        
    }

    public void recargar()
    {
      this.tinta = 100;
    }

    public bool pintar(int gasto, out string dibujo) {
      bool ret=false;
      var builder = new StringBuilder();
      
    
        if (this.tinta > 0 && (this.tinta+gasto)>0)
        {
        int ast = this.tinta+gasto;
        Console.WriteLine(ast.ToString());
          setTinta(this.tinta+=(short)gasto);
          for(int i=0; i < ast; i++)
          {
          builder.Append("*");
          }

          dibujo = builder.ToString();
          ret = true;
      }
      else
      {
        dibujo = "No se puede";
      } 
        
      

      return ret;
    }

  }
}
