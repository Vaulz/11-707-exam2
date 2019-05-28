using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FoodDelivery.Context;
using Microsoft.AspNetCore.Mvc;
using FoodDelivery.Models;

namespace FoodDelivery.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult RegisterPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterPage(User user)
        {
            if (_context.Users.FirstOrDefault(r => r.Login ==user.Login) != null)
                return RedirectToPage("RegistrationError");
            _context.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
