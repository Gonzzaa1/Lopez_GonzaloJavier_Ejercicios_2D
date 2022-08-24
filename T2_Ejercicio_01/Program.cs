using System;

namespace T2_Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 1;
            int numero;
            int numeroMin = 0;
            int numeroMax = 0;
            float promedio;
            int acumulador = 0;


            Validador checker = new Validador(); 

            Console.WriteLine("Ingresen 10 numero enteros");

            while(contador < 11)
            {
                Console.Write($"{contador} Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());

                while(checker.Validar(numero, -100, 100) == false)
                {
                    Console.WriteLine("ERROR... Numero no valido, rango -100 a 100");
                    Console.Write($"{contador} Ingrese numero: ");
                    numero = int.Parse(Console.ReadLine());
                }

                if (contador == 1)
                {
                    numeroMax = numero;
                    numeroMin = numero;
                }
                else if (numeroMax < numero)
                {
                    numeroMax = numero;
                }
                else if (numeroMin > numero)
                {
                    numeroMin = numero;
                }
                acumulador += numero;
                contador++; 
            }
            promedio = (float) acumulador / 10;
            Console.WriteLine($"El valor minimo ingresado fue {numeroMin}, el valor maximo ingresado fue {numeroMax} y el promedio es de {promedio}");
        }
    }
}
