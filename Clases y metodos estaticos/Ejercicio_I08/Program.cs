using System;

namespace Ejercicio_I08
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Ingrese fecha de nacimiento: ");
            string fechaNacimientoIngresada = Console.ReadLine();
            DateTime fechaIngresada = DateTime.Parse(fechaNacimientoIngresada);
            Console.WriteLine($"Los dias que pasaron desde tu fecha de nacimiento son: {CalcularDias(fechaIngresada)} dias");
        }

        public static int CalcularDias(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;
            int dias = fechaActual.Subtract(fecha).Days;
            return dias;
        }
    }
}
