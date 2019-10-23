using System;

namespace PerimetroAreaDiag {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine ("-----ÁREA - PERIMETRO - DIAGONAL-----");
            Console.ResetColor ();
            System.Console.WriteLine ("Nos passe os dados do seu retangulo que retornaremos \na sua área, perimetro e a Diagonal.");
            float h = 0;
            float b = 0;
            System.Console.WriteLine ("Altura do retangulo em metros: ");
            h = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Base do retangulo em metros: ");
            b = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ($"A área é igual à {h * b}m");
            System.Console.WriteLine ($"O Perimetro é igual à {h + h + b + b}m");
            System.Console.WriteLine ($"E a diagonal vale {Math.Sqrt((b * b) + (h * h))}m");

        }
    }
}