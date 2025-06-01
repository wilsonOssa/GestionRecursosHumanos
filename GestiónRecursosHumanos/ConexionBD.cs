using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GestiónRecursosHumanos
{
    using System.Data.SqlClient;

    public static class ConexionBD
    {
        private static SqlConnection _conexion;

        public static SqlConnection ObtenerConexion()
        {
            if (_conexion == null)
            {
                string cadenaConexion = "Server=TU_SERVIDOR;Database=GestionRecursosHumanos;Integrated Security=True;";
                _conexion = new SqlConnection(cadenaConexion);
            }
            return _conexion;
        }
    }
}
