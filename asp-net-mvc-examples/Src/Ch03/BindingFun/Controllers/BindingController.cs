using System;
using System.Diagnostics.Contracts;
using System.Web.Mvc;
using BindingFun.ViewModels.Binding;

namespace BindingFun.Controllers
{
    public class BindingController : Controller
    {
        public ActionResult Repeat(String text, Int32 number)
        {
            //Contract.Requires<ArgumentException>(text.Length > 0);
            //Contract.Requires<ArgumentException>(number > 0 && number < 10);

            var model = new RepeatViewModel { Number = number, Text = text };
            return View(model);
        }

        public ActionResult RepeatNull(String text, Int32? number)
        {
            var model = new RepeatViewModel { Number = number.GetValueOrDefault(), Text = text };
            return View("repeat", model);
        }

        public ActionResult RepeatDefault(String text, Int32 number = 4)
        {
            var model = new RepeatViewModel { Number = number, Text = text };
            return View("repeat", model);
        }

        public ActionResult RepeatWithPrecedence(String text, Int32 number = 20)
        {
            var model = new RepeatViewModel { Number = number, Text = text };
            return View("repeat", model);
        }
    }
}
