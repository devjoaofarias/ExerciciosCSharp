using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;

public class AdministradorController : AbstractController {
    public IActionResult Administrador () {
        ViewData ["NomeView"] = "Administrador";
        return View();
    }

}