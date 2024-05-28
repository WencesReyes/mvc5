using System.Web.Mvc;

namespace mvc_project.Controllers
{
    public class ViewBagDataController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Street"] = "Chapulin";
            ViewBag.ExternalNumber = 1435;
            ViewBag.InternalNumber = "10B";

            return View();
        }
    }
}