using Entities;
using System;
using System.IO;

namespace Persistencia
{
    public class WhatsappTexto : IData<string>
    {
        private readonly string path;

        /// <summary>
        /// Asignar valor al path
        /// </summary>
        public WhatsappTexto()
        {   
            //TODO
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        

        public void Guardar(Emisor emisor)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.AppendAllText(path, "\n " +emisor.Mostrar() + "\n ");
           
        }

   

        public string Leer()
        {
           return  File.ReadAllText(path);
            
        }
    }
}
