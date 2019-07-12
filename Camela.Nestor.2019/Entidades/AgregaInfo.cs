using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AgregaInfo
    {
        public static bool agregaInfo(this Aeropuerto<IAvion>  a)
        {
            string connectionStr = "Data Source=. SQLEXPRESS; Initial Catalog=final-20190711; Integrated Security=true";
            SqlConnection conexion = new SqlConnection(connectionStr);
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            string currentquery = "INSERT INTO dbo.Bitacora (entrada, alumno) VALUES ('" + System.DateTime.Now + "', '" + (string)a+ "')";

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

            return true;
        }
    }
}
