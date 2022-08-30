using System;

namespace Ejercicio_I02
{
    public class Validador
    {
        public static bool ValidarRespuestas()
        {
            bool check = false;
            string rta;

            Console.Write("¿Desea continuar? (s/n) : ");
            rta = Console.ReadLine();

            if (rta == "s")
            {
                check = true;
            }
            return check;
        }

    }
}