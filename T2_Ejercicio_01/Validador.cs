using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Ejercicio_01
{

    public class Validador
    {
        
        public bool Validar(int valor, int min, int max)
        {
            bool check = false;

            if(valor >= min && valor <= max)
            {
                check = true;
            }

            return check;
        }

    }
    
}
