using System;

namespace média_aritmética
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float num4 = 0;

            Console.WriteLine("Iremos calcular sua média de notas escolares, assim vamos saber se você foi aprovado ou reprovado.");

            Console.WriteLine("Digite sua 1º nota");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 2º nota");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 3º nota");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 4º nota");
            num4 = float.Parse(Console.ReadLine());

            float soma = (num1 + num2 + num3 + num4) /4; 

            if (soma >= 7 ) {
                Console.WriteLine($"Sua nota é {soma}, Você foi aprovado! PARABÉNS!!!");
            } else if (soma == 7) {
                Console.WriteLine($"Sua nota é {soma},Ufa, quase que não passa em!");
            } else {
                Console.WriteLine($"Sua nota é {soma},Você infelizmente foi reprovado! Estude mais!");
            }
            
        }
    }
}
