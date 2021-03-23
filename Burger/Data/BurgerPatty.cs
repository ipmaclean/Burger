using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class BurgerPatty
    {
        public Burger Burger { get; set; }
        public Patty Patty { get; set; }
        public Guid BurgerPattyID { get; set; }
        public int SortOrder { get; set; } = 0;
    }
}
