using Microsoft.AspNetCore.Mvc;

public class ClienteController : Controller {
    public IActionResult Login () {
        ViewData["NomeView"] = "Home";
        return View ();
    }

    public IActionResult Usuario () {
        ViewData["NomeView"] = "Usuario";
        return View ();
    }
    
}