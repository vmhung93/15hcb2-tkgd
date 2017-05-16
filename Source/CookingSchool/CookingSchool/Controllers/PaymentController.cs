using System.Web.Mvc;

namespace CookingSchool.Controllers
{
    public class PaymentController : Controller
    {
        [Route("payment")]
        public ActionResult Index()
        {
            return View();
        }
    }
}