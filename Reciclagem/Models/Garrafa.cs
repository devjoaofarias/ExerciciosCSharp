using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Garrafa : Lixo, IVidro
    {
      public bool Verde () {
          System.Console.WriteLine("A lixeira correspondente a sua Garrafa é lixeira VERDE, pertencente a classe dos VIDROS! ");
          return true;
      }
    }
}