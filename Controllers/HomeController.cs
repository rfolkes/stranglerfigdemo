using System.Web.Mvc;

namespace StranglerFigDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Page1()
        {
            if (HttpContext.Session.Contents["Counter"] == null)
            {

                HttpContext.Session.Contents["Counter"] = 0;
            }

            ViewData["Counter"] = HttpContext.Session.Contents["Counter"];

            return View(ViewData);
        }
        
        public ActionResult Page2()
        {
            if (HttpContext.Session.Contents["Counter"] == null)
            {

                HttpContext.Session.Contents["Counter"] = 0;
            }

            ViewData["Counter"] = HttpContext.Session.Contents["Counter"];

            return View(ViewData);
        }
        
        [HttpPost]
        public ActionResult Page1UpdateCounter()
        {

            if (HttpContext.Session.Contents["Counter"] == null)
            {

                HttpContext.Session.Contents["Counter"] = 0;
            }

            HttpContext.Session.Contents["Counter"] = (int)HttpContext.Session.Contents["Counter"] + 1;

            return RedirectToAction("Page1");
        }
        
        [HttpPost]
        public ActionResult Page2UpdateCounter()
        {

            if (HttpContext.Session.Contents["Counter"] == null)
            {

                HttpContext.Session.Contents["Counter"] = 0;
            }

            HttpContext.Session.Contents["Counter"] = (int)HttpContext.Session.Contents["Counter"] + 1;

            return RedirectToAction("Page2");
        }
    }
}