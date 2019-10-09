using System;
namespace SENAIzinho {
    public class Sala {
        public int capacidadeAtual { get; set; }
        public int capacidadeTotal { get; set; }
        public int numeroSala { get; set; }
        public string[] Alunos { get; set; }

        // !CONSTRUTOR
        public Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
        }

        // !MÉTODO ALOCAR ALUNO
        public string AlocarAluno (string nomeAluno) {
            System.Console.WriteLine ("Digite o nome do aluno a ser cadastrado na sala: ");
            nomeAluno = string.Parse (Console.ReadLine ());
            if (capacidadeAtual == 0) {
                System.Console.WriteLine ("Não foi possivel cadastrar o aluno, infelizmente a sala não possui vagas.");
            } else {
                Alunos[capacidadeTotal - capacidadeAtual] = nomeAluno;
                capacidadeAtual = capacidadeAtual - 1;
                System.Console.WriteLine ("O aluno foi cadastrado com sucesso!");
            }

        }

        // !MÉTODO REMOVER ALUNO

        public string RemoverAluno (string nomeAlunoRemov) {
            System.Console.WriteLine ("Digite o nome do aluno que deseja remover da sala: ");
            nomeAlunoRemov = Console.ReadLine ();
            for (nomeAlunoRemov == Alunos[0]; nomeAlunoRemov == Alunos[99]; Alunos++) {
                
                
                System.Console.WriteLine($"O aluno {nomeAlunoRemov} foi removido com sucesso!");
            } 
        }

        // !MÉTODO MOSTRAR ALUNO
        public string MostrarAlunos () {

        }

    }
}