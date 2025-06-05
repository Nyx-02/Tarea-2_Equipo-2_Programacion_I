using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Ejercicio6
{
    static void Main()
    {
        double totalVentas = 0.0;
        int numeroProducto;
        int cantidadVendida;

        Console.WriteLine("Ingrese el número del producto (1-5) o 0 para terminar:");

        while (true)
        {
            Console.Write("Número del producto: ");
            numeroProducto = int.Parse(Console.ReadLine());

            // Centinela para terminar el ciclo
            if (numeroProducto == 0)
            {
                break;
            }

            Console.Write("Cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            double precioProducto;

            // Determinar el precio del producto usando switch
            switch (numeroProducto)
            {
                case 1:
                    precioProducto = 2.98;
                    break;
                case 2:
                    precioProducto = 4.50;
                    break;
                case 3:
                    precioProducto = 9.98;
                    break;
                case 4:
                    precioProducto = 4.49;
                    break;
                case 5:
                    precioProducto = 6.87;
                    break;
                default:
                    Console.WriteLine("Número de producto inválido. Intente de nuevo.");
                    continue; // Volver al inicio del bucle
            }

            // Calcular el total de ventas
            totalVentas += precioProducto * cantidadVendida;
        }

        // Mostrar el total de ventas
        Console.WriteLine($"El valor total de venta de todos los productos vendidos es: {totalVentas:C}");
    }
}
