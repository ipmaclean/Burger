using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class Patty
    {
        public Patty()
        {
            BurgerPatties = new HashSet<BurgerPatty>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal BasePrice { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        public string Color { get; set; }
        public HashSet<BurgerPatty> BurgerPatties { get; set; }
        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}
