using System;
using SENAIzinho.Models;
namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            Aluno[] alunos = new Aluno[10];
            Sala[] salas = new Sala[10];
            int alunosCadastrados = "";
            int salaCadastradas = "";
            bool querSair;

            //! MENU DE AÇÕES
            System.Console.WriteLine ("BEM VINDO AO SENAIZINHO!");
            System.Console.WriteLine ("Digite o numero correspondente a acçao que deseja realizar");
            System.Console.Write (" 1 - CADASTRAR ALUNO");
            System.Console.Write (" 2 - CADASTRAR SALA");
            System.Console.Write (" 3 - ALOCAR ALUNO");
            System.Console.Write (" 4 - REMOVER ALUNO");
            System.Console.Write (" 5 - VERIFICAR SALAS");
            System.Console.Write (" 6 - VERIFICAR ALUNOS");
            System.Console.Write (" 0 - SAIR");
            OpcaoMenu = Console.ReadLine ();

            switch (OpcaoMenu) {
                case "1":
                    Sala sala = AlocarAluno ();
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "0":

                    break;

                default:
            }

        }
        public void CadastrarAluno () {

        }
        public void CadastrarSala () {

        }
        public void AlocarAluno () {

        }
        public void RemoverAluno () {

        }
        public void VerificarSala () {

        }
        public void VerificarAlunos () {
            
        }

    }

}