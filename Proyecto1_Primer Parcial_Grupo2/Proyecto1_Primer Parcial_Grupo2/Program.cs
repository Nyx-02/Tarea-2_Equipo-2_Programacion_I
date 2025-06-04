using System;

namespace Estacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_CLIENTES = 3;
            double totalRecibos = 0;

            Console.WriteLine("Cálculo de cargos por estacionamiento");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Horas de estacionamiento para cada cliente:");

            for (int i = 1; i <= NUM_CLIENTES; i++)
            {
                Console.Write($"Cliente {i}: Ingrese las horas de estacionamiento: ");
                double horas = Convert.ToDouble(Console.ReadLine());
                double cargo = CalcularCargos(horas);
                totalRecibos += cargo;

                Console.WriteLine($"Cargo para el Cliente {i}: ${cargo:F2}");
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Total de los recibos de ayer: ${totalRecibos:F2}");
            Console.WriteLine("Gracias por utilizar nuestro servicio.");
        }

        static double CalcularCargos(double horas)
        {
            const double CUOTA_MINIMA = 2.00;
            const double CARGO_ADICIONAL = 0.50;
            const double CARGO_MAXIMO = 10.00;

            if (horas <= 3)
            {
                return CUOTA_MINIMA;
            }
            else
            {
                double horasAdicionales = Math.Ceiling(horas - 3);
                double cargo = CUOTA_MINIMA + (horasAdicionales * CARGO_ADICIONAL);
                return Math.Min(cargo, CARGO_MAXIMO);
            }
        }
    }
}