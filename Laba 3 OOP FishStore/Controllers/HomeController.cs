using Microsoft.AspNetCore.Mvc;

namespace Laba_3_OOP_FishStore.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        [HttpGet, Route("")]
        public ActionResult Index(Guid id)
        {
            return View(id);
        }
    }
}
