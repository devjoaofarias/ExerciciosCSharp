using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        public IActionResult Pagamento () {
            return View (new BaseViewModel () {
            NomeView = "Pagamento",
                UsuarioEmail = ObterUsuarioSession (),
                UsuarioNome = ObterUsuarioNomeSession ()
        });
        }

    }
}