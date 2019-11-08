using System;

namespace Imc {
    class Program {
        static void Main (string[] args) {
            float Peso = 0;
            float Altura = 0;
            float Imc = 0;
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine ("----CALCULO - IMC----");
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine ("Nos informe sua Altura e seu Peso!");
            System.Console.WriteLine ("Peso em kg: ");
            Peso = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Altura em Metros: ");
            Altura = float.Parse (Console.ReadLine ());
            Imc = (Peso / (Altura * Altura));

            if (Imc < 20) {
                System.Console.WriteLine ($"Você está abaixo do peso!\nE se IMC vale {Imc}!");
            } else if (Imc >= 20 && Imc < 25) {
                System.Console.WriteLine ($"Você está na faixa normal\nE seu IMC vale {Imc}!");
            } else if (Imc >= 25 && Imc < 30) {
                System.Console.WriteLine ($"Você está na faixa de excesso de peso\nE seu IMC vale {Imc}!");
            } else if (Imc >= 30 && Imc < 35) {
                System.Console.WriteLine ($"Você está na faixa de obesidade\nE seu Imc vale {Imc}!");
            } else {
                System.Console.WriteLine ($"Você está na faixa de obesidade mórbida\nE seu Imc vale {Imc}!");
            }
            //! SÓ FUNCIONA SE O USUÁRIO USAR VIRGULA, NAO PONTO!
        }
    }
}