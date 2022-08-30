using System;

namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese altura del triangulo: ");
            _ = int.TryParse(Console.ReadLine(), out int altura);

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < altura; j++) ;
                {
                    Console.WriteLine();
                    for (int l = 0; l <= i * 2; l++)
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}
