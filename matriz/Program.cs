using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int par = 0;
            int impar = 0;

            for(int cont = 0 ; cont < 6; cont++){
                Console.Write($"Digite o {cont+1}º número: ");
                vetor[cont] = int.Parse(Console.ReadLine());
            }

            foreach(int num in vetor){
                if(num % 2 == 0){
                    par = par + 1;
                
                } else {
                    impar= impar + 1; 
                }

            }
            Console.WriteLine($"Dentre esse numeros, {par} são pares, e {impar} sao impares");

            // JEITO COM VARIAS VARIÁVEIS --------------------------------------------------
            // int[] vetor = new int[6];
            //     Console.WriteLine("Digite 6 numeros para mim dizer se é impar ou par: ");
            //     Console.WriteLine("Primeiro número: ");
            //     vetor[0] = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Segundo número: ");
            //     vetor[1] = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Terceiro número: ");
            //     vetor[2] = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Quarto número: ");
            //     vetor[3] = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Quinto número: ");
            //     vetor[4] = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Sexto número: ");
            //     vetor[5] = int.Parse(Console.ReadLine());

            //     float op1 = vetor[0] % 2;
            //     float op2 = vetor[1] % 2;
            //     float op3 = vetor[2] % 2;
            //     float op4 = vetor[3] % 2;
            //     float op5 = vetor[4] % 2;
            //     float op6 = vetor[5] % 2;

            //     if ( op1 == 0) {
            //         Console.WriteLine($"O primeiro numero '{vetor[0]}' é par");
            //    } else { 
            //        Console.WriteLine($"O primeiro numero '{vetor[0]}' é impar");
            //    }

            //     if ( op2 == 0) {
            //         Console.WriteLine($"O primeiro numero '{vetor[1]}' é par");
            //    } else { 
            //        Console.WriteLine($"O primeiro numero '{vetor[1]}' é impar");
            //    }

            //     if ( op3 == 0) {
            //         Console.WriteLine($"O primeiro numero '{vetor[2]}' é par");
            //    } else { 
            //        Console.WriteLine($"O primeiro numero '{vetor[2]}' é impar");
            //    }

            //     if ( op4 == 0) {
            //         Console.WriteLine($"O primeiro numero '{vetor[3]}' é par");
            //    } else { 
            //        Console.WriteLine($"O primeiro numero '{vetor[3]}' é impar");
            //    }

            //     if ( op5 == 0) {
            //         Console.WriteLine($"O primeiro numero '{vetor[4]}' é par");
            //    } else { 
            //        Console.WriteLine($"O primeiro numero '{vetor[4]}' é impar");
            //     }

            //     if ( op6 == 0) {
            //         Console.WriteLine($"O primeiro numero '{vetor[5]}' é par");
            //    } else { 
            //        Console.WriteLine($"O primeiro numero '{vetor[5]}' é impar");
            //    }
              

               
            }

        }
    }

