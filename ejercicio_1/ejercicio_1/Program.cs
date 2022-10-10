using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caract1 = ' ', caract2;
            char resp = ' ';
            bool salida = false;

            while (!resp.Equals('N'))
            {
                Console.WriteLine("Ingrese un caracter");
                caract2 = char.Parse(Console.ReadLine());

                if (!caract1.Equals(' '))
                {
                    Console.WriteLine($"El caracter anterior es '{caract1}' ");

                    if (caract2.CompareTo(caract1) > 0) Console.WriteLine("El caracter es MAYOR");
                    if (caract2.CompareTo(caract1) < 0) Console.WriteLine("El caracter es MENOR");

                    if (caract1.Equals(caract2)) Console.WriteLine("Ambos caracteres son IGUALES");
                    else Console.WriteLine("Ambos caracteres son DIFERENTES");

                    Console.WriteLine("¿Desea continuar comparando? presione 'S' para contuniar ó 'N' para abandonar");
                    while (!salida)
                    {
                        salida = char.TryParse(Console.ReadLine().ToUpper(), out resp); 
                    }
                }
                salida = false;
                caract1 = caract2;

            }







            Console.ReadKey();

        }





    }
}
