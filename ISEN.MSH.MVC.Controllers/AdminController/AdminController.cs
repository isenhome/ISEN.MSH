using System;
using System.Linq;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;
using ISEN.MSH.APP.Service.Base.User.Service;
using ISEN.MSH.Nhibernate.Model.User;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class AdminController : BaseController
    {

        public IUserInfoManager UserInfoManager { get; set; }
        //
        // GET: /Admin/
        
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Message()
        {
            return PartialView();
        }

        public ActionResult Info()
        {
            UserInfo userInfo = new UserInfo();
            userInfo = Session["user"] as UserInfo;
            ViewData["userName"] = userInfo.Account;
            return PartialView();
        }

        public ActionResult Nav()
        {
            return PartialView();
        }
        
        public ActionResult SignOut()
        {
            Session.Clear();
            return RedirectToAction("login", "login");
        }

    }
}