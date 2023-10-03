using Microsoft.AspNetCore.Mvc;

namespace Url_Shortener.Controllers
{
    public class XYZController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
