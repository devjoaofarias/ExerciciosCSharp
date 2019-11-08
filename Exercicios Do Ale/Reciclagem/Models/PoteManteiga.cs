using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga : Lixo, IOrganico
    {   public bool Preto() {
        System.Console.WriteLine("A lixeira correspondente ao seu Pote de Manteiga é a lixeira PRETA, pertencente a classe dos ORGANICOS!");
        return true;
    }
      
}
}