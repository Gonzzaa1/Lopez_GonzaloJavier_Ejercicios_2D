using System;

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año de inicio: ");
            _ = int.TryParse(Console.ReadLine(), out int añoInicio);

            Console.Write("Ingrese un año final: ");
            _ = int.TryParse(Console.ReadLine(), out int añoFinal);

            while (añoInicio > añoFinal)
            {
                Console.Write("Error..{0}año final menor al año inicial...{0}Reingrese un año final: ", Environment.NewLine);
                _ = int.TryParse(Console.ReadLine(), out añoFinal);
            }

            for (int i = añoInicio; i < añoFinal; i++)
            {
                if ((i % 4) == 0 || (i % 400) == 0)
                {
                    Console.WriteLine($"El año {i} es bisiesto");
                }
            }
        }
    }
}
