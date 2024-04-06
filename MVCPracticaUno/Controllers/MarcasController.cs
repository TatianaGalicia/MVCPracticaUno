using Microsoft.AspNetCore.Mvc;

namespace MVCPracticaUno.Controllers
{
    public class MarcasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
