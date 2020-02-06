using System;

namespace Matriz3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos criar uma matrix 3x3 com números aleátórios e somaremos todos eles! ");
            int[,] matrix = new int[3,3];
            Random numAleatorio = new Random ();

            for (int i = 0; i < 3; i++)
            {   matrix[i,i] = numAleatorio.Next(1, 200);
                
            }
        }
    }
}
