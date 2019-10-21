using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GuadraChuva : IIndefinido
    { 
     public bool Cinza() {
        System.Console.WriteLine("A lixeira correspondente ao seu Guarda-Chuva é lixeira CINZA, pertencente a classe dos INDEFINIDOS! ");
        return true;
     }
}
}