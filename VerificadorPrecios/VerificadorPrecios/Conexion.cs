using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorPrecios
{
    class Conexion
    {
        public static string establecimiento;
        public static string dispositivo;
        public static string BD;

        static Conexion()
        {
            establecimiento = ConfigurationManager.AppSettings["establecimiento"];
            dispositivo = ConfigurationManager.AppSettings["dispositivo"];
            BD = "BMSEdy";
        }

        public static SqlConnection conectar()
        {
            SqlConnection sqlConnection;
            try
            {
                //Data Source=187.216.118.170,14335;Initial Catalog=BMSEdy;Integrated Security=False;User ID=prgrmusr;Password=$M3rc4d0$;Connect Timeout=30;ConnectRetryCount=3;ConnectRetryInterval=10
                SqlConnection sqlConnection1 = new SqlConnection($"Server='187.216.118.170,14335';Database={BD};User Id=prgrmusr;Password=$M3rc4d0$;Connect Timeout=10;ConnectRetryCount=3;ConnectRetryInterval=10;");
                sqlConnection1.Open();
                sqlConnection = sqlConnection1;
            }
            catch (Exception)
            {
                sqlConnection = null;
            }
            return sqlConnection;
        }

        public static bool FileConfigExists()
        {
            return FileConfigExists(System.Reflection.Assembly.GetEntryAssembly());
        }

        public static bool FileConfigExists(Assembly assembly)
        {
            return System.IO.File.Exists(assembly.Location + ".config");
        }

        public static bool AppKeyExists(string appKey)
        {
            return ConfigurationManager.AppSettings[appKey] != null;
        }

    }



}
