using System;
using System.Linq;
using System.Web.Mvc;
using ISEN.MSH.WEB.Filters;
using ISEN.MSH.Service.Interfaces;

namespace ISEN.MSH.WEB.Controllers
{
    [UserActionFilter]
    public class SettingController : Controller
    {
        //
        // GET: /Setting/

        IUserInfoManager userInfoManager { get; set; }

        public ActionResult Index()
        {
            return Redirect("/Setting/UserSetting");
        }
        
        public ActionResult UserSetting()
        {
            long total = 0;
            var list = userInfoManager.LoadAllWithPage(out total, 0, 10);
            return View(list); 
        }
        public ActionResult UserAdd()
        {
            return View();
        }
        public ActionResult UserDelete(string id)
        {
            Guid guid = new Guid(id);
            userInfoManager.Delete(guid);
            return Redirect("/Setting/UserSetting");
        }
    }
}
