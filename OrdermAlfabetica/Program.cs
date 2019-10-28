using System;

namespace OrdermAlfabetica {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine ("---ORDEM - ALFABÉTICA---");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine ("Nos passe dois nomes e iremos colocar em ordem alfabética");
            string nome1 = "";
            string nome2 = "";
            System.Console.WriteLine ("Nome 1: ");
            nome1 = Console.ReadLine ();
            System.Console.WriteLine ("Nome 2: ");
            nome2 = Console.ReadLine ();
            int comp = string.Compare (nome1, nome2);
            if (comp > 0) {
                System.Console.WriteLine ($"A ordem é 1º{nome2} e 2º{nome1}!");
            } else if (comp == 0) {
                System.Console.WriteLine ("Os nomes sao iguais!");
            } else {
                System.Console.WriteLine ($"A ordem é 1º{nome1} e 2º{nome2}!");
            }

            // string[] oi = new string[3];
            // oi[0] = "lucas";
            // oi[1] = "joao";
            // oi[2] = "pedro";
            // Array.Sort (oi);
            // foreach (string ola in oi) {
            //     System.Console.WriteLine (ola);
        }

    }
}
