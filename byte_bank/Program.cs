using System;
namespace byte_bank {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("ByteBank - Cadastro de Clientes");
            Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("Email: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool trocouSenha = false;
            do {
                Console.Write ("Senha: ");
                string senha = Console.ReadLine ();
                trocouSenha = cliente1.TrocaSenha (senha);
                if (trocouSenha) {
                    System.Console.WriteLine ("Senha alterada com sucesso!");
                } else {
                    System.Console.WriteLine ("Senha Invalida!");
                }
            } while (!trocouSenha);

            Console.Clear ();
            System.Console.WriteLine ();
            #region cadastro de clientes.
            System.Console.WriteLine ("ByteBank - Cadastro de Contas Bancária");
            Console.Write ("Numero da agencia: ");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.Write ("Numero da conta: ");
            int numero = int.Parse (Console.ReadLine ());

            ContaCorrente contaCorrente1 = new contaCorrente (agencia, numero);
            double saldo;
            do {
                System.Console.WriteLine ("Entre com o saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo > 0) {
                    System.Console.WriteLine ($"Conta criada, seu saldo é de {saldo} reais");
                } else {
                    System.Console.WriteLine ($"Impossível realizar a abertura de uma conta com saldo negativo!");
                }
            } while (saldo < 0);
            System.Console.WriteLine();
            #endregion

            Cliente cliente2 = new Cliente("Joao","123.123.123-00","joao.teste@gmail.com");
            ContaCorrente contaCorrente2 = new ContaCorrente (123, 321, cliente2);

            #region Depósito.
            Cliente usuário = contaCorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"BEM VINDO - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor do depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.Depósito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente.Saldo}");
            System.Console.WriteLine();
            #endregion

            
        }

    }

}