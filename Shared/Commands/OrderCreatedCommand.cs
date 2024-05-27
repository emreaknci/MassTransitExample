using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Commands
{
    public class OrderCreatedCommand
    {
        public int OrderId { get; set; }

        public List<BasketItem> Items { get; set; }

    }
}
