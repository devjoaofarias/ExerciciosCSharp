using System;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Models {
    public class Pedido {
        public Pedido(ulong id, Cliente cliente, Hamburguer hamburguer, Shake shake, DateTime dataDoPedido, double precoTotal, uint status) 
        {
            this.Id = id;
                this.Cliente = cliente;
                this.Hamburguer = hamburguer;
                this.Shake = shake;
                this.DataDoPedido = dataDoPedido;
                this.PrecoTotal = precoTotal;
                this.Status = status;
               
        }
                public ulong Id { get; set; }
        public Cliente Cliente { get; set; }

        public Hamburguer Hamburguer { get; set; }

        public Shake Shake { get; set; }

        public DateTime DataDoPedido { get; set; }

        public double PrecoTotal { get; set; }
        public uint Status { get; set; }
        public Pedido () {
            this.Cliente = new Cliente ();
            this.Hamburguer = new Hamburguer ();
            this.Shake = new Shake ();
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
        }
    }
}