using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Dish> OrderList { get; set; }
    }
}
