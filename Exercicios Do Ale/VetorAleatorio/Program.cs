using System;

namespace VetorAleatorio {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Iniciaremos um vetor com números aleato´rios\nE vamos separar duas listas, números pares e impáres!");
            int[] num = new int[10];
            Random numAleatorio = new Random ();

            for (int i = 0; i < 10; i++) {
                num[i] = numAleatorio.Next (1, 200);
            }

            for (int o = 0; o < 10; o++) {
                if (num[o] % 2 == 0) {
                    System.Console.WriteLine ($"O número {num[o]} é Par!");
                }
            }
            
            for (int o = 0; o < 10; o++) {
                if (num[o] % 2 != 0) {
                    System.Console.WriteLine ($"O número {num[o]} é Impar!");
                }
            }
        }
    }
}