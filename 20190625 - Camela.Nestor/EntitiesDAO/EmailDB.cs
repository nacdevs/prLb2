using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Persistencia
{
    public class EmailDB: IData<List<EmisorDeEmails>>
    {
        private readonly string connectionString;
        private SqlConnection conexion;
        private SqlCommand comando;
        /// <summary>
        /// Asigna un valor al connectionString
        /// </summary>
        public EmailDB()
        {
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            connectionString = "Data Source=DESKTOP; Initial Catalog= db; Integrated Security=true";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            string currentquery = "INSERT INTO dbo.aaa () VALUES ()";

            comando.CommandText = currentquery;
            conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException sqle)
            {
                throw sqle;
            }



        }

        public void Guardar(Emisor emisor)
        {
            EmisorDeEmails emiEmail = ((EmisorDeEmails)emisor);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            string currentquery = "INSERT INTO dbo.tab () VALUES ()";

            comando.CommandText = currentquery;
            conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException sqle)
            {
                throw sqle;
            }
            //DB
        }

        public List<EmisorDeEmails> Leer()
        {
            throw new NotImplementedException();
        }
    }
}
