using System;

namespace ControlCreditoClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Control de Crédito de Clientes ===");

            while (true)
            {
                // Solicitar número de cuenta
                Console.Write("\nIngrese el número de cuenta (o 0 para salir): ");
                int numeroCuenta = int.Parse(Console.ReadLine());

                // Condición de salida
                if (numeroCuenta == 0)
                {
                    Console.WriteLine("\nFin del programa. Gracias.");
                    break;
                }

                // Solicitar datos del cliente
                Console.Write("Ingrese el saldo al inicio del mes: ");
                double saldoInicial = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el total de los cargos del mes: ");
                double cargos = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el total de los créditos aplicados: ");
                double creditos = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el límite de crédito permitido: ");
                double limiteCredito = double.Parse(Console.ReadLine());

                // Calcular nuevo saldo
                double nuevoSaldo = saldoInicial + cargos - creditos;

                // Mostrar resultados
                Console.WriteLine($"\n--- Estado de Cuenta ---");
                Console.WriteLine($"Número de cuenta: {numeroCuenta}");
                Console.WriteLine($"Nuevo saldo: L.{nuevoSaldo}");
                Console.WriteLine($"Límite de crédito: L.{limiteCredito}");

                // Verificar si excede el crédito
                if (nuevoSaldo > limiteCredito)
                {
                    Console.WriteLine("** Se excedió el límite de su crédito **");
                }
                else
                {
                    Console.WriteLine("Dentro del límite de crédito.");
                }
            }

            Console.ReadKey();
        }
    }
}
