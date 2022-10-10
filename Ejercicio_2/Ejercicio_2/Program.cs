using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = ' ';
            char salida = ' ';
            bool respuesta = false;

            do
            {
                do
                {
                    Console.WriteLine("\nIngrese un caracter");
                    respuesta = char.TryParse(Console.ReadLine(), out char1);

                } while (respuesta == false);
                
                Console.WriteLine($"Categoría del caracter: {char.GetUnicodeCategory(char1)}");


                Console.WriteLine("\n¿Desea seguir evaluando caracteres? Oprima 's' para continuar ó 'n' para salir");
                respuesta = char.TryParse(Console.ReadLine(), out salida);
                Console.ReadKey();

            } while (salida == 's' || salida == 'S');




           
        }




    }
}
