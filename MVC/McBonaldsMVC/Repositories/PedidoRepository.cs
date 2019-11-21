using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories {
    public class PedidoRepository : RepositoryBase {
        private const string PATH = "Database/Pedidos.csv";
        public PedidoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (Pedido pedido) {
            var linha = new string[] { PrepararPedidoCSV (pedido) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        public List<Pedido> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Pedido> pedidos = new List<Pedido> ();

            foreach (var linha in linhas) {
                Pedido pedido = new Pedido ();
                pedido.Cliente = new Cliente();
                pedido.Cliente.Nome = ExtraiValorDoCampo ("cliente_nome", linha);
                pedido.Cliente.Email = ExtraiValorDoCampo ("cliente_email", linha);
                pedido.Cliente.Endereco = ExtraiValorDoCampo ("cliente_endereco", linha);
                pedido.Cliente.Telefone = ExtraiValorDoCampo ("cliente_telefone", linha);
                pedido.Hamburguer.Preco = double.Parse (ExtraiValorDoCampo ("hamburguer_preco", linha));
                pedido.Hamburguer.Nome = ExtraiValorDoCampo ("hamburguer_nome", linha);
                pedido.Shake.Preco = double.Parse (ExtraiValorDoCampo ("shake_preco", linha));
                pedido.Shake.Nome = ExtraiValorDoCampo ("shake_nome", linha);
                pedido.PrecoTotal = double.Parse (ExtraiValorDoCampo ("preco_total", linha));
                pedido.DataDoPedido = DateTime.Parse (ExtraiValorDoCampo ("data_pedido", linha));

                pedidos.Add (pedido);
            }
            return pedidos;
        }

        public List<Pedido> ObterTodosPorCliente (string emailCliente) {
            var pedidos = ObterTodos ();
            List<Pedido> pedidosCliente = new List<Pedido> ();
            foreach (var pedido in pedidos) {
                if (pedido.Cliente.Email.Equals (emailCliente)) {
                    pedidosCliente.Add (pedido);
                }
            }
            return pedidosCliente;
        }

        private string PrepararPedidoCSV (Pedido pedido) {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"cliente_nome = {c.Nome}; cliente_endereco = {c.Endereco}; cliente_telefone = {c.Telefone}; cliente_email = {c.Email}; hamburguer_nome = {h.Nome}; hamburguer_preco = {h.Preco}; shake_nome = {s.Nome}; shake_preco = {s.Preco}; data_pedido = {pedido.DataDoPedido}; preco_total = {pedido.PrecoTotal}";
        }

    }
}