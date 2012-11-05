using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class MessageController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShortCut()
        {
            return PartialView();
        }
    }
}
