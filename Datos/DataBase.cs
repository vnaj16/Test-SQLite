using System;
using System.Collections.Generic;
using System.Configuration;//Importo esto para tener comunicacion entre esta DLL y el archivo de configuracion del .exe
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Datos
{
    public class DataBase
    {
        public static IDbConnection GetConnection()//Se usa de manera generica IDbConnection
        {
            try
            {
                IDbConnection Conexion = new SQLiteConnection(GetConnectionString());

                Conexion.Open();

                return Conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /*public static SQLiteConnection GetConnection()
        {
            try
            {
                SQLiteConnection Conexion = new SQLiteConnection(GetConnectionString());

                Conexion.Open();

                return Conexion;
            }
            catch(Exception ex)
            {
                return null;
            }
        }*/

        private static string GetConnectionString(string ID = "Default")
        {
            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;//Retorno la cadena de conexion que hay en el App.config
        }
    }
}
