using System;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operador;
            string rta;

            Console.WriteLine("   ****   CALCULADORA   ****");
            Console.WriteLine();

            do
            {
                Console.Write("ingrese el primer numero: ");
                _ = int.TryParse(Console.ReadLine(), out int num1);
                Console.Write("ingrese el segundo numero: ");
                _ = int.TryParse(Console.ReadLine(), out int num2);
                Console.Write("ingrese la operacion matematica: ");
                operador = Console.ReadLine();

                Console.WriteLine($"El resultado es: {Calculadora.Calcular(num1, num2, operador)}");

                Console.Write("Desea realizar otra operacion? (s/n): ");
                rta = Console.ReadLine();

            } while (rta == "s");
        }
    }
}
