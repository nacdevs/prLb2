using Entities;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Persistencia
{
    public class WhatsappXml:IData<IEnumerable<EmisorDeWhatsapp>>
    {
        private readonly string path;

        /// <summary>
        /// Le asigna un valor al path.
        /// </summary>
        public WhatsappXml()
        {
        }

        public void Guardar(Emisor emisor)
        {
          

            
        }

        public IEnumerable<EmisorDeWhatsapp> Leer()
        {
            throw new System.NotImplementedException();
        }
    }
}
