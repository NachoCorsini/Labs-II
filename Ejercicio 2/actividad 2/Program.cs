using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 2 DE STRING

            string nombre; string apellido; string password;

            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
            } while (nombre == "");

            apellido = ChequearApellido("Ingrese apellido");

            Console.WriteLine("Ingrese clave de acceso");
            password = Console.ReadLine();

            if (password != "demo") Console.WriteLine("ACCESO DENEGADO");
            else Console.WriteLine(String.Format("ACCESO CONCEDIDO A: {0} {1}", apellido, nombre));


            Console.ReadKey();
        }

        static string ChequearApellido(string ap)
        {
            string name2;
            do
            {
                Console.WriteLine(ap);
                name2 = Console.ReadLine();

            } while (name2 == "");

            return name2;
        }





    }



    
}
