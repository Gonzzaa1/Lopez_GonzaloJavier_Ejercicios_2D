using System;
using System.Text;

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *****   TABLA DE MULTIPLICAR ***** {0} ", Environment.NewLine);
            Console.Write("Ingrese un numero: ");
            _=int.TryParse(Console.ReadLine(), out int numeroIngresado);
            Console.WriteLine();
            Console.WriteLine(CalcularTabla(numeroIngresado));
            Console.ReadKey();

        }
        public static string CalcularTabla(int numero)
        {            
            StringBuilder myStringBuilder = new StringBuilder();

            for (int i = 1; i < 11; i++)
            {
                myStringBuilder.Append($"{numero} X {i} = ");
                myStringBuilder.Append(numero * i + Environment.NewLine);
            }

            return myStringBuilder.ToString(); ;
        }
    }
}
