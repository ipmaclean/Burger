using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Burger> Burgers { get; set; } = new List<Burger>();
        public decimal Price { get; set; } = 0m;
        public DateTime CreatedTime { get; set; }

        public string GetFormattedOrderPrice()
        {
            return Price.ToString("0.00");
        }


    }
}
