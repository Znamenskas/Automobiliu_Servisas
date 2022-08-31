using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AutomobiliuServisas.Controllers
{
    public class HelloWorldController : Controller
    {
        private char masyvosuma;
        private int i;

        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        

        //
        // GET: /HelloWorld/Paieska

        public string Paieska()
        {
            return "Ieskoma...";
        }

        //
        // GET:HelloWorld/Antanas/
        public string Antanas()
        {
            return "Čiayra ne Antano pasaulis, o mano...";
        }

        //
        // GET: /Antanas/Info
        public string Info()

        {
            return "Man yra x metų, dirbu y įmoneje..."; 
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1 )
        {
            return HtmlEncoder.Default.Encode($"Sveiki, mano vardas: {name}, man yra : {numTimes} metai");
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome1(string vardas, int metai, string imone)
        {
            return HtmlEncoder.Default.Encode($"Sveiki, mano vardas: { vardas}, man yra :! {metai} metai,imon {imone}:");
        }

        //
        // GET:/Skaiciavimai/suma/
        public string suma(double x,double y, double suma)
        {
           
            suma = (double)(x + y);
            return HtmlEncoder.Default.Encode($"Skaicius {x} ir {y} Dvieju skaiciu suma yra: {suma}");
        }
        
        //
        // GET: /Skaiciavimai/vardo ilgis
        
        public string  vardoilgis(string vardas )
        {
            if (vardas.Length <= 5)
            {
                return HtmlEncoder.Default.Encode($"Jūsų vardas {vardas} yra trumpas");
            }
            else
            {
                return HtmlEncoder.Default.Encode($"Jūsų vardas {vardas} yra ilgas");
            }
        }
        //
        // GET: /Skaičiavimai/masyvosuma
        public string masyvoSuma(double[] mas)
        {
            double suma = 0;
            for (int i = 0; i < mas.Length; i++)
            {
               suma += mas[i];
            }
            return HtmlEncoder.Default.Encode($"masyvo suma yra: {suma}");
        }




    }
}
