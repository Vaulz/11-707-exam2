using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FoodDelivery.Context;
using FoodDelivery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Controllers
{
    public class UserController : Controller
    {
        private AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
            if (!_context.Users.Any())
            {
                _context.Users.Add(new User
                    { Login = "admin", Password = "admin" });
                _context.SaveChanges();
            }
        }
        public bool IsLogged()
        {
            return TempData.Peek("CurrentUser") != null;
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            User user;
            try
            {
                user = _context.Users
                    .FirstOrDefault(r => r.Login == login && r.Password == password);
                TempData["CurrentUser"] = user.Id;
                TempData.Keep("CurrentUser");
            }
            catch (Exception)
            {
                return RedirectToPage("LoginError");
            }

            return RedirectToAction("ProfilePage");
        }

        public IActionResult ProfilePage()
        {
            User user;
            try
            {
                user =_context.Users.
                    FirstOrDefault(r => r.Id == (int)TempData.Peek("CurrentUser"));
            }
            catch (Exception)
            {
                return RedirectToPage("Error");
            }
            return View(user);
        }

        public IActionResult GetAllRestaurants()
        {

            return View(_context.Restaurants.ToList());
        }
        public IActionResult GetRestaurant(int id)
        {
            _context.Restaurants.FirstOrDefault(x => x.Id == id);
            return View();
        }
        public IActionResult GetAllDishesInBasket()
        {
            return View(_context.Basket.ToList());
        }
        public IActionResult AddToBakset(int id)
        {
            _context.Basket.Add(_context.Dishes.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
           return RedirectToAction("Index", "Home");
        }
    }
}