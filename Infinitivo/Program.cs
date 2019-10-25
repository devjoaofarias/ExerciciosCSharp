using System;

namespace Infinitivo {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("-----CONJUGAÇÕES-----");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine ("Nos passe um verbo para dizermos em qual conjugaçao do infinitivo ele está!");
            System.Console.WriteLine ("Verbo: ");
            string Verbo = Console.ReadLine ();
            string UltimasLetrasDoVerbo = Verbo.Substring (Verbo.Length - 2, 2);
            switch (UltimasLetrasDoVerbo) {
                case "ar":
                    System.Console.WriteLine ("O verbo está na 1º Conjugação do infinitivo!");
                    break;
                case "er":
                    System.Console.WriteLine ("O verbo está na 2º Conjugação do infinitivo!");
                    break;
                case "ir":
                    System.Console.WriteLine ("O verbo está na 3º Cojungação do infinitivo!");
                    break;
                default:
                    System.Console.WriteLine ("O verbo nao está no infinitivo!");
                    break;
            }

        }
    }
}