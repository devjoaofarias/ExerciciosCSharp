using System;
using System.Collections.Generic;
using System.Text;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem {
    class Program {
        static void Main (string[] args) {
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine ("---RECICLAGEM DE LIXOS!--");
            System.Console.WriteLine (" 1 ----GARRAFA----------");
            System.Console.WriteLine (" 2 ----GARRAFA PET------");
            System.Console.WriteLine (" 3 ----GUARDA-CHUVA-----");
            System.Console.WriteLine (" 4 ----LATINHA----------");
            System.Console.WriteLine (" 5 ----PAPELÃO----------");
            System.Console.WriteLine (" 6 ----POTE DE MANTEIGA-");
            System.Console.WriteLine ("Digite o número relacionado ao lixo que deseja reciclar:");
            int opcao = int.Parse (Console.ReadLine ());
            

            switch (opcao) {
                case 1:
                        Garrafa garrafa = new Garrafa ();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        garrafa.Verde();
                        Console.BackgroundColor = ConsoleColor.Black;     
                    break;
                case 2:
                        GarrafaPET garrafaPet = new GarrafaPET ();
                        Console.BackgroundColor = ConsoleColor.Red;
                        garrafaPet.Vermelho();
                        Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 3: 
                        GuadraChuva guardaChuva = new GuadraChuva();
                        Console.BackgroundColor = ConsoleColor.Gray;
                        guardaChuva.Cinza();
                        Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 4:
                        Latinha latinha = new Latinha();
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        latinha.Amarelo();
                        Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 5:
                        Papelao papelao = new Papelao();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        papelao.Azul();
                        Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 6:
                        PoteManteiga PoteManteiga = new PoteManteiga();                       
                        PoteManteiga.Preto();
                        Console.BackgroundColor = ConsoleColor.Black;
                    break;
                    default: System.Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
        public static void ReciclarNovo(IPapel papel)
        {

        }

    }
}