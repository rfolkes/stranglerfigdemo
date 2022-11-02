using Microsoft.AspNetCore.Mvc;

namespace StranglerFigDemoCore
{
    public class HomeController : Controller
    {
        public IActionResult Page1()
        {
            if (System.Web.HttpContext.Current?.Session?["Counter"] == null)
            {
                System.Web.HttpContext.Current.Session["Counter"] = 0;
            }

            ViewData["Counter"] = System.Web.HttpContext.Current?.Session?["Counter"];

            return View(ViewData);
        }

        [HttpPost]
        public IActionResult Page1UpdateCounter()
        {

            if (System.Web.HttpContext.Current?.Session?["Counter"] == null)
            {

                System.Web.HttpContext.Current.Session["Counter"] = 0;
            }

            System.Web.HttpContext.Current.Session["Counter"] = (int)System.Web.HttpContext.Current.Session["Counter"] + 1;

            return RedirectToAction("Page1");
        }
    }
}