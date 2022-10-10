using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string parrafo = "";


            do
            {
                opcion = SelecionarMenu();

                if (opcion == 1)
                {
                    parrafo = IngresarTexto();

                }

                if (opcion == 2)
                {
                    if (parrafo == " ")
                    {
                        Console.WriteLine("No ha ingresado ningun texto");
                        Console.ReadLine();
                    }
                    else
                    {
                        string[] palabras = parrafo.Split(' ');
                        Console.WriteLine($"CANTIDAD DE PALABRAS: {palabras.Length}");

                    }

                }

                if (opcion == 3)
                {
                    int cantLetras = 0; int cantNum = 0;
                    for (int i = 0; i < parrafo.Length; i++)
                    {
                        if (char.IsLetter(parrafo[i])) cantLetras++;
                        if (char.IsNumber(parrafo[i])) cantNum++;
                    }
                    Console.WriteLine($"CANTIDAD DE LETRAS: {cantLetras}");
                    Console.WriteLine($"CANTIDAD DE NUMEROS: {cantNum}");
                    Console.WriteLine($"OTROS CARACTERES: {parrafo.Length - cantLetras - cantNum}");
                }
                if (opcion == 4)
                {
                    ordenamiento(parrafo);
                }




            } while (opcion != 0);
            
            
                

            Console.ReadKey();


        }

        static string IngresarTexto() 
        {
            string texto = " ";
            do
            {
                Console.WriteLine("Ingrese texto");
                texto = Console.ReadLine();
                if (texto.Trim().Length < 25)
                {
                    Console.WriteLine("- ERROR - su párrafo tiene menos de 25 letras");
                }

            } while (texto.Trim().Length < 25);
        
        
            return texto;
        }

        static int SelecionarMenu() 
        {
            bool salida = false;
            int opcion;

            do
            {
                Console.WriteLine("\nSELECCIONE UNA OPCIÓN DEL MENÚ");
                Console.WriteLine("1- INGRESAR TEXTO");
                Console.WriteLine("2- MOSTRAR INFO DEL TEXTO");
                Console.WriteLine("3- MOSTRAR INFO DE CARACTERES");
                Console.WriteLine("4- MOSTRAR PALABRAS ORDENADAS");    
                Console.WriteLine("0- SALIR");
                
                salida = int.TryParse(Console.ReadLine(), out opcion);

            } while (!salida || opcion < 0 || opcion > 4 );

            return opcion;
            
        }
        static void ordenamiento(string texto)
        {
            string[] palabras;
            char[] delimitar = { ' ',',','.' };
            palabras = texto.Split(delimitar);
            Array.Sort(palabras);
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] != "")
                {
                    Console.WriteLine($"{palabras[i]} [{palabras[i].Length}]");
                }
            }
        
        
        }




    }



}
