using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese 3 notas:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;

        switch (promedio)
        {
            case double n when (n < 70):
                Console.WriteLine("Reprueba");
                break;
            case double n when (n <= 80):
                Console.WriteLine("Bueno");
                break;
            case double n when (n <= 90):
                Console.WriteLine("Muy Bueno");
                break;
            case double n when (n <= 100):
                Console.WriteLine("Sobresaliente");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}