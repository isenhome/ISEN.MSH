using System;
using System.Linq;
using System.Web.Mvc;

namespace ISEN.MSH.MVC.Controllers.Filters
{
    public class UserActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["user"] == null)
            {
                filterContext.Result = new RedirectResult("/login/Login.aspx");
            }
        }
    }
}