using System;

namespace CalculoAumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Aumento de Salario");
            Console.WriteLine("--------------------------------");
            Console.Write("Ingrese su salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            double aumento = CalcularAumento(salario);
            double nuevoSalario = salario + aumento;
            Console.WriteLine($"Aumento: ${aumento:F2}");
            Console.WriteLine($"Nuevo salario: ${nuevoSalario:F2}");
        }

        static double CalcularAumento(double salario)
        {
            double aumento;

            if (salario < 5000)
            {
                aumento = salario * 0.20;
            }
            else if (salario >= 5000 && salario < 10000)
            {
                aumento = salario * 0.10;
            }
            else if (salario >= 10000 && salario < 15000)
            {
                aumento = salario * 0.05;
            }
            else
            {
                aumento = salario * 0.03;
            }

            return aumento;
        }
    }
}