using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSQL.DATA
{
    public class Conexion
    {
        static string servidor = "MAESTRO\\MAESTRO";
        static string bd = "fesepsa";
        static string usuario = "sa";
        static string password = "Fesepsa2012";

        public static string rutaConexion = "Data Source=" + servidor + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";
    }
}