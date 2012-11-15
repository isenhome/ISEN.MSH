using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISEN.MSH.APP.Service.Base.User.Service;
using ISEN.MSH.Nhibernate.Model.Users;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    public class LoginController : BaseController
    { 

        // GET: /Login/
        public IUserManager UserManager { get; set; }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel user, string strReturnUrl)
        {
            user = UserManager.Get(user.Account, user.Password);
            if (user == null)
            {
                ModelState.AddModelError("IsEnabled", "用户名或密码错误");
                return View(user);
            }
            if (!user.IsEnabled)
            {
                ModelState.AddModelError("IsEnabled", "用户已经被禁用");
                return View(user);
            }
            else
            {
                Session.Add("user", user);
                if (Url.IsLocalUrl(strReturnUrl) && strReturnUrl.Length > 1 && strReturnUrl.StartsWith("/") && !strReturnUrl.StartsWith("//") && !strReturnUrl.StartsWith("/\\"))
                {
                    return Redirect(strReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
        }

        //ajax 实现登录功能
        public ActionResult DoLogin(string userName, string password)
        {
            if (userName == "")
            {
                return Json(new { IsSuccess = false, message = "请输入用户名" });
            }
            if (password == "")
            {
                return Json(new { IsSuccess = false, message = "请输入密码" });
            }

            UserModel user = new UserModel();
            user = UserManager.Get(userName, password);
            if (user == null)
            {
                return Json(new { IsSuccess = false, message = "用户名或密码错误" });
            }
            if (!user.IsEnabled)
            {
                return Json(new { IsSuccess = false, message = "用户已经冻结" });
            }
            else
            {
                Session.Add("user", user);
                return Json(new { IsSuccess = true, message = "登陆成功", action = "/Admin/Index" });
            }

        }

    }
}
