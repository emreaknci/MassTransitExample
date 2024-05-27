using MassTransit;
using Shared.Commands;
using Shared.Events;

namespace OrderService.Consumers
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
