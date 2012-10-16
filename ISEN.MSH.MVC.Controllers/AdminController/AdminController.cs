using System;
using System.Linq;
using System.Web.Mvc;
using ISEN.MSH.Nhibernate.Models;
using ISEN.MSH.Service.Interfaces;
using ISEN.MSH.MVC.Controllers.Filters;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class AdminController : Controller
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