using Microsoft.AspNetCore.Mvc;

namespace CvBuilder.Mvc.Ui.Controllers
{
    public class CvController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}
