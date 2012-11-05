using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ISEN.MSH.MVC.Controllers
{
    public class BaseController : Controller
    {
        public ViewResult BaseView()
        {
            ViewData["Controller"] = RouteData.Values["controller"];
            ViewData["Action"] = RouteData.Values["action"];
            StringBuilder viewScript = new StringBuilder();
            viewScript.Append("<script type='text/javascript'>");
            viewScript.Append("var controller = '"+RouteData.Values["controller"]+"';");
            viewScript.Append("var action = '"+RouteData.Values["action"]+"';");
            viewScript.Append("</script>");
            HttpContext.Response.Output.Write(viewScript.ToString());
            return View();
        }
        
    }
}
