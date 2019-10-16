using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.Models {
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia {
        public bool TocarSolo () {
            System.Console.WriteLine ("Tocando solo da guitarra");
            return true;
        }
        public bool TocarAcordes () {
            System.Console.WriteLine ("Tocando acordes da guitarra!");
            return true;
        }

    }
}