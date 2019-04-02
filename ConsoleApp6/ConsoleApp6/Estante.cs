using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
  class Estante
  {
    Producto[] productos;
    private int ubicacionEstante;

    private Estante(int capacidad)
    {
      productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion):this(capacidad)
    {      
      this.ubicacionEstante = ubicacion;      
    }

    public Producto[] getProductos()
    {
      return this.productos;
    }


    public string mostarEstante(Estante e)
    {
      
    }

    public static bool operator ==(Producto p1, Estante e)
    {
      bool ret = false;
      for (int i = 0; i < e.productos.Length; i++)
      {
        if (p1.getMarca().Equals(e.productos[i].getMarca()))
        {
          ret = true;
        }
      }
      

      return ret;
    }

    public static bool operator !=(Producto p1, Estante e)
    {
      bool ret = false;
      for (int i = 0; i < e.productos.Length; i++)
      {
        if (p1.getMarca().Equals(e.productos[i].getMarca()))
        {
          ret = true;
        }
      }


      return ret;
    }


  }
}
