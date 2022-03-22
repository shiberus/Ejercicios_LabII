using System;

namespace EjercicioI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroActual, minimo = 0, maximo = 0;
            float promedio = 0;
            bool exito;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese {5 - i} numeros (de a uno)");
                exito = int.TryParse(Console.ReadLine(), out numeroActual);

                while(!exito)
                {
                    Console.WriteLine("Error, ingrese un numero valido");
                    exito = int.TryParse(Console.ReadLine(), out numeroActual);
                }

                promedio += (float) numeroActual / 5;

                if (i == 0 || numeroActual > maximo)
                {
                    maximo = numeroActual;
                }

                if (i == 0 || numeroActual < minimo)
                {
                    minimo = numeroActual;
                }
            }

            Console.WriteLine("El minimo fue {0}, el maximo {1} y el promedio {2}", minimo, maximo, promedio);
        }
    }
}
