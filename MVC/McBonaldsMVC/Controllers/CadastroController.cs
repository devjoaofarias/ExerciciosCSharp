using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace McBonaldsMVC.Controllers {
    public class CadastroController : Controller {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index () {
            return View ();
        }

        public IActionResult CadastrarCliente(IFormCollection form) {
            try 
            {
                    Cliente cliente = new Cliente(form["nome"], form["email"], form["endereco"], form["telefone"], form["senha"], DateTime.Parse(form["data-nascimento"]));
                    clienteRepository.Inserir(cliente);
                    return View("Sucesso");
            } 
            catch(Exception e) {
                    System.Console.WriteLine(e.StackTrace);
                    return View("Error");
            }
        }

    }
}