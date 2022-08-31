using Microsoft.AspNetCore.Mvc;

namespace AutomobiliuServisas.Controllers
{
    public class AntanasController : Controller
    {
        //
        // GET:/Antanas/
        public string Index()
        {
            return "Sveiki, čia servisas Keturi Ratai...";
        }

        //
        // GET:/Antanas/Info
        public string Info()
        {
            return "Man yra x metų, dirbu y įmonėje...";
        }
        
    }
}
