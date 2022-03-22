using System;
using Util;

namespace EjercicioIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, i = 2;

            while (contador < 4)
            {
                if(Mate.esPerfecto(i))
                {
                    Console.WriteLine(i);
                    contador++;
                }
                i++;
            }
        }
    }
}
