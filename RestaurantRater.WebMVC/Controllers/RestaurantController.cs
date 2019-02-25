using RestaurantRater.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static RestaurantRater.WebMVC.Models.Restaurant;

namespace RestaurantRater.WebMVC.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDBContext db = new RestaurantDBContext();

        // GET: Restaurant
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RestaurantID,Name,Address,Rating")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Restaurants.Add(restaurant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

    }
}