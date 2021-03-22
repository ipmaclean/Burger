using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class OrderService
    {
        public List<OrderWithStatus> OrdersWithStatus { get; set; } = new List<OrderWithStatus>();

        public async Task<int> PlaceOrder(Order order)
        {
            int orderId = 1;
            foreach (OrderWithStatus item in OrdersWithStatus)
            {
                if (item.Order.OrderID == orderId)
                {
                    orderId++;
                }
            }
            order.OrderID = orderId;
            order.CreatedTime = DateTime.Now;
            var orderWithStatus = new OrderWithStatus();
            orderWithStatus.Order = order;

            await Task.Delay(500);
            OrdersWithStatus.Add(orderWithStatus);
            
            
            return order.OrderID;
        }

        public async Task<OrderWithStatus> GetOrder(int orderId)
        {
            await Task.Delay(1);
            foreach (OrderWithStatus orderWithStatus in OrdersWithStatus)
            {
                if (orderWithStatus.Order.OrderID == orderId)
                {
                    return orderWithStatus;
                }
            }
            return new OrderWithStatus();
        }

        public async Task<List<OrderWithStatus>> GetOrders()
        {
            await Task.Delay(1000);
            return OrdersWithStatus;
        }
    }
}
