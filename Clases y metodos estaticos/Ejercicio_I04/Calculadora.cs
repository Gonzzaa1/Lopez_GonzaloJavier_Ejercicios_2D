using System;

namespace Ejercicio_I04
{
    public class Calculadora
    {
        public static int Calcular(int numero1, int numero2, string operador)
        {
            int resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (Validar(numero2))
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine($"No se puede dividir por {numero2}");
                    }
                    break;

            }
            return resultado;
        }
        private static bool Validar(int numero2)
        {
            bool valido;

            _ = numero2 > 0 ? valido = true : valido = false;

            return valido;
        }
    }
}