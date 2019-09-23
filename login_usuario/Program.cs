using System;

namespace login_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string login ;
            string senha ;

            Console.WriteLine("LOGIN: ");
            login = Console.ReadLine();
            Console.WriteLine("SENHA: ");
            senha = Console.ReadLine();

            if ((login == "admin") && (senha == "admin")){
                Console.WriteLine("Bem Vindo Administrador!");
            } else {
                Console.WriteLine("Bem Vindo Usuário!");
            }

        }
    }
}
