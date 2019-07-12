using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190711_Final
{
    public class ErrorArchivoException: Exception
    {
        public ErrorArchivoException(string mensaje) : base(mensaje) {
        }
    }
}
