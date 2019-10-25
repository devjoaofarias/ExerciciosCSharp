using System;

namespace VetorN {
    class Program {
        static void Main (string[] args) {
            int Quantidade = 0;
            Console.WriteLine ("Nos diga um número que iremos criar um vetor e você dara o valor a cada número do vetor");
            System.Console.WriteLine ("Qual a quantidade de casas deve ter o vetor: ");
            Quantidade = int.Parse (Console.ReadLine ());
            int vetor = new int[Quantidade];
            System.Console.WriteLine ("Agora os valores de cada posição");
            
            for (int i = 0; i <= Quantidade; i++) {
                System.Console.WriteLine($"{i}º Posição: ");
                vetor[i] = int.Parse (Console.ReadLine ());
            }
            System.Console.WriteLine(i);
        }
    }
}