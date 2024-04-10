using Microsoft.AspNetCore.Mvc;

namespace Medicamentos_Web.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
