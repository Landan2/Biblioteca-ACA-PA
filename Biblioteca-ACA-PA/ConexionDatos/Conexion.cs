using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;


namespace Biblioteca_ACA_PA.ConexionDatos
{
    public class Conexion
    {
        public static string CadenaConexion = "Server=USUARIO; DataBase= Biblioteca-ACA-ProgramacionA; Integrated Security=True; TrustServerCertificate=True;";
      
        public SqlConnection ObtenerConexion()
        {

            return new SqlConnection(CadenaConexion);
        }

    }
}