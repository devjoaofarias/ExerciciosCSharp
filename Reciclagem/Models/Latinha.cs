using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : IMetal
    {
        public bool Amarelo() {
            System.Console.WriteLine("A lixeira correspondente a sua Latinha é a lixeira AMARELA, pertencente a classe dos METAIS!");
            return true;
        }
     
}
}