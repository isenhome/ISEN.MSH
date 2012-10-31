using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Spring.Web.Mvc;
using Spring.Context;
using Spring.Context.Support;
using ISEN.MSH.Service.Interfaces;
using ISEN.MSH.Service.Implements;

namespace ISEN.MSH.MVC.WEB
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : SpringMvcApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        protected override void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "Default", // 路由名称
            //    "{controller}/{action}/{id}", // 带有参数的 URL
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional } // 参数默认值
            //);
            routes.MapRoute("NoAction", "{controller}.aspx", new { controller = "home", action = "index", id = "" });//无Action的匹配
            routes.MapRoute("NoID", "{controller}/{action}.aspx", new { controller = "home", action = "index", id = "" });//无ID的匹配
            routes.MapRoute("Default", "{controller}/{action}/{id}.aspx", new { controller = "home", action = "index", id = "" });//默认匹配
            routes.MapRoute("Root", "", new { controller = "home", action = "index", id = "" });//根目录匹配


        }

        protected override void Application_Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);
            this.SetInitAccount();
        }

        /// <summary>
        /// 设置初始账号
        /// </summary>
        private void SetInitAccount()
        {
            IApplicationContext cxt = ContextRegistry.GetContext();
            IUserInfoManager manger = (IUserInfoManager)cxt.GetObject("Manager.UserInfo");

            const string account = "admin";
            var user = manger.Get(account);
            if (user == null)
            {
                user = new ISEN.MSH.Nhibernate.Models.UserInfo
                {
                    Account = account,
                    Name = "管理员",
                    ID = Guid.NewGuid(),
                    CreateTime = DateTime.Now,
                    IsEnabled = true
                };
                manger.Save(user);
            }

        }
    }
}