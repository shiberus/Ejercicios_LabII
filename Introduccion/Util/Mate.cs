using System;

namespace Util
{
    public static class Mate
    {
        public static bool esPrimo(int num)
        {
            bool result = true;
            int limite, i = 2;
            limite = (int)Math.Sqrt(num);

            while (i <= limite)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
                i++;
            }

            return result;
        }

        public static bool esPerfecto(int num)
        {
            bool result = false;
            int sumaDeDivisores = 0;

            for (int i = 1; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    sumaDeDivisores += i;
                }
            }
            result = sumaDeDivisores == num;

            return result;
        }

        public static bool esCentroNumerico(int num)
        {
            bool result = false;
            int sumaDeAnteriores, sumaDeSiguientes = 0;
            sumaDeAnteriores = sumarAnteriores(num);

            while(sumaDeSiguientes < sumaDeAnteriores)
            {
                num++;
                sumaDeSiguientes += num;
            }
            result = sumaDeSiguientes == sumaDeAnteriores;

            return result;
        }

        private static int sumarAnteriores(int num)
        {
            int result = 0;

            for (int i = 0; i < num; i++)
            {
                result += i;
            }

            return result;
        }

        public static bool esBisiesto(int year)
        {
            bool result = false;
            
            if(year % 4 == 0)
            {
                result = true;
            }

            if (year % 100 == 0 && year % 400 != 0)
            {
                result = false;
            }

            return result;
        }
    }
}
