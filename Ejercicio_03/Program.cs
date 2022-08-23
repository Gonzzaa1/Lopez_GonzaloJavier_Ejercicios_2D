using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rta;
            int numero;
            bool num;
            int divisor;
            bool esPrimo;

            do
            {
                Console.Write("Ingresar un numero : ");
                num = int.TryParse(Console.ReadLine(), out numero);

                while(num != true)
                {
                    Console.Write("Dato invalido..Reingresar un numero : ");
                    num = int.TryParse(Console.ReadLine(), out numero);
                }

                Console.Write($"Los numeros primos hasta el numero {numero} son :");

                for (int i = 2; i < numero; i++)
                {
                    divisor = 2;
                    esPrimo = true;

                    while(esPrimo && divisor < i)
                    {
                        if( i % divisor == 0 )
                        {
                            esPrimo = false;
                        }
                        else
                        {
                            divisor++;
                        }
                    }
                    if(esPrimo)
                    {
                        Console.Write($" {i} ");
                    }
                }

                Console.Write("{0}Desea ingresar otro numero? 'si/salir' : ",Environment.NewLine);
                rta = Console.ReadLine();

            } while (rta != "salir");
        }
    }
}
