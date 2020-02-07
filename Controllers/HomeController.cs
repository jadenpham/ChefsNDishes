using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs.Include(c => c.OwnDishes).ToList();
            ViewBag.allchefs= AllChefs;
            return View();
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                newChef.Age = AgeCalculator.CalcAge(newChef.DOB);
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewChef");
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dish()
        {
            ViewBag.dishes = dbContext.Dishes.Include(d => d.Creator).ToList();
            return View("Dishes");
        }

        [HttpGet("dishes/{id}")]
        public IActionResult SingleDish(int id)
        {
            ViewBag.Dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult DishPage()
        {
            List<Chef> chefs = dbContext.Chefs.ToList();
            ViewBag.chefs = chefs;
            return View();
        }

        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDish)
        {
            ViewBag.chefs = dbContext.Chefs.ToList();
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dish");
            }
            else
            {
                return View("DishPage");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
