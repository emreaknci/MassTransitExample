using MassTransit;
using Shared.Commands;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Consumers.OrderService
{
    public class OrderCreatedCommandConsumer : IConsumer<IOrderCreatedCommand>
    {
        public async Task Consume(ConsumeContext<IOrderCreatedCommand> context)
        {
            var message = context.Message;

            await Console.Out.WriteLineAsync($"\n\nOrder Created: #{message.OrderId}");
            foreach (var item in message.Items)
            {
                await Console.Out.WriteLineAsync($"{item.Id} - {item.Name} - {item.Units}");
            }
            Dictionary<int, int> dicItems = new Dictionary<int, int>();
            foreach (var item in message.Items)
            {
                dicItems.Add(item.Id, item.Units);
            }

            await context.Publish<IOrderStartedEvent>(new
            {
                OrderId = message.OrderId,
                Items = dicItems,
                Succeeded = true
            });
        }
    }
}
