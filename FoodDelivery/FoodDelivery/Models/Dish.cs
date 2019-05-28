using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }

        public Dish()
        {
            
        }

        public Dish(string name,string description,int cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }
    }
}
