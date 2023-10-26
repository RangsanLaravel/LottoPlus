using Microsoft.AspNetCore.Mvc;

namespace LottoPlus.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
