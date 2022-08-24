using System;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisor = 1;
            int acumulador = 0;

            for (int i = 1; i < 10000; i++)
            {
                while(divisor < i)
                {
                    if ((i % divisor) == 0)
                    {
                        acumulador += divisor;
                    }
                    divisor++;  
                }

                if (acumulador == i)
                {
                    Console.WriteLine($"El numero {i} es un numero perfecto");
                }

                acumulador = 0;
                divisor = 1;
            }
        }
    }
}
