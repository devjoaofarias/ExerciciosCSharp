using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class PedidosController : Controller {

        HambuerguerRepository hambuerguerRepository = new HambuerguerRepository();
        public IActionResult Index () {

            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hambuerguerRepository.ObterTodos();
            return View (pvm   );
        }
        public IActionResult Registrar (IFormCollection form) {

            ViewData["Action"] = "Pedidos";
            try {  
                PedidoRepository pedidoRepository = new PedidoRepository ();

                Pedido pedido = new Pedido ();

                Shake shake = new Shake ();
                shake.Nome = form["shake"];
                shake.Preco = 0.0;
                pedido.Shake = shake;


                Hamburguer hamburguer = new Hamburguer ();
                hamburguer.Nome = form["hamburguer"];
                hamburguer.Preco = 0.0;
                pedido.Hamburguer = hamburguer;

                Cliente cliente = new Cliente () {
                    Nome = form["nome"],
                    Endereco = form["endereco"],
                    Telefone = form["telefone"],
                    Email = form["email"]
                };

                pedido.Cliente = cliente;

                pedido.DataDoPedido = DateTime.Now;

                pedido.PrecoTotal = 0.0;

                pedidoRepository.Inserir(pedido);
                return View ("Sucesso");
            } catch (Exception e) {
                System.Console.WriteLine(e.StackTrace);
                return View ("Error");
            }

        }
    }
}