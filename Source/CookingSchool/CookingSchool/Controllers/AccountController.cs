using System.Web.Mvc;

namespace CookingSchool.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
        }
                
        [Route("login")]
        public ActionResult Login()
        {
            ViewBag.MenuTab = "sign-in";

            return View();
        }

        [Route("register")]
        public ActionResult Register()
        {
            ViewBag.MenuTab = "sign-up";

            return View();
        }

        [Route("profile")]
        public ActionResult Profile()
        {
            return View();
        }
    }
}