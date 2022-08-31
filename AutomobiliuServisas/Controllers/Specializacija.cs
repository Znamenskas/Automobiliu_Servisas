using Microsoft.AspNetCore.Mvc;

namespace AutomobiliuServisas.Controllers
{
    public class Specializacija : Controller
    {
        public int Id { get; internal set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
