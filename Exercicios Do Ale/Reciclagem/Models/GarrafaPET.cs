using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GarrafaPET : Lixo, IPlastico
    {
        public bool Vermelho() {
            System.Console.WriteLine("A lixeira correspondente a sua Garrafa Pet é a lixeira VERMELHA, pertencente a classe dos PLÀSTICOS!");
            return true;
        }
    
}
}
