using System.Web.Mvc;

namespace mvc_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public JsonResult ReturningJson()
        //{
        //    return Json(new { Name = "wenceslao" }, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Redirecting()
        //{
        //    // return Redirect("https://www.google.com");

        //    // return RedirectToAction("Index");

        //    // Needs to pass route name that is configured in RouteConfig.cs
        //    // return RedirectToRoute("Example");
        //}

        //public ActionResult ReturningStatusCode()
        //{
        //    return new HttpStatusCodeResult(HttpStatusCode.MovedPermanently, "moved test");
        //}

        //public ActionResult ReturningFile()
        //{
        //    var path = Server.MapPath("~/Files/Recibo-Abr.pdf");

        //    return File(path, "application/pdf", "recibo.pdf");
        //}

        public ActionResult UsingQueryParams(string name, int age)
        {
            return Content($"Nombre: {name}, Age: {age}");
        }
    }
}