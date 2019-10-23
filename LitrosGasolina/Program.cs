using System;

namespace LitrosGasolina
{
    class Program
    {
        static void Main(string[] args)
        {   float Tempo = 0;
            float Velocidade = 0;
            float Litros = 0;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---------LITROS GASOLINA---------");
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Nos informe qual o tempo de duraçao da sua viagem e sua velocidade média \nEm seguinte iremos calcular a quantidade de gasolina gasta!");
            System.Console.WriteLine("Tempo gasto na viagem em horas: ");
            Tempo = float.Parse(Console.ReadLine());
            System.Console.WriteLine("velocidade média : ");
            Velocidade = float.Parse(Console.ReadLine());
            Litros = ((Tempo * Velocidade) / 12);
            System.Console.WriteLine($"Nessa sua viagem considerando que seu carro faz 12km/l você gastou \n{Litros} litros\nDemorou {Tempo} horas\nPercorreu {Tempo + Velocidade} Km! ");
        }
    }
}
