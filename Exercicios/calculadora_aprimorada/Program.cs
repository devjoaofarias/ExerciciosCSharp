using System;

namespace calculadora_aprimorada
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1º número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador: ");
            oper = Console.ReadLine();

            if (oper == "+" ) {
                    Console.WriteLine($"O resultado é: {num1 + num2}");
                } else if (oper == "-" ) {
                    Console.WriteLine($"O resultado é: {num1 - num2}");
                } else if (oper == "*" ) {
                    Console.WriteLine($"O resultado é: {num1 * num2}");
                } else if (oper == "/" )  {
                    Console.WriteLine($"O resultado é: {num1 / num2}");
                } else {
                    Console.WriteLine("Operação inválida!");
                }

            // switch(oper){
            //     case "+": 
            //     Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //     break;

            //     case "-": 
            //     Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //     break;

            //     case "*": 
            //     Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //     break;

            //     case "/": 
            //     Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //     break;

            //     case "%": 
            //     Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            //     break;
            //     default:
            //     Console.WriteLine("Operação inválida!");
            //     break:
            // }
        }
    }
}
