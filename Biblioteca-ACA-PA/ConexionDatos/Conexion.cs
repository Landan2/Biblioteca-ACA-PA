using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;


namespace Biblioteca_ACA_PA.ConexionDatos
{
    public class Conexion
    {
        public SqlConnection ObtenerConexion()
        {
            // Servidor por defecto 
            string servidor = "Localhost";

            // Si el proyecto se ejecuta en la PC del primer colaborador, usa su servidor
            if (Environment.MachineName.Equals("Usuario", StringComparison.OrdinalIgnoreCase))
            {
                servidor = "USUARIO";
            }

            string cadenaConexion = $"Server={servidor};Database=Biblioteca-ACA-ProgramacionA;Integrated Security=True; TrustServerCertificate=True;";
            return new SqlConnection(cadenaConexion);
        }
    }
}