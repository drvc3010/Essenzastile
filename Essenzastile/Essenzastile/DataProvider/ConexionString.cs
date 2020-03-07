using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Essenzastile.DataProvider
{
    public static class ConexionString
    {
        public static string conexion = ConfigurationManager.AppSettings["ConexionBD"].ToString();
    }
}