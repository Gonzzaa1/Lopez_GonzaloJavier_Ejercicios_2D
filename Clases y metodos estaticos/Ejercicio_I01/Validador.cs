namespace Ejercicio_I01
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool check = false;

            if (valor >= min && valor <= max)
            {
                check = true;
            }
            return check;
        }

    }
}