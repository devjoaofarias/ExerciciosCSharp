using System;

namespace aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno aluno1 = new aluno("João","456.333.222-11");
            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("Cpf: " + aluno1.cpf);

            aluno aluno2 = new aluno("João","456.333.222-11","Desenvolvimento de sistemas");
            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("Cpf: " + aluno2.cpf);
            Console.WriteLine("Curso: " + aluno2.curso);

            Console.Write("Entre com o Nome: ");
            nome = Console.ReadLine();
            Console.Write("Entre com o CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Entre com o curso: ");
            curso = Console.ReadLine();
            Console.Write("Entre com a nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.Write("Entre com o bimestre: ");
            int bimestre = int.Parse(Console.ReadLine());
            aluno aluno = new aluno(nome, cpf, curso);
            aluno3.setnotas(bimestre, nota);    

            Console.WriteLine("Nome: " + aluno3.nome);
            Console.WriteLine("CPF: " + aluno3.cpf);
            Console.WriteLine("Curso: " + aluno3.curso);
            Console.WriteLine("Notas: ");
            
            foreach(int n in aluno3.getnotas()) {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
