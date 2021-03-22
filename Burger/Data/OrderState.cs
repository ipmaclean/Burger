using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class OrderState
    {
        public Order Order { get; set; } = new Order();
        public Burger Burger { get; set; } = new Burger();
        public bool HideOverOrderBox { get; set; } = true;
        public string OverOrderMessage { get; set; } = "";

        public void AddItemToBurger(Patty patty)
        {
            if (Burger.Patties.Count >= 3)
            {
                OverOrderMessage = "You've tried to order too many patties! We can't fit that many in the bun!";
                HideOverOrderBox = false;
            }
            else
            {
                Burger.Patties.Add(patty);
            }
        }

        public void AddItemToBurger(Bun bun)
        {
            Burger.Bun = bun;
        }

        public void AddBurgerToOrder(Burger burger)
        {
            Order.Price += burger.CalculateBurgerPrice();
            Order.Burgers.Add(burger);
            Burger = new Burger();
            
        }

        public void RemoveBurger(Burger burger)
        {
            Order.Price -= burger.CalculateBurgerPrice();
            Order.Burgers.Remove(burger);
        }

        public void ResetOrder()
        {
            Order = new Order();
        }
    }
}
