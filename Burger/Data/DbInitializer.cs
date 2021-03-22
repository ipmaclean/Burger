using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class DbInitializer
    {
        public static void Initialize(BurgerStoreContext context)
        {
            context.Database.EnsureCreated();

            // Look for any buns.
            if (context.Buns.Any())
            {
                return;   // DB has been seeded
            }

            var Buns = new Bun[]
            {
                new Bun
                {
                    Name = "Classic",
                    Description = "Classic bread. They're nice!",
                    Image = "classic-bun.png",
                    BasePrice = 1m,
                    Vegetarian = true,
                    Vegan = true
                },
                new Bun
                {
                    Name = "Brioche",
                    Description = "For you fancy burger munchers out there.",
                    Image = "brioche-bun.png",
                    BasePrice = 1.5m,
                    Vegetarian = true,
                    Vegan = true
                },
                new Bun
                {
                    Name = "Doughnut",
                    Description = "For those of you with a sweet tooth!",
                    Image = "doughnut-bun.png",
                    BasePrice = 2m,
                    Vegetarian = true,
                    Vegan = true
                }
            };
            foreach (Bun b in Buns)
            {
                context.Buns.Add(b);
            }
            context.SaveChanges();

            var Patties = new Patty[]
            {
                new Patty
                {
                    Name = "Beef",
                    Description = "28 day aged Angus beef. Delectable",
                    Image = "beef-patty.png",
                    BasePrice = 3.5m,
                    Vegetarian = false,
                    Vegan = false,
                    Color = "#8B4513"
                },
                new Patty
                {
                    Name = "Chicken",
                    Description = "Breaded chicken breast deep fried Korean style.",
                    Image = "chicken-patty.png",
                    BasePrice = 3m,
                    Vegetarian = false,
                    Vegan = false,
                    Color = "#DA8224"
                },
                new Patty
                {
                    Name = "Veggie",
                    Description = "Made from the poor corpses of hundreds of murdered plants",
                    Image = "veggie-patty.png",
                    BasePrice = 2.5m,
                    Vegetarian = true,
                    Vegan = true,
                    Color = "#808022"
                }
            };
            foreach (Patty p in Patties)
            {
                context.Patties.Add(p);
            }
            context.SaveChanges();
        }
    }
}
