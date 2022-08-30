using System;

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Area del cuadrado = {CalculadoraDeArea.CalcularAreaCuadrado(20)}");
            Console.WriteLine($"Area del tringulo = {CalculadoraDeArea.CalcularAreaTriangulo(20, 10)}");
            Console.WriteLine($"Area del circulo = {CalculadoraDeArea.CalcularAreaCirculo(20)}");
        }
    }
}
