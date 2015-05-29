using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetReCaptcha.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            Helpers.CaptchaHelper captha = new Helpers.CaptchaHelper(HttpContext);
            if (captha.Validate())
            {
                return Content("Tamamdır");
            }
            return View();
        }
    }
}