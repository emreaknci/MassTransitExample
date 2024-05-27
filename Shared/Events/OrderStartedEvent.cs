using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    public class OrderStartedEvent
    {
        public int OrderId { get; set; }
        public bool Succeeded { get; set; }

        public Dictionary<int, int> Items { get; set; } // Id, Quantity

    }

    public class BasketItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Units { get; set; }
    }
}
