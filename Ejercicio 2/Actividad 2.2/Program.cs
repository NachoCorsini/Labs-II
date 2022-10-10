using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //EJERCICIO 3 DE STRING
            
            string nombre; string apellido;
            int dni; string mensaje;
            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
            } while (nombre == "");

            do
            {
                Console.WriteLine("Ingrese su apellido");
                apellido = Console.ReadLine();
            } while (apellido == "");

            do
            {
                Console.WriteLine("Ingrese su DNI");
            } while (!int.TryParse(Console.ReadLine(), out dni) ) ;

            mensaje = String.Concat("NOMBRE: ", nombre, " \nAPELLIDO: ", apellido, " \nD.N.I: ", dni);
            Console.WriteLine(mensaje);

            Console.ReadKey();
        }






    }



}
