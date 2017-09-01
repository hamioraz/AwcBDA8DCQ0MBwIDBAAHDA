using System.Threading.Tasks;
using System.Web.Mvc;

namespace Orchard.Candidate.Net.Areas.Dashboard.Controllers
{
    [RouteArea("Dashboard")]
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(int? id)
        {
            //TODO: Load first page from posts API
            

            return View();
        }
    }
}