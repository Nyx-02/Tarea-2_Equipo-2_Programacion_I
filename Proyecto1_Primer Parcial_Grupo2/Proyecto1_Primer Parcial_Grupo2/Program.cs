using System;

namespace VentaDeCamisas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentarle al cliente el precio de la camisas
            Console.WriteLine("Bienvenido a la tienda de camisas.");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("El precio de cada camisa es L.100.00");
            Console.WriteLine("Se aplican descuentos según la cantidad comprada:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("- 10% de descuento si compra más de 10 camisas.");
            Console.WriteLine("- 20% de descuento si compra más de 20 camisas.");
            Console.WriteLine("- 40% de descuento si compra más de 30 camisas.");
            Console.WriteLine("-----------------------------------------------------------");

            // Precio fijo por camisa
            const double precioCamisa = 100.0;

            // Solicitar al usuario la cantidad de camisas
            Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Calcular el total sin descuento
            double totalSinDescuento = cantidad * precioCamisa;
            double descuento = 0.0;

            // Aplicar descuento según cantidad
            if (cantidad > 30)
            {
                descuento = 0.40;
            }
            else if (cantidad > 20)
            {
                descuento = 0.20;
            }
            else if (cantidad > 10)
            {
                descuento = 0.10;
            }

            // Calcular monto de descuento y total con descuento
            double montoDescuento = totalSinDescuento * descuento;
            double totalConDescuento = totalSinDescuento - montoDescuento;

            // Mostrar resultados
            Console.WriteLine("\nResumen de la compra:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Cantidad de camisas: {cantidad}");
            Console.WriteLine($"Precio unitario: L.{precioCamisa}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Total sin descuento: L.{totalSinDescuento}");
            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Monto del descuento: L.{montoDescuento}");
            Console.WriteLine($"Total a pagar: L.{totalConDescuento}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Gracias por su compra. ¡Vuelva pronto!");

            // Esperar que el usuario presione una tecla para salir
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
