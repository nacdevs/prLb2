using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class Xml : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            throw new NotImplementedException();
        }

        public void Leer(string archivo, out T datos)
        {
            throw new NotImplementedException();
        }
    }
}
