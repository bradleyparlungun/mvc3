using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [OptionalAuthentication]
        public ActionResult Index1()
        {
            // This method requires login only under certain runtime conditions.
            return View();
        }

        //[Authorize]
        [FormsAuthentication(Order = 1)]
        [AddEmailAuthentication(Order = 2)]
        public ActionResult Index2()
        {
            // This method requires requires login and first time also email
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //protected override void OnAuthentication(System.Web.Mvc.Filters.AuthenticationContext filterContext)
        //{
        //    var page = filterContext.ActionDescriptor.ActionName;
        //    if (page.ToLower() == "index1") //&& DateTime.Now.Millisecond % 2 == 0)
        //    {
        //        filterContext.Result = Index1();
        //        return;
        //    }

        //    base.OnAuthentication(filterContext);
        //}

        //protected override void OnAuthenticationChallenge(System.Web.Mvc.Filters.AuthenticationChallengeContext filterContext)
        //{
        //    base.OnAuthenticationChallenge(filterContext);
        //}
    }
}