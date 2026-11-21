using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVita.DAL
{
    internal class Conexion
    {
        private static string cadena =
            "server=localhost;port=3306;database=clinica_rrhh;uid=root;pwd=admin;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
