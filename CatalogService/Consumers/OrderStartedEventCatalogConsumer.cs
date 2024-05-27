using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Consumers
{
    public class OrderStartedEventCatalogConsumer : IConsumer<OrderStartedEvent>
    {
        public Task Consume(ConsumeContext<OrderStartedEvent> context)
        {
            var message = context.Message;

            Console.Out.WriteLineAsync($"\n#{message.OrderId} siparişi oluşturuldu.");
            foreach (var item in message.Items)
            {
                Console.WriteLine($"{item.Key} ürününden {item.Value} adet stoklardan düştü");
            }

            return Task.CompletedTask;
        }
    }
}
