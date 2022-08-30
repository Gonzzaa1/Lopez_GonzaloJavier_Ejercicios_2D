using System;

namespace Ejercicio_I03
{
    public class Conversor
    {

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int auxiliar;
            string binario = string.Empty;

            while (numeroEntero > 0)
            {
                auxiliar = numeroEntero % 2;
                numeroEntero /= 2;
                binario = auxiliar.ToString() + binario;
            }

            return binario;
        }
        public static int ConvertirBinarioADecimal(string numeroEntero)
        {
            int sum = 0;
            char[] binario = numeroEntero.ToCharArray();
            Array.Reverse(binario);

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    sum += (int)Math.Pow(2, i);
                }
            }

            return sum;
        }
    }
}