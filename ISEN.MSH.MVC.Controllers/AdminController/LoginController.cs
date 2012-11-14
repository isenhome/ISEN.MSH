using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISEN.MSH.APP.Service.Base.User.Service;
using ISEN.MSH.Nhibernate.Model.User;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    public class LoginController : BaseController
    { 

        // GET: /Login/
        public IUserInfoManager UserInfoManager { get; set; }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserInfo userInfo, string strReturnUrl)
        {
            userInfo = UserInfoManager.Get(userInfo.Account, userInfo.Password);
            if (userInfo == null)
            {
                ModelState.AddModelError("IsEnabled", "用户名或密码错误");
                return View(userInfo);
            }
            if (!userInfo.IsEnabled)
            {
                ModelState.AddModelError("IsEnabled", "用户已经被禁用");
                return View(userInfo);
            }
            else
            {
                Session.Add("user", userInfo);
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

            UserInfo userInfo = new UserInfo();
            userInfo = UserInfoManager.Get(userName, password);
            if (userInfo == null)
            {
                return Json(new { IsSuccess = false, message = "用户名或密码错误" });
            }
            if (!userInfo.IsEnabled)
            {
                return Json(new { IsSuccess = false, message = "用户已经冻结" });
            }
            else
            {
                Session.Add("user", userInfo);
                return Json(new { IsSuccess = true, message = "登陆成功", action = "/Admin/Index" });
            }

        }

    }
}
