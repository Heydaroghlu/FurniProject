using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
