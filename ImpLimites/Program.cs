using System;

namespace ImpLimites {
    class Program {
        static void Main (string[] args) {
            int Num = 0;
            System.Console.WriteLine ("Nos diga um numero que imprimiremos os numeros impares que antecede ele!");
            System.Console.WriteLine("Numero: ");
            Num = int.Parse(Console.ReadLine());
            for (int i = 1; i < Num; i = i + 2) {
                System.Console.WriteLine(i);
            }
        }
    }
}