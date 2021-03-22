using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class Burger
    {
        public int ID { get; set; }
        public List<Patty> Patties { get; set; } = new List<Patty>();
        public Bun Bun { get; set; }

        public decimal CalculateBurgerPrice()
        {
            decimal price = 0m;

            if (Bun != null)
            {
                price += Bun.BasePrice;
            }
            foreach (Patty patty in Patties)
            {
                price += patty.BasePrice;
            }

            return price;
        }

        public string GetFormattedBurgerPrice()
        {
            decimal cost = CalculateBurgerPrice();

            return cost.ToString("0.00");
        }
    }
}
