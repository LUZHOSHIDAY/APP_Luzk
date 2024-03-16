using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    /// <summary>
    /// Cadena de conexion a Bases de datos
    /// </summary>
    internal class Conexion
    {
        public static string Cn =
            "Data Source=DESKTOP-6V9JTSL\\MSSQLSERVER01; " +
            "Initial Catalog =DB_Clinica; " +
            "Integrated Security=true";
    }
}
