using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookingSchool.Controllers
{
    [RoutePrefix("courses")]
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        // Search: Courses
        [Route("search")]
        public ActionResult Search(string q)
        {
            return View("Index");
        }

        // Search: Courses
        [Route("{id}")]
        public ActionResult Detail(int id)
        {
            return View();
        }
    }
}