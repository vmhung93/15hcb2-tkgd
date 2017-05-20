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

        [Route("profileinfo")]
        public ActionResult Profileinfo()
        {
            return View("Profile-info");
        }

        [Route("profileimage")]
        public ActionResult Profileimage()
        {
            return View("Profile-image");
        }

        [Route("profilenotice")]
        public ActionResult Profilenotice()
        {
            return View("Profile-notification");
        }

        [Route("profilecredit")]
        public ActionResult Profilecredit()
        {
            return View("Profile-creditcard");
        }
    }
}