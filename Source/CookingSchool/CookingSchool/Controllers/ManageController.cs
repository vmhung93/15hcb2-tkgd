using System.Web.Mvc;

namespace CookingSchool.Controllers
{
    public class ManageController : Controller
    {
        public ManageController()
        {
        }
        
        public ActionResult Index()
        {
            return View();
        }
    }
}