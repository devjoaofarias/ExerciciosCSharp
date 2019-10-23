using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {   Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("-----------PAR - IMPAR----------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Nos escreva um número e diremos se ele é Par ou Impar");
            int num = 0;
            System.Console.WriteLine("Numero: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                System.Console.WriteLine($"{num} é par!");
            } else {
                System.Console.WriteLine($"{num} é impar!");
            }
            
        }
    }
}
