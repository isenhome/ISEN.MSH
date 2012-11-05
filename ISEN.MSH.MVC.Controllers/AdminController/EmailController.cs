using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class EmailController:BaseController
    {
        public ActionResult Index()
        {
            return BaseView();
        }

        public ActionResult ShortCut()
        {
            return PartialView();
        }
    }
}
