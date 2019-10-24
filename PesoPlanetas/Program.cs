using System;

namespace PesoPlanetas {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine ("---PESO - NOS - PLANETAS----");
            Console.BackgroundColor = ConsoleColor.Black;
            float peso = 0;
            int Pla = 0;
            System.Console.WriteLine ("Nos informe um planeta e seu peso \nPara calcularmos seu peso no respectivo planeta!");
            System.Console.WriteLine ("Peso: ");
            peso = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("---PLANETAS--");
            System.Console.WriteLine ("-1 Mercurio-- ");
            System.Console.WriteLine ("-2 Venûs----- ");
            System.Console.WriteLine ("-3 Marte----- ");
            System.Console.WriteLine ("-4 Júpiter--- ");
            System.Console.WriteLine ("-5 Saturno--- ");
            System.Console.WriteLine ("-6 Urano----- ");
            System.Console.WriteLine ("Digite o número do planeta escolhido!");
            Pla = int.Parse (Console.ReadLine ());
            switch (Pla) {
                case 1:
                    System.Console.WriteLine ($"O seu peso na terra é {peso} \nE em Mercurio é {(peso / 10) * 0.37}Kg!");
                    break;
                case 2:
                    System.Console.WriteLine ($"O seu peso na terra é {peso} \nE em Venus é {(peso / 10) * 0.88}Kg!");
                    break;
                case 3:
                    System.Console.WriteLine ($"O seu peso na terra é {peso} \nE em Marte é {(peso / 10) * 0.38}Kg!");
                    break;
                case 4:
                    System.Console.WriteLine ($"O seu peso na terra é {peso} \nE em Júpiter é {(peso / 10) * 2.64}Kg!");
                    break;
                case 5:
                    System.Console.WriteLine ($"O seu peso na terra é {peso} \nE em Saturno é {(peso / 10) * 1.15}Kg!");
                    break;
                case 6:
                    System.Console.WriteLine ($"O seu peso na terra é {peso} \nE em Urano é {(peso / 10) * 1.17}Kg!");
                    break;
                default:
                    System.Console.WriteLine ("Operação Invalida!");
                    break;

            }

        }
    }
}