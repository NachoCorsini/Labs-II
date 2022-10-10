using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1, respuesta;
            bool respCorrecta;

            do
            {

                do
                {
                    Console.WriteLine("Ingrese un caracter");
                    respCorrecta = char.TryParse(Console.ReadLine(), out char1);

                } while (respCorrecta == false);

                if (char.IsNumber(char1)) Console.WriteLine($"El doble del numero ingresado es: {char.GetNumericValue(char1) * 2} ");
                if (char.IsLetter(char1)) Console.WriteLine($"El caracter ingresado es una letra: {char1}");
                if (!char.IsLetter(char1) && !char.IsNumber(char1)) Console.WriteLine($"El caracter ingresado pertenece a: {char.GetUnicodeCategory(char1)}");


                Console.WriteLine("\nSi desea CONTINUAR presione 'S' o 's'");
                respCorrecta = char.TryParse(Console.ReadLine(), out respuesta);

            } while (respuesta.Equals('S') || respuesta.Equals('s'));

            Console.ReadKey();
        }






    }
}
