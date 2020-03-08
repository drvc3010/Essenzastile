using System.Configuration;

namespace Essenzastile.DataProvider
{
    public static class ConexionString
    {
        public static string conexion = ConfigurationManager.AppSettings["ConexionBD"].ToString();
    }
}