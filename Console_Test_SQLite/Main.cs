using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Console_Test_SQLite
{
    class main
    {
        
        public static void Main(string[] Args)
        {
            //Console.WriteLine(DataBase.GetConnection().ConnectionString);
            string Nombre_;

            /*do
            {
                Console.WriteLine("Ingrese el nombre: ");
                Nombre_ = Console.ReadLine();
                string State = dPersona.Insertar(new ePersona() { Nombre = Nombre_ }) ;
                Console.WriteLine(State);
                Console.WriteLine("Desea continuar?: ");
                Nombre_ = Console.ReadLine();
            } while (Nombre_ != "n");

            Console.Clear();*/

            foreach(var x in dPersona.GetNames())
            {
                Console.WriteLine(x.ToString());
            }

            Console.ReadKey();
        }

    }
}
