using System;

namespace Ejercicio_I06
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }
        public static double CalcularAreaTriangulo(double bases, double altura)
        {
            return (bases * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}