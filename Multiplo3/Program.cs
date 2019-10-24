using System;

namespace Multiplo3 {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine ("----MULTIPLO - DE - 3----");
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine ("Nos informe um número inteiro e diremos se ele é multiplo de 3 ou nao!");
            int num = 0;
            System.Console.WriteLine ("Número: ");
            num = int.Parse (Console.ReadLine ());
            if (num % 3 == 0) {
                System.Console.WriteLine ($"{num} é multiplo de 3!");
            } else {
                System.Console.WriteLine ($"{num} não é multiplo de 3!");
            }
        }
    }
}