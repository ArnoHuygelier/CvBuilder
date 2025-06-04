using Microsoft.AspNetCore.Mvc;

namespace CvBuilder.Mvc.Ui.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
