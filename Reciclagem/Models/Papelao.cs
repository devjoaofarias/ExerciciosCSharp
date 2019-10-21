using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : IPapel
    { public bool Azul() {
        System.Console.WriteLine("A lixeira correspondente ao seu Papelão é a lixeira AZUL, pertencente a classe dos PAPÉIS!");
        return true;
    }
       
    }
}
