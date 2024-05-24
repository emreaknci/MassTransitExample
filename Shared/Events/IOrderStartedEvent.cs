using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    public interface IOrderStartedEvent
    {
        int OrderId { get; }
        bool Succeeded { get; }

        public Dictionary<string, int> Items { get; set; } // ProductName, Quantity

    }

    public class BasketItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Units { get; set; }
    }
}
