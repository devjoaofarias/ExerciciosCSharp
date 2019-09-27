using System;

namespace Temperatura_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[12];
            double maior = 0;
            double menor = 0;
            for(int meses = 0; meses < 12; meses++) {

                Console.Write($"Digite a temperatura do mês {meses + 1}: ");
                temperaturas[meses] = double.Parse(Console.ReadLine());
            }
            maior = temperaturas[0];    
            menor = temperaturas[0];
            foreach(double temp in temperaturas) {
            
                if(temp > maior)
                {
                    maior = temp;
                }else if (temp < menor)
                {
                    menor = temp;
                }
            }
            Console.WriteLine($"A maior temperatura é de {maior} graus!");
            Console.WriteLine($"a menor temperatura é de {menor} graus!");

        }
    }
}
