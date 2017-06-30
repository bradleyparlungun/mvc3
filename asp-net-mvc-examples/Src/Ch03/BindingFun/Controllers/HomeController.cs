using System.Web.Mvc;
using BindingFun.ViewModels;

namespace BindingFun.Views
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ViewModelBase() {Title = "Programming ASP.NET MVC"};
            return View(model);
        }
    }
}
