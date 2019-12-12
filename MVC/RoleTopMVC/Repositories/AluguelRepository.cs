using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;
namespace RoleTopMVC.Repositories {
    public class AluguelRepository : RepositoryBase {
        private const string PATH = "Database/Alugueis.csv";

        public AluguelRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (FormaPagamento formaPagamento) {
            var linha = new string[] { PrepararRegistroCSV (formaPagamento) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<FormaPagamento> ObterTodosPorCliente(string emailCliente)
        {
            var alugueis = ObterTodos();
            List<FormaPagamento> alugueisCliente = new List<FormaPagamento>();

            foreach (var aluguel in alugueis)
            {
                if(aluguel.Cliente.Email.Equals(emailCliente))
                {
                    alugueisCliente.Add(aluguel);
                }
            }
            return alugueisCliente;
        }

        public List<FormaPagamento> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<FormaPagamento> formaPagamentos = new List<FormaPagamento> ();

            foreach (var item in linhas) {
                Cliente c = new Cliente();
                FormaPagamento formas = new FormaPagamento ();
                formas.Id = ulong.Parse(ExtrairValorDoCampo("id", item));
                formas.DataEvento = DateTime.Parse(ExtrairValorDoCampo ("data-evento", item));
                formas.NomeCartao = ExtrairValorDoCampo ("nomeCartao", item);
                formas.Email = ExtrairValorDoCampo ("email", item);
                formas.Telefone = ExtrairValorDoCampo ("telefone", item);
                formas.Status = uint.Parse(ExtrairValorDoCampo("statusAluguel", item));
                formas.tipoEvento = ExtrairValorDoCampo ("tipoEvento", item);
                formas.publicoPrivado = ExtrairValorDoCampo ("publicoPrivado", item);
                formas.tipoPacote = ExtrairValorDoCampo ("tipoPacote", item);
                formas.NumeroCartao = ExtrairValorDoCampo ("numeroCartao", item);
                formas.Cvv = ExtrairValorDoCampo ("Cvv", item);
                formas.DataValidade = DateTime.Parse (ExtrairValorDoCampo ("data-validade", item));
                formas.PrecoTotal = double.Parse(ExtrairValorDoCampo("precoTotal", item));
               
                formaPagamentos.Add (formas);
            }
            return formaPagamentos;
        }
        private string PrepararRegistroCSV (FormaPagamento formaPagamento) {
            return $"data-evento={formaPagamento.DataEvento};nomeCartao={formaPagamento.NomeCartao};email={formaPagamento.Email};telefone={formaPagamento.Telefone};statusAluguel={formaPagamento.Status};tipoEvento={formaPagamento.tipoEvento};publicoPrivado={formaPagamento.publicoPrivado};tipoPacote={formaPagamento.tipoPacote};numeroCartao={formaPagamento.NumeroCartao};Cvv={formaPagamento.Cvv};data-validade={formaPagamento.DataValidade};precoTotal={formaPagamento.PrecoTotal};";
        }

         public FormaPagamento ObterPor(ulong id)
        {
            var alugueisTotais = ObterTodos();
            foreach (var aluguel in alugueisTotais)
            {
                if(id.Equals(aluguel.Id))
                {
                    return aluguel;
                }
            }
            return null;
        }
                public bool Atualizar(FormaPagamento formaPagamento)
        {
            var alugueisTotais = File.ReadAllLines(PATH);
            var aluguelCSV = PrepararRegistroCSV(formaPagamento);
            var linhaAluguel = -1;
            var resultado = false;
            
            for (int i = 0; i < alugueisTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", alugueisTotais[i]));
                if(formaPagamento.Id.Equals(idConvertido))
                {
                    linhaAluguel = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                alugueisTotais[linhaAluguel] = aluguelCSV;
                File.WriteAllLines(PATH, alugueisTotais);
            }

            return resultado;
        }


    }
}