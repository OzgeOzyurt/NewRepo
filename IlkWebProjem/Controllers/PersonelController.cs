using IlkWebProjem.Models;
using Microsoft.AspNetCore.Mvc;

namespace IlkWebProjem.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            Personel p1 = new Personel() { Ad = "Selami", Soyad = "Şahin", Departman = "Müzik", Aktif = true };

            return View(p1);
        }
    }
}

//www.hepsiburada.com/personel/index
