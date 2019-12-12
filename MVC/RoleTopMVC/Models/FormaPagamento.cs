using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class FormaPagamento
    {   
         public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCartao {get;set;}
        public string Email {get;set;}
        public string NumeroCartao {get;set;}
        public string Cvv {get;set;}
        public string Telefone {get;set;}
        public DateTime DataValidade {get;set;}
        public DateTime DataEvento {get;set;}
        public string tipoEvento {get;set;}
        public string publicoPrivado {get;set;}
        public string tipoPacote {get;set;}
         public uint Status { get; set; }
         public double PrecoTotal {get;set;}
        public FormaPagamento () {
            this.Id = 0;
            this.Status = (uint) StatusAluguel.PENDENTE;
        }

    }
}