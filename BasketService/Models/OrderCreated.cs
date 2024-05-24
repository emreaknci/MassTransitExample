using Shared.Commands;
using Shared.Events;

namespace BasketService.Models
{
    public class OrderCreated : IOrderCreatedCommand
    {
        public int OrderId { get; set; }

        public List<BasketItem> Items { get; set; }
    }
}
