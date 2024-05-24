using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Commands
{
    public interface IOrderCreatedCommand
    {
        int OrderId { get; }

        List<BasketItem> Items { get; }

    }
}
