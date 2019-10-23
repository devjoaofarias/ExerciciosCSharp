using System;

namespace CelsiusFahrenheit {
    class Program {
        static void Main (string[] args) {
            float Temp = 0;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine ("---------CELSIUS - FAHRENHEIT--------");
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine ("Nos passe uma temperatura em Celsius que iremos converter para Fahrenheit");
            System.Console.WriteLine ("Temperatura: ");
            Temp = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ($"{Temp} graus celsiues equivale à {(Temp * 1.8) + 32} graus Fahrenheit!");

        }
    }
}