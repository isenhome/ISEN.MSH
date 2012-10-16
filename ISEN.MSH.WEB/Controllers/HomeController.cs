using System;
using System.Linq;
using System.Web.Mvc;

namespace ISEN.MSH.WEB.Controllers
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
