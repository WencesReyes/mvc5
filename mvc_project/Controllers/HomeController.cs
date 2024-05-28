using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}