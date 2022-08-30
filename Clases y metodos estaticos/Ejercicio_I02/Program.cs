using System;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumador;

            do
            {
                Console.Write("Ingrese un numero: ");
                _ = int.TryParse(Console.ReadLine(), out sumador);

                sumador += sumador;

            } while (Validador.ValidarRespuestas() == true);

            Console.WriteLine($"La suma de todos los numeros es: {sumador}");
        }
    }
}
