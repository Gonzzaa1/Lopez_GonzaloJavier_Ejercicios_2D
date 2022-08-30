using System;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            int numeroMin = 0;
            int numeroMax = 0;
            int acumulador = 0;
            int promedio;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero: ");

                numeros[i] = int.Parse(Console.ReadLine());
                acumulador += numeros[i];

                if (i == 0)
                {
                    numeroMax = numeros[i];
                    numeroMin = numeros[i];
                }
                else if (numeroMax > numeros[i])
                {
                    numeroMax = numeros[i];
                }
                else if (i == 0 || numeroMin < numeros[i])
                {
                    numeroMin = numeros[i];
                }

            }
            promedio = acumulador / 5;
            Console.WriteLine($"El numero maximo es {numeroMax}, El numero minimo es {numeroMin} y el promedio es {promedio}");
        }
    }
}
