using System.Web.Mvc;

namespace CookingSchool.Controllers
{
    [RoutePrefix("courses")]
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            ViewBag.MenuTab = "courses";

            return View();
        }

        // Search: Courses
        [Route("search")]
        public ActionResult Search(string q)
        {
            ViewBag.MenuTab = "courses";

            return View("Index");
        }

        // Search: Courses
        [Route("{id}")]
        public ActionResult Detail(int id)
        {
            ViewBag.MenuTab = "courses";

            return View();
        }

        [Route("manage")]
        public ActionResult Manage()
        {
            return View();
        }
    }
}