using System.Web.Mvc;

namespace CookingSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        [Route("courses")]
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

        // Course detail
        [Route("courses/{id}")]
        public ActionResult Detail(int id)
        {
            ViewBag.MenuTab = "courses";

            return View();
        }

        // Lesson detail
        [Route("lessons/{id}")]
        public ActionResult Lesson(int id)
        {
            ViewBag.MenuTab = "my-courses";

            return View();
        }

        [Route("manage-courses")]
        public ActionResult Manage()
        {
            return View();
        }

        [Route("list-courses")]
        public ActionResult ListCourses()
        {
            return View();
        }
    }
}