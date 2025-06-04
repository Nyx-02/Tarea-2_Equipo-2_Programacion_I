using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAdivinar = random.Next(1, 1001);
        int intento = 0;

        Console.WriteLine("Adivina el número entre 1 y 1000:");

        while (true)
        {
            intento = Convert.ToInt32(Console.ReadLine());

            if (intento < numeroAdivinar)
            {
                Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
            }
            else if (intento > numeroAdivinar)
            {
                Console.WriteLine("Demasiado alto. Intenta de nuevo.");
            }
            else
            {
                Console.WriteLine("¡Excelente! ¡Adivinaste el número!");
                break;
            }
        }
    }
}