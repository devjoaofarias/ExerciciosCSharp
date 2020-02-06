using System;

namespace TriangInvertido {
    class Program {
        static void Main (string[] args) {
            int alt = 0;
            string ast = "*";

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine ("-------BemVindo(a) ao Triangulo Invertido--------");
            Console.ResetColor ();

            System.Console.WriteLine ("Digite a altura do triangulo: ");
            alt = int.Parse (Console.ReadLine ());

            while (alt != 0) {
                for (int i = alt; i != 0; i--) {
                    Console.Write (ast);
                }
                alt--;
                System.Console.WriteLine ("");
            }

        }
    }
}