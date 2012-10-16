using System;
using System.Linq;
using System.Web.Mvc;

namespace ISEN.MSH.MVC.Controllers.HomeController
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Articles()
        {
            return View();
        }
    }
}
