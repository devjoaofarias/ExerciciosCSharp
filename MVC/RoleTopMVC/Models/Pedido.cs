using System;

namespace RoleTopMVC.Models
{
    public class Pedido
    {  
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public double PrecoTotal {get;set;}
        public DateTime DataEvento {get;set;}
        public uint Status {get;set;}

        public bool Som {get;set;}
        public bool Iluminaçao {get;set;}
        public bool Publico {get;set;}

        public Pedido () {

        }

        public Pedido (ulong Id, Cliente cliente, double PrecoTotal, DateTime DataEvento, uint Status, bool Som, bool Iluminacao, bool Publico, bool Particular) {
            this.Id = 0;
            this.Cliente = new Cliente();
            this.PrecoTotal = PrecoTotal;
            this.DataEvento = DataEvento;
            this.Status = Status;
            this.Som = false;
            this.Iluminaçao = false;
            this.Publico = false;
        }

    }
}