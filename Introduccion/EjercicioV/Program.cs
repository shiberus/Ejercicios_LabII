using System;
using Util;

namespace EjercicioV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exito;
            int numero = 0;

            Console.WriteLine("Ingrese un numero");
            exito = int.TryParse(Console.ReadLine(), out numero);

            while (!exito || numero <= 0)
            {
                Console.WriteLine("Error. ¡Reingresar numero!");
                exito = int.TryParse(Console.ReadLine(), out numero);
            }

            Console.WriteLine("Los centros numericos entre 1 y {0} son :", numero);
            for (int i = 1; i < numero; i++)
            {
                if(Mate.esCentroNumerico(i))
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
