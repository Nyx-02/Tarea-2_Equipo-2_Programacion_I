using System;

namespace FacturacionPanaderia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FACTURACIÓN PANADERÍA ===");

            // Solicitar monto total de compra
            Console.Write("Ingrese el total de la compra (L.): ");
            double totalCompra = double.Parse(Console.ReadLine());
            Console.WriteLine(""); 
            // Línea en blanco para mejor orden

            // Mencionar que tipo de membresía se aplica un descuento
            Console.WriteLine("Tipos de membresía disponibles:");
            Console.WriteLine("A: 10% de descuento");   
            Console.WriteLine("B: 15% de descuento");   
            Console.WriteLine("C: 20% de descuento");   
            Console.WriteLine("Si no tiene membresía, no se aplicará descuento.");  
            Console.WriteLine("");  

            // Solicitar tipo de membresía
            Console.Write("Ingrese el tipo de membresía (A, B o C): ");
            string tipoMembresia = Console.ReadLine().ToUpper(); // Convertimos a mayúscula

            double descuento = 0.0;

            // Determinar descuento según el tipo de membresía
            switch (tipoMembresia)
            {
                case "A":
                    descuento = 0.10;
                    break;
                case "B":
                    descuento = 0.15;
                    break;
                case "C":
                    descuento = 0.20;
                    break;
                default:
                    Console.WriteLine("Tipo de membresía no válido. No se aplicará descuento.");
                    break;
            }

            // Calcular monto descontado y total final
            double montoDescuento = totalCompra * descuento;
            double totalFinal = totalCompra - montoDescuento;

            // Mostrar factura
            Console.WriteLine("\n--- FACTURA ---");
            Console.WriteLine($"Total antes del descuento: L.{totalCompra}");
            Console.WriteLine($"Descuento aplicado: L.{montoDescuento} ({descuento * 100}%)");
            Console.WriteLine($"Total a pagar: L.{totalFinal}");

            Console.WriteLine("\nGracias por su compra. ¡Vuelva pronto!");
            Console.ReadKey();
        }
    }
}
