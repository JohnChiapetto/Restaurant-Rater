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
    }
}