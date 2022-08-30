using System;

namespace Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"{Factorial(5)}");
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
            string retorno = $"El factorial de {numero} son el {factores}y el resultado es {resultado}";

            return retorno;
        }
    }
}
