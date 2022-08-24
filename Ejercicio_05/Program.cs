using System;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            while (int.TryParse(Console.ReadLine(), out numero))
            {
                for(int i = 1; i < numero; i++)
                {
                    int numAntes = 0;

                    for (int j = 0; j < i; j++)
                    {
                        numAntes += j;
                    }

                    int numDespues = 0;

                    for (int k = i+1; k < numAntes; k++)
                    {
                        if(numAntes == numDespues || numDespues > numAntes)
                        {
                            break;
                        }
                        numDespues += k;
                    }
                    if(numAntes == numDespues)
                    {
                        Console.WriteLine($"Es un centro numero: {i}");
                    }
                }
            }
            Console.WriteLine("No es numero");
        }
    }
}
