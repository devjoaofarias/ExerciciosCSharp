using Microsoft.AspNetCore.Mvc;

public class CadastroController : Controller {
    public IActionResult Cadastro () {
        ViewData["NomeView"] = "cadastro";
        return View ();
    }
}