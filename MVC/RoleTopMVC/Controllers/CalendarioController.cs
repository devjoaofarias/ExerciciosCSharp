using Microsoft.AspNetCore.Mvc;

public class CalendarioController : Controller {
    public IActionResult Index() {
        ViewData ["NomeView"] = "Calendario";
        return View();
    }
}