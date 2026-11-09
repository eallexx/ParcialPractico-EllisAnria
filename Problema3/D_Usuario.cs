using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    public class D_Usuario: Conexion
    {
        public string IniciarSesion(string usuario, string password)
        {
            MySqlConnection cn = Conexion.ObtenerConexion();

            if (cn == null)
                return null;

            try
            {
                string consulta = @"SELECT idUsuario, nombreUsuario, paHash
                            FROM usuarios
                            WHERE nombreUsuario = @usuario";

                using (MySqlCommand comando = new MySqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            int id = lector.GetInt32("idUsuario");
                            string nombre = lector.GetString("nombreUsuario");
                            string hash = lector.GetString("passwordHash");

                            lector.Close();

                            bool correcto = BCrypt.Net.BCrypt.Verify(password, hash);

                           

                            if (correcto)
                                return nombre;

                            return null;
                        }
                    }
                }

                

                return null;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al iniciar sesión: " + ex.Message);
                return null;
            }
        }
        
        }
    }
