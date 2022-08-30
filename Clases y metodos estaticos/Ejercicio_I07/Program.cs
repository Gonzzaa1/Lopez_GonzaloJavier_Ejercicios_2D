using System;

namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float hipotenusa;

            Console.Write("Ingrese base del Tringulo en cm: ");
            _ = float.TryParse(Console.ReadLine(), out float baseTriangulo);

            Console.Write("Ingrese altura del Tringulo en cm: ");
            _ = float.TryParse(Console.ReadLine(), out float alturaTriangulo);


            hipotenusa = (float)Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));

            Console.WriteLine($"La hipotenusa es = {hipotenusa}");
        }
    }
}
