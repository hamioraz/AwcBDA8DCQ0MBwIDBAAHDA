using System.Web.Mvc;

namespace Orchard.Candidate.Net.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }

    
}