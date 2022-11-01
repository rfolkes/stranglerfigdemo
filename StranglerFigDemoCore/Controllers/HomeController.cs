using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SystemWebAdapters;

namespace StranglerFigDemoCore
{
    public class HomeController : Controller
    {
        public IActionResult Page1()
        {
            ViewData["Counter"] = System.Web.HttpContext.Current?.Session?["Counter"];
            return View(ViewData);
        }
    }
}
