using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerStore.Data
{
    public class OrderWithStatus
    {
        public readonly static TimeSpan PreparationDuration = TimeSpan.FromSeconds(10);
        public readonly static TimeSpan DeliveryDuration = TimeSpan.FromSeconds(30);

        public Order Order { get; set; }
        public string StatusText { get; set; }
        public static OrderWithStatus UpdateStatus(Order order) {
            var orderWithStatus = new OrderWithStatus() { Order = order };
            var dispatchTime = orderWithStatus.Order.CreatedTime.Add(PreparationDuration);

            if (DateTime.Now < dispatchTime)
            {
                orderWithStatus.StatusText = "Preparing";
            }
            else if (DateTime.Now < dispatchTime + DeliveryDuration)
            {
                orderWithStatus.StatusText = "Out for delivery";
            }
            else
            {
                orderWithStatus.StatusText = "Delivered";
            }

            return orderWithStatus;
        }
    }
}
