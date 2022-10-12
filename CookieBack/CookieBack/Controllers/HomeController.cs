using CookieBack.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CookieBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {

            HttpContext.Session.SetString("Name", "Azer");
            Response.Cookies.Append("Surname", "Humbetov", new CookieOptions { MaxAge = TimeSpan.FromSeconds(30) });
            return View();

        }
        public IActionResult Test()
        {
            var sessionData = HttpContext.Session.GetString("Name");
            var cookieData = Request.Cookies["Surname"];
            return Json(sessionData + " - " + cookieData);
        }

        public async Task<IActionResult> AddBasket()
        {
            return Json("SalamP130");
        }
    }
}
