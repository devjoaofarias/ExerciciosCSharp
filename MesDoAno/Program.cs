using System;

namespace MesDoAno {
    class Program {
        static void Main (string[] args) {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("-----MES - DO - ANO-----");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine ("Nos informe um número inteiro entre 1 e 12\nPara dizermos qual mês do ano é correspondente à ele!");
            int Mes = int.Parse (Console.ReadLine ());
            switch (Mes) {
                case 1:
                    System.Console.WriteLine ("O Mês é Janeiro!");
                    break;
                case 2:
                    System.Console.WriteLine ("O Mês é Fevereiro!");
                    break;
                case 3:
                    System.Console.WriteLine ("O Mês é Março!");
                    break;
                case 4:
                    System.Console.WriteLine ("O Mês é Abril!");
                    break;
                case 5:
                    System.Console.WriteLine ("O Mês é Maio!");
                    break;
                case 6:
                    System.Console.WriteLine ("O Mês é Junho!");
                    break;
                case 7:
                    System.Console.WriteLine ("O Mês é Julho!");
                    break;
                case 8:
                    System.Console.WriteLine ("O Mês é Agosto!");
                    break;
                case 9:
                    System.Console.WriteLine ("O Mês é Setembro!");
                    break;
                case 10:
                    System.Console.WriteLine ("O Mês é Outubro!");
                    break;
                case 11:
                    System.Console.WriteLine ("O Mês é Novembro!");
                    break;
                case 12:
                    System.Console.WriteLine ("O Mês é Dezembro!");
                    break;
                default:
                    System.Console.WriteLine ("O número é invalido!");
                    break;
            }

        }
    }
}