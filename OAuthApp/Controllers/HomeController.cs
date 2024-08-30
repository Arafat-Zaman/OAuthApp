using Microsoft.AspNetCore.Mvc;
using OAuthApp.Models;
using System.Diagnostics;

namespace OAuthApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Logout", "Account");
        }
    }
}
