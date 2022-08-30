using System;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            double cuadrado;
            double cubo;

            do
            {
                Console.Write("ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado <= 0)
                {
                    Console.WriteLine("ERROR.¡Reingresar número!");
                }

            } while (numeroIngresado <= 0);

            cuadrado = Math.Pow(numeroIngresado, 2);
            cubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine($"El numero ingresado es {numeroIngresado}, su cuadrado es {cuadrado} y su cubo es {cubo}");
        }
    }
}
