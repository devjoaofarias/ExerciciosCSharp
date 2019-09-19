using System;

namespace aumento_salario
{
    class Program
    {
        static void Main(string[] args)
        { float sal = 0;

        Console.WriteLine("Iremos dar um aumento de 30% no sálario de quem recebe menos de R$500.00");
        Console.WriteLine("Porfavor, digite seu salário");
        sal = float.Parse(Console.ReadLine());

        if (sal <= 500) {
            Console.WriteLine($"Seu salário subirá de {sal}, para {sal*1.3}! Parabens!");
        }
        else {
            Console.WriteLine($"Seu salário é acima dos 500 reais, não podemos aumenta-lo.");
        }
            
        }
    }
}
