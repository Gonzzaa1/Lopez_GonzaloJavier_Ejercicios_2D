using System;

namespace Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"{Factorial(10)}");
            Console.WriteLine();
        }
        public static string Factorial(int numero)
        {
            int resultado = 1;
            string factores = "";

            for (int i = numero; i > 0; i--)
            {
                resultado *= i;
                factores += $"{i} ";
            }
            string retorno = $"El factorial de {numero} es: {resultado} y se saca del multiplo de {factores}";

            return retorno;
        }
    }
}
