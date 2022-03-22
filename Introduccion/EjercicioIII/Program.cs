using System;
using Util;

namespace EjercicioIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exito, continuar = true;
            int numero = 0;
            string input;


            while (continuar)
            {
                Console.WriteLine("Ingrese un numero");
                input = Console.ReadLine();
                exito = int.TryParse(input, out numero);

                while (!exito && input != "salir")
                {
                    Console.WriteLine("Error. ¡Reingresar numero!");
                    input = Console.ReadLine();
                    exito = int.TryParse(input, out numero);
                }

                if(exito)
                {
                    for (int i = 2; i < numero; i++)
                    {
                        if(Mate.esPrimo(i))
                        {
                            Console.Write($"{i}, ");
                        }
                    }
                    Console.WriteLine(".\nDesea continuar?");
                    input = Console.ReadLine();
                }

                if (input != "si")
                {
                    continuar = false;
                }

            }
        }

    }
}
