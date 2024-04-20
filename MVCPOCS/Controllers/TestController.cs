using Microsoft.AspNetCore.Mvc;

namespace MVCPOCS.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
