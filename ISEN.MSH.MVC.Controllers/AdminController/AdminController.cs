using System;
using System.Linq;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;
using ISEN.MSH.APP.Service.Base.User.Service;
using ISEN.MSH.Nhibernate.Model.Users;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class AdminController : BaseController
    {

        public IUserManager UserManager { get; set; }
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
            UserModel user = new UserModel();
            user = Session["user"] as UserModel;
            ViewData["userName"] = user.Account;
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