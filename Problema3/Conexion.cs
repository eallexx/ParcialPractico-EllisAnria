using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace Problema3
{
    public class Conexion
    {
        private static string cadenaConexion = "Server=localhost; Database=parcialpractico;Uid=root;Pwd=Cambio23";

        public static MySqlConnection ObtenerConexion()
        {
            try
            {

                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                return (conexion);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
                return null;
            }
        } 
        
    }
}
