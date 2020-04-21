using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Chef_Dishes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chef_Dishes.Controllers {
    public class HomeController : Controller {
        private MyContext _context;
        public HomeController (MyContext context) {
            _context = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {

            List<Chef> AllChefs  = _context.Chefs.Include(l=>l.DishesByChef).ToList();


            return View (AllChefs);
        }
        [HttpGet ("Dishes")]
        public IActionResult Dishes () {

            List<Dish> AllDishes  = _context.Dishes.ToList();
            ViewBag.AllDisshes  = _context.Dishes.Include(h=>h.DishCreator).ToList();


            return View (AllDishes);
        }
        [HttpGet ("Add")]
        public IActionResult Add () {
            return View ();
        }
        [HttpGet ("AddDish")]
        public IActionResult AddDish () {
            ViewBag.AllChefs = _context.Chefs.Include(g=>g.DishesByChef).ToList();
            return View ();
        }

        [HttpPost ("Create")]
        public IActionResult Create (Chef newChef) {
            if (ModelState.IsValid) {
                _context.Chefs.Add (newChef);
                _context.SaveChanges ();
                return Redirect ("/");
            } else {
                return View("Add");
            }

        }
        [HttpPost ("CreateDish")]
        public IActionResult CreateDish (Dish newDish) {
            if (ModelState.IsValid) {
                _context.Dishes.Add (newDish);
                _context.SaveChanges ();
                return Redirect ("/Dishes");
            } else {
                ViewBag.AllChefs = _context.Chefs.Include(g=>g.DishesByChef).ToList();
                return View("AddDish");
            }

        }
        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}