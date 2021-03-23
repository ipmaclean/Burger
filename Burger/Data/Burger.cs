using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class Burger
    {
        public Burger()
        {
            BurgerPatties = new HashSet<BurgerPatty>();
        }
        public int ID { get; set; }
        public HashSet<BurgerPatty> BurgerPatties { get; set; } = new HashSet<BurgerPatty>();
        public Bun Bun { get; set; }

        public decimal CalculateBurgerPrice()
        {
            decimal price = 0m;

            if (Bun != null)
            {
                price += Bun.BasePrice;
            }

            price += BurgerPatties.Sum(burgerPatty => burgerPatty.Patty.BasePrice);

            return price;
        }

        public string GetFormattedBurgerPrice()
        {
            decimal cost = CalculateBurgerPrice();

            return cost.ToString("0.00");
        }
    }
}
