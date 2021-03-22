using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BurgerStore.Data
{
    public class OrderController
    {
        private readonly BurgerStoreContext _context;

        public OrderController(BurgerStoreContext context)
        {
            _context = context;
        }

        public async Task<int> PlaceOrder(Order order)
        {

            order.CreatedTime = DateTime.Now;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order.OrderID;
        }

        public async Task<List<Order>> GetOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.Burgers).ThenInclude(b => b.Patties)
                .OrderByDescending(o => o.CreatedTime)
                .ToListAsync();

            return orders.ToList();
        }

        public async Task<OrderWithStatus> GetOrderWithStatus(int orderId)
        {
            var order = await _context.Orders
                .Where(o => o.OrderID == orderId)
                .Include(o => o.Burgers).ThenInclude(b => b.Patties)
                .SingleOrDefaultAsync();

            if (order == null)
            {
                return new OrderWithStatus();
            }

            return OrderWithStatus.UpdateStatus(order);
        }
    }
}
