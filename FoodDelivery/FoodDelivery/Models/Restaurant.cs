using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dish> Menu { get; set; }
    }
}
