using System;

namespace _0a10Impar {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine ("---NUMEROS - IMPARES---");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 1; i < 10; i = i + 2) {
                System.Console.WriteLine (i);
            };
        }
    }
}