using System;

namespace VocalChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un carácter:");
            char caracter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            char caracterLower = char.ToLower(caracter);

            if (caracterLower == 'a' || caracterLower == 'e' || caracterLower == 'i' ||
                caracterLower == 'o' || caracterLower == 'u')
            {
                Console.WriteLine("El carácter ingresado es una vocal.");
            }
            else
            {
                Console.WriteLine("El carácter ingresado no es una vocal.");
            }

            Console.WriteLine("-----------------------------------------------------"); 
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}