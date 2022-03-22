using System;

namespace EjercicioII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exito;
            int numero = 0;

            Console.WriteLine("Ingrese un numero");
            exito = int.TryParse(Console.ReadLine(), out numero);

            while(!exito || numero <= 0)
            {
                Console.WriteLine("Error. ¡Reingresar numero!");
                exito = int.TryParse(Console.ReadLine(), out numero);
            }

            Console.WriteLine($"el numero {numero} al cuadrado es {numero * numero} y al cubo es {numero * numero * numero}");
        }
    }
}
