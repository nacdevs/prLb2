using Entities;

namespace Persistencia
{
    public interface IData<T>
    {
        void Guardar(Emisor emisor);
        T Leer();
    }
}