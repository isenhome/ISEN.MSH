using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;
using ISEN.MSH.APP.Service.Base.User.Service;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class UserManagerController : BaseController
    {
        IUserManager userManager { get; set; }

        public ActionResult Index()
        {
            return Redirect("/Setting/UserSetting");
        }

        public ActionResult UserSetting()
        {
            long total = 0;
            var list = userManager.LoadAllWithPage(out total, 0, 10);
            return View(list);
        }
        public ActionResult UserAdd()
        {
            return View();
        }
        public ActionResult UserDelete(string id)
        {
            Guid guid = new Guid(id);
            userManager.Delete(guid);
            return Redirect("/Setting/UserSetting");
        }
    }
}
