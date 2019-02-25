using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.WebMVC.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        string Name             { get; set; }
        public int Rating       { get; set; }
        public string Address   { get; set; }

        public class RestaurantDBContext : DbContext
        {
            public DbSet<Restaurant> Restaurants { get; set; }
        }
    }
}
