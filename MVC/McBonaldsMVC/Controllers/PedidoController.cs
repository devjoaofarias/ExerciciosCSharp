using McBonaldsMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class PedidoController : Controller {
        public IActionResult Index () {
            return View ();
        }
        public IActionResult Registrar (IFormCollection form) {
            Pedido pedido = new Pedido ();

            Shake shake = new Shake ();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;

            Hamburguer hamburguer = new Hamburguer ();
            hamburguer.Nome = form["hamburguer"];
            hamburguer.Preco = 0.0;

            Cliente cliente = new Cliente () {
                Nome = form["nome"],
                Endereco = form["endereço"],
                Telefone = form["telefone"],
                Email = form["email"] };

        }
    }
}