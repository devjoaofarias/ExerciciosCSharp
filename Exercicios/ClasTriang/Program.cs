using System;

namespace ClasTriang {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine ("---CLASSIFICAÇÃO - TRIANGULOS---");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine ("Nos informe 3 numeros, e diremos se eles podem ser o comprimento dos lados de um triangulo!");
            float lado1 = 0;
            float lado2 = 0;
            float lado3 = 0;
            System.Console.WriteLine ("Tamanho do lado 1: ");
            lado1 = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Tamanho do lado 2: ");
            lado2 = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Tamanho do lado 3: ");
            lado3 = float.Parse (Console.ReadLine ());

            if ((lado1 == lado2) && (lado2 == lado3)) {
                System.Console.WriteLine ("é possivel que esses comprimentos formem um triangulo EQUILATERO!");

            } else if ((lado1 < lado2 + lado3) && (lado2 == lado3)) {
                System.Console.WriteLine ($"É possivel que esses comprimentos formem um triangulo ISÓSCELES");
            } else if ((lado2 < lado1 + lado3) && (lado1 == lado3)) {
                System.Console.WriteLine ($"É possivel que esses comprimentos formem um triangulo ISÓSCELES");
            } else if ((lado3 < lado1 + lado2) && (lado1 == lado2)) {
                System.Console.WriteLine ($"É possivel que esses comprimentos formem um triangulo ISÓSCELES");
            } else if (lado1 < lado2 + lado3) {
                System.Console.WriteLine ("É possivel que esses comprimentos formem um triangulo ESCALENO!");
            } else if (lado2 < lado1 + lado3) {
                System.Console.WriteLine ("É possivel que esses comprimentos formem um triangulo ESCALENO!");
            } else if (lado3 < lado1 + lado2) {
                System.Console.WriteLine ("É possivel que esses comprimentos formem um triangulo ESCALENO!");
            } else {
                System.Console.WriteLine("Triangulo Inválido!");
            }
        }
    }
}