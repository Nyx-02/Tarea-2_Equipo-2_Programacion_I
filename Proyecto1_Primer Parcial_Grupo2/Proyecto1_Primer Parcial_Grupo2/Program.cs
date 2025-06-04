using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Grados Centígrados a Fahrenheit:");
        Console.WriteLine("Celsius\tFahrenheit");
        for (int celsius = 0; celsius <= 100; celsius++)
        {
            Console.WriteLine($"{celsius}\t{CelsiusToFahrenheit(celsius)}");
        }

        Console.WriteLine("\nGrados Fahrenheit a Centígrados:");
        Console.WriteLine("Fahrenheit\tCelsius");
        for (int fahrenheit = 32; fahrenheit <= 212; fahrenheit++)
        {
            Console.WriteLine($"{fahrenheit}\t{FahrenheitToCelsius(fahrenheit)}");
        }
    }

    static double CelsiusToFahrenheit(int celsius)
    {
        return (celsius * 9.0 / 5.0) + 32;
    }

    static double FahrenheitToCelsius(int fahrenheit)
    {
        return (fahrenheit - 32) * 5.0 / 9.0;
    }
}