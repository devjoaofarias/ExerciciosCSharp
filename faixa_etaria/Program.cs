using System;

namespace faixa_etaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            int idade = 0;

            Console.WriteLine("Iremos dizer a sua faixa etária de acorno com o ano de seu nascimento!");
            do{ 
                Console.WriteLine("Digite seu ano de nascimento: "); 
                ano = int.Parse(Console.ReadLine());
                if(ano >2021){
                Console.WriteLine("Data Inválida");
                }
            } while((ano > 2021) || (ano < 1850));

            idade = 2019 - ano;

            if(idade < 3 ) {
                Console.WriteLine($" Você tem {idade} anos e você é um Recém-Nascido");
            } else if ((idade >= 3) && (idade <= 11)){
                Console.WriteLine($" Você tem cle{idade} anos e você é uma Criança");
            } else if ((idade >= 12) && (idade <= 19)){
                Console.WriteLine($" Você tem {idade} anos e você é um adolescente");
            } else if ((idade >= 20) && (idade <= 65)){
                Console.WriteLine($" Você tem {idade} anos e você é um adulto");
            } else if (idade > 65) {
                Console.WriteLine($"Você tem {idade} anos e você é um idoso");
            }

        }
    }
}
