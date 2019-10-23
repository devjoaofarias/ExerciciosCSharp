using System;

namespace TrocaValores {
    class Program {
        static void Main (string[] args) {
            float num1 = 0;
            float num2 = 0;
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("----TROCA DE VALORES----");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine ("Me passe dois números");
            System.Console.WriteLine ("Número A: ");
            num1 = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Número B: ");
            num2 = float.Parse (Console.ReadLine ());

            System.Console.WriteLine ($"Agora os valores se inverteram!\nValor A = {num2}\nValor B = {num1}");

        }
    }
}