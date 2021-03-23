using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class MenuController
    {
        private readonly BurgerStoreContext _context;

        public MenuController(BurgerStoreContext context)
        {
            _context = context;
        }

        public async Task<List<Bun>> GetBuns()
        {
            return (await _context.Buns.OrderByDescending(b => b.BasePrice).ToListAsync());
        }

        public async Task<List<Patty>> GetPatties()
        {
            return (await _context.Patties.OrderByDescending(p => p.BasePrice).ToListAsync());
        }
    }
}
