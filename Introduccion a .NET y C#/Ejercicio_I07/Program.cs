using System;

namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float sueldoBruto;
            float sueldoNeto;
            string rta;

            do
            {
                Console.WriteLine("Ingrese Nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de la hora: ");
                _ = int.TryParse(Console.ReadLine(), out int valorHora);

                Console.WriteLine("Ingrese antigueadad del empleado: ");
                _ = int.TryParse(Console.ReadLine(), out int antiguedad);

                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                _ = int.TryParse(Console.ReadLine(), out int cantidadHorasTrabajadas);

                sueldoBruto = (float)(valorHora * cantidadHorasTrabajadas) + (antiguedad * 150);

                sueldoNeto = sueldoBruto - (sueldoBruto * 13 / 100);

                Console.WriteLine();
                Console.WriteLine("NOMBRE   ANTIGUEDAD   VALOR HORA    SUELDO BRUTO    SUELDO NETO");
                Console.WriteLine($"{nombre}       {antiguedad}              {valorHora}           {sueldoBruto}          {sueldoNeto}");
                Console.WriteLine();
                Console.Write("Desea agregar otro empleado (s/n): ");
                rta = Console.ReadLine();
            } while (rta != "n");
        }
    }
}
