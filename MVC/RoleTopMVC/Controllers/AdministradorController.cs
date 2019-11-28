using Microsoft.AspNetCore.Mvc;

public class AdministradorController : Controller {
    public IActionResult Administrador () {
        ViewData ["NomeView"] = "Administrador";
        return View();
    }

}