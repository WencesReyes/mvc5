using System;
using System.Web.Mvc;

namespace mvc_project.Controllers
{
    [RoutePrefix("Fruit")]
    public class FruitController : Controller
    {
        public ActionResult FruitName(string fruitName)
        {
            return Content($"Fruit name: {fruitName}");
        }

        [Route("Family/{family}/{date}")]
        public ActionResult Family(string family, DateTime date, string description)
        {
            return Content($"Fruit family: {family}, date: {date:yyyy}, description: {description}");
        }
    }
}