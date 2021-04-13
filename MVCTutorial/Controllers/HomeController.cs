using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\tbran\Logs\mvcLog.txt", text);
            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}
            User user = new User();
            user.Id = 1;
            user.FirstName = "Tyler";
            user.LastName = "Branscome";
            user.Age = 30;
            return View(user);
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
    }
}