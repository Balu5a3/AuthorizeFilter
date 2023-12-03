using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AuthorizeFilter.Controllers
{
    public class HomeController : Controller
    {
        //[Route("Balu")]
        public ActionResult Index()
        {
            //return Redirect("Home/About");

            //return RedirectToAction("About");

            //return RedirectToAction("Index","Admin");

            return RedirectToRoute("Default");
            
        }


        //[Authorize]
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