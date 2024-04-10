using Microsoft.AspNetCore.Mvc;

namespace Medicamentos_Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
