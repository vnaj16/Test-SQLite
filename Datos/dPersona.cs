using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dPersona
    {

        /////////////ADO.NET
        /*public static string Insertar(string x)
        {
            using (SQLiteConnection Conexion = DataBase.GetConnection())
            {
                try
                {
                    string insert = string.Format("INSERT INTO Persona(Nombre) VALUES('{0}')", x);

                    SQLiteCommand Command = new SQLiteCommand(insert, Conexion);
                    Command.ExecuteNonQuery();
                    return "Persona Registrada";
                }
                catch (Exception e) { return e.Message; }
            }
        }*/


        /*public static List<string> GetNames()
        {
            List<string> Lista = new List<string>();

            using (IDbConnection Conexion = DataBase.GetConnection())
            {
                try
                {
                    SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Persona", Conexion);
                    SQLiteDataReader Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        Lista.Add((string)Reader[1]);
                    }

                    Reader.Close();
                    return Lista;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }*/



        /////////DAPPER
        public static string Insertar(ePersona obj)
        {
            using (IDbConnection Conexion = DataBase.GetConnection())
            {
                try
                {
                    Conexion.Execute("INSERT INTO Persona(Nombre) VALUES(@Nombre)", obj);//El arroba permite usar esa descripcion para relacionarla con la propiedad respectiva del objeto pasado

                    return "Persona Registrada";
                }
                catch (Exception e) { return e.Message; }
            }
        }


        public static List<ePersona> GetNames()
        {
            using (IDbConnection Conexion = DataBase.GetConnection())
            {
                try
                {
                    var Lista = Conexion.Query<ePersona>("SELECT * FROM Persona");
                    return Lista.ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }


}
