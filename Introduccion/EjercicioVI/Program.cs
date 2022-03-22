using System;
using Util;

namespace EjercicioVI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exito;
            int inicio = 0, fin = 0;

            Console.WriteLine("Ingrese un anio de inicio");
            exito = int.TryParse(Console.ReadLine(), out inicio);

            while (!exito || inicio <= 0)
            {
                Console.WriteLine("Error. ¡Reingresar anio!");
                exito = int.TryParse(Console.ReadLine(), out inicio);
            }

            Console.WriteLine("Ingrese un anio de fin");
            exito = int.TryParse(Console.ReadLine(), out fin);

            while (!exito || fin <= inicio)
            {
                Console.WriteLine("Error. ¡Reingresar anio!");
                exito = int.TryParse(Console.ReadLine(), out fin);
            }

            for (int i = inicio; i < fin; i++)
            {
                if(Mate.esBisiesto(i))
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
