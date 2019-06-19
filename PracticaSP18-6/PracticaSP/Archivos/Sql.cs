using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Archivos
{
    class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public void Guardar(string archivo, Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            Patente.Tipo tipo;
            comando.CommandText = "SELECT codPatente, tipoCodigo FROM Patente";
            conexion    
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            
        }
    }
}


