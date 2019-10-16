using System;
using System.Collections.Generic;
using EscolaDeRock.interfaces;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    enum FormacaoEnum : int {
        TRIO = 3,
        QUARTETO
    }

    enum InstrumentoEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    }

    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    }

    class Program {
        static void Main (string[] args) {
            string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames (typeof (CategoriaEnum));

            var opcoesFormacao = new List<string> () {
                "     - 0     ",
                "     - 1     "
            };
            int opcoesFormacaoSelecionada = 0;
            string menuBar = "============================";

            do {
                bool formacaoEscolhida = false;
                do {
                    #region Area do menu
                    System.Console.WriteLine (menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine ("       Seja bem vindo!        ");
                    System.Console.WriteLine ("       Escolha uma formaçao   ");
                    Console.ResetColor ();
                    System.Console.WriteLine (menuBar);

                    for (int i = 0; i < opcoesFormacao.Count; i++) {
                        string titulo = itensMenuPrincipal[i];
                        if (opcoesFormacaoSelecionada == i) {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine (opcoesFormacao);
                            Console.ResetColor ();
                        } else {
                            System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), titulo));
                        }
                    }
                    var key = Console.ReadKey (true).Key;

                    switch (key) {
                        case ConsoleKey.UpArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                            break;
                    }
                    #endregion
                } while (false);
            } while (!querSair);
        }
    }
}