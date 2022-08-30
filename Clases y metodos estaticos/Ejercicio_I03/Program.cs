using System;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binario;
            int numeroDecimal;

            Console.Write("Ingrese el numero: ");
            _ = int.TryParse(Console.ReadLine(), out int numero);

            binario = Conversor.ConvertirDecimalABinario(numero);

            Console.WriteLine($"numero convertido en binario = {binario}");

            numeroDecimal = Conversor.ConvertirBinarioADecimal(binario);

            Console.WriteLine($"numero convertido en decimal = {numeroDecimal}");

        }
    }
}
