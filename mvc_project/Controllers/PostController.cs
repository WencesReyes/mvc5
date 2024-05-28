using System.Web.Mvc;

namespace mvc_project.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            return View("Information");
        }

        [HttpPost]
        public ActionResult Post(int age)
        {
            ViewBag.Age = age;

            return View("Information");
        }
    }
}