using System;

namespace byte_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocouSenha = false;
            do{
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha  = cliente1.TrocaSenha(senha); 
                if(trocouSenha){
                    System.Console.WriteLine("Senha alterada com sucesso!");
                } else{
                    System.Console.WriteLine("Senha Invalida!");
                }
            }while(!trocouSenha);
            
            Console.Clear();
            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Cadastro de Contas Bancária");
            Console.Write("Numero da agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();
            System.Console.WriteLine("Saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());
             
            ContaCorrente conta1 = new ContaCorrente (agencia, numero, titular);

            if (saldo > 0)
            {
                System.Console.WriteLine($"Conta criada, seu saldo é de {saldo} reais");
            } else {
                System.Console.WriteLine($"Impossível realizar a abertura de uma conta com saldo negativo!");
            }

            

            }
        }
    }