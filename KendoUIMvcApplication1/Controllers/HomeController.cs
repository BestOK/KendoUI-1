using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoUIMvcApplication1.Models;

namespace KendoUIMvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var tdList = new List<TestData>();
            var td = new TestData {TextOne = "Line1", TextTwo = "Text Two", DropOne = "Drop One", IntOne = 123};
            tdList.Add(td);
            td = new TestData { TextOne = "Line2", TextTwo = "Text Two", DropOne = "Drop One", IntOne = 123 };
            tdList.Add(td);
            return View(tdList);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
